"use strict";

if (typeof (window.Nikfort) === "undefined") {
    window.Nikfort = {}
};

Nikfort.Activity = {
    notificationId: "new_t_activity__new_msg_text",
    isCustomizationApplied: false,
    updateNotificationODataInterval: null,
    OnLoad: function () {
        setInterval(Nikfort.Activity.refreshTaskGrid, 300000);
        Xrm.Page.data.process.addOnStageChange(Nikfort.Activity.refreshTaskGrid);
        Xrm.Page.getAttribute("new_msg_text").addOnChange(
            Nikfort.Activity.showNotification
        );
        Xrm.Page.getAttribute("new_msg_type").addOnChange(
            Nikfort.Activity.showNotification
        );
        Nikfort.Activity.showNotification();
        Nikfort.Common.collapseProcessRibbon();
        Nikfort.Common.hideFormTitle();
        if (!Nikfort.Activity.isCustomizationApplied) {
            Nikfort.Activity.isCustomizationApplied = true;
            Nikfort.Common.adjustActivitiesButtons();
        }
        Nikfort.Activity.updateNotificationOData();
    },
    refreshTaskGrid: function () {
        var control = Xrm.Page.getControl("Activity_Tasks");
        if (control) {
            try {
                control.refresh();
                Nikfort.Common.collapseProcessRibbon();
            } catch (ex) {
                console.log("Control Activity_Tasks can not be refreshed");
            }
        } else {
            console.log("Control Activity_Tasks not found at this form");
        }
    },

    showNotification: function () {
        var text = Xrm.Page.getAttribute("new_msg_text").getValue();
        var type = Xrm.Page.getAttribute("new_msg_type").getValue();
        if (text && type) {
            Xrm.Page.ui.setFormNotification(
                text,
                Nikfort.Activity.OptionSets.MessageTypes[type],
                Nikfort.Activity.notificationId
            );
        } else {
            Xrm.Page.ui.clearFormNotification(Nikfort.Activity.notificationId);
        }
    },
    updateNotificationOData: function () {
        Nikfort.Activity.updateNotificationODataInterval = setInterval(function () {
            var url = false;
            try {
                url = Xrm.Page.context.getClientUrl() + "/api/data/v8.2/"
                    + Xrm.Internal.getEntitySetName(
                        Xrm.Page.data.entity.getEntityName()
                    )
                    + "("
                    + Xrm.Page.data.entity.getId().replace(/[\{\}]/g, "")
                    + ")?$select=new_msg_type,new_msg_text";
            } catch (ex) {
                url = false;
            }
            if (url) {
                parent.$
                    .getJSON(url)
                    .then(function (result) {
                        if (!result.new_msg_type || !result.new_msg_text) {
                            Xrm.Page.ui.clearFormNotification(Nikfort.Activity.notificationId);
                        }
                        var text = Xrm.Page.getAttribute("new_msg_text").getValue();
                        var type = Xrm.Page.getAttribute("new_msg_type").getValue();
                        if (result.new_msg_type === type && result.new_msg_text === text) {
                            return;
                        }
                        Xrm.Page.ui.setFormNotification(
                            result.new_msg_text,
                            Nikfort.Activity.OptionSets.MessageTypes[result.new_msg_type],
                            Nikfort.Activity.notificationId
                        );
                    });
            } else {
                console.log("Update Notification Data Url is not defined");
            }
        }, 3000);
    },
    OptionSets: {
        MessageTypes: {
            100000000: "INFO",
            100000001: "WARNING",
            100000002: "ERROR"
        }
    },

    Ribbon: {
        processNextStageHandler: function () {
            clearInterval(Nikfort.Activity.updateNotificationODataInterval);
            var valid = Nikfort.Common.CheckMandatoryFields();

            if (!valid) {
                Xrm.Page.ui.setFormNotification(
                    "Заполните обязательные поля",
                    "WARNING",
                    Nikfort.Activity.notificationId
                );
                return;
            }

            Xrm.Page.data.save().then(
                function () {
                    var actionName = "xd_ActivityNextStep";
                    Nikfort.XrmSdk.Process.callAction(
                        actionName,
                        [{
                            key: "Target",
                            type: "a:EntityReference",
                            value: { id: Xrm.Page.data.entity.getId(), entityType: "new_t_activity" }

                        }],
                        function (data) {
                            //successCallback
                            var message = data[0].value;
                            var type = data[1].value;
                            var needRefersh = data[2].value;

                            setTimeout(Nikfort.Activity.updateNotificationOData, 5000);
                            if (!needRefersh) {
                                Xrm.Page.ui.setFormNotification(
                                    message,
                                    Nikfort.Activity.OptionSets.MessageTypes["10000000" + type],
                                    Nikfort.Activity.notificationId
                                );
                            }
                            else
                            {
                                Xrm.Page.data.refresh(false).then(
                                    function () {
                                        Xrm.Page.ui.setFormNotification(
                                            message,
                                            Nikfort.Activity.OptionSets.MessageTypes["10000000" + type],
                                            Nikfort.Activity.notificationId
                                        );
                                    }
                                )
                            }
                        },
                        function (data) {
                            //errorCallback
                            Xrm.Page.ui.setFormNotification(
                                "При выполнении перехода произошла ошибка: " + data,
                                "ERROR",
                                Nikfort.Activity.notificationId
                            );

                            setTimeout(Nikfort.Activity.updateNotificationOData, 5000);
                        }
                    )
                }
            );
        },

        createInitiativeHandler: function () {
            parent.$("#stageNavigateActionContainer").click();
            setTimeout(function () {
                parent.$("#bpfNavigateCreate").click();
            }, 200);
        },

        createInitiativeEnableRule: function () {
            var lastActivityStageId = Xrm.Page.data.process
                .getActivePath()
                .getAll()
                .filter(function (e) {
                    return e.getEntityName() === "new_t_activity";
                })
                .slice(-1)[0]
                .getId();
            var currentStageId = Xrm.Page.data.process.getSelectedStage().getId();
            return currentStageId === lastActivityStageId;
        }
    },
};

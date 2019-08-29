"use strict";
if (typeof (window.Nikfort) === "undefined") {
    console.log("Nikfort undefined, creating new object at FileStorage.js");
    window.Nikfort = {}
};

Nikfort.ProjectInitiative = {
    isCustomizationApplied: false,
    notificationId: "new_project_initiative__new_msg_text",
    updateNotificationODataInterval: null,
    OnLoad: function () {

        setInterval(Nikfort.ProjectInitiative.refreshTaskGrid, 3000);
        Xrm.Page.data.process.addOnStageChange(
            Nikfort.ProjectInitiative.refreshTaskGrid
        );

        Xrm.Page.getAttribute("new_msg_text").addOnChange(
            Nikfort.ProjectInitiative.showNotification
        );
        Xrm.Page.getAttribute("new_msg_type").addOnChange(
            Nikfort.ProjectInitiative.showNotification
        );
        Nikfort.ProjectInitiative.showNotification();
        Nikfort.Common.collapseProcessRibbon();
        Nikfort.Common.hideFormTitle();
        if (!Nikfort.ProjectInitiative.isCustomizationApplied) {
            Nikfort.ProjectInitiative.isCustomizationApplied = true;
            Nikfort.Common.adjustActivitiesButtons();
        }
        Nikfort.ProjectInitiative.updateNotificationOData();

    },
    refreshTaskGrid: function () {
        var control = Xrm.Page.getControl("project_initiative_task");
        if (control) {
            try {
                control.refresh();
                Nikfort.Common.collapseProcessRibbon();
            } catch (ex) {
                console.log("Control project_initiative_task can not be refreshed");
            }
        } else {
            console.log("Control project_initiative_task not found at this form");
        }
    },

    showNotification: function () {
        var text = Xrm.Page.getAttribute("new_msg_text").getValue();
        var type = Xrm.Page.getAttribute("new_msg_type").getValue();
        if (text && type) {
            Xrm.Page.ui.setFormNotification(
                text,
                Nikfort.ProjectInitiative.OptionSets.MessageTypes[type],
                Nikfort.ProjectInitiative.notificationId
            );
        } else {
            Xrm.Page.ui.clearFormNotification(
                Nikfort.ProjectInitiative.notificationId
            );
        }
    },
    updateNotificationOData: function () {
        Nikfort.ProjectInitiative.updateNotificationODataInterval = setInterval(function () {
            try {
                parent.$
                    .getJSON(
                    Xrm.Page.context.getClientUrl() +
                    "/api/data/v8.2/" +
                    Xrm.Internal.getEntitySetName(
                        Xrm.Page.data.entity.getEntityName()
                    ) +
                    "(" +
                    Xrm.Page.data.entity.getId().replace(/[\{\}]/g, "") +
                    ")?$select=new_msg_type,new_msg_text"
                    )
                    .then(function (result) {
                        if (!result.new_msg_type || !result.new_msg_text) {
                            Xrm.Page.ui.clearFormNotification(Nikfort.ProjectInitiative.notificationId);
                        }
                        var text = Xrm.Page.getAttribute("new_msg_text").getValue();
                        var type = Xrm.Page.getAttribute("new_msg_type").getValue();
                        if (result.new_msg_type === type && result.new_msg_text === text) {
                            return;
                        }
                        Xrm.Page.ui.setFormNotification(
                            result.new_msg_text,
                            Nikfort.ProjectInitiative.OptionSets.MessageTypes[
                            result.new_msg_type
                            ],
                            Nikfort.ProjectInitiative.notificationId
                        );
                    });
            } catch (ex) {
                console.log("Error while getting Notification Data on Project Initiative");
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
            /*clearInterval(Nikfort.ProjectInitiative.updateNotificationODataInterval);
            var valid = Nikfort.Common.CheckMandatoryFields();

            if (!valid) {
                Xrm.Page.ui.setFormNotification(
                    "Заполните обязательные поля",
                    "WARNING",
                    Nikfort.ProjectInitiative.notificationId
                );
                return;
            }

            Xrm.Page.data.save().then(
                function () {
                    var actionName = "xd_AssessmentPINextStep";
                    Nikfort.XrmSdk.Process.callAction(
                        actionName,
                        [{
                            key: "Target",
                            type: "a:EntityReference",
                            value: { id: Xrm.Page.data.entity.getId(), entityType: Xrm.Page.data.entity.getEntityName() }

                        }],
                        function (data) {
                            //successCallback
                            var message = data[0].value;
                            var type = data[1].value;
                            var needRefersh = data[2].value;

                            setTimeout(Nikfort.ProjectInitiative.updateNotificationOData, 5000);
                            if (!needRefersh) {
                                Xrm.Page.ui.setFormNotification(
                                    message,
                                    Nikfort.ProjectInitiative.OptionSets.MessageTypes["10000000" + type],
                                    Nikfort.ProjectInitiative.notificationId
                                );
                            }
                            else {
                                Xrm.Page.data.refresh(false).then(
                                    function () {
                                        Xrm.Page.ui.setFormNotification(
                                            message,
                                            Nikfort.ProjectInitiative.OptionSets.MessageTypes["10000000" + type],
                                            Nikfort.ProjectInitiative.notificationId
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
                                Nikfort.ProjectInitiative.notificationId
                            );

                            setTimeout(Nikfort.ProjectInitiative.updateNotificationOData, 5000);
                        }
                    )
                }
            );*/
        }
    }
};

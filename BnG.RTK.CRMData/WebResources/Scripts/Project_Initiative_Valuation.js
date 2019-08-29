"use strict";
if (typeof (window.Xdsoft) === "undefined") {
    console.log("Xdsoft undefined, creating new object");
    window.Xdsoft = {}
};

Xdsoft.ProjectInitiativeValuation = {
    updateNotificationODataInterval: null,
    notificationId: "new_project_initiative_valuation",

    OnLoad: function () {
    },
    
    Ribbon: {
        processNextStageHandler: function () {
            var valid = Nikfort.Common.CheckMandatoryFields();

            if (!valid) {
                Xrm.Page.ui.setFormNotification(
                    "Заполните обязательные поля",
                    "WARNING"
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

                            //setTimeout(Xdsoft.ProjectInitiativeValuation.updateNotificationOData, 5000);
                            if (!needRefersh) {
                                Xrm.Page.ui.setFormNotification(
                                    message,
                                    Xdsoft.ProjectInitiativeValuation.OptionSets.MessageTypes[type],
                                    Xdsoft.ProjectInitiativeValuation.notificationId
                                );
                            }
                            else {
                                Xrm.Page.data.refresh(false).then(
                                    function () {
                                        Xrm.Page.ui.setFormNotification(
                                            message,
                                            Xdsoft.ProjectInitiativeValuation.OptionSets.MessageTypes[type],
                                            Xdsoft.ProjectInitiativeValuation.notificationId
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
                                Xdsoft.ProjectInitiativeValuation.notificationId
                            );

                            //setTimeout(Xdsoft.ProjectInitiativeValuation.updateNotificationOData, 5000);
                        }
                    )
                }
            );
        }
    },

    OptionSets: {
        MessageTypes: {
            0: "INFO",
            1: "WARNING",
            2: "ERROR"
        }
    }
}

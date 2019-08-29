"use strict";

//console.log("evaluating common.js");

if (typeof window.Nikfort === "undefined") {
    //console.log("Nikfort undefined, creating new object at Common.js");
    window.Nikfort = {};
}

Nikfort.Common = {
    CheckMandatoryFields: function () {
        var populated = true;

        Xrm.Page.getAttribute(function (attribute, index) {
            if (attribute.getRequiredLevel() == "required") {
                if (attribute.getValue() === null) {
                    populated = false;
                }
            }
        });

        return populated;
    },
    hideFormTitle: function () {
        window.parent.document
            .querySelector(
            "#crmFormHeaderTop > div > div.headerDataContainerTable > div"
            )
            .setAttribute("style", "display:none");
    },
    collapseProcessRibbon: function () {
        Xrm.Page.ui.process && Xrm.Page.ui.process.setDisplayState("collapsed");

        parent
            .$("#processStagesScrollRegion")
            .children(".processStageContainer")
            .off();
    },
    adjustActivitiesButtons: function () {
        //#region Переименовать "Задача" в "Поручение" в фильтре блока Действия
        parent.document
            .querySelector("#activityFilterButton")
            .addEventListener("click", function () {
                var li = parent.document.querySelector(
                    '#moreActivitiesList > li[title="Задача"]'
                );
                var tag = li.querySelector("* > label");
                tag.innerHTML = tag.innerHTML.replace("Задача", "Поручение");
                li.title = "Поручение";
            });
        //#endregion

        //#region Перенести пункты списка доп команд (По кнопке "..."") к остальным кнопкам блока Действия
        parent.document.querySelector("#moreActivitiesButton").click();
        var container = parent.document.querySelector("#moreActivitiesButton")
            .parentNode;
        container
            .querySelectorAll(".activity-bar-label.activity-button-text")
            .forEach(function (e) {
                e.style.width = "";
                e.style.display = "";
            });

        Array.from(
            parent.document.querySelector("#moreActivitiesButton_Menu").children
        ).forEach(function (li) {
            var a = document.createElement("a");
            a.className = "activity-bar-label activity-button-text";
            a.href = "#";
            a.innerText = li.innerText;
            a.onclick = li.onclick;
            container.appendChild(a);
        });
        var moreActivitiesButton = parent.document.querySelector("#moreActivitiesButton");
        moreActivitiesButton.click();
        moreActivitiesButton.style.display = "none";
        //#endregion

        //#region Заменить кнопку "Добавить поручение" на кастомную, открывающую форму создания Поручения
        var task = parent.document
            .querySelector("#moreActivitiesButton")
            .parentNode.querySelector('a[title="Поручение"]');
        var a = document.createElement("a");
        a.className = "activity-bar-label activity-button-text";
        a.href = "#";
        a.innerText = "Добавить Поручение";
        a.onclick = function () {
            Xrm.Utility.openEntityForm(
                "task",
                null,
                {
                    new_CreateFromId: Xrm.Page.data.getEntity().getId(),
                    new_CreateFromType: Xrm.Page.data.getEntity().getEntityName()
                },
                {
                    openInNewWindow: true
                }
            );
        };
        if (task != null && task.parentNode != null) {
            task.parentNode.insertBefore(a, task.nextSibling);
            task.remove();
        }
        //#endregion

        //#region Сокрытие кнопки "Завершить"
        parent.document.querySelectorAll(".markcomplete").forEach(function (e) {
            e.remove();
        });
        //#endregion

        //#region Периодическое обновление блока "Действия"

        //    setInterval(function() {
        //      var activitiesTab = parent.document.querySelector('a[tabid="ActivitiesTab"]');
        //	  if (activitiesTab.click) {
        //		activitiesTab.click();
        //	  }
        //    }, 5000);

        //#endregion
    }
};

if (typeof (XdSoft) == "undefined") {
    XdSoft = {
        //ожидание асинхронной загрузки нужных скриптов
        WaitForScripts: function (namespaseNames, callback) {
            function checkScripts() {
                var allLoaded = true;
                for (var i = 0; i < namespaseNames.length; i++) {
                    var hasLoaded = true;
                    var namespase = namespaseNames[i];
                    hasLoaded = namespase != undefined;
                    allLoaded = allLoaded && hasLoaded;
                    if (!allLoaded) {
                        setTimeout(checkScripts, 10);
                        break;
                    }
                }
                if (allLoaded) {
                    callback();
                }
            }
            setTimeout(checkScripts, 0);
        },

        //загрузка jQuery из родительского фрейма (для MS CRM 2016 Turbo Forms)
        LoadJQueryFromParent: function () {
            if (typeof ($) === 'undefined') {
                $ = parent.$;
                jQuery = parent.jQuery;
            }
        }
    }
}

XdSoft.Transfer = {
    IntervalCheckStateIframeAdvancedFind: null,
    RefreshedOnload: false,
    
    OnLoad: function () {
        XdSoft.Transfer.AdvFindFrame();
    },

    AdvFindFrame: function () {
        var queryTextControl = Xrm.Page.getControl(XdSoft.Transfer.FieldNames.Query);
        var advFindFrame = Xrm.Page.getControl(XdSoft.Transfer.IFrames.AdvancedFind);
		advFindFrame.setSrc("../advancedfind/advfind.aspx?" + Math.round(Math.random()*10000));
		XdSoft.Transfer.IntervalCheckStateIframeAdvancedFind = setInterval(function () { XdSoft.Transfer.CheckStateIframeAdvancedFind() }, 2000);
		window.addEventListener("beforeunload", XdSoft.Transfer.OnFormClose);
		setTimeout(function () { Xrm.Page.data.refresh(false); }, 100);
    },

    OnSave: function () {
        XdSoft.Transfer.SaveFetchXml();
    },

    FixAdvFindBug: function () {
        if (!XdSoft.Transfer.RefreshedOnload) {
            Xrm.Page.data.refresh(false);
            XdSoft.Transfer.RefreshedOnload = true;
        }
    },

    SaveFetchXml: function () {
        var isFetchChanged = XdSoft.Transfer.GetFetchChanged();
        if (isFetchChanged && confirm("Запрос был изменен. \n Нажмите кнопку \"ОК\" для подтверждения изменений или кнопку \"Отмена\" чтобы продолжить редактирование условий")) {
            XdSoft.Transfer.SetFetchXmlToEntityField();
        }
    },

    GetFetchChanged: function () {
        try {
            var oldFetch = Xrm.Page.data.entity.attributes.get(XdSoft.Transfer.FieldNames.Query).getValue();
            var newFetch = XdSoft.Transfer.GetInnerFilterControl().get_fetchXml();
        }
        catch (e) {
            return false;
        }
        return (oldFetch != newFetch);
    },

    SetFetchXmlToEntityField: function () {
        try {
            var fetchXml = Xrm.Page.data.entity.attributes.get(XdSoft.Transfer.FieldNames.Query);
            XdSoft.Transfer.GetInnerFilterControl().set_isDirty(false);
            fetchXml.setValue(XdSoft.Transfer.GetInnerFetchXml());
            Xrm.Page.data.entity.save();
        }
        catch (e) {
            alert("Не удалось получить Fetch");
        }
    },

    OnFormClose: function (e) {
        var control = XdSoft.Transfer.GetInnerFilterControl();
        if (control && control.get_isDirty()) {
            control.set_isDirty(false);
        }
    },

    CheckStateIframeAdvancedFind: function () {
        try {
            var fetchXmlControl = Xrm.Page.data.entity.attributes.get(XdSoft.Transfer.FieldNames.Query);
            if (fetchXmlControl) {
                var fetchXmlValue = fetchXmlControl.getValue();
                sEntityName = XdSoft.Transfer.GetEntityNameFromFetch(fetchXmlValue);
                if (XdSoft.Transfer.SelectEntityInEntityList(sEntityName) && XdSoft.Transfer.SetFetchXmlToInnerFilterControl(fetchXmlValue)) {
                    clearInterval(XdSoft.Transfer.IntervalCheckStateIframeAdvancedFind);
                    XdSoft.Transfer.FixAdvFindBug();
                }
            }
        } catch (e) {
            //console.log("error in CheckStateIframeAdvancedFind");
        }
    },

    GetEntityNameFromFetch: function (fetchXml) {
        sEntityName = '';
        if (fetchXml == null) {
            fetchXml = '';
        }
        try {
            if (window.DOMParser) {
                var xml = new DOMParser().parseFromString(fetchXml, "text/xml");
                if (xml.getElementsByTagName("entity").length > 0)
                    var sEntityName = xml.getElementsByTagName("entity")[0].attributes["name"].value;
            }
            if (window.ActiveXObject) {
                var oXmlDoc = new ActiveXObject("Microsoft.XMLDOM");
                oXmlDoc.loadXML(fetchXml);
                if (oXmlDoc.selectSingleNode("//entity") != null)
                    sEntityName = oXmlDoc.selectSingleNode("//entity").attributes[0].value;
            }
        }
        catch (e) {
            alert("Не удалось получить имя сущности из fetch");
            return;
        }
        return sEntityName;
    },

    SetFetchXmlToInnerFilterControl: function (fetchXml) {
        var innerFilterControl = XdSoft.Transfer.GetInnerFilterControl();
        if (innerFilterControl) {
            innerFilterControl.set_fetchXml(fetchXml);
            return true;
        }
        return false;
    },

    SelectEntityInEntityList: function (newEntityName) {
        var entityList = XdSoft.Transfer.GetInnerFilterEntityList();
        try {
            if (newEntityName != '' && entityList.value != newEntityName) {
                entityList.value = newEntityName;

                if ("createEvent" in document) {
                    var evt = document.createEvent("HTMLEvents");
                    evt.initEvent("change", false, true);
                    entityList.dispatchEvent(evt);

                }
                else {
                    entityList.fireEvent("onchange");
                }
            }
            return true;
        }
        catch (e) {
            return false;
        }
    },

    GetInnerFetchXml: function () {
        var fetchXml = null;
        var innerFilterControl = XdSoft.Transfer.GetInnerFilterControl();
        if (innerFilterControl) {
            fetchXml = innerFilterControl.get_fetchXml();
        }
        return fetchXml;
    },

    GetInnerFilterControl: function () {
        try {
            var container = parent.$("#" + XdSoft.Transfer.IFrames.AdvancedFind).contents();
            var object = container.find("#contentIFrame").length != 0 ? container.find("#contentIFrame").contents().find("#advFind") : container.find("#contentIFrame0").contents().find("#advFind");
            return object.get(0).control;
        }
        catch (e) {
            return;
        }
    },

    GetInnerFilterEntityList: function () {
        try {
            var container = parent.$("#" + XdSoft.Transfer.IFrames.AdvancedFind).contents();
            var object = container.find("#contentIFrame").length != 0 ? container.find("#contentIFrame").contents().find("#advFind") : container.find("#contentIFrame0").contents().find("#advFind");
            return object.find("#slctPrimaryEntity").get(0);
        }
        catch (e) {
            return;
        }
    },

    ProcessEntityListChange: function (isDirty) {
        XdSoft.Transfer.GetInnerFilterEntityList();
    },

    IFrames: {
        AdvancedFind: "IFRAME_AdvFind"
    },

    FieldNames: {
        Query: "new_fetchquery",
    },
}
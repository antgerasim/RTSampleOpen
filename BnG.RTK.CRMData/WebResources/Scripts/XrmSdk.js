if (typeof (Nikfort) == "undefined")
{ Nikfort = {}; }
if (typeof (Nikfort.XrmSdk) == "undefined")
{ Nikfort.XrmSdk = {}; }

Nikfort.XrmSdk = {
    OData: {
        Create: function (object, type, successCallback, errorCallback, async) {
            var req = new XMLHttpRequest();
            var url = "/" + Xrm.Page.context.getOrgUniqueName() + "/XRMServices/2011/OrganizationData.svc/" + type;
            req.open("POST", url, async);
            req.setRequestHeader("Accept", "application/json");
            req.setRequestHeader("Content-Type", "application/json; charset=utf-8");
            req.onreadystatechange = function () {
                if (this.readyState == 4 /* complete */) {
                    if (this.status == 201) {
                        successCallback(JSON.parse(this.responseText, Nikfort.XrmSdk.Helper.DateReviver).d);
                    } else {
                        errorCallback(this);
                    }
                }
            };
            req.send(JSON.stringify(object));
        },
        Update: function (id, object, type, successCallback, errorCallback, async) {
            var req = new XMLHttpRequest();
            var url = "/" + Xrm.Page.context.getOrgUniqueName() + "/XRMServices/2011/OrganizationData.svc/" + type;
            req.open("POST", url + "(guid'" + id + "')", async);
            req.setRequestHeader("Accept", "application/json");
            req.setRequestHeader("Content-Type", "application/json; charset=utf-8");
            req.setRequestHeader("X-HTTP-Method", "MERGE");

            req.onreadystatechange = function () {
                if (this.readyState == 4 /* complete */) {
                    if (this.status == 204 || this.status == 1223) {
                        successCallback();
                    } else {
                        errorCallback(this);
                    }
                }
            };
            req.send(JSON.stringify(object));
        },
        RetrieveRecord: function (id, type, select, expand, successCallback, errorCallback, sync) {
            Nikfort.XrmSdk.Helper.ParameterCheck('Параметр id должен быть определен');
            Nikfort.XrmSdk.Helper.StringParameterCheck('Параметр id должен быть строкой');

            if (select != null)
                Nikfort.XrmSdk.Helper.StringParameterCheck(select, "Параметр select должен быть строкой");
            if (expand != null)
                Nikfort.XrmSdk.Helper.StringParameterCheck(select, "Параметр expand должен быть строкой");
            Nikfort.XrmSdk.Helper.CallbackParameterCheck(successCallback, "Параметр successCallback должен быть функцией");
            Nikfort.XrmSdk.Helper.CallbackParameterCheck(errorCallback, "Параметр errorCallback должен быть функцией");

            var systemQueryOptions = "";

            if (select != null || expand != null) {
                systemQueryOptions = "?";
                if (select != null) {
                    var selectString = "$select=" + select;
                    systemQueryOptions = systemQueryOptions + selectString;
                }
                if (expand != null) {
                    systemQueryOptions = systemQueryOptions + "&$expand=" + expand;
                }
            }

            $.ajax({
                method: "GET",
                url: Nikfort.XrmSdk.Helper.OData.GetBaseUrl() + type + "Set(guid'" + id + "')" + systemQueryOptions,
                async: !sync,
                headers: {
                    "Accept": "application/json",
                },
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    successCallback(response.d);
                },
                error: function (response) {
                    errorCallback(response);
                }
            });
        },

        RetrieveMultipleRecords: function (type, select, expand, filter, top, successCallback, errorCallback, sync) {
            if (select != null)
                Nikfort.XrmSdk.Helper.StringParameterCheck(select, "Параметр select должен быть строкой");
            if (expand != null)
                Nikfort.XrmSdk.Helper.StringParameterCheck(expand, "Параметр expand должен быть строкой");
            if (filter != null)
                Nikfort.XrmSdk.Helper.StringParameterCheck(filter, "Параметр filter должен быть строкой");
            if (top != null)
                Nikfort.XrmSdk.Helper.IntParameterCheck(top, "Параметр top должен быть числом");
            Nikfort.XrmSdk.Helper.CallbackParameterCheck(successCallback, "Параметр successCallback должен быть функцией");
            Nikfort.XrmSdk.Helper.CallbackParameterCheck(errorCallback, "Параметр errorCallback должен быть функцией");
            var systemQueryOptions = "";
            if (select != null || expand != null) {
                systemQueryOptions = "?";
                if (select != null) {
                    var selectString = "$select=" + select;
                    systemQueryOptions = systemQueryOptions + selectString;
                }
                if (expand != null) {
                    systemQueryOptions = systemQueryOptions + "&$expand=" + expand;
                }
                if (filter != null) {
                    systemQueryOptions = systemQueryOptions + "&$filter=" + filter;
                }
                if (top != null) {
                    systemQueryOptions = systemQueryOptions + "&$top=" + top;
                }
            }
            $.ajax({
                method: "GET",
                async: !sync,
                headers: {
                    "Accept": "application/json",
                },
                contentType: "application/json; charset=utf-8",
                url: Nikfort.XrmSdk.Helper.OData.GetBaseUrl() + type + "Set" + systemQueryOptions,
                success: function (response) {
                    successCallback(response.d);
                },
                error: function (response) {
                    errorCallback(response);
                }
            });
        },

        RetrieveRecordAssociation: function (id, paramType, association) {
            var serverUrl = "/" + Xrm.Page.context.getOrgUniqueName();
            var query = serverUrl + "/XRMServices/2011/OrganizationData.svc/" + paramType + "Set(guid'" + id + "')" + ((association == null || association == "") ? ("") : ("//" + association));
            var service = new XMLHttpRequest();
            service.open("GET", query, false);
            service.setRequestHeader("X-Requested-Width", "XMLHttpRequest");
            service.setRequestHeader("Accept", "application/json, text/javascript, */*");
            service.send(null);
            var requestResults = eval('(' + service.responseText + ')').d;
            return requestResults;
        },

        GetUserTimeZoneDetails: function () {
            var ODataPath = Xrm.Page.context.getServerUrl() + "/XRMServices/2011/OrganizationData.svc";
            var filter = "/UserSettingsSet(guid'" + Xrm.Page.context.getUserId() + "')";
            var userSettingReq = new XMLHttpRequest();
            userSettingReq.open('GET', ODataPath + filter, false);
            userSettingReq.setRequestHeader("Accept", "application/json");
            userSettingReq.setRequestHeader("Content-Type", "application/json; charset=utf-8");
            userSettingReq.send(null);
            var userSetting = eval('(' + userSettingReq.responseText + ')').d;
            var timeZoneBias;
            try {
                timeZoneBias = userSetting.TimeZoneBias;
            }
            catch (e) {
                timeZoneBias = 0;
            }
            return timeZoneBias;
        }
    },

    Soap: {
        Fetch: function (fetchXml, callback) {
            var msgBody = "<query i:type='a:FetchExpression' xmlns:a='http://schemas.microsoft.com/xrm/2011/Contracts'>" +
                            "<a:Query>" +
                                ((typeof window.CrmEncodeDecode != 'undefined') ? window.CrmEncodeDecode.CrmXmlEncode(fetchXml) : crmXmlEncode(fetchXml)) +
                            "</a:Query>" +
                        "</query>";
            var async = !!callback;

            return Nikfort.XrmSdk.Helper.Soap.ExecuteRequest(msgBody, "RetrieveMultiple", !!callback, Nikfort.XrmSdk.Helper.Soap.GetBaseUrl() + 'web', function (resultXml) {
                var fetchResult;
                if ($(resultXml).find("a\\:Entities").length != 0) {
                    fetchResult = $(resultXml).find("a\\:Entities").eq(0)[0];
                } else {
                    fetchResult = $(resultXml).find("Entities").eq(0)[0]; //chrome could not load node
                }

                var fetchResults = [];

                for (var i = 0; i < fetchResult.childNodes.length; i++) {
                    var entity = new Nikfort.XrmSdk.Helper.BusinessEntity();

                    entity.deserialize(fetchResult.childNodes[i]);
                    fetchResults[i] = entity;
                }

                if (!async)
                    return fetchResults;
                else
                    callback(fetchResults);
                // ReSharper disable NotAllPathsReturnValue
            });
        },

        CustomActionExecutor: function (requestXml, successCallback, errorCallback, async) {
            var url = Xrm.Page.context.getClientUrl() + "/XRMServices/2011/Organization.svc/web";
            var req = new XMLHttpRequest();
            req.open("POST", url, !!async);

            try {
                req.responseType = 'msxml-document';
            } catch (e) { }
            req.setRequestHeader("Accept", "application/xml, text/xml, */*");
            req.setRequestHeader("Content-Type", "text/xml; charset=utf-8");
            req.setRequestHeader("SOAPAction", "http://schemas.microsoft.com/xrm/2011/Contracts/Services/IOrganizationService/Execute");
            req.onreadystatechange = function () {
                if (req.readyState == 4) { // "complete"
                    if (req.status == 200) { // "OK"
                        Nikfort.XrmSdk.Helper.ProcessCustomActionExecutorResponse(req.responseXML, successCallback, errorCallback);
                    } else {
                        errorCallback('error');
                    }
                }
            };
            req.send(requestXml);
        },
        SetState: function (entityName, id, stateCode, statusCode, callback) {
            var request = [
                    "<request i:type='b:SetStateRequest' xmlns:a='http://schemas.microsoft.com/xrm/2011/Contracts' xmlns:b='http://schemas.microsoft.com/crm/2011/Contracts'>",
                        "<a:Parameters xmlns:c='http://schemas.datacontract.org/2004/07/System.Collections.Generic'>",
                            "<a:KeyValuePairOfstringanyType>",
                                "<c:key>EntityMoniker</c:key>",
                                "<c:value i:type='a:EntityReference'>",
                                  "<a:Id>", id, "</a:Id>",
                                  "<a:LogicalName>", entityName, "</a:LogicalName>",
                                  "<a:Name i:nil='true' />",
                                "</c:value>",
                              "</a:KeyValuePairOfstringanyType>",
                              "<a:KeyValuePairOfstringanyType>",
                                "<c:key>State</c:key>",
                                "<c:value i:type='a:OptionSetValue'>",
                                  "<a:Value>", stateCode.toString(), "</a:Value>",
                                "</c:value>",
                              "</a:KeyValuePairOfstringanyType>",
                              "<a:KeyValuePairOfstringanyType>",
                                "<c:key>Status</c:key>",
                                "<c:value i:type='a:OptionSetValue'>",
                                  "<a:Value>", statusCode.toString(), "</a:Value>",
                                "</c:value>",
                              "</a:KeyValuePairOfstringanyType>",
                        "</a:Parameters>",
                        "<a:RequestId i:nil='true' />",
                        "<a:RequestName>SetState</a:RequestName>",
                    "</request>"
            ].join("");

            var async = !!callback;

            return Nikfort.XrmSdk.Helper.Soap.ExecuteRequest(request, "Execute", async, Nikfort.XrmSdk.Helper.Soap.GetBaseUrl() + 'web', function (resultXml, isError) {
                if (!async)
                    return result;
                else
                    callback(resultXml, isError);
            });
        },
        Assign: function (targetEntityName, targetId, assigneeEntityName, assigneeId, callback) {
            var request = "<request i:type='b:AssignRequest' xmlns:a='http://schemas.microsoft.com/xrm/2011/Contracts' xmlns:b='http://schemas.microsoft.com/crm/2011/Contracts'>" +
                            "<a:Parameters xmlns:c='http://schemas.datacontract.org/2004/07/System.Collections.Generic'>" +
                              "<a:KeyValuePairOfstringanyType>" +
                                "<c:key>Target</c:key>" +
                                "<c:value i:type='a:EntityReference'>" +
                                  "<a:Id>" + targetId + "</a:Id>" +
                                  "<a:LogicalName>" + targetEntityName + "</a:LogicalName>" +
                                  "<a:Name i:nil='true' />" +
                                "</c:value>" +
                              "</a:KeyValuePairOfstringanyType>" +
                              "<a:KeyValuePairOfstringanyType>" +
                                "<c:key>Assignee</c:key>" +
                                "<c:value i:type='a:EntityReference'>" +
                                  "<a:Id>" + assigneeId + "</a:Id>" +
                                  "<a:LogicalName>" + assigneeEntityName + "</a:LogicalName>" +
                                  "<a:Name i:nil='true' />" +
                                "</c:value>" +
                              "</a:KeyValuePairOfstringanyType>" +
                            "</a:Parameters>" +
                            "<a:RequestId i:nil='true' />" +
                            "<a:RequestName>Assign</a:RequestName>" +
                          "</request>";
            var async = !!callback;

            return Nikfort.XrmSdk.Helper.Soap.ExecuteRequest(request, "Execute", async, "/" + Xrm.Page.context.getOrgUniqueName() + "/XRMServices/2011/OrganizationData.svc/web", function (result) {
                //            var response = $(resultXml).find('ExecuteResult').eq(0);
                //            var result = ((typeof window.CrmEncodeDecode != 'undefined') ? window.CrmEncodeDecode.CrmXmlDecode(response.text()) : crmXmlDecode(response.text()));
                if (!async)
                    return result;
                else
                    callback(result);
            });
        }
    },
    Process: {}
};

Nikfort.XrmSdk.Helper = {
    ProcessCustomActionExecutorResponse: function (responseXml, successCallback) {
        try {
            var namespaces = [
                "xmlns:s='http://schemas.xmlsoap.org/soap/envelope/'",
                "xmlns:a='http://schemas.microsoft.com/xrm/2011/Contracts'",
                "xmlns:i='http://www.w3.org/2001/XMLSchema-instance'",
                "xmlns:b='http://schemas.microsoft.com/crm/2011/Contracts'",
                "xmlns:c='http://schemas.datacontract.org/2004/07/System.Collections.Generic'"];
            responseXml.setProperty("SelectionNamespaces", namespaces.join(" "));
        } catch (e) { }

        var resultNodes = Nikfort.XrmSdk.Helper.SelectNodes(responseXml, "//a:Results/a:KeyValuePairOfstringanyType");

        successCallback(Nikfort.XrmSdk.Helper.ObjectifyNodes(resultNodes));
    },
    ObjectifyNodes: function (nodes) {
        var result = {};

        for (var i = 0; i < nodes.length; i++) {
            var fieldName = Nikfort.XrmSdk.Helper.GetNodeText(nodes[i].firstChild);
            var fieldValue = nodes[i].childNodes[1];
            result[fieldName] = Nikfort.XrmSdk.Helper.ObjectifyNode(fieldValue);
        }

        return result;
    },
    ObjectifyNode: function (node) {
        if (node.attributes != null) {
            if (node.attributes.getNamedItem("i:nil") != null && node.attributes.getNamedItem("i:nil").nodeValue == "true") {
                return null;
            }

            var nodeTypeName = node.attributes.getNamedItem("i:type") == null ? "c:string" : node.attributes.getNamedItem("i:type").nodeValue;

            switch (nodeTypeName) {
                case "a:EntityReference":
                    return {
                        id: Nikfort.XrmSdk.Helper.GetNodeText(node.childNodes[0]),
                        entityType: Nikfort.XrmSdk.Helper.GetNodeText(node.childNodes[1])
                    };
                case "a:Entity":
                    return Nikfort.XrmSdk.Helper.ObjectifyRecord(node);
                case "a:EntityCollection":
                    return Nikfort.XrmSdk.Helper.ObjectifyCollection(node.firstChild);
                case "c:dateTime":
                    return Nikfort.XrmSdk.Helper.ParseIsoDate(Nikfort.XrmSdk.Helper.GetNodeText(node));
                case "c:guid":
                case "c:string":
                    return Nikfort.XrmSdk.Helper.GetNodeText(node);
                case "c:int":
                    return parseInt(Nikfort.XrmSdk.Helper.GetNodeText(node));
                case "a:OptionSetValue":
                    return parseInt(Nikfort.XrmSdk.Helper.GetNodeText(node.childNodes[0]));
                case "c:boolean":
                    return Nikfort.XrmSdk.Helper.GetNodeText(node.childNodes[0]) == "true";
                case "c:double":
                case "c:decimal":
                case "a:Money":
                    return parseFloat(Nikfort.XrmSdk.Helper.GetNodeText(node.childNodes[0]));
                default:
                    return null;
            }
        }

        return null;
    },
    ObjectifyCollection: function (node) {
        var result = [];

        for (var i = 0; i < node.childNodes.length; i++) {
            result.push(Nikfort.XrmSdk.Helper.ObjectifyRecord(node.childNodes[i]));
        }

        return result;
    },
    ObjectifyRecord: function (node) {
        var result = {};

        result.logicalName = (node.childNodes[4].text !== undefined) ? node.childNodes[4].text : node.childNodes[4].textContent;
        result.id = (node.childNodes[3].text !== undefined) ? node.childNodes[3].text : node.childNodes[3].textContent;

        result.attributes = Nikfort.XrmSdk.Helper.ObjectifyNodes(node.childNodes[0].childNodes);
        result.formattedValues = Nikfort.XrmSdk.Helper.ObjectifyNodes(node.childNodes[2].childNodes);

        return result;
    },
    ParseIsoDate: function (s) {
        if (s == null || !s.match(Nikfort.XrmSdk.Helper.isoDateExpression))
            return null;

        var dateParts = Nikfort.XrmSdk.Helper.isoDateExpression.exec(s);
        return new Date(Date.UTC(parseInt(dateParts[1], 10),
            parseInt(dateParts[2], 10) - 1,
            parseInt(dateParts[3], 10),
            parseInt(dateParts[4], 10) - (dateParts[8] == "" || dateParts[8] == "Z" ? 0 : parseInt(dateParts[8])),
            parseInt(dateParts[5], 10),
            parseInt(dateParts[6], 10)));
    },
    SelectNodes: function (node, xPathExpression) {
        if (typeof (node.selectNodes) != "undefined") {
            return node.selectNodes(xPathExpression);
        }
        else {
            var output = [];
            var xPathResults = node.evaluate(xPathExpression, node, Nikfort.XrmSdk.Helper.NSResolver, XPathResult.ANY_TYPE, null);
            var result = xPathResults.iterateNext();
            while (result) {
                output.push(result);
                result = xPathResults.iterateNext();
            }
            return output;
        }
    },
    isoDateExpression: /^(\d{4})-(\d{2})-(\d{2})T(\d{2}):(\d{2}):(\d{2})\.?(\d*)?(Z|[+-]\d{2}?(:\d{2})?)?$/,
    namespace: true,
    ProcessResponse: function (responseXml, responseText) {
        var error;
        var faultString;
        var xmlDoc;
        if (responseXml === null || typeof responseXml === 'undefined' || responseXml.xml === null || responseXml.xml === "") {
            if (responseText !== null && responseText !== "") {
                throw new Error(responseText);
            }
            else
                throw new Error("No response received from the server. ");
        }
        if (typeof responseXml.xml === 'undefined') {
            error = $(responseText).find("error").text();
            faultString = $(responseText).find("faultstring").text();
            if (error != '' || faultString != '') {
                throw new Error(error !== '' ? $(responseText).find('description').text() : faultString);
            }
            xmlDoc = Nikfort.XrmSdk.Helper.XmlParser(responseText);
        } else {
            error = $(responseXml).find("error").text();
            faultString = $(responseXml).find("faultstring").text();
            if (error != '' || faultString != '') {
                throw new Error(error !== '' ? $(responseXml).find('description').text() : faultString);
            }
            xmlDoc = Nikfort.XrmSdk.Helper.XmlParser(Nikfort.XrmSdk.Helper.XmlToString(responseXml));
        }
        return xmlDoc;
    },
    ParameterCheck: function (parameter, message) {
        if ((typeof parameter === "undefined") || parameter === null) {
            throw new Error(message);
        }
    },
    StringParameterCheck: function (parameter, message) {
        if (typeof parameter != "string") {
            throw new Error(message);
        }
    },
    CallbackParameterCheck: function (callbackParameter, message) {
        if (typeof callbackParameter != "function") {
            throw new Error(message);
        }
    },
    BooleanParameterCheck: function (parameter, message) {
        if (typeof parameter != "boolean") {
            throw new Error(message);
        }
    },
    IntParameterCheck: function (parameter, message) {
        if (isNaN(parameter)) {
            throw new Error(message);
        }
    },
    DateReviver: function (key, value) {
        var a;
        if (typeof value === 'string') {
            a = /Date\(([-+]?\d+)\)/.exec(value);
            if (a) {
                return new Date(parseInt(value.replace("/Date(", "").replace(")/", ""), 10));
            }
        }
        return value;
    },

    OData: {
        GetBaseUrl: function () {
            var serverUrl = "/" + Xrm.Page.context.getOrgUniqueName();
            return serverUrl + "/XRMServices/2011/OrganizationData.svc/";
        }
    },

    Soap: {
        ExecuteRequest: function (soapBody, requestType, async, url, internalCallback) {
            async = async || false;
            var soapXml =
            ["<soap:Envelope xmlns:soap='http://schemas.xmlsoap.org/soap/envelope/'>",
                "<soap:Body>",
                    "<", requestType, " xmlns='http://schemas.microsoft.com/xrm/2011/Contracts/Services' xmlns:i='http://www.w3.org/2001/XMLSchema-instance'>", soapBody, "</", requestType, ">",
                "</soap:Body>",
                "</soap:Envelope>"
            ].join("");

            var req = new XMLHttpRequest();
            req.open("POST", url, async);
            req.setRequestHeader("Accept", "application/json; charset=utf-8");
            req.setRequestHeader("Content-Type", "text/xml; charset=utf-8");
            req.setRequestHeader("SOAPAction", "http://schemas.microsoft.com/xrm/2011/Contracts/Services/IOrganizationService/" + requestType);

            req.send(soapXml);

            if (async) {
                req.onreadystatechange = function () {
                    if (req.readyState === 4 /* complete */) {
                        req.onreadystatechange = null; //Addresses potential memory leak issue with IE
                        var doc = req.responseXML;
                        try { Nikfort.XrmSdk.Helper.SetSelectionNamespaces(doc); } catch (e) { }
                        if (req.status === 200) { // "OK"
                            internalCallback(doc, false);
                        }
                        else {
                            internalCallback(doc, true);
                        }
                    }
                };
            }
            else {
                var result = Nikfort.XrmSdk.Helper.ProcessResponse(req.responseXML, req.responseText);
                return !!internalCallback ? internalCallback(result) : result;
            }
        },
        GetBaseUrl: function () {
            var serverUrl = "/" + Xrm.Page.context.getOrgUniqueName();
            return serverUrl + "/XRMServices/2011/Organization.svc/";
        }
    },





//Rename from here
    XrmValue: function (sType, sValue) {
        this.type = sType;
        this.value = sValue;
    },

    XrmEntityReference: function (gId, sLogicalName, sName) {
        this.id = gId;
        this.logicalName = sLogicalName;
        this.name = sName;
        this.type = 'EntityReference';
    },

    XrmEntityCollection: function (items) {
        this.value = items;
        this.type = 'EntityCollection';
    },

    XrmOptionSetValue: function (iValue, sFormattedValue) {
        this.value = iValue;
        this.formattedValue = sFormattedValue;
        this.type = 'OptionSetValue';
    },

    StringToDate: function (s) {
        var b = s.split(/\D/);
        return new Date(Date.UTC(b[0], --b[1], b[2], b[3], b[4], b[5]));
    },

    NsResolver: function (prefix) {
        var ns = {
            "s": "http://schemas.xmlsoap.org/soap/envelope/",
            "a": "http://schemas.microsoft.com/xrm/2011/Contracts",
            "i": "http://www.w3.org/2001/XMLSchema-instance",
            "b": "http://schemas.datacontract.org/2004/07/System.Collections.Generic",
            "c": "http://schemas.microsoft.com/xrm/2011/Metadata",
            "ser": "http://schemas.microsoft.com/xrm/2011/Contracts/Services"
        };
        return ns[prefix] || null;
    },

    IsNodeNull: function (node) {
        if (node == null)
        { return true; }
        if ((node.attributes.getNamedItem("i:nil") != null) && (node.attributes.getNamedItem("i:nil").value === "true"))
        { return true; }
        return false;
    },

    SelectNodes: function (node, xPathExpression) {
        if (typeof (node.selectNodes) != "undefined") {
            return node.selectNodes(xPathExpression);
        }
        else {
            var output = [];
            var xPathResults = node.evaluate(xPathExpression, node, Nikfort.XrmSdk.Helper.NsResolver, XPathResult.ANY_TYPE, null);
            var result = xPathResults.iterateNext();
            while (result) {
                output.push(result);
                result = xPathResults.iterateNext();
            }
            return output;
        }
    },

    SelectSingleNode: function (node, xpathExpr) {
        if (typeof (node.selectSingleNode) != "undefined") {
            return node.selectSingleNode(xpathExpr);
        }
        else {
            var xpe = new XPathEvaluator();
            var results = xpe.evaluate(xpathExpr, node, Nikfort.XrmSdk.Helper.NsResolver, XPathResult.FIRST_ORDERED_NODE_TYPE, null);
            return results.singleNodeValue;

        }
    },

    SelectSingleNodeText: function (node, xpathExpr) {
        var x = selectSingleNode(node, xpathExpr);
        if (Nikfort.XrmSdk.Helper.IsNodeNull(x))
        { return null; }
        if (typeof (x.text) != "undefined") {
            return x.text;
        }
        else {
            return x.textContent;
        }
    },

    GetNodeText: function (node) {
        if (typeof (node.text) != "undefined") {
            return node.text;
        }
        else {
            return node.textContent;
        }
    },

    SetSelectionNamespaces: function (doc) {
        var namespaces = [
            "xmlns:s='http://schemas.xmlsoap.org/soap/envelope/'",
            "xmlns:a='http://schemas.microsoft.com/xrm/2011/Contracts'",
            "xmlns:i='http://www.w3.org/2001/XMLSchema-instance'",
            "xmlns:b='http://schemas.datacontract.org/2004/07/System.Collections.Generic'",
            "xmlns:c='http://schemas.microsoft.com/xrm/2011/Metadata'",
            "xmlns:ser='http://schemas.microsoft.com/xrm/2011/Contracts/Services'"
        ];
        doc.setProperty("SelectionNamespaces", namespaces.join(" "));
    },

    XmlParser: function (txt) {
        ///<summary>
        /// cross browser responseXml to return a XML object
        ///</summary>
        var xmlDoc = null;
        try {
            xmlDoc = new ActiveXObject("Microsoft.XMLDOM");
            xmlDoc.async = false;
            xmlDoc.loadXML(txt);
        } catch (e) {
            if (window.DOMParser) {
                // ReSharper disable InconsistentNaming
                var parser = new DOMParser();
                // ReSharper restore InconsistentNaming
                xmlDoc = parser.parseFromString(txt, "text/xml");
            } else {
                alertMessage("Cannot convert the XML string to a cross-browser XML object.");
            }
        }

        return xmlDoc;
    },

    XmlToString: function (responseXml) {
        var xmlString = '';
        try {
            if (responseXml != null) {
                if (typeof XMLSerializer !== "undefined" && typeof responseXml.xml === "undefined") {
                    // ReSharper disable InconsistentNaming
                    xmlString = (new XMLSerializer()).serializeToString(responseXml);
                    // ReSharper restore InconsistentNaming
                } else {
                    if (typeof responseXml.xml !== "undefined") {
                        xmlString = responseXml.xml;
                    }
                    else if (typeof responseXml[0].xml !== "undefined") {
                        xmlString = responseXml[0].xml;
                    }

                }
            }
        } catch (e) {
            alertMessage("Cannot convert the XML to a string.");
        }
        return xmlString;
    },

    BusinessEntity: function (logicalName, id) {
        ///<summary>
        /// A object represents a business entity for CRM 2011.
        ///</summary>
        ///<param name="logicalName" type="String">
        /// A String represents the name of the entity.
        /// For example, "contact" means the business entity will be a contact entity
        /// </param>
        ///<param name="id" type="String">
        /// A String represents the id of the entity. If not passed, it will be auto populated as a empty guid string
        /// </param>
        this.id = (!id) ? "00000000-0000-0000-0000-000000000000" : id;
        this.logicalName = logicalName;
        this.attributes = new Object();
    }
};

Nikfort.XrmSdk.Helper.BusinessEntity.prototype = {
    /**
    * Serialize a CRM Business Entity object to XML string in order to be passed to CRM Web Services.
    * @return {String} The serialized XML string of CRM entity.
    */
    serialize: function () {
        var xml = ["<b:value i:type='a:Entity'>"];
        xml.push('<a:Attributes xmlns:b="http://schemas.datacontract.org/2004/07/System.Collections.Generic">');
        var attributes = this.attributes;
        for (var attributeName in attributes) {
            if (attributes.hasOwnProperty(attributeName)) {
                var attribute = attributes[attributeName];

                xml.push("<a:KeyValuePairOfstringanyType>");
                xml.push("<b:key>", attributeName, "</b:key>");

                if (attribute === null || attribute.value === null) {
                    xml.push("<b:value i:nil='true' />");
                } else {
                    var sType = (!attribute.type)
                        ? typeof attribute
                        : crmXmlEncode(attribute.type);
                    var value;
                    var encodedValue;
                    var id;
                    var encodedId;
                    var logicalName;
                    var encodedLogicalName;
                    switch (sType) {
                        case "OptionSetValue":
                            value = (attribute.hasOwnProperty("value")) ? attribute["value"] : attribute;
                            encodedValue = encodeValue(value);
                            xml.push("<b:value i:type='a:OptionSetValue'>");
                            xml.push("<a:Value>", encodedValue, "</a:Value>", "</b:value>");
                            break;

                        case "EntityCollection":
                            xml.push("<b:value i:type='a:EntityCollection'>");
                            xml.push("<a:Entities>");
                            value = (attribute.hasOwnProperty("value")) ? attribute["value"] : attribute;
                            var collections = isArray(value) ? value : [value];

                            for (var i = 0, collectionLengh = collections.length; i < collectionLengh; i++) {
                                var item = collections[i];
                                id = (item.hasOwnProperty("id")) ? item["id"] : item;
                                encodedId = encodeValue(id);
                                logicalName = (item.hasOwnProperty("logicalName")) ? item["logicalName"] : item;
                                encodedLogicalName = encodeValue(logicalName);
                                xml.push("<a:Entity>");
                                xml.push("<a:Attributes>");
                                xml.push("<a:KeyValuePairOfstringanyType>");
                                xml.push("<b:key>partyid</b:key>");
                                xml.push("<b:value i:type='a:EntityReference'>");
                                xml.push("<a:Id>", encodedId, "</a:Id>");
                                xml.push("<a:LogicalName>", encodedLogicalName, "</a:LogicalName>");
                                xml.push("<a:Name i:nil='true' />");
                                xml.push("</b:value>");
                                xml.push("</a:KeyValuePairOfstringanyType>");
                                xml.push("</a:Attributes>");
                                xml.push("<a:EntityState i:nil='true' />");
                                xml.push("<a:FormattedValues />");
                                xml.push("<a:Id>00000000-0000-0000-0000-000000000000</a:Id>");
                                xml.push("<a:LogicalName>activityparty</a:LogicalName>");
                                xml.push("<a:RelatedEntities />");
                                xml.push("</a:Entity>");
                            }
                            xml.push("</a:Entities>");
                            xml.push("<a:EntityName i:nil='true' />");
                            xml.push("<a:MinActiveRowVersion i:nil='true' />");
                            xml.push("<a:MoreRecords>false</a:MoreRecords>");
                            xml.push("<a:PagingCookie i:nil='true' />");
                            xml.push("<a:TotalRecordCount>0</a:TotalRecordCount>");
                            xml.push("<a:TotalRecordCountLimitExceeded>false</a:TotalRecordCountLimitExceeded>");
                            xml.push("</b:value>");
                            break;

                        case "EntityReference":
                            id = (attribute.hasOwnProperty("id")) ? attribute["id"] : attribute;
                            encodedId = encodeValue(id);
                            logicalName = (attribute.hasOwnProperty("logicalName")) ? attribute["logicalName"] : attribute;
                            encodedLogicalName = encodeValue(logicalName);
                            xml.push("<b:value i:type='a:EntityReference'>");
                            xml.push("<a:Id>", encodedId, "</a:Id>");
                            xml.push("<a:LogicalName>", encodedLogicalName, "</a:LogicalName>");
                            xml.push("<a:Name i:nil='true' />", "</b:value>");
                            break;

                        case "Money":
                            value = (attribute.hasOwnProperty("value")) ? attribute["value"] : attribute;
                            encodedValue = encodeValue(value);
                            xml.push("<b:value i:type='a:Money'>");
                            xml.push("<a:Value>", encodedValue, "</a:Value>", "</b:value>");
                            break;

                        case "guid":
                            value = (attribute.hasOwnProperty("value")) ? attribute["value"] : attribute;
                            encodedValue = encodeValue(value);
                            xml.push("<b:value i:type='c:guid' xmlns:c='http://schemas.microsoft.com/2003/10/Serialization/'>");
                            xml.push(encodedValue, "</b:value>");
                            break;

                        case "number":
                            value = (attribute.hasOwnProperty("value")) ? attribute["value"] : attribute;
                            encodedValue = encodeValue(value);
                            var oType = (parseInt(encodedValue) === encodedValue) ? "c:int" : "c:decimal";
                            xml.push("<b:value i:type='", oType, "' xmlns:c='http://www.w3.org/2001/XMLSchema'>");
                            xml.push(encodedValue, '</b:value>');
                            break;

                        default:
                            value = (attribute.hasOwnProperty("value")) ? attribute["value"] : attribute;
                            encodedValue = encodeValue(value);
                            sType = (typeof value === "object" && value.getTime) ? "dateTime" : sType;
                            xml.push("<b:value i:type='c:", sType, "' xmlns:c='http://www.w3.org/2001/XMLSchema'>", encodedValue, "</b:value>");
                            break;
                    }
                }
                xml.push("</a:KeyValuePairOfstringanyType>");
            }
        }

        xml.push("</a:Attributes><a:EntityState i:nil='true' />");
        xml.push("<a:FormattedValues xmlns:b='http://schemas.datacontract.org/2004/07/System.Collections.Generic' />");
        xml.push("<a:Id>", encodeValue(this.id), "</a:Id>");
        xml.push("<a:LogicalName>", this.logicalName, "</a:LogicalName>");
        xml.push("<a:RelatedEntities xmlns:b='http://schemas.datacontract.org/2004/07/System.Collections.Generic' />");
        xml.push("</b:value>");
        return xml.join("");
    },

    /**
    * Deserialize an XML node into a CRM Business Entity object. The XML node comes from CRM Web Service's response.
    * @param {object} resultNode The XML node returned from CRM Web Service's Fetch, Retrieve, RetrieveMultiple messages.
    */
    deserialize: function (resultNode) {
        var obj = new Object();
        var resultNodes = resultNode.childNodes;

        for (var j = 0, lenj = resultNodes.length; j < lenj; j++) {
            var sKey;
            var parentNode = resultNodes[j];
            switch (parentNode.nodeName) {
                case "a:Attributes":
                    var attr = parentNode;
                    for (var k = 0, lenk = attr.childNodes.length; k < lenk; k++) {
                        var tempParentNode = attr.childNodes[k];
                        // Establish the Key for the Attribute
                        var tempParentNodeChildNodes = tempParentNode.childNodes;
                        sKey = Nikfort.XrmSdk.Helper.GetNodeText(tempParentNodeChildNodes[0]);

                        var tempNode = tempParentNodeChildNodes[1];
                        // Determine the Type of Attribute value we should expect
                        var sType = tempNode.attributes.getNamedItem("i:type").value;

                        // check for AliasedValue
                        if (sType.replace('c:', '').replace('a:', '') === "AliasedValue") {
                            // reset the type to the actual attribute type
                            var subNode = tempNode.childNodes[2];
                            sType = subNode.attributes.getNamedItem("i:type").value;

                            //sKey = getNodeText(tempNode.childNodes[1]) + "." + getNodeText(tempNode.childNodes[0]);
                            // reset the node to the AliasedValue value node
                            tempNode = subNode;
                        }

                        var entRef;
                        var entCv;
                        switch (sType) {
                            case "a:OptionSetValue":
                                var entOsv = new Nikfort.XrmSdk.Helper.XrmOptionSetValue();
                                entOsv.type = sType.replace('a:', '');
                                entOsv.value = parseInt(Nikfort.XrmSdk.Helper.GetNodeText(tempNode));
                                obj[sKey] = entOsv;
                                break;

                            case "a:EntityReference":
                                entRef = new Nikfort.XrmSdk.Helper.XrmEntityReference();
                                entRef.type = sType.replace('a:', '');
                                var oChildNodes = tempNode.childNodes;
                                entRef.id = Nikfort.XrmSdk.Helper.GetNodeText(oChildNodes[0]);
                                entRef.logicalName = Nikfort.XrmSdk.Helper.GetNodeText(oChildNodes[1]);
                                entRef.name = Nikfort.XrmSdk.Helper.GetNodeText(oChildNodes[2]);
                                obj[sKey] = entRef;
                                break;

                            case "a:EntityCollection":
                                entRef = new Nikfort.XrmSdk.Helper.XrmEntityCollection();
                                entRef.type = sType.replace('a:', '');

                                //get all party items....
                                var items = [];
                                var partyNodes = tempNode.childNodes;
                                for (var y = 0, leny = partyNodes[0].childNodes.length; y < leny; y++) {
                                    var itemNodes = tempParentNode.childNodes[1].childNodes[0].childNodes[y].childNodes[0].childNodes;
                                    for (var z = 0, lenz = itemNodes.length; z < lenz; z++) {
                                        var itemNodeChildNodes = itemNodes[z].childNodes;
                                        var nodeText = Nikfort.XrmSdk.Helper.GetNodeText(itemNodeChildNodes[0]);
                                        if (nodeText === "partyid") {
                                            var itemRef = new Nikfort.XrmSdk.Helper.XrmEntityReference();
                                            itemRef.id = Nikfort.XrmSdk.Helper.GetNodeText(itemNodeChildNodes[1].childNodes[0]);
                                            itemRef.logicalName = Nikfort.XrmSdk.Helper.GetNodeText(itemNodeChildNodes[1].childNodes[1]);
                                            itemRef.name = Nikfort.XrmSdk.Helper.GetNodeText(itemNodeChildNodes[1].childNodes[2]);
                                            items[y] = itemRef;
                                        }
                                    }
                                }
                                entRef.value = items;
                                obj[sKey] = entRef;
                                break;

                            case "a:Money":
                                entCv = new Nikfort.XrmSdk.Helper.XrmValue();
                                entCv.type = sType.replace('a:', '');
                                entCv.value = parseFloat(Nikfort.XrmSdk.Helper.GetNodeText(tempNode));
                                obj[sKey] = entCv;
                                break;

                            default:
                                entCv = new Nikfort.XrmSdk.Helper.XrmValue();
                                entCv.type = sType.replace('c:', '').replace('a:', '');
                                if (entCv.type === "int") {
                                    entCv.value = parseInt(Nikfort.XrmSdk.Helper.GetNodeText(tempNode));
                                }
                                else if (entCv.type === "decimal" || entCv.type === "double") {
                                    entCv.value = parseFloat(Nikfort.XrmSdk.Helper.GetNodeText(tempNode));
                                }
                                else if (entCv.type === "dateTime") {
                                    entCv.value = Nikfort.XrmSdk.Helper.StringToDate(Nikfort.XrmSdk.Helper.GetNodeText(tempNode));
                                }
                                else if (entCv.type === "boolean") {
                                    entCv.value = (Nikfort.XrmSdk.Helper.GetNodeText(tempNode) === 'false') ? false : true;
                                }
                                else {
                                    entCv.value = Nikfort.XrmSdk.Helper.GetNodeText(tempNode);
                                }
                                obj[sKey] = entCv;
                                break;
                        }
                    }
                    this.attributes = obj;
                    break;

                case "a:Id":
                    this.id = Nikfort.XrmSdk.Helper.GetNodeText(parentNode);
                    break;

                case "a:LogicalName":
                    this.logicalName = Nikfort.XrmSdk.Helper.GetNodeText(parentNode);
                    break;

                case "a:FormattedValues":
                    var foVal = parentNode;

                    for (var o = 0, leno = foVal.childNodes.length; o < leno; o++) {
                        // Establish the Key, we are going to fill in the formatted value of the already found attribute
                        var foNode = foVal.childNodes[o];
                        sKey = Nikfort.XrmSdk.Helper.GetNodeText(foNode.childNodes[0]);
                        this.attributes[sKey].formattedValue = Nikfort.XrmSdk.Helper.GetNodeText(foNode.childNodes[1]);
                        if (isNaN(this.attributes[sKey].value) && this.attributes[sKey].type === "dateTime") {
                            this.attributes[sKey].value = new Date(this.attributes[sKey].formattedValue);
                        }
                    }
                    break;
            }
        }
    }
};

// Supported Action input parameter types
Nikfort.XrmSdk.Process.Type = {
    Bool: "c:boolean",
    Int: "c:int",
    String: "c:string",
    DateTime: "c:dateTime",
    EntityReference: "a:EntityReference",
    OptionSet: "a:OptionSetValue",
    Money: "a:Money",
    Float: "c:double",
    Decimal: "c:decimal",
    Entity: "a:Entity",
}
// inputParams: Array of parameters to pass to the Action. Each param object should contain key, value, and type.
// successCallback: Function accepting 1 argument, which is an array of output params, each containing key, and value.
// errorCallback: Function accepting 1 argument, which is the string error message. Can be null.
// Unless the Action is global, you must specify a 'Target' input parameter as EntityReference
// actionName is required
Nikfort.XrmSdk.Process.callAction = function (actionName, inputParams, successCallback, errorCallback, url, async) {
    if (url == null) {
        url = Xrm.Page.context.getClientUrl();
    }

    var requestXml = "<s:Envelope xmlns:s='http://schemas.xmlsoap.org/soap/envelope/'>" +
          "<s:Body>" +
            "<Execute xmlns='http://schemas.microsoft.com/xrm/2011/Contracts/Services' xmlns:i='http://www.w3.org/2001/XMLSchema-instance'>" +
              "<request xmlns:a='http://schemas.microsoft.com/xrm/2011/Contracts'>" +
                "<a:Parameters xmlns:b='http://schemas.datacontract.org/2004/07/System.Collections.Generic'>";

    if (inputParams) {
        // Add each input param
        for (var i = 0; i < inputParams.length; i++) {
            var param = inputParams[i];

            var value = "";
            var displayXmlns = false;

            // Check the param type to determine how the value is formed
            switch (param.type) {
                case "c:double":
                case "c:decimal":
                case "c:boolean":
                case "c:int":
                case "c:string":
                    value = param.value;
                    displayXmlns = true;
                    break;
                case "c:dateTime":
                    value = param.value.toISOString();
                    displayXmlns = true;
                    break;
                case "a:Entity":
                case "a:EntityReference":
                    value = "<a:Id>" + param.value.id + "</a:Id>" +
                      "<a:LogicalName>" + param.value.entityType + "</a:LogicalName>" +
                      "<a:Name i:nil='true' />";
                    break;
                case "a:OptionSetValue":
                case "a:Money":
                    value = "<a:Value>" + param.value + "</a:Value>";
                    break;
                
                default:
                    if (errorCallback) {
                        errorCallback("Type of input parameter " + (i + 1) + " '" + param.type + "' is invalid or unsupported");
                    }
                    return;
                    break;
            }

            requestXml += "<a:KeyValuePairOfstringanyType>" +
                    "<b:key>" + param.key + "</b:key>" +
                    "<b:value i:type='" + param.type + "' " + (displayXmlns ? "xmlns:c='http://www.w3.org/2001/XMLSchema'" : "") + ">" + value + "</b:value>" +
                  "</a:KeyValuePairOfstringanyType>";
        }
    }

    requestXml += "</a:Parameters>" +
                "<a:RequestId i:nil='true' />" +
                "<a:RequestName>" + actionName + "</a:RequestName>" +
              "</request>" +
            "</Execute>" +
          "</s:Body>" +
        "</s:Envelope>";

    var req = new XMLHttpRequest();
    req.open("POST", url + "/XRMServices/2011/Organization.svc/web", !!async);
    req.setRequestHeader("Accept", "application/xml, text/xml, */*");
    req.setRequestHeader("Content-Type", "text/xml; charset=utf-8");
    req.setRequestHeader("SOAPAction", "http://schemas.microsoft.com/xrm/2011/Contracts/Services/IOrganizationService/Execute");

    req.onreadystatechange = function () {
        if (req.readyState == 4) {
            if (req.status == 200) {
                // Action completed successfully - get output params
                var responseParams = req.responseXML.getElementsByTagName("a:KeyValuePairOfstringanyType"); // IE
                if (responseParams.length == 0) {
                    responseParams = req.responseXML.getElementsByTagName("KeyValuePairOfstringanyType"); // FireFox and Chrome
                }

                var outputParams = [];
                for (i = 0; i < responseParams.length; i++) {

                    var attrNameNode = responseParams[i].childNodes[0].firstChild;
                    var attributeName = attrNameNode.textContent || attrNameNode.nodeValue || attrNameNode.data || attrNameNode.text;

                    var attributeValue = "";
                    if (responseParams[i].childNodes[1].firstChild != null) {
                        var attrValueNode = responseParams[i].childNodes[1].firstChild;
                        attributeValue = attrValueNode.textContent || attrValueNode.nodeValue || attrValueNode.data || attrValueNode.text;
                    }

                    // Values will be string, figure out the types yourself
                    outputParams.push({ key: attributeName, value: attributeValue });

                    /*
                    DateTime = "2015-06-23T21:00:00Z" (AS UTC STRING)
                    bool = "true" (AS STRING)
                    OptionSet, int, etc = "1" (AS STRING)
                    */
                }

                if (successCallback) {
                    // Make sure the callback accepts exactly 1 argument - use dynamic function if you want more
                    successCallback(outputParams);
                }
            }
            else {
                // Error has occured, action failed
                if (errorCallback) {
                    var error = null;
                    try { error = req.responseXML.getElementsByTagName("Message")[0].firstChild.nodeValue; } catch (e) { }
                    errorCallback(error);
                }
            }
        }
    };

    req.send(requestXml);
}

// Runs the specified workflow for a particular record
// successCallback and errorCallback accept no arguments
// workflowId, and recordId are required
Nikfort.XrmSdk.Process.callWorkflow = function (workflowId, recordId, successCallback, errorCallback, url, async) {
    if (url == null) {
        url = Xrm.Page.context.getClientUrl();
    }

    var request = "<s:Envelope xmlns:s='http://schemas.xmlsoap.org/soap/envelope/'>" +
          "<s:Body>" +
            "<Execute xmlns='http://schemas.microsoft.com/xrm/2011/Contracts/Services' xmlns:i='http://www.w3.org/2001/XMLSchema-instance'>" +
              "<request i:type='b:ExecuteWorkflowRequest' xmlns:a='http://schemas.microsoft.com/xrm/2011/Contracts' xmlns:b='http://schemas.microsoft.com/crm/2011/Contracts'>" +
                "<a:Parameters xmlns:c='http://schemas.datacontract.org/2004/07/System.Collections.Generic'>" +
                  "<a:KeyValuePairOfstringanyType>" +
                    "<c:key>EntityId</c:key>" +
                    "<c:value i:type='d:guid' xmlns:d='http://schemas.microsoft.com/2003/10/Serialization/'>" + recordId + "</c:value>" +
                  "</a:KeyValuePairOfstringanyType>" +
                  "<a:KeyValuePairOfstringanyType>" +
                    "<c:key>WorkflowId</c:key>" +
                    "<c:value i:type='d:guid' xmlns:d='http://schemas.microsoft.com/2003/10/Serialization/'>" + workflowId + "</c:value>" +
                  "</a:KeyValuePairOfstringanyType>" +
                "</a:Parameters>" +
                "<a:RequestId i:nil='true' />" +
                "<a:RequestName>ExecuteWorkflow</a:RequestName>" +
              "</request>" +
            "</Execute>" +
          "</s:Body>" +
        "</s:Envelope>";

    var req = new XMLHttpRequest();
    req.open("POST", url + "/XRMServices/2011/Organization.svc/web", !!async);

    req.setRequestHeader("Accept", "application/xml, text/xml, */*");
    req.setRequestHeader("Content-Type", "text/xml; charset=utf-8");
    req.setRequestHeader("SOAPAction", "http://schemas.microsoft.com/xrm/2011/Contracts/Services/IOrganizationService/Execute");
    req.onreadystatechange = function () {
        if (req.readyState == 4) {
            if (req.status == 200) {
                if (successCallback) {
                    successCallback();
                }
            }
            else {
                if (errorCallback) {
                    errorCallback();
                }
            }
        }
    };

    req.send(request);
}

// Pops open the specified dialog process for a particular record
// dialogId, entityName, and recordId are required
// callback fires even if the dialog is closed/cancelled
Nikfort.XrmSdk.Process.callDialog = function (dialogId, entityName, recordId, callback, url) {
    tryShowDialog("/cs/dialog/rundialog.aspx?DialogId=%7b" + dialogId + "%7d&EntityName=" + entityName + "&ObjectId=" + recordId, 600, 400, callback, url);

    // Function copied from Alert.js https://alertjs.codeplex.com
    function tryShowDialog(url, width, height, callback, baseUrl) {
        width = width || Alert._dialogWidth;
        height = height || Alert._dialogHeight;

        var isOpened = false;

        try {
            // Web (IE, Chrome, FireFox)
            var Mscrm = Mscrm && Mscrm.CrmDialog && Mscrm.CrmUri && Mscrm.CrmUri.create ? Mscrm : parent.Mscrm;
            if (Mscrm && Mscrm.CrmDialog && Mscrm.CrmUri && Mscrm.CrmUri.create) {
                // Use CRM light-box (unsupported)
                var crmUrl = Mscrm.CrmUri.create(url);
                var dialogwindow = new Mscrm.CrmDialog(crmUrl, window, width, height);

                // Allows for opening non-webresources (e.g. dialog processes) - CRM messes up when it's not a web resource (unsupported)
                if (!crmUrl.get_isWebResource()) {
                    crmUrl.get_isWebResource = function () { return true; }
                }

                // Open the lightbox
                dialogwindow.show();
                isOpened = true;

                // Make sure when the dialog is closed, the callback is fired
                // This part's all pretty unsupported, hence the try-catches
                // If you can avoid using a callback, best not to use one
                if (callback) {
                    try {
                        // Get the lightbox iframe (unsupported)
                        var $frame = parent.$("#InlineDialog_Iframe");
                        if ($frame.length == 0) { $frame = parent.parent.$("#InlineDialog_Iframe"); }
                        $frame.load(function () {
                            try {
                                // Override the CRM closeWindow function (unsupported)
                                var frameDoc = $frame[0].contentWindow;
                                var closeEvt = frameDoc.closeWindow; // OOTB close function
                                frameDoc.closeWindow = function () {
                                    // Bypasses onunload event on dialogs to prevent "are you sure..." (unsupported - doesn't work with 2015 SP1)
                                    try { frameDoc.Mscrm.GlobalVars.$B = false; } catch (e) { }

                                    // Fire the callback and close
                                    callback();
                                    try { closeEvt(); } catch (e) { }
                                }
                            } catch (e) { }
                        });
                    } catch (e) { }
                }
            }
        } catch (e) { }

        try {
            // Outlook
            if (!isOpened && window.showModalDialog) {
                // If lightbox fails, use window.showModalDialog
                baseUrl = baseUrl || Xrm.Page.context.getClientUrl();
                var params = "dialogWidth:" + width + "px; dialogHeight:" + height + "px; status:no; scroll:no; help:no; resizable:yes";

                window.showModalDialog(baseUrl + url, window, params);
                if (callback) {
                    callback();
                }

                isOpened = true;
            }
        } catch (e) { }

        return isOpened;
    }
}
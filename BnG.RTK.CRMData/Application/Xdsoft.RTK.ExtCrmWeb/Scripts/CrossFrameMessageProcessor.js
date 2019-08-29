if (typeof (Xdsoft) == "undefined") {
    Xdsoft = {};
}

Xdsoft.CrossFrameMessageProcessor = {
    Message: function () {
        return {
            Name: "",
            Data: "",
            Handler: function () { alert("This message has no handler"); }
        };
    },

    Handlers: {},

    AddMessageHandler: function (name, handler) {
        Xdsoft.CrossFrameMessageProcessor.Handlers[name] = handler;
    },

    RemoveMessageHandler: function (name) {
        delete Xdsoft.CrossFrameMessageProcessor.Handlers[name];
    },

    SendMessage: function (name, data, target) {
        var message = new Xdsoft.CrossFrameMessageProcessor.Message();
        message.Name = name;
        message.Data = data;
        target.postMessage(JSON.stringify(message), "*");
    },

    GetMessage: function (event) {
        var message = JSON.parse(event.data);
        if (typeof (message.Name) != 'undefined') {
            Xdsoft.CrossFrameMessageProcessor.Handlers[message.Name].call(null, message.Data);
        }
    },

    AddMessageListener: function () {
        if (window.addEventListener) {
            window.addEventListener("message", Xdsoft.CrossFrameMessageProcessor.GetMessage, false);
        } else {
            window.attachEvent("onmessage", Xdsoft.CrossFrameMessageProcessor.GetMessage);
        }
    },

    AddMessageListenerForTurboForms: function () {
        if (window.parent.addEventListener) {
            window.parent.addEventListener("message", Xdsoft.CrossFrameMessageProcessor.GetMessage, false);
        } else {
            window.parent.attachEvent("onmessage", Xdsoft.CrossFrameMessageProcessor.GetMessage);
        }
    },

    ClearMessageListeners: function () {
        if (window.removeEventListener) {
            window.removeEventListener("message", Xdsoft.CrossFrameMessageProcessor.GetMessage, false);
        } else {
            window.detachEvent("onmessage", Xdsoft.CrossFrameMessageProcessor.GetMessage);
        }
    }
}
mergeInto(LibraryManager.library, {

    Hello: function () {
        window.alert("Hello, world!");
    },

    HelloString: function (str) {
        window.alert(UTF8ToString(str));
    },

    HelloConsole: function () {
        console.log("Hello console!");
    },

    ConsoleString: function (str) {
        console.log(UTF8ToString(str));
    }

});
mergeInto(LibraryManager.library, {
    
    Test: function () {
        console.log("Test");
    },

    LogonFromUnity: function () {
        logEvent(analytics, 'logon_from_unity');
        console.log("LogonFromUnity!");
    },
        
});

var plugin = {
    LogonFromUnityTwo: function() {
        UnityLogEvent();
        console.log("LogonFromUnityTWO!");
    }
};

mergeInto(LibraryManager.library, plugin);
var blazorFramework = {};

blazorFramework.getSessionStorage = function (key) {
    return sessionStorage.getItem(key);
}

blazorFramework.setSessionStorage = function (key, data) {
    sessionStorage.setItem(key, data);
}

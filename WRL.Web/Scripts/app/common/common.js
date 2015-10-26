(function () {
    "use strict";

    var commonModule = angular.module("common", ["ui.router", "ngResource"]);

    commonModule.constant("baseApiUrl", "/api/");
})();
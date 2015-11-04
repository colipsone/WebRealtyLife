(function() {
    "use strict";

    function homeController() {
        var vm = this;
    };

    homeController.$inject = [];

    var module = angular.module("wrl.common");

    module.controller("homeController", homeController);
})();
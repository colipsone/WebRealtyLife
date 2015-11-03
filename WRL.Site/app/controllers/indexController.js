(function () {
    "use strict";

    function indexController($state, authService) {
        var vm = this;

        vm.authentication = authService.authentication;

        vm.logOut = function() {
            authService.logOut();
            $state.go("home");
        };
    }

    angular
        .module("wrl.common")
        .controller("indexController", indexController);

    indexController.$inject = ["$state", "authService"];
})();

(function () {
    "use strict";

    function indexController($state, authService) {
        var vm = this;

        vm.authentication = authService.authentication;

        vm.logOut = function() {
            authService.logOut();
            $state.go("home");
        };

        vm.setActive = function (event) {
            $(".selected-menuitem").removeClass("selected-menuitem");
            $(event.currentTarget).addClass("selected-menuitem");
        }
    }

    angular
        .module("wrl.common")
        .controller("indexController", indexController);

    indexController.$inject = ["$state", "authService"];
})();

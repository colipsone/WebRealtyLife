(function () {
    "use strict";

    var module = angular.module("wrl.common", ["ui.router", "wrl.security", "wrl.apartments"]);

    function configure($stateProvider, $httpProvider) {

        // #region Configure routing

        $stateProvider.
                    state("home", {
                        url: "/home",
                        templateUrl: "app/templates/home.html",
                        controller: "homeController",
                        controllerAs: "vm"
                    }).
                    state("login", {
                        url: "/login",
                        templateUrl: "app/security/templates/login.html",
                        controller: "loginController",
                        controllerAs: "vm"
                    }).
                    state("signup", {
                        url: "/signup",
                        templateUrl: "app/security/templates/signup.html",
                        controller: "signupController",
                        controllerAs: "vm"
                    }).
                    state("apartments", {
                        url: "/apartments",
                        templateUrl: "app/apartments/templates/apartmentsList.html",
                        controller: "apartmentsController",
                        controllerAs: "vm"
                    });

        // #endregion

        $httpProvider.interceptors.push("authInterceptionService");
    }

    configure.$inject = ["$stateProvider", "$httpProvider"];

    module.config(configure);

    module.service("settings", function() {
        return {
            baseApiUrl: "http://localhost:4897/",
            langLocale: "ru"
        };
    });

    module.run(["authService", function(authService) {
        authService.fillAuthData();
    }]);
})();
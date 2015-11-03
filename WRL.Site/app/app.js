(function () {
    "use strict";

    var module = angular.module("wrl.common", ["ui.router", "wrl.security"]);

    function configure($stateProvider) {
        $stateProvider.
            state("home", {
                url: "/home",
                templateUrl: ""
            }).
            state("login", {
                url: "/login",
                templateUrl: "app/security/templates/login.html",
                controller: "loginController",
                controllerAs: "vm"
            }).
            state("logout", {
                url: "/logout",
                templateUrl: ""
            }).
            state("signup", {
                url: "/signup",
                templateUrl: "app/security/templates/signup.html",
                controller: "signupController",
                controllerAs: "vm"
            }).
            state("apartments", {
                url: "/apartments",
                templateUrl: ""
                /*controller: "signupController",
                controllerAs: "vm"*/
            });
    }

    configure.$inject = ["$stateProvider"];

    module.config(configure);

    module.service("settings", function() {
        return {
            baseApiUrl: "http://localhost:4897/",
        };
    });

    module.run(["authService", function(authService) {
        authService.fillAuthData();
    }]);
})();
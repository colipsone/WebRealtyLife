(function () {
    "use strict";

    var app = angular.module("wrl", function() {
        
    });

    // #region Routes configuration

    app.config(["$stateProvider", function ($stateProvider) {
        $stateProvider.state("apartments", {
            templateUrl: "/app/apartments/templates/apartments.html",
            controller: "ApartmentsCtrl",
            url: "/apartments"
        });
    }]);

    // #endregion

})();

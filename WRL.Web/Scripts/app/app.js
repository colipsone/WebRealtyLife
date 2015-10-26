(function () {
    "use strict";

    var app = angular.module("wrl", ["apartments"]);

    // #region Routes configuration

    app.config(["$stateProvider", function ($stateProvider) {
        $stateProvider.state("apartments", {
            templateUrl: "/Scripts/app/apartments/templates/apartments.html",
            controller: "ApartmentsCtrl",
            url: "/apartments"
        });
    }]);

    // #endregion

})();

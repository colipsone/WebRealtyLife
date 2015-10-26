(function () {
    "use strict";

    function apartmetsCtrl($scope, apartmentsService) {
        apartmentsService.query().$promise.then(function(result) {
            $scope.apartments = result;
        });
    }

    angular
        .module("apartments")
        .controller("ApartmentsCtrl", apartmetsCtrl);

    apartmetsCtrl.$inject = ["$scope", "apartmentsService"];
})();
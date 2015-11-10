(function () {
    "use strict";

    angular
        .module("wrl.apartments")
        .controller("apartmentsController", apartmentsController);

    apartmentsController.$inject = ["apartmentsService", "settings", "$aside"];

    function apartmentsController(apartmentsService, settings, $aside) {
        var vm = this;

        vm.lang = settings.langLocale;

        vm.gridOptions = {
            columnDefs: [
                {
                    name: "Номер",
                    field: "number"
                },
                {
                    name: "Название улицы",
                    field: "streetName"
                },
                {
                    name: "№ дома",
                    field: "houseNumber"
                }
            ]
        }

        apartmentsService.getApartments().then(function (apartments) {
            vm.gridOptions.data = apartments;
        });

        // #region Aside menu

        vm.asideState = {
            open: false
        };

        vm.openAside = function (position, backdrop) {
            vm.asideState = {
                open: true,
                position: position
            };

            function postClose() {
                vm.asideState.open = false;
            }

            $aside.open({
                templateUrl: "app/apartments/templates/aside.html",
                placement: position,
                size: "sm",
                backdrop: backdrop,
                controller: ["$scope", "$uibModalInstance", function ($scope, $uibModalInstance) {
                    $scope.ok = function (e) {
                        $uibModalInstance.close();
                        e.stopPropagation();
                    };
                    $scope.cancel = function (e) {
                        $uibModalInstance.dismiss();
                        e.stopPropagation();
                    };
                }]
            }).result.then(postClose, postClose);
        }

        // #endregion
    }
})();

(function () {
    "use strict";

    angular
        .module("wrl.apartments")
        .controller("apartmentsController", apartmentsController);

    apartmentsController.$inject = ["apartmentsService", "settings"];

    function apartmentsController(apartmentsService, settings) {
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
    }
})();

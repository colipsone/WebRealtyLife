(function () {
    "use strict";

    angular
        .module("wrl.apartments")
        .controller("apartmentsController", apartmentsController);

    apartmentsController.$inject = ["apartmentsService", "NgTableParams"];

    function apartmentsController(apartmentsService, ngTableParams) {
        var vm = this;

        vm.tableParams = new ngTableParams({}, {
            getData: function(params) {
                return apartmentsService.getApartments().then(function(apartments) {
                    params.total = apartments.length;
                    return apartments;
                });
            }
        });
    }
})();

(function () {
    "use strict";

    angular
        .module("wrl.apartments")
        .controller("apartmentsController", apartmentsController);

    apartmentsController.$inject = ["apartmentsService"];

    function apartmentsController(apartmentsService) {
        var vm = this;
    }
})();

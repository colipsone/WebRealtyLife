(function () {
    "use strict";

    angular
        .module("wrl.apartments")
        .factory("apartmentsService", apartmentsService);

    apartmentsService.$inject = ["$resource"];

    function apartmentsService($resource) {
        var service = {
            getData: getData
        };

        return service;

        function getData() { }
    }
})();
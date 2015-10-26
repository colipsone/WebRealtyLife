(function () {
    "use strict";

    function apartmentsService($resource, baseApiUrl) {
        var service = $resource(baseApiUrl + "Apartments", {}, {
        });

        return service;
    }

    angular
        .module("apartments")
        .factory("apartmentsService", apartmentsService);

    apartmentsService.$inject = ["$resource", "baseApiUrl"];
})();
(function () {
    "use strict";

    function apartmetsCtrl($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = "apartmetsCtrl";
    }

    angular
        .module("wrl")
        .controller("ApartmetsCtrl", apartmetsCtrl);

    apartmetsCtrl.$inject = ["$location"];
})();
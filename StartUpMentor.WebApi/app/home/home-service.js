(function () {
    'use strict';

    angular
        .module("startupmentor")
        .service("HomeService", HomeService);

    HomeService.$inject = ['$http', 'routePrefix'];

    function HomeService($http, routePrefix) {

    }

})();
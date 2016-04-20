(function () {
    'use strict';

    var app = angular
        .module('app', [
            'ngRoute',
            'ui.router'
        ])
        .config($stateProvider);

    $stateProvider
        .state('/home', {
            url: '/home',
            views: {
                "root": {
                    templateUrl: '/home/index.html',
                    controller: 'HomeController'
                }
            }
        })
        .state('/fields', {
            url: '/fields',
            views: {
                "root": {
                    templateUrl: '/fields/fields.html',
                    controller: 'FieldsController'
                }
            }
        })


})();
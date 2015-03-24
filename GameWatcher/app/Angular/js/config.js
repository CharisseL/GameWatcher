;(function () {
    'use strict';

    angular.module('watcherApp')
        .config(function ($routeProvider) {
            $routeProvider
            .when('/games', {
                templateUrl: 'views/games/index.cshtml',
                controller: 'GamesController',
                controllerAs: 'GameCtrl'
            })
        })
})
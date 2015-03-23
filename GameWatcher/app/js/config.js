(function () {
    'use strict';

    angular.module('GW.GameController', [

    ])
        .config(function ($routeProvider) {
            $routeProvider
            .when('/games', {
                templateUrl: 'views/games/index.cshtml',
                controller: 'GamesController',
                controllerAs: 'GameCtrl'
            })
        })
})
angular.module('GW.GameController', [])
    .controller('GameCtrl', [
        '$scope', '$http', function ($scope, $http) {
            $scope.model = {};

            $http.get('/Games/Contact').success(function (data) {
                $scope.model = data;
            });
        }
    ]);


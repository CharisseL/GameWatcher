angular.module('GW.GameController', [])
    .controller('GameCtrl', ['$scope','$http', function ($scope, $http) {
        $http.get('/Games/IndexVM').success(function (data) {
                $scope.model = data;
            });
        }]);


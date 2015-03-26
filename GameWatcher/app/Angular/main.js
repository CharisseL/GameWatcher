; (function () {
    'use strict';
    angular.module('watcherApp', ['ngRoute'])
    .directive('loadingButton', function () {
        return {
            restrict: 'A',
            link: function (scope, element, attrs) {
                $(element).ladda();

                $(element).ladda(start);

            }
        };

    });
})();

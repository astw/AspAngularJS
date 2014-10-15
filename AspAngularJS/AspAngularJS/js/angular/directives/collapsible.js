'use strict';

(function() {
    
    var app = angular.module("PhotoApp");


    var collapsible = function() {
        return {
            restrict: "E",
            replace: true,
            template: '<div><h4 class="well-title" ng-click="toggleVisibility();" >{{title}}</h4><div ng-show="visible" ng-transclude /></div>',
            transclude:true,
            scope: {
                title:'@'
            },

            controller: function($scope) {
                $scope.visible = true;

                $scope.toggleVisibility = function() {
                    $scope.visible = ! $scope.visible;
                };
            }
        };
    };

    app.directive("collapsible", collapsible);

}())
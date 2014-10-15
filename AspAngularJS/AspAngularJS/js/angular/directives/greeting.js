'use strict';

(function() {
    var app = angular.module("PhotoApp");
    app.directive("greeting", function() {
        return {
            restrict: "E",
            replace: true,
            template: "<button class='btn' ng-click='sayHello()'>Say Hello</button>",
            controller: "@",
            name: "ctrl1"
            //controller : 'GreetingController'
            /*
            controller: function ($scope) {
                $scope.sayHello = function() {
                    alert("hello");
                };
            }
            */
        }; 

    });

    app.controller('GreetingController',
        function GreetingController($scope) {
            $scope.sayHello = function() {
                alert("hello - controller");
            };
        });


}());
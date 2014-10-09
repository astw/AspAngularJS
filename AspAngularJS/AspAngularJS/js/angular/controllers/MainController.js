'use strict';

(function() {

    var app = angular.module("PhotoApp");

    var mainController = function($scope, $interval, $location) {

        $scope.message = " the message is :this is the main controller";

        $scope.search = function(username) {
            $location.path("/user/" + username);
        }; 
    };


    app.controller("MainController", ['$scope', '$interval', '$location', mainController]);

}());
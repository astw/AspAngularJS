'use strict';

(function () {

    var app = angular.module("PhotoApp");

    var eventController = function($scope, eventsClient, $routeParams, $route) {
        var onComplete = function(data) {
            $scope.event = data; 
        };

        var onError = function(error) {
            $scope.Error = error;
        };

        eventsClient.getEvent($routeParams.eventId).then(onComplete, onError);

        $scope.upVoteSession = function(session) {
            session.upVoteCount++;
        };

        $scope.downVoteSession = function(session) {
            session.upVoteCount--;
        };

        $scope.reload = function() {
            $route.reload();
        };
    };

    app.controller("EventController", eventController);

}());
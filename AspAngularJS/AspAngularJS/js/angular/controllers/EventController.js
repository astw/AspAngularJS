'use strict';

(function () {

    var app = angular.module("PhotoApp");

    var eventController = function($scope, eventsClient, $routeParams) {
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
    };

    app.controller("EventController", eventController);

}());
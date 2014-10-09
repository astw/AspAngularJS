'use strict';

(function () {

    var app = angular.module("PhotoApp");

    var editEventController = function($scope, eventData) {

        $scope.event = {};

        $scope.saveEvent = function (event, form) {
            if (form.$valid) {
                eventData.save(event);
            }
        };

        $scope.cancelEdit = function () {
            window.location = "/EventDetails.html";
        };
    };

    app.controller("EditEventController", editEventController);
}())
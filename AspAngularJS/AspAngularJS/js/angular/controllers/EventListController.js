'use strict';

(function() {

    var app = angular.module("PhotoApp");

    var eventListController = function ($scope, $location, eventData, eventsClient) {
       
        var onCompleted = function (data) {    
            $scope.events = data;
        };
         
        var onError = function (reason) {
            $scope.error = "Could not fetch the data.";
        };

        eventsClient.getEvents().then(onCompleted, onError()); 

    };

  
    app.controller("EventListController", eventListController);
    }());
 

//app.controller('EventListController',
//        function EventListController($scope, $location, eventData) {
//            $scope.events = eventData.getAllEvents();
//            alert(JSON.stringify($scope.events));
//        }
//    );


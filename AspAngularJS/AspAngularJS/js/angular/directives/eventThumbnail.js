'use strict';

(function () {

    var app = angular.module("PhotoApp");

    app.directive("eventThumbnail",
        function() {
            return {
                restrict: "E",
                replace:true,
                templateUrl: "/templates/directives/eventThumbnail.html",
                scope: {
                    event:"=event"
                }
            };
        }
    );


}())
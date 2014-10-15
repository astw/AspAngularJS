'use strict';

(function () {

    var app = angular.module("PhotoApp");

    app.directive("upvote",
        function () {
            return {
                restrict: "E",
                replace: true,
                templateUrl: "/templates/directives/upvoting.html",
                scope: {
                    upvote: "&",
                    downvote: "&",
                    count:"="
                }

            };
        }
    );


}())
﻿'use strict';

(function () {

    var app = angular.module("PhotoApp");

    app.directive("gravatar",
        function (gravatarUrlBuilder) {
            return {
                restrict: "E",
                replace: true,
                template: "<img />",
                link:function(scope, element, attrs, controller) {
                    attrs.$observe('email', function(newValue, oldValue) {
                        if (newValue !== oldValue) {
                            attrs.$set('src', gravatarUrlBuilder.buildGravatarUrl(newValue));
                        }
                    });
                } 
            };
        }
    );


}())
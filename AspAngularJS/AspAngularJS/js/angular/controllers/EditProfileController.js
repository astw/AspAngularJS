'use strict';

(function() {

    var app = angular.module("PhotoApp");

    var editProfileController = function ($scope, gravatarUrlBuilder) {
        $scope.user = {
            firstName: "Shu-hao",
            lastName: "Wang"
        };

        $scope.getGravatarUrl = function(email) {
            return gravatarUrlBuilder.buildGravatarUrl(email);
        };
    };

    app.controller('EditProfileController', editProfileController);

}());
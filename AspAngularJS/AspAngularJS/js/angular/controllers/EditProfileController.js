'use strict';

(function() {

    var app = angular.module("PhotoApp");

    var editProfileController = function($scope) {
        $scope.user = {
            firstName: "Shu-hao",
            lastName: "Wang"
        };
    };

    app.controller('EditProfileController', editProfileController);

}());
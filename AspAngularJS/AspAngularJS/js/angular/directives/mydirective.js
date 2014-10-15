'use strict';

(function () {
    
    var app = angular.module("PhotoApp");
    app.directive("mySample", function ($compile) {
        return {
            restrict: 'E',
            template: "<input type='text' ng-model='sampleData' />{{sampleData}}<br/>",
            scope: {
                
            }
        };

    });


}())
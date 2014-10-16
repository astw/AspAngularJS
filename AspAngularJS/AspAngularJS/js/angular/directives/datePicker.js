'use restrict',

(function () {

    var app = angular.module("PhotoApp");
    var datepicker = function () {
        return {
            restroct: 'A',
            link: function (scope, element) {
                element.datepicker();
            }

            
        };
    };

    app.directive("datePicker", datepicker);


}())
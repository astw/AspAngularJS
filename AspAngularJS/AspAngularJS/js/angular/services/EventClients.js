(function () {

    var eventsClient = function ($http) {

        var getEvent = function (id) {
            return $http.get("/v1/events/" + id)
                        .then(function (response) {
                            return response.data;
                        });
        };

        var getEvents = function () {
            return $http.get("/v1/events/")
                        .then(function (response) { 
                            return response.data;
                        });
        };



        return {
            getEvent: getEvent,
            getEvents: getEvents
        };

    };

    var module = angular.module("PhotoApp");
    module.factory("eventsClient", eventsClient);

}());


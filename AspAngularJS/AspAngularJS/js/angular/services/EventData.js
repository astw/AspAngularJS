'use strict';

(function() {


    var app = angular.module("PhotoApp");

    app.factory('eventData', function($resource) {
        var resource = $resource('/data/event/:id', { id: '@id' }, { "get": { method: "GET", isArray: true, params: { something: "foo" } } });
        //var resource = $resource('/v1/events', {
        //    "query": {
        //        method: "GET",
        //        isArray: true,
        //        params: { something: "foo" },
        //        headers: { 'Accept': 'application/json'}
        //    }
        //});

        return {
            getEvent: function() {
                return resource.get({ id: 1 });
            },
            save: function(event) {
                event.id = 999;
                return resource.save(event);
            },
            getAllEvents: function() {
               //return resource.query();
                return resource.get({ id: 'all.json' });
            }
        };
    });

}());
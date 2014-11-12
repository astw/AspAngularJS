 
'use strict';
 
 
(function () {
    var app = angular.module('PhotoApp', ['ngResource', 'ngRoute']);
   
   app.config(function($routeProvider, $locationProvider) {
       $routeProvider
           .when("/main",
           {
               templateUrl: "templates/main.html",
               controller: "MainController"
           })
           .when("/account/login",
           {
               templateUrl: "login.html",
               controller: "AccountController"
           })
           .when("/about",
           {
               templateUrl: "templates/about.html",
               controller: "MainController"
           })
           .when("/newEvent",
           {
               templateUrl: "templates/NewEvent.html",
               controller: "EditEventController"
           })
           .when("/eventDetails",
           {
               templateUrl: "templates/EventDetails.html",
               controller: "EventController"
           })
           .when("/editProfile",
           {
               templateUrl: "templates/EditProfile.html",
               controller: "EditProfileController"
           })
           .when("/events/:eventId", {
               templateUrl: "templates/EventDetails.html",
               controller: "EventController"
           })
           .when("/events",
           {
               templateUrl: 'templates/EventList.html',
               controller: "EventListController"
           })
           .when("/sampleDirective",
           {
               templateUrl: 'templates/SampleDirective.html',
               controller: "SampleDirectiveController"
           }
           //.when("/GoogleLogin", {
           //    templateUrl: "templates/GoogleLogin.htm",
          //     controller:"GoogleLoginController"
          // })
               );
        

        $routeProvider.otherwise({ redirectTo: '/main' });
 
   });  
}());
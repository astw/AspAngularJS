(function(){
    
    var app = angular.module("githubViewer", ["ngRoute"]);
    
    app.config(function($routeProvider){
        $routeProvider
            .when("/main", {
                templateUrl: "lesson/main.html",
                controller: "MainController"
            })
            .when("/user/:username", {
                templateUrl: "lesson/user.html",
                controller: "UserController"
            })
            .when("/repo/:username/:reponame", {
                templateUrl: "lesson/repo.html",
                controller: "RepoController"
            })
            .otherwise({redirectTo:"/main"});
    });
    
}());
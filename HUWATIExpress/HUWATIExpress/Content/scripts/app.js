define(['ui-router', 'ngStorage', 'ngCookies'], function () {

    //defining angularjs module
    var app = angular.module("app", ['ui.router', 'ngCookies', 'ngStorage']);

    //global service
    app.constant("utility",
        {
            baseAddress: "http://localhost:5100/api/"
        });

    //manual bootstrap
    app.init = function () {
        angular.bootstrap(document, ['app']);
    };

    //defining routes
    app.config(function ($stateProvider, $urlRouterProvider) {

        $urlRouterProvider.otherwise("/");

        $stateProvider
            .state("Home", {
                url: "/",
                templateUrl: 'views/home/Home.html',
                controller: 'homeCtrl'
            })
            .state("Register", {
                url: "/Register",
                templateUrl: 'views/account/Register.html',
                controller: 'RegisterCtrl'
            })
            .state("Detail", {
                url: "/detail",
                templateUrl: 'views/home/Detail.html',
                controller: 'detailCtrl'
            })
            .state("Route", {
                url: "/Route",
                templateUrl: 'views/home/Route.html',
                controller: 'RouteCtrl'
            })
            .state("Login", {
                url: "/Login",
                templateUrl: 'views/account/Login.html',
                controller: 'LoginlCtrl'
            })
            .state("CheckTicket", {
                url: "/CheckTicket",
                templateUrl: 'views/home/CheckTicket.html',
                controller: 'CheckTicketlCtrl'
            })
            .state("CheckInfo", {
                url: "/CheckInfo",
                templateUrl: 'views/home/CheckInfo.html',
                controller: 'CheckInfoCtrl'
                })
            .state("Payment", {
                url: "/Payment",
                templateUrl: 'views/home/Payment.html',
                controller: 'PaymentCtrl'
                });

    });
    return app;
});
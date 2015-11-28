(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
        function($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise('/');
            $stateProvider
                .state('home', {
                    url: '/',
                    templateUrl: '/App/Main/views/home/home.cshtml',
                    menu: 'Home' //Matches to name of 'Home' menu in RenCaiEXNavigationProvider
                })
                .state('corporation', {
                    url: '/corporation',
                    templateUrl: '/App/Main/views/corporation/corporation.cshtml',
                    menu: 'corporation' //Matches to name of 'company' menu in RenCaiEXNavigationProvider
                })
                .state('job', {
                    url: '/job',
                    templateUrl: '/App/Main/views/job/job.cshtml',
                    menu: 'job' //Matches to name of 'company' menu in RenCaiEXNavigationProvider
                })
                .state('about', {
                    url: '/about',
                    templateUrl: '/App/Main/views/about/about.cshtml',
                    menu: 'About' //Matches to name of 'About' menu in RenCaiEXNavigationProvider
                });
        }
    ]);
})();
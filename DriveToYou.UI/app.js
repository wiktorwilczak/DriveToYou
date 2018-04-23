var app = angular.module('DriveToYou', ['ngRoute'])

app.config(function($routeProvider) {
	$routeProvider
		.otherwise({
			redirectTo: '/home',
			controller: 'homeController'
		});
});




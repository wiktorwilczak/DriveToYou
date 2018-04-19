angular.module('DriveToYou')

	.config(function($routeProvider) {
		$routeProvider
			.when('/home', {
				templateUrl: 'home/home.html',
				controller: 'homeController'
			});
	})

	.controller('homeController', function($scope) {
		


	});
angular.module('DriveToYou')

	.config(function($routeProvider) {
		$routeProvider
			.when('/intro', {
				templateUrl: 'intro/intro.html',
				controller: 'introController'
			});
	})

	.controller('introController', function($scope, baseUrlService) {
		
		$scope.baseUrl = baseUrlService.baseUrl();
	});
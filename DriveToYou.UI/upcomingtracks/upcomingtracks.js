angular.module('DriveToYou')
   
  

	.config(function($routeProvider) {
		$routeProvider
			.when('/upcomingtracks', {
				templateUrl: 'upcomingtracks/upcomingtracks.html',
				controller: 'upcomingtracksController'
			})
    })
    
    .controller('upcomingtracksController', function($scope, $http, baseUrlService) {
  
  
		
          $http.get(baseUrlService.baseUrl() +"transits/reports/upcomingtracks")
            .then(function (response) {$scope.upcomingtracksList = response.data;});	  				                      	

          
	});

angular.module('DriveToYou')

	.config(function($routeProvider) {
		$routeProvider
			.when('/addatrack', {
				templateUrl: 'addatrack/addatrack.html',
				controller: 'addatrackController'
			})
	})
	
	.controller('addatrackController', function($scope, $http) {
  
  
		$scope.submitForm = function() {
		  $http.post("http://localhost:50445/transits/addtrack", $scope.track)
		  alert('send to server: ' + " Destination Address: " +$scope.track.Destination_address
								   + ", Source Address: " +$scope.track.Source_address)
	  				  
			$scope.reset();
		};		
		

		$scope.reset = function() {
			$scope.track = {}; 
			
			    $scope.trackForm.$setPristine();
				$scope.trackForm.$setUntouched();
		  };

	
	

	});




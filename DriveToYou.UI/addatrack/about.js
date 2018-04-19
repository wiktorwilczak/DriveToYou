angular.module('DriveToYou')

	.config(function($routeProvider) {
		$routeProvider
			.when('/addatrack', {
				templateUrl: 'addatrack/about.html',
				controller: 'aboutController'
			})
	})
	
	.controller('aboutController', function($scope, $http, $log) {
  
  
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

	// 	$scope.earning = function(startdate, enddate){
	// 	  $http.get("http://localhost:50445/transits/reports/daily/" +$scope.startdate +"/" +$scope.enddate)
	// 	  .then(onComplete);
	// 	}
		
	// 	$scope.monthly = function(startdate, enddate){
	// 	  $http.get("http://localhost:50445/transits/reports/monthly/")
	// 	  .then(onCompleteMonthly);
	// 	}
	
	//    function onCompleteEarning(response) {
	// 	  $scope.total = response.data;
	//    }
		
	// 	 function onCompleteMonthly(response) {
	// 	  $scope.monthlylist = response.data;
	// 	}
		
	

	});



// 	// Code goes here

// (function() {

// 	var app = angular.module("DriveToYou", []);
  
// 	var MainController = function($scope, $http, $log) {
  
  
// 	  $scope.submitForm = function() {
// 		$log.info("Submitting user with:" +$scope.track.source_address)
// 		$http.post("http://localhost:50445/transits/addtrack", $scope.track);
	   
// 	  };
	  
	  
// 	  $scope.earning = function(startdate, enddate){
// 		$http.get("http://localhost:50445/transits/reports/daily/" +$scope.startdate +"/" +$scope.enddate)
// 		.then(onComplete);
// 	  }
	  
// 	  $scope.monthly = function(startdate, enddate){
// 		$http.get("http://localhost:50445/transits/reports/monthly/")
// 		.then(onCompleteMonthly);
// 	  }
  
// 	 function onCompleteEarning(response) {
// 		$scope.total = response.data;
// 	 }
	  
// 	   function onCompleteMonthly(response) {
// 		$scope.monthlylist = response.data;
// 	  }
	  
// 	};
  
// 	app.controller("MainController", MainController);
//   }());
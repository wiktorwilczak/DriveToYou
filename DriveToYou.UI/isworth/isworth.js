angular.module('DriveToYou')

	.config(function($routeProvider) {
		$routeProvider
			.when('/isworth', {
				templateUrl: 'isworth/isworth.html',
				controller: 'isworthController'
			})
    })
    
    .controller('isworthController', function($scope, $http) {


        $scope.trackRaport = function(){
                $http.get("http://localhost:50445/transits/reports/trackraport/" + $scope.track.Source_address +"/" +$scope.track.Destination_address)
                    .then(onCompleteRaport)

                    $scope.reset();
            };
    
            function onCompleteRaport(response) {
                $scope.raport = response.data;
              };


		$scope.reset = function() {
			$scope.track = {}; 
			
			    $scope.tracksmallForm.$setPristine();
				$scope.tracksmallForm.$setUntouched();
		  };

            });
angular.module('DriveToYou')

	.config(function($routeProvider) {
		$routeProvider
			.when('/isworth', {
				templateUrl: 'isworth/isworth.html',
				controller: 'isworthController'
			})
    })
    
    .controller('isworthController', function($scope, $http, baseUrlService) {


        $scope.trackRaport = function(){
                $http.get(baseUrlService.baseUrl() +"transits/reports/trackraport/" + $scope.track.Source_address +"/" +$scope.track.Destination_address)
                    .then(onCompleteRaport)

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
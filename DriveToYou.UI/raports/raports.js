angular.module('DriveToYou')

	.config(function($routeProvider) {
		$routeProvider
			.when('/raports', {
				templateUrl: 'raports/raports.html',
				controller: 'raportController'
			})
	})
	
	.controller('raportController', function($scope, $http) {



		$(function(){
			$("#to").datepicker({ dateFormat: 'yy-mm-dd' });
			$("#from").datepicker({ dateFormat: 'yy-mm-dd' }).bind("change",function(){
				var minValue = $(this).val();
				minValue = $.datepicker.parseDate("yy-mm-dd", minValue);
				minValue.setDate(minValue.getDate()+1);
				$("#to").datepicker( "option", "minDate", minValue );
			})
		});

		

		$scope.monthly = function(monthNumber){
				  $http.get("http://localhost:50445/transits/reports/monthly/" +$scope.monthNumber)
				  .then(onCompleteMonthly);
				};

				function onCompleteMonthly(response) {
						  $scope.monthlylist = response.data;
						};

		$scope.earning = function(startdate, enddate){
					$http.get("http://localhost:50445/transits/reports/daily/" +$("#from").val() +"/" +$("#to").val())
					.then(onCompleteEarning);
				};
				
				function onCompleteEarning(response) {
					$scope.total = response.data;
				 };
				  

			

  
	
						
	});
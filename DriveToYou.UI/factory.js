angular.module('DriveToYou')
    .factory('baseUrlService', function () {      

     return {       
        baseUrl: function() {
            return "http://localhost:50445/";       
         }     
    }  
        
 });
        
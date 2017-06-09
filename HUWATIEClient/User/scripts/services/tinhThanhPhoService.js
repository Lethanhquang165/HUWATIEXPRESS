define(['app'], function (app) {
    //defining service using factory method
    app.factory('tinhThanhPhoService', function ($http, utility) {
        var serviceurl = utility.baseAddress + "Station/";
        return {
            getTinhThanhList: function () {
                var url = serviceurl + "GetStationsList";
                return $http.get(url);
            }
        };
    });
});
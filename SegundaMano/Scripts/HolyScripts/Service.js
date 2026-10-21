app.service("SegundaManoService", ["$http", function ($http) {

    this.GetWelcomeMessage = function () {
        return $http.get("/Main/GetWelcomeMessage");
    };

}]);

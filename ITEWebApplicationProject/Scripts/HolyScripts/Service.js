app.service("ITEWebApplicationProjectService", function ($http) {

    this.GetWelcomeMessage = function () {
        return $http.get("/Main/GetWelcomeMessage");
    };

});

app.service("ITEWebApplicationProjectService", function ($http) {

    // Fetches the welcome message from the C# MainController
    this.GetWelcomeMessage = function () {
        return $http.get("/Main/GetWelcomeMessage");
    };

});

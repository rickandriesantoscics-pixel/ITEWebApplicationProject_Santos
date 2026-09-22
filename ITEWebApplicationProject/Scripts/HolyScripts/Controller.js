app.controller("ITEWebApplicationProjectController", function ($scope, ITEWebApplicationProjectService) {

    $scope.userarray = [];

    $scope.alertFunc = function () {
           alert("yehey!")
    }

    $scope.nameFunc = function (username) {
        alert(username);
    }


    $scope.getName = function () {
        alert($scope.username)
    }

    $scope.registrationFunc = function () {
        if (!$scope.inputValidation()) {
            return;
        }

        var userdata = {
            FName: $scope.firstName,
            MName: $scope.middleName,
            LName: $scope.lastName,
            Suffix: $scope.suffix,
            Email: $scope.email.toLowerCase(),
            Password: $scope.password,
            ContactNumber: $scope.contactNumber,
            Address: $scope.address
        };

        $scope.userarray.push(userdata);
        Swal.fire({
            title: "Success",
            text: "Registration successful!",
            icon: "success"
        });
        $scope.firstName = "";
        $scope.middleName = "";
        $scope.lastName = "";
        $scope.suffix = "";
        $scope.email = "";
        $scope.password = "";
        $scope.confirmPassword = "";
        $scope.contactNumber = "";
        $scope.address = "";
    };

    $scope.updateFunc = function (userindex) {

        var userdata = $scope.userarray[userindex];

        if (!$scope.inputValidation(userindex)) {
            return;
        }

        if ($scope.firstName != userdata.FName ||
            $scope.middleName != userdata.MName ||
            $scope.lastName != userdata.LName ||
            $scope.suffix != userdata.Suffix ||
            $scope.email.toLowerCase() != userdata.Email ||
            $scope.password != userdata.Password ||
            $scope.contactNumber != userdata.ContactNumber ||
            $scope.address != userdata.Address) {

            Swal.fire({
                title: "Update User",
                text: "Are you sure you want to update " + userdata.FName + " " + userdata.LName + "?",
                icon: "warning",
                showCancelButton: true,
                confirmButtonColor: "#3085d6",
                cancelButtonColor: "#d33",
                confirmButtonText: "Yes, update it!"
            }).then((result) => {
                if (result.isConfirmed) {
                    userdata.FName = $scope.firstName;
                    userdata.MName = $scope.middleName;
                    userdata.LName = $scope.lastName;
                    userdata.Suffix = $scope.suffix;
                    userdata.Email = $scope.email.toLowerCase();
                    userdata.Password = $scope.password;
                    userdata.ContactNumber = $scope.contactNumber;
                    userdata.Address = $scope.address;
                    $scope.$applyAsync();
                    Swal.fire(
                        "Updated!",
                        "User has been updated successfully.",
                        "success"
                    );
                }
            });
        } else {
            Swal.fire({
                title: "No Changes",
                text: "No changes found in the existing data",
                icon: "info"
            });
        }
    };

    $scope.deleteFunc = function (userindex) {
        var userdata = $scope.userarray[userindex];

        Swal.fire({
            title: "Delete User",
            text: "Are you sure you want to delete " + userdata.FName + " " + userdata.LName + "?",
            icon: "warning",
            showCancelButton: true,
            confirmButtonColor: "#3085d6",
            cancelButtonColor: "#d33",
            confirmButtonText: "Yes, delete it!"

        }).then((result) => {
            if (result.isConfirmed) {
                $scope.userarray.splice(userindex, 1);
                $scope.$apply();
                Swal.fire(
                    "Deleted!",
                    "User has been deleted.",
                    "success"
                );
            }
        });
    }

    $scope.redirectFunc = function () {
        window.location.href = "/Main/AboutPage"; 
    }

    $scope.loginFunc = function () {
        Swal.fire({
            title: "Logged in",
            text: "Logged in Successfully",
            icon: "success"
        }).then((result) => {
            window.location.href = "/Main/HomePage"; 
        });
    }

    $scope.clearLogin = function () {
        $scope.loginUsername = "",
        $scope.loginPassword = ""
    }

    $scope.inputValidation = function (userindex) {
        if ($scope.firstName == undefined || $scope.firstName == "") {
            Swal.fire("Notification", "First name is required.", "error");
            return false;
        }

        if ($scope.middleName == undefined || $scope.middleName == "") {
            Swal.fire("Notification", "Middle name is required.", "error");
            return false;
        }

        if ($scope.lastName == undefined || $scope.lastName == "") {
            Swal.fire("Notification", "Last name is required.", "error");
            return false;
        }

        if ($scope.email == undefined || $scope.email == "") {
            Swal.fire("Notification", "Email is required.", "error");
            return false;
        }

        if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test($scope.email)) {
            Swal.fire("Notification", "Please enter a valid email address.", "error");
            return false;
        }

        var normalizedEmail = $scope.email.toLowerCase();
        var duplicateEmail = $scope.userarray.some(function (user, index) {
            return index != userindex && user.Email != undefined && user.Email.toLowerCase() == normalizedEmail;
        });

        if (duplicateEmail) {
            Swal.fire("Notification", "Email is already in use.", "error");
            return false;
        }

        if ($scope.password == undefined || $scope.password == "") {
            Swal.fire("Notification", "Password is required.", "error");
            return false;
        }

        if (!/^(?=.*[A-Z])(?=.*[0-9])(?=.*[^A-Za-z0-9]).{8,}$/.test($scope.password)) {
            Swal.fire("Notification", "Password must be at least 8 characters and contain an uppercase letter, a number, and a special character.", "error");
            return false;
        }

        if ($scope.confirmPassword == undefined || $scope.confirmPassword == "") {
            Swal.fire("Notification", "Confirm password is required.", "error");
            return false;
        }

        if ($scope.password != $scope.confirmPassword) {
            Swal.fire("Notification", "Passwords do not match. Please try again.", "error");
            return false;
        }

        if ($scope.contactNumber == undefined || $scope.contactNumber == "") {
            Swal.fire("Notification", "Contact number is required.", "error");
            return false;
        }

        if (!/^[0-9]+$/.test($scope.contactNumber)) {
            Swal.fire("Notification", "Contact number must contain numbers only.", "error");
            return false;
        }

        if ($scope.address == undefined || $scope.address == "") {
            Swal.fire("Notification", "Address is required.", "error");
            return false;
        }

        return true;
    };

});
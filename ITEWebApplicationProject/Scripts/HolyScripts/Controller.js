app.controller("ITEWebApplicationProjectController", function ($scope, ITEWebApplicationProjectService) {

    $scope.customerArray = [];

    $scope.editingIndex = -1;

    var now = new Date();
    var mm = ("0" + (now.getMonth() + 1)).slice(-2);
    var dd = ("0" + now.getDate()).slice(-2);
    $scope.today = now.getFullYear() + "-" + mm + "-" + dd;

    $scope.GetWelcomeMessage = function () {
        var getData = ITEWebApplicationProjectService.GetWelcomeMessage();

        getData.then(function (returnedData) {
            $scope.welcomeMessage = returnedData.data;
        });
    };

    $scope.redirectFunc = function (targetURL) {
        window.location.href = targetURL;
    };

    $scope.loginFunc = function () {
        window.location.href = "/Main/Index";
    };

    $scope.clearLoginFunc = function () {
        $scope.loginUsername = "";
        $scope.loginPassword = "";
    };

    $scope.resetRegistrationFormState = function () {
        if ($scope.regForm) {
            $scope.regForm.$setPristine();
            $scope.regForm.$setUntouched();
        }
    };

    $scope.touchAllFields = function () {
        if (!$scope.regForm) {
            return;
        }

        for (var controlName in $scope.regForm) {
            if (Object.prototype.hasOwnProperty.call($scope.regForm, controlName)) {
                var control = $scope.regForm[controlName];
                if (control && control.$invalid && typeof control.$setTouched === "function") {
                    control.$setTouched();
                }
            }
        }
    };

    $scope.sanitizeContactNumber = function () {
        if ($scope.contactNumber != undefined) {
            $scope.contactNumber = $scope.contactNumber.replace(/\D/g, "").slice(0, 11);
        }
    };

    $scope.clearRegistrationFunc = function () {
        $scope.username = "";
        $scope.firstName = "";
        $scope.middleName = "";
        $scope.lastName = "";
        $scope.suffix = "";
        $scope.email = "";
        $scope.password = "";
        $scope.confirmPassword = "";
        $scope.contactNumber = "";
        $scope.gender = "";
        $scope.birthday = "";
        $scope.address = "";
        $scope.editingIndex = -1;
        $scope.resetRegistrationFormState();
    };

    $scope.inputValidation = function (userindex) {

        if ($scope.firstName == undefined || $scope.firstName == "") {
            Swal.fire({
                title: "Notification",
                text: "First name is required.",
                icon: "error"
            });
            return false;
        }
        if ($scope.lastName == undefined || $scope.lastName == "") {
            Swal.fire({
                title: "Notification",
                text: "Last name is required.",
                icon: "error"
            });
            return false;
        }
        if ($scope.username == undefined || $scope.username == "") {
            Swal.fire({
                title: "Notification",
                text: "Username is required.",
                icon: "error"
            });
            return false;
        }
        if ($scope.email == undefined || $scope.email == "") {
            Swal.fire({
                title: "Notification",
                text: "Email is required.",
                icon: "error"
            });
            return false;
        }
        if ($scope.password == undefined || $scope.password == "") {
            Swal.fire({
                title: "Notification",
                text: "Password is required.",
                icon: "error"
            });
            return false;
        }
        if ($scope.confirmPassword == undefined || $scope.confirmPassword == "") {
            Swal.fire({
                title: "Notification",
                text: "Confirm password is required.",
                icon: "error"
            });
            return false;
        }
        if ($scope.contactNumber == undefined || $scope.contactNumber == "") {
            Swal.fire({
                title: "Notification",
                text: "Contact number is required.",
                icon: "error"
            });
            return false;
        }
        if ($scope.gender == undefined || $scope.gender == "") {
            Swal.fire({
                title: "Notification",
                text: "Gender is required.",
                icon: "error"
            });
            return false;
        }
        if ($scope.birthday == undefined || $scope.birthday == "") {
            Swal.fire({
                title: "Notification",
                text: "Birthday is required.",
                icon: "error"
            });
            return false;
        }
        if ($scope.address == undefined || $scope.address == "") {
            Swal.fire({
                title: "Notification",
                text: "Address is required.",
                icon: "error"
            });
            return false;
        }

        if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test($scope.email)) {
            Swal.fire({
                title: "Notification",
                text: "Please enter a valid email address.",
                icon: "error"
            });
            return false;
        }

        if (!/^09\d{9}$/.test($scope.contactNumber)) {
            Swal.fire({
                title: "Notification",
                text: "Contact number must start with 09 and be exactly 11 digits.",
                icon: "error"
            });
            return false;
        }

        if (!/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$/.test($scope.password)) {
            Swal.fire({
                title: "Notification",
                text: "Password must be at least 8 characters and contain an uppercase letter, a lowercase letter, a number, and a special character.",
                icon: "error"
            });
            return false;
        }

        if ($scope.password != $scope.confirmPassword) {
            Swal.fire({
                title: "Notification",
                text: "Passwords do not match.",
                icon: "error"
            });
            return false;
        }

        if (new Date($scope.birthday) > new Date($scope.today)) {
            Swal.fire({
                title: "Notification",
                text: "Birthday cannot be a future date.",
                icon: "error"
            });
            return false;
        }

        var emailLower = $scope.email.toLowerCase();
        var usernameLower = $scope.username.toLowerCase();

        for (var i = 0; i < $scope.customerArray.length; i++) {

            if (i == userindex) {
                continue;
            }
            if ($scope.customerArray[i].Username.toLowerCase() == usernameLower) {
                Swal.fire({
                    title: "Notification",
                    text: "Username already exists.",
                    icon: "error"
                });
                return false;
            }
            if ($scope.customerArray[i].Email.toLowerCase() == emailLower) {
                Swal.fire({
                    title: "Notification",
                    text: "Email already exists.",
                    icon: "error"
                });
                return false;
            }
        }

        return true;
    };

    $scope.registrationFunc = function () {
        $scope.touchAllFields();

        if ($scope.inputValidation(-1) == false) {
            return;
        }

        var customer = {
            Username: $scope.username,
            FName: $scope.firstName,
            MName: $scope.middleName,
            Suffix: $scope.suffix,
            LName: $scope.lastName,
            Email: $scope.email.toLowerCase(),
            Password: $scope.password,
            ContactNumber: $scope.contactNumber,
            Gender: $scope.gender,
            Birthday: $scope.birthday,
            Address: $scope.address
        };

        $scope.customerArray.push(customer);
        Swal.fire({
            title: "Success",
            text: "Customer registered successfully!",
            icon: "success"
        });
        $scope.clearRegistrationFunc();
    };

    $scope.editFunc = function (index) {
        var customer = $scope.customerArray[index];

        $scope.username = customer.Username;
        $scope.firstName = customer.FName;
        $scope.middleName = customer.MName;
        $scope.lastName = customer.LName;
        $scope.suffix = customer.Suffix;
        $scope.email = customer.Email;
        $scope.password = customer.Password;
        $scope.confirmPassword = customer.Password;
        $scope.contactNumber = customer.ContactNumber;
        $scope.gender = customer.Gender;
        $scope.birthday = customer.Birthday;
        $scope.address = customer.Address;

        $scope.editingIndex = index;
        $scope.resetRegistrationFormState();
    };

    $scope.updateFunc = function (userindex) {

        if (userindex == undefined || userindex < 0) {
            Swal.fire({
                title: "Notification",
                text: "Click EDIT on a row first.",
                icon: "error"
            });
            return;
        }

        $scope.touchAllFields();

        if ($scope.inputValidation(userindex) == false) {
            return;
        }

        var customer = $scope.customerArray[userindex];
        customer.Username = $scope.username;
        customer.FName = $scope.firstName;
        customer.MName = $scope.middleName;
        customer.Suffix = $scope.suffix;
        customer.LName = $scope.lastName;
        customer.Email = $scope.email.toLowerCase();
        customer.Password = $scope.password;
        customer.ContactNumber = $scope.contactNumber;
        customer.Gender = $scope.gender;
        customer.Birthday = $scope.birthday;
        customer.Address = $scope.address;

        Swal.fire({
            title: "Success",
            text: "Customer updated successfully!",
            icon: "success"
        });
        $scope.clearRegistrationFunc();
    };

    $scope.deleteFunc = function (userindex) {
        var customer = $scope.customerArray[userindex];

        Swal.fire({
            title: "Delete Customer",
            text: "Are you sure you want to delete " + customer.FName + " " + customer.LName + "?",
            icon: "warning",
            showCancelButton: true,
            confirmButtonText: "Yes, delete it!"
        }).then(function (result) {
            if (result.isConfirmed) {
                $scope.$apply(function () {
                    $scope.customerArray.splice(userindex, 1);
                });

                Swal.fire({
                    title: "Deleted!",
                    text: "The customer has been removed.",
                    icon: "success"
                });
            }
        });
    };

});

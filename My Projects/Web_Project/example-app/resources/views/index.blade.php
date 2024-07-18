@extends('layout')
@section('title','User Registration')
@section('content')
<html lang="{{ $selectedLanguage }}">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>{{ $translations['user_registration_form'] }}</title>
    <style>
        /* Your CSS styles here */
    </style>
</head>

<body>
    <h2>{{ $translations['user_registration_form'] }}</h2>

    <!-- Translation switcher dropdown menu -->
    <!-- Form handling for changing language -->
    <form method="post" action="{{ route('user.switchLanguage') }}">
        @csrf
        <label for="language">{{ $translations['select_language'] }}:</label>
        <select name="language" id="language">
            <option value="english" {{ $selectedLanguage === 'english' ? 'selected' : '' }}>{{ $translations['english'] }}</option>
            <option value="arabic" {{ $selectedLanguage === 'arabic' ? 'selected' : '' }}>{{ $translations['arabic'] }}</option>
        </select>
        <input type="submit" value="{{ $translations['switch'] }}">
    </form>

    <!-- User registration form -->
    <form method="post" action="{{ route('user.register') }}" enctype="multipart/form-data" onsubmit="return validateForm()">
        @csrf
        <!-- Full Name -->
        <label for="full_name">{{ $translations['full_name'] }}:</label><br>
        <input type="text" id="full_name" name="full_name" placeholder="{{ $translations['enter_full_name'] }}" required><br><br>

        <!-- Username -->
        <label for="user_name">{{ $translations['username'] }}:</label><br>
        <input type="text" id="user_name" name="user_name" placeholder="{{ $translations['enter_username'] }}" required><br><br>

        <!-- Birthdate -->
        <label for="birthdate">{{ $translations['birthdate'] }}:</label><br>
        <input type="date" id="birthdate" name="birthdate" required><br><br>

        <!-- Phone -->
        <label for="phone">{{ $translations['phone'] }}:</label><br>
        <input type="text" id="phone" name="phone" placeholder="{{ $translations['enter_phone'] }}" required><br><br>

        <!-- Address -->
        <label for="address">{{ $translations['address'] }}:</label><br>
        <input type="text" id="address" name="address" placeholder="{{ $translations['enter_address'] }}" required><br><br>

        <!-- Password -->
        <label for="password">{{ $translations['password'] }}:</label><br>
        <input type="password" id="password" name="password" placeholder="{{ $translations['enter_password'] }}" required><br><br>

        <!-- Confirm Password -->
        <label for="confirm_password">{{ $translations['confirm_password'] }}:</label><br>
        <input type="password" id="confirm_password" name="confirm_password" placeholder="{{ $translations['confirm_password'] }}" required><br><br>

        <!-- User Image -->
        <label for="user_image">{{ $translations['user_image'] }}:</label><br>
        <input type="file" id="user_image" name="user_image" required><br><br>

        <!-- Email -->
        <label for="email">{{ $translations['email'] }}:</label><br>
        <input type="email" id="email" name="email" placeholder="{{ $translations['enter_email'] }}" required><br><br>

        <!-- Submit Button -->
        <input type="submit" name="submit" value="{{ $translations['register'] }}">
    </form>

    <!-- JavaScript code here -->
    <script>
        // Function to validate form
        function validateForm() {
            // Check if all fields are filled out
            var fullName = document.getElementById("full_name").value;
            var userName = document.getElementById("user_name").value;
            var birthdate = document.getElementById("birthdate").value;
            var phone = document.getElementById("phone").value;
            var address = document.getElementById("address").value;
            var password = document.getElementById("password").value;
            var confirmPassword = document.getElementById("confirm_password").value;
            var email = document.getElementById("email").value;
            var userImage = document.getElementById("user_image").value;

            if (fullName === "" || userName === "" || birthdate === "" || phone === "" || address === "" || password === "" || confirmPassword === "" || email === "" || userImage === "") {
                alert("{{ $translations['mandatory_fields'] }}");
                return false;
            }

            // Validate email format
            var emailRegex = /^\S+@\S+\.\S+$/;
            if (!emailRegex.test(email)) {
                alert("{{ $translations['invalid_email'] }}");
                return false;
            }

            // Validate birthdate format
            var birthdateRegex = /^\d{4}-\d{2}-\d{2}$/;
            if (!birthdateRegex.test(birthdate)) {
                alert("{{ $translations['invalid_birthdate'] }}");
                return false;
            }

            // Validate phone number format
            var phoneRegex = /^(012|010|011|015)\d{8}$/;
            if (!phoneRegex.test(phone)) {
                alert("{{ $translations['invalid_phone'] }}");
                return false;
            }

            // Validate password length and pattern
            var passwordRegex = /^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8,}$/;
            if (password.length < 8 || !passwordRegex.test(password)) {
                alert("{{ $translations['invalid_password'] }}");
                return false;
            }

            // Validate password match
            if (password !== confirmPassword) {
                alert("{{ $translations['passwords_not_match'] }}");
                return false;
            }

            return true; // Form is valid
        }
    </script>
</body>
<script>
    // Function to check actors born on the same day
    function checkActors() {

        var birthdate = document.getElementById("birthdate").value;

        // Check if birthdate is not null or empty
        if (!birthdate) {
            alert("Please enter a birthdate.");
            return; // Exit the function if birthdate is not provided
        }
        // Extract day and month from birthdate
        var birthdateObj = new Date(birthdate);
        var day = birthdateObj.getDate();
        var month = birthdateObj.getMonth() + 1;

        console.log(day);
        console.log(month);

        // Perform AJAX request to the server
        var xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function() {
            if (this.readyState == 4 && this.status == 200) {
                // Display the response from the server
                document.getElementById("actors-list").innerHTML = this.responseText;
            }
        };
        xhttp.open("GET", "check_actors.php?day=" + day + "&month=" + month, true);
        xhttp.send();
    }
</script>

<!-- Div to display the list of actors -->
<div id="actors-list"></div>


<div id="actorInfo"></div>
<script>
    function findActor() {

        var inputDate = document.getElementById("birthdate").value;
        var actors = [{
                name: "Actor 1",
                dob: "1990-01-01"
            },
            {
                name: "Actor 2",
                dob: "1985-02-15"
            },
            {
                name: "Actor 3",
                dob: "1992-03-22"
            },

        ];

        var actorFound = false;
        var actorInfo = "";

        for (var i = 0; i < actors.length; i++) {
            if (actors[i].dob === inputDate) {
                actorFound = true;
                actorInfo = actors[i].info;
                break;
            }
        }

        if (actorFound) {
            document.getElementById("actorInfo").innerHTML = "<p>" + actorInfo + "</p>";
        } else {
            document.getElementById("actorInfo").innerHTML = "<p>No actor found with that birth date.</p>";
        }
    }
</script><br>
<button onclick="findActor()"> <?php echo $translations['find Actor']; ?> </button>

<div class="main">
    </br>
    </br>
    </br>
    <table>
        <tr>
            <th align="left">
                <font color="white">Full Name</font>
            </th>
            <th align="left">
                <font color="white">User Name</font>
            </th>
            <th align="left">
                <font color="white">Birthdate</font>
            </th>
            <th align="left">
                <font color="white">Phone</font>
            </th>
            <th align="left">
                <font color="white">Address</font>
            </th>
            <th align="left">
                <font color="white">User Image</font>
            </th>
            <th align="left">
                <font color="white">Email</font>
            </th>
        </tr>
        <tbody>
            <tr>
                <td id="name1">
                    <font color="white">John Doe</font>
                </td>
                <td id="username1">
                    <font color="white">johndoe123</font>
                </td>
                <td id="birthdate1">
                    <font color="white">1990-01-01</font>
                </td>
                <td id="phone1">
                    <font color="white">123-456-7890</font>
                </td>
                <td id="address1">
                    <font color="white">123 Main St, City</font>
                </td>
                <td id="userimage1">
                    <font color="white">---</font>
                </td>
                <td id="email1">
                    <font color="white">johndoe@example.com</font>
                </td>
            </tr>
            Add more rows as needed
        </tbody>
    </table>
</div>

</body>

</html>

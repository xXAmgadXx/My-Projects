<?php include 'header.php'; ?>
<?php include 'DB_Ops.php'; ?>



<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>User Registration</title>
    <script>
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
                alert("All fields are mandatory.");
                return false;
            }

            // Validate email format
            var emailRegex = /^\S+@\S+\.\S+$/;
            if (!emailRegex.test(email)) {
                alert("Email is not in a valid format.");
                return false;
            }

            // Validate birthdate format
            var birthdateRegex = /^\d{4}-\d{2}-\d{2}$/;
            if (!birthdateRegex.test(birthdate)) {
                alert("Birthdate is not in a valid format.");
                return false;
            }

            //validate the phone number 
            var phoneRegex = /^(012|010|011|015)\d{8}$/;
            if (!phoneRegex.test(phone)) {
            alert("Phone number is not in a valid format. It should start with 012, 010, 011, or 015 followed by 8 digits.");
            return false;
            }

            // Validate password length and pattern
            var passwordRegex = /^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8,}$/;
            if (password.length < 8 || !passwordRegex.test(password)) {
                alert("Password must be at least 8 characters long and contain at least 1 number and 1 special character.");
                return false;
            }

            // Validate password match
            if (password !== confirmPassword) {
                alert("Passwords do not match.");
                return false;
            }

            return true; // Form is valid
        }
    </script>



</head>

<body>
    <h2>User Registration Form</h2>
    <form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" enctype="multipart/form-data" onsubmit="return validateForm()">
        <label for="full_name">Full Name:</label><br>
        <input type="text" id="full_name" name="full_name" placeholder="Enter your full name" required><br><br>




        <label for="user_name">Username:</label><br>
        <input type="text" id="user_name" name="user_name" placeholder="Username" required><br><br>

        <label for="dob">Birthdate:</label><br>
        
        <input type="date" id="birthdate" name="birthdate" required><br><br>

        <label for="phone">Phone:</label><br>
        <input type="text" id="phone" name="phone" placeholder="Phone number" required><br><br>

        <label for="address">Address:</label><br>
        <input type="text" id="address" name="address" placeholder="Address" required><br><br>

        <label for="password">Password:</label><br>
        <input type="password" id="password" name="password" placeholder="Password" required><br><br>

        <label for="confirm_password">Confirm Password:</label><br>
        <input type="password" id="confirm_password" name="confirm_password" placeholder="Confirm password" required><br><br>

        <label for="user_image">User Image:</label><br>
        <input type="file" id="user_image" name="user_image" required><br><br>

        <label for="email">Email:</label><br>
        <input type="email" id="email" name="email" placeholder="example@example.com" required><br><br>

        <input type="submit" name="submit" value="Register">
        
    </form>

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
    <button onclick="findActor()"> check Actor </button>

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

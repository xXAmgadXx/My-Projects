<?php
// Database connection
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "test";

// Create connection
$conn = new mysqli('localhost', "root", "", "test");

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Post Method
if (isset($_POST["submit"])) {
    $full_name = $_POST["full_name"];
    $user_name = $_POST["user_name"];
    $birthdate = $_POST["birthdate"];
    $phone = $_POST["phone"];
    $address = $_POST["address"];
    $password = $_POST["password"];
    $confirm_password = $_POST["confirm_password"];
    $email = $_POST["email"];

    // Check if username already exists
    $check_query = "SELECT * FROM user WHERE user_name = '$user_name'";
    $check_result = mysqli_query($conn, $check_query);

    if (mysqli_num_rows($check_result) > 0) {
        // Username already exists, display an alert
        echo "<script>alert('Username already exists. Please choose another username.');</script>";
    } else {
        // Continue with the registration process

        // Check if image is uploaded
        if ($_FILES["user_image"]["error"] == 4) {
            echo "<script> alert('User Image is required'); </script>";
        } else {
            $fileName = $_FILES["user_image"]["name"];
            $fileSize = $_FILES["user_image"]["size"];
            $tmpName = $_FILES["user_image"]["tmp_name"];

            // Valid image extensions
            $validImageExtension = ['jpg', 'jpeg', 'png'];
            $imageExtension = explode('.', $fileName);
            $imageExtension = strtolower(end($imageExtension));

            // Check if image extension is valid
            if (!in_array($imageExtension, $validImageExtension)) {
                echo "<script> alert('Invalid Image Extension'); </script>";
            }
            // Check if image size is too large
            else if ($fileSize > 1000000) {
                echo "<script> alert('Image Size Is Too Large'); </script>";
            } else {
                $newImageName = uniqid() . '.' . $imageExtension;
                $targetPath = 'user_images/' . $newImageName;

                // Move uploaded image to the target directory
                if (move_uploaded_file($tmpName, $targetPath)) {
                    // Insert data into the database
                    $query = "INSERT INTO user (full_name, user_name, birthdate, phone, address, password, email, user_image)
                              VALUES ('$full_name', '$user_name', '$birthdate', '$phone', '$address', '$password', '$email', '$newImageName')";

                    if (mysqli_query($conn, $query)) {
                        echo "<script> alert('Registration Successful'); </script>";
                    } else {
                        echo "<script> alert('Failed to register user'); </script>";
                    }
                } else {
                    echo "<script> alert('Failed to move uploaded image to target directory'); </script>";
                }
            }
        }
    }
}
?>

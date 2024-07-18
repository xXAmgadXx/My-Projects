<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@yield("title")</title>
    <style>
        * {
            padding: 0;
            margin: 0;
            box-sizing: border-box;
        }

        body {
            font-family: 'Arial', sans-serif;
            margin: 0;
            padding: 0;
            background-image: url(https://img.freepik.com/free-vector/circles-background-dark-tones_60389-166.jpg);
            background-size: cover;
            background-position: center center;
            color: #fff; 
        }

        nav {
            background-color: #1112 !important;
        }

        nav ul {
            display: flex;
            list-style-type: none;
        }

        nav ul li {
            margin: 0 20px;
        }

        nav a {
            float: left;
            display: block;
            color: white; 
            text-align: center;
            padding: 14px 16px;
            text-decoration: none;
            transition: all 0.7s;
        }

        nav a:hover {
            color: black;
            background-color: #ddd8;
            border-radius: 4666px;
            transform: scale(1.01, 1.01) translatey(7px);
        }

        h1 {
            color: #fff; 
            text-align: center;
            margin: 20px 0;
        }

        form {
            width: 75%;
            margin: 20px auto;
            background-color: #1112;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            display: flex;
            flex-wrap: wrap;
            justify-content: space-between;
        }

        label {
            display: block;
            margin-bottom: 8px;
            color: #fff; 
        }

        input,
        select {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            box-sizing: border-box;
            border: 1px solid #ddd;
            border-radius: 4px;
        }

        input[type="radio"] {
            margin-right: 5px;
        }

        .submit {
            width: 100%;
            display: flex;
            justify-content: center;
        }

        input[type="submit"] {
            background-color: #4CAF50;
            color: white;
            padding: 10px 15px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            transition: all 0.7s;
            margin: auto !important;
        }

        input[type="submit"]:hover {
            background-color: #45a049;
        }

        .d {
            text-align: center;
        }

        footer {
    position: fixed;
    left: 0;
    bottom: 0;
    width: 100%;
    background-color: #111; 
    color: white;
    text-align: center;
    padding: 5px 0; 
    
}
.main table {
            border-collapse: collapse;
            width: 127%;
            background-color: transparent; 
        }

        .main th,
        .main td {
            border: 1px solid black;
            padding: 8px;
            background-color: transparent; 
        }

        .main th {
            text-align: left;
        }

        .main tbody tr:nth-child(even) {
            background-color: #f2f2f2;
        }
    </style>
</head>
<body>

<header>
    <nav>
        <ul>
            <li><a href="#">Home</a></li>
            <li><a href="#">About</a></li>
            <li><a href="#">Services</a></li> <!-- Added Services -->
            <li><a href="#">Contact</a></li>
        </ul>
    </nav>
    <div class="header-info"> <!-- Added header information section -->
        <h1>User Registration</h1>
    </div>
</header>


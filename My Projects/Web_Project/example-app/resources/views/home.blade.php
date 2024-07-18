<!DOCTYPE html>
<html>
<head>
    <title>Home</title>
</head>
<body>
    @if(session('success'))
        <div class="alert alert-success">
            {{ session('success') }}
        </div>
    @endif
    <!-- Your home page content goes here -->
</body>
</html>

<?php
echo "hello";
if (isset($_GET['day']) && isset($_GET['month'])) {
    $day = $_GET['day'];
    $month = $_GET['month'];


    // Perform API request to retrieve the response
    $curl = curl_init();

    curl_setopt_array($curl, [
        CURLOPT_URL => "https://imdb8.p.rapidapi.com/actors/list-born-today?month=" . $month . "&day=" . $day,
        CURLOPT_RETURNTRANSFER => true,
        CURLOPT_ENCODING => "",
        CURLOPT_MAXREDIRS => 10,
        CURLOPT_TIMEOUT => 30,
        CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
        CURLOPT_CUSTOMREQUEST => "GET",
        CURLOPT_HTTPHEADER => [
            "X-RapidAPI-Host: imdb8.p.rapidapi.com",
            "X-RapidAPI-Key: 8a4713f103msh29f55c7b3d8b65fp1147cbjsnb6bf9e435a7c"
        ],
    ]);

    $response = curl_exec($curl);
    echo $response;
    $err = curl_error($curl);

    curl_close($curl);

    // If there is an error, display it
    if ($err) {
        echo "cURL Error #:" . $err;
    } else {
        // Decode the JSON response
        $data = json_decode($response, true);

        // Regular expression pattern to extract the numbers
        $pattern = '/\d+/';

        // Array to store the extracted numbers
        $numbers = [];

        foreach ($data as $value) {
            preg_match($pattern, $value, $matches);
            if (!empty($matches)) {
                // Extracted number is in $matches[0]
                $numbers[] = $matches[0];
            }
        }

        // Output the extracted numbers
        echo "<table border='1'>";
        foreach ($numbers as $number) {
            $curl = curl_init();

            curl_setopt_array($curl, [
                CURLOPT_URL => "https://imdb8.p.rapidapi.com/actors/get-bio?nconst=nm" . $number,
                CURLOPT_RETURNTRANSFER => true,
                CURLOPT_ENCODING => "",
                CURLOPT_MAXREDIRS => 10,
                CURLOPT_TIMEOUT => 30,
                CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
                CURLOPT_CUSTOMREQUEST => "GET",
                CURLOPT_HTTPHEADER => [
                    "X-RapidAPI-Host: imdb8.p.rapidapi.com",
                    "X-RapidAPI-Key: 8a4713f103msh29f55c7b3d8b65fp1147cbjsnb6bf9e435a7c"
                ],
            ]);

            $response = curl_exec($curl);
            $err = curl_error($curl);

            curl_close($curl);

            if ($err) {
                echo "cURL Error #:" . $err;
            } else {
                // Decode the JSON response
                $data = json_decode($response, true);
                echo "<tr>";
                foreach ($data as $key => $value) {
                    if ($key == "name") {
                        echo "<td>" . $value . "</td>";
                    }
                }
                echo "</tr>";
            }
        }
        echo "</table>";
    }
} else {
    // If day and month parameters are not provided, return an error message
    echo "Error: Day and month parameters are required.";
}

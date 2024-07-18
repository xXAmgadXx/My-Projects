<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\views\DB_Ops;

class RegistrationController extends Controller
{
    public function register(Request $request)
    {
        // Validate the incoming request data
        $validatedData = $request->validate([
            'full_name' => 'required',
            'user_name' => 'required|unique:users',
            'birthdate' => 'required|date',
            'phone' => 'required',
            'address' => 'required',
            'password' => 'required|min:8',
            'confirm_password' => 'required|same:password',
            'email' => 'required|email|unique:users',
            'user_image' => 'required|image|max:1000', // Max 1MB
        ]);

        // Handle file upload
        $imageFile = $request->file('user_image');

        // Check if the folder exists, and if not, create it
        if (!file_exists(public_path('user_images'))) {
            mkdir(public_path('user_images'), 0777, true);
        }

        // Generate a unique filename for the image
        $imageName = uniqid() . '.' . $imageFile->getClientOriginalExtension();

        // Move the uploaded image to the target directory
        $imagePath = $imageFile->move(public_path('user_images'), $imageName);

        // Prepare user data to be inserted into the database
        // Prepare user data to be inserted into the database
        $userData = [
            'full_name' => $request->input('full_name'),
            'user_name' => $request->input('user_name'),
            'birthdate' => $request->input('birthdate'),
            'phone_number' => $request->input('phone'), // Changed to match the column name in the migration file
            'address' => $request->input('address'), // Changed to match the column name in the migration file
            'password' => bcrypt($request->input('password')),
            'email' => $request->input('email'),
            'user_image' => $imageName,
        ];


        // Insert user data into the database using DB_Ops class
        if (DB_Ops::insertUser($userData)) {
            return redirect()->route('index');
        } else {
            return redirect()->back()->with('error', 'Failed to register user');
        }
    }
}



namespace App\views;

use Illuminate\Support\Facades\DB;

class DB_Ops
{
    public static function insertUser($data)
    {
        try {
            // Perform insertion into the 'user' table
            return DB::table('Web_based_proj.users')->insert($data);
        } catch (\Exception $e) {

            return false;
        }
    }

    public static function checkUsernameExists($username)
    {
        try {
            // Check if username already exists in the 'user' table
            return DB::table('Web_based_proj.users')->where('user_name', $username)->exists();
        } catch (\Exception $e) {
            // Handle any exceptions, such as database errors
            return false;
        }
    }

    // You can add more database operations here as needed
}

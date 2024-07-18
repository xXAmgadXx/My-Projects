<?php

namespace App\Http\Controllers;
use Illuminate\Http\Request;
class UserController extends Controller
{
    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        // Define validation rules for the request
        $validatedData = $request->validate([
            'full_name' => 'required|string|max:255',
            'user_name' => 'required|string|max:255',
            'birthdate' => 'required|date',
            'phone' => 'required|string|regex:/^(012|010|011|015)\d{8}$/',
            'address' => 'required|string|max:255',
            'password' => 'required|string|min:8|regex:/^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8,}$/',
            'confirm_password' => 'required|string|same:password',
            'user_image' => 'required|image|max:2048', // Assuming it's an image upload
            'email' => 'required|string|email|max:255|unique:users',
        ]);

        // If validation passes, proceed with storing the user data

        // Display success message or redirect as needed
        return redirect()->route('welcome')->with('success', 'User registration successful!');
    }
}
abstract class Controller
{
    //
}

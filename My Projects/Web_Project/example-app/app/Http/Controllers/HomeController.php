<?php
namespace App\Http\Controllers;

use App\views\layouts\home;

class HomeController extends Controller
{
    public function index()
    {
        return view('home')->with('success', session('success'));
    }
}

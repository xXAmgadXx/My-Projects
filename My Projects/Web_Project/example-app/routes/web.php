<?php
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\UserControllerPage;
use App\Http\Controllers\RegistrationController;
use App\Http\Controllers\HomeController;

// Default route to show the registration form
Route::get('/', [UserControllerPage::class, 'showRegistrationForm']);

// Route to show the registration form
Route::get('/reload/{selectedLanguage}', [UserControllerPage::class, 'reload'])->name('user.reload');

// Route to switch language
Route::post('/switch-language', [UserControllerPage::class, 'switchLanguage'])->name('user.switchLanguage');

// Route to handle registration
Route::post('/register', [RegistrationController::class, 'register'])->name('user.register');
Route::get('/home', [HomeController::class, 'index'])->name('home');

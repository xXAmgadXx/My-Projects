<?php

namespace App\Http\Controllers;

use App\index;
use Illuminate\Http\Request;


class UserControllerPage extends Controller
{
    private $defaultLanguage = 'english'; // Set the default language here

    // Translation arrays for English and Arabic
    private $translations = [
        'english' => [
            'user_registration_form' => 'User_registration_form',
            'select_language' => 'Select Language',
            'english' => 'English',
            'arabic' => 'Arabic',
            'full_name' => 'Full Name',
            'username' => 'Username',
            'birthdate' => 'Birthdate',
            'phone' => 'Phone',
            'address' => 'Address',
            'password' => 'Password',
            'confirm_password' => 'Confirm Password',
            'user_image' => 'User Image',
            'email' => 'Email',
            'enter_full_name' => 'Enter your full name',
            'enter_username' => 'Enter your username',
            'enter_phone' => 'Enter your phone number',
            'enter_address' => 'Enter your address',
            'enter_password' => 'Enter your password',
            'enter_email' => 'Enter your email',
            'register' => 'Register',
            'mandatory_fields' => 'All fields are mandatory',
            'invalid_email' => 'Email is not in a valid format',
            'invalid_birthdate' => 'Birthdate is not in a valid format',
            'invalid_phone' => 'Phone number is not in a valid format',
            'invalid_password' => 'Password must be at least 8 characters long and contain at least 1 number and 1 special character',
            'passwords_not_match' => 'Passwords do not match',
            'switch' => 'Switch',
            'find Actor' => 'Find Actor',
        ],
        'arabic' => [
            'user_registration_form' => 'فورم تسجيل بيانات المستخدم',
            'select_language' => 'اختر اللغة',
            'english' => 'الإنجليزية',
            'arabic' => 'العربية',
            'full_name' => 'الاسم الكامل',
            'username' => 'اسم المستخدم',
            'birthdate' => 'تاريخ الميلاد',
            'phone' => 'الهاتف',
            'address' => 'العنوان',
            'password' => 'كلمة المرور',
            'confirm_password' => 'تأكيد كلمة المرور',
            'user_image' => 'صورة المستخدم',
            'email' => 'البريد الإلكتروني',
            'enter_full_name' => 'أدخل اسمك الكامل',
            'enter_username' => 'أدخل اسم المستخدم',
            'enter_phone' => 'أدخل رقم هاتفك',
            'enter_address' => 'أدخل عنوانك',
            'enter_password' => 'أدخل كلمة المرور الخاصة بك',
            'enter_email' => 'أدخل بريدك الالكتروني',
            'register' => 'تسجيل',
            'mandatory_fields' => 'جميع الحقول إلزامية',
            'invalid_email' => 'البريد الإلكتروني ليس بتنسيق صحيح',
            'invalid_birthdate' => 'تاريخ الميلاد ليس بتنسيق صحيح',
            'invalid_phone' => 'رقم الهاتف ليس بتنسيق صحيح',
            'invalid_password' => 'يجب أن تتكون كلمة المرور من 8 أحرف على الأقل وتحتوي على رقم وحرف خاص واحد على الأقل',
            'passwords_not_match' => 'كلمات المرور غير متطابقة',
            'switch' => 'حول',
            'find Actor' => 'أوجد الممثل',
            'Choose file' => 'اختر ملف',
            "No file chosen" =>'لا يوجد ملف مختار',
        ]
    ];
    // Method to display the registration form
    // Method to display the registration form with the default language (English)
    public function showRegistrationForm(Request $request)
    {
        // Set the selected language to the default language (English)
        $selectedLanguage = $this->defaultLanguage;

        // Load translations from the appropriate language file or use the default translations
        $translations = $this->translations[$selectedLanguage] ?? $this->translations[$this->defaultLanguage];

        // Pass the translations and selected language to the view
        return view('index', [
            'translations' => $translations,
            'selectedLanguage' => $selectedLanguage
        ]);
    }
    public function reload(Request $request, $selectedLanguage )
    {
        $translations = $this->translations[$selectedLanguage] ?? $this->translations[$this->defaultLanguage];

        // Pass the translations and selected language to the view
        return view('index', [
            'translations' => $translations,
            'selectedLanguage' => $selectedLanguage
        ]);

    }


   

    // Method to handle the language switching
    public function switchLanguage(Request $request)
    {
        // Get the selected language from the request
        $selectedLanguage = $request->input('language');

        // Store the selected language in the session
        $request->session()->put('selectedLanguage', $selectedLanguage);

        // Load translations for the selected language or use the default translations
        $translations = $this->translations[$selectedLanguage] ?? $this->translations[$this->defaultLanguage];

        return redirect()->route('user.reload', ['selectedLanguage' => $selectedLanguage]);

    }


    
}








import 'package:flutter/material.dart';
import 'package:petcare_p/HomePage.dart';
import 'package:petcare_p/SignupPage.dart';

import 'Shared/MyTextField.dart';




class LoginPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Pet Care Login'),
        backgroundColor: Colors.blue,
      ),
      body: Container(
        child : SingleChildScrollView(

        child: Padding(
          padding: const EdgeInsets.all(16.0),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: [
                  const Text(
                    'Welcome to Pet Care',
                    style: TextStyle(
                        fontSize: 24.0,
                        fontWeight: FontWeight.bold,
                         color: Colors.blue
                    ),
                  ),
                  const SizedBox(width: 8.0),
                  Image.asset(
                    'assets/Pet_care.jpg', // Replace with the actual path to your image
                    width: 200.0,
                    height: 300.0,
                  ),
                ],
              ),


              MyTextField(
                texttype: TextInputType.emailAddress,
                hinttext: "Email Address",
                ispassword: false,
              ),

              const SizedBox(
                height: 12.0,
              ),

              MyTextField(
                texttype: TextInputType.text,
                hinttext: "User Name",
                ispassword: false,
              ),

              const SizedBox(height: 12.0),

              MyTextField(
                texttype: TextInputType.text,
                hinttext: "Password",
                ispassword: true ,
              ),

              const SizedBox(height: 30.0),

              MaterialButton(
                  elevation: 5.0,
                  color: Colors.blue,
                  padding: const EdgeInsets.symmetric(
                      vertical: 20,
                      horizontal: 80
                  ),
                  shape: OutlineInputBorder(
                      borderRadius: BorderRadius.circular(50),
                      borderSide: BorderSide.none

                  ),
                  onPressed: (){
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                          builder: (context) => HomePage()
                      ),
                    );

                  },
                  child: const Text('Log In',
                    style: TextStyle(
                        color: Colors.white,
                        fontSize: 23,
                        fontWeight: FontWeight.bold
                    ),
                  )
              ),
              const SizedBox(height: 12.0),
              TextButton(
                onPressed: () {
                  // Navigate to the signup page
                  Navigator.push(
                    context,
                    MaterialPageRoute(builder: (context) => SignupPage()),
                  );
                },
                style: ButtonStyle(
                  foregroundColor: MaterialStateProperty.all(Colors.blue)
                ),
                child: const Text(
                    'Create an account',

                ),
              ),
            ],
          ),
        ),
        ),
      ),
    );
  }
}




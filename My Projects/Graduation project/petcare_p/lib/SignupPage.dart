import 'package:flutter/material.dart';
import 'package:petcare_p/PersonalInfo.dart';

import 'Shared/MyTextField.dart';



class SignupPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Sign Up'),
        backgroundColor:Colors.blue ,
      ),
      body: Container(
        decoration: const BoxDecoration(
          image: DecorationImage(
            image: AssetImage('assets/pet_care.png'),
            fit: BoxFit.cover,
          ),
        ),
        child: Padding(
          padding: const EdgeInsets.all(16.0),
          child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              const Text(
                'Create an Account',
                style: TextStyle(fontSize: 24.0, fontWeight: FontWeight.bold),
              ),
              const SizedBox(height: 20.0),
              MyTextField(
                texttype: TextInputType.emailAddress,
                hinttext: "Email Assress",
                ispassword: false,
              ),
              const SizedBox(height: 12.0),
              MyTextField(
                texttype: TextInputType.text,
                hinttext: "Password",
                ispassword: true,
              ),
              const SizedBox(height: 12.0),
              MyTextField(
                texttype: TextInputType.text,
                hinttext: "Confirm Password",
                ispassword: true,
              ),
              const SizedBox(height: 50),
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
                          builder: (context) => PersonalInfo()
                      ),
                    );

                  },
                  child: const Text('Sign Up',
                    style: TextStyle(
                        color: Colors.white,
                        fontSize: 23,
                        fontWeight: FontWeight.bold
                    ),
                  )
              ),
            ],
          ),
        ),
      ),
    );
  }
}
import 'package:flutter/material.dart';
import 'package:petcare_p/UserProfile';
import 'package:petcare_p/HomePage.dart';
import 'Shared/MyTextField.dart';
import 'package:firebase_auth/firebase_auth.dart';

class SignupPage extends StatefulWidget {
  late UserProfile userprofile;

  SignupPage({super.key});

  @override
  _SignupPageState createState() => _SignupPageState();
}

class _SignupPageState extends State<SignupPage> {
  TextEditingController usernameController = TextEditingController();
  TextEditingController passwordController = TextEditingController();
  // ignore: non_constant_identifier_names
  TextEditingController confirm_passController = TextEditingController();

  var auth = FirebaseAuth.instance;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Sign Up'),
        backgroundColor: Colors.blue,
      ),
      body: Container(
        decoration: const BoxDecoration(),
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
              MyTextField2(
                controller: usernameController,
                texttype: TextInputType.emailAddress,
                hinttext: "Email Address",
                ispassword: false,
                icon: Icons.email_outlined,
              ),
              const SizedBox(height: 12.0),
              MyTextField2(
                texttype: TextInputType.text,
                hinttext: "Password",
                ispassword: true,
                icon: Icons.lock_clock_outlined,
                controller: passwordController,
              ),
              const SizedBox(height: 12.0),
              MyTextField2(
                controller: confirm_passController,
                texttype: TextInputType.text,
                hinttext: "Confirm Password",
                ispassword: true,
                icon: Icons.check_box,
              ),
              const SizedBox(height: 50),
              MaterialButton(
                elevation: 5.0,
                color: Colors.blue,
                padding:
                    const EdgeInsets.symmetric(vertical: 20, horizontal: 80),
                shape: OutlineInputBorder(
                  borderRadius: BorderRadius.circular(50),
                  borderSide: BorderSide.none,
                ),
                onPressed: () {
                  auth
                      .createUserWithEmailAndPassword(
                    email: usernameController.text,
                    password: passwordController.text,
                  )
                      .then((authResult) {
                    // Authentication successful, now navigate to the next page
                    Navigator.push(
                      context,
                      MaterialPageRoute(builder: (context) => const HomePage()),
                    );
                  }).catchError((e) {
                    if (e is FirebaseAuthException) {
                      if (e.code == 'weak-password') {
                        print('The Password is weak');
                      } else if (e.code == 'email-already-in-use') {
                        print('The account already exists for this email');
                      }
                      print(e.message);
                    }
                  });
                },
                child: const Text(
                  'Sign Up',
                  style: TextStyle(
                    color: Colors.white,
                    fontSize: 23,
                    fontWeight: FontWeight.bold,
                  ),
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }
}

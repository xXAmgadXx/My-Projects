import 'package:flutter/material.dart';
import 'package:petcare_p/HomePage.dart';
import 'package:petcare_p/Shared/MyTextField.dart';

class PetInfo extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Pet Information'),
        backgroundColor: Colors.blue,
      ),
      body: Container(
        padding: const EdgeInsets.symmetric(horizontal: 10),
        width: double.infinity,
        child: SingleChildScrollView(
          child: Row(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            crossAxisAlignment: CrossAxisAlignment.start, // Align columns at the top
            children: <Widget>[
              Container(
                width: 180, // Adjust the width based on your design
                padding: const EdgeInsets.all(20),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: <Widget>[
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Pet Name",
                      ispassword: false,
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Pet Type",
                      ispassword: false,
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Gender",
                      ispassword: false,
                    ),
                    MyTextField(
                      texttype: TextInputType.datetime,
                      hinttext: "Date Of Birth",
                      ispassword: false,
                    ),
                    MyTextField(
                      texttype: TextInputType.number,
                      hinttext: "Weight",
                      ispassword: false,
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Allergies",
                      ispassword: false,
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Rabies Vac",
                      ispassword: false,
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Disease",
                      ispassword: false,
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Surgeries",
                      ispassword: false,
                    ),
                  ],
                ),
              ),
              Container(
                width: 180, // Adjust the width based on your design
                padding: const EdgeInsets.all(20),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: <Widget>[
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Favourite Food",
                      ispassword: false,
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Vet Name",
                      ispassword: false,
                    ),
                    MyTextField(
                      texttype: TextInputType.number,
                      hinttext: "Vet Number",
                      ispassword: false,
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Vet Address",
                      ispassword: false,
                    )
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
      // Add a button at the end of the page
      floatingActionButton: FloatingActionButton(
        onPressed: () {
          // Handle press for the button
          // For example, you can navigate to another page here
          Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => HomePage()),
          );
        },
        child: Icon(Icons.arrow_forward),
        backgroundColor: Colors.blue,
      ),
    );
  }

}

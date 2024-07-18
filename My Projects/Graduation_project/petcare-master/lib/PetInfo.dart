import 'package:flutter/material.dart';
import 'HomePage.dart';
import 'Shared/MyTextField.dart';
import 'package:petcare_p/UserProfile';
import 'package:cloud_firestore/cloud_firestore.dart';
import 'package:firebase_auth/firebase_auth.dart';

class PetInfo extends StatefulWidget {
  late UserProfile userprofile;

  PetInfo({super.key, required this.userprofile});

  @override
  _PetInfoState createState() => _PetInfoState();
}

class _PetInfoState extends State<PetInfo> {
  final FirebaseFirestore _firestore = FirebaseFirestore.instance;

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
            crossAxisAlignment:
                CrossAxisAlignment.start, // Align columns at the top
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
                      onChangedCallback: (value) {
                        setState(() {
                          widget.userprofile.petName =
                              value; // Store the entered value in a variable
                        });
                      },
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Pet Type",
                      ispassword: false,
                      onChangedCallback: (value) {
                        setState(() {
                          widget.userprofile.petType =
                              value; // Store the entered value in a variable
                        });
                      },
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Gender",
                      ispassword: false,
                      onChangedCallback: (value) {
                        setState(() {
                          widget.userprofile.gender =
                              value; // Store the entered value in a variable
                        });
                      },
                    ),
                    MyTextField(
                      texttype: TextInputType.datetime,
                      hinttext: "Date Of Birth",
                      ispassword: false,
                      onChangedCallback: (value) {
                        setState(() {
                          widget.userprofile.datOfB =
                              value; // Store the entered value in a variable
                        });
                      },
                    ),
                    MyTextField(
                      texttype: TextInputType.number,
                      hinttext: "Weight",
                      ispassword: false,
                      onChangedCallback: (value) {
                        setState(() {
                          widget.userprofile.weight =
                              value; // Store the entered value in a variable
                        });
                      },
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Allergies",
                      ispassword: false,
                      onChangedCallback: (value) {
                        setState(() {
                          widget.userprofile.allergies =
                              value; // Store the entered value in a variable
                        });
                      },
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Rabies Vac",
                      ispassword: false,
                      onChangedCallback: (value) {
                        setState(() {
                          widget.userprofile.rabiesVac =
                              value; // Store the entered value in a variable
                        });
                      },
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Disease",
                      ispassword: false,
                      onChangedCallback: (value) {
                        setState(() {
                          widget.userprofile.disease =
                              value; // Store the entered value in a variable
                        });
                      },
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Surgeries",
                      ispassword: false,
                      onChangedCallback: (value) {
                        setState(() {
                          widget.userprofile.surgeries =
                              value; // Store the entered value in a variable
                        });
                      },
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
                      onChangedCallback: (value) {
                        setState(() {
                          widget.userprofile.favouriteFood =
                              value; // Store the entered value in a variable
                        });
                      },
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Vet Name",
                      ispassword: false,
                      onChangedCallback: (value) {
                        setState(() {
                          widget.userprofile.vetName =
                              value; // Store the entered value in a variable
                        });
                      },
                    ),
                    MyTextField(
                      texttype: TextInputType.number,
                      hinttext: "Vet Number",
                      ispassword: false,
                      onChangedCallback: (value) {
                        setState(() {
                          widget.userprofile.vetNumber =
                              value; // Store the entered value in a variable
                        });
                      },
                    ),
                    MyTextField(
                      texttype: TextInputType.text,
                      hinttext: "Vet Address",
                      ispassword: false,
                      onChangedCallback: (value) {
                        setState(() {
                          widget.userprofile.vetAddress =
                              value; // Store the entered value in a variable
                        });
                      },
                    ),
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
      // Add a button at the end of the page
      floatingActionButton: FloatingActionButton(
        onPressed: () async {
          User? user = FirebaseAuth.instance.currentUser;
          if (user != null) {
            String userId = user.uid;
            await saveUserProfileToFirestore(userId, widget.userprofile);
            Navigator.push(
              context,
              MaterialPageRoute(builder: (context) => const HomePage()),
            );
          } else {
            // Handle the case where the user is not authenticated
            print('User not authenticated');
          }
        },
        backgroundColor: Colors.blue,
        child: const Icon(Icons.arrow_forward),
      ),
    );
  }

  Future<void> saveUserProfileToFirestore(
      String userId, UserProfile userprofile) async {
    try {
      DocumentReference userDocument =
          _firestore.collection('users').doc(userId);
      // Use the 'users' collection (replace with your desired collection name)
      await userDocument.set({
        'username': userprofile.username,
        'phoneNumber': userprofile.phoneNumber,
        'dateOfBirth': userprofile.dateOfBirth,
        'petName': userprofile.petName,
        'petType': userprofile.petType,
        'gender': userprofile.gender,
        'datOfB': userprofile.datOfB,
        'weight': userprofile.weight,
        'allergies': userprofile.allergies,
        'rabiesVac': userprofile.rabiesVac,
        'disease': userprofile.disease,
        'surgeries': userprofile.surgeries,
        'favouriteFood': userprofile.favouriteFood,
        'vetName': userprofile.vetName,
        'vetNumber': userprofile.vetNumber,
        'vetAddress': userprofile.vetAddress,
      });
      print('User profile data saved to Firestore');
    } catch (e) {
      print('Error saving user profile data: $e');
    }
  }
}

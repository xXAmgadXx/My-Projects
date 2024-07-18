import 'package:flutter/material.dart';
import 'PetInfo.dart';
import 'Shared/MyTextField.dart';
import 'UserProfile';

// ignore: must_be_immutable
class PersonalInfo extends StatefulWidget {
  const PersonalInfo({super.key});

 

  @override
  State<PersonalInfo> createState() => _PersonalInfoState();
}

class _PersonalInfoState extends State<PersonalInfo> {
  final TextEditingController userNameController = TextEditingController();
  final TextEditingController phoneNumberController = TextEditingController();
  final TextEditingController dobController = TextEditingController();

  UserProfile userprofile = UserProfile(
    username: '',
    phoneNumber:'',
    dateOfBirth:'',
    petName:'',
    petType:'',
    gender:'',
    datOfB:'',
    weight:'',
    allergies:'',
    rabiesVac:'',
    disease:'',
    surgeries:'',
    favouriteFood:'',
    vetName:'',
   vetNumber:'',
   vetAddress:'',
  );

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.blue,
        title: const Text('personal Information'),
      ),
      body: Container(
        padding: const EdgeInsets.symmetric(
          horizontal: 20,
        ),
        width: MediaQuery.of(context).size.width,
        child: SingleChildScrollView(
          child: Column(
            children: <Widget>[
              const SizedBox(height: 150),
              MyTextField(
                texttype: TextInputType.text,
                hinttext: "User Name",
                ispassword: false,
                onChangedCallback: (value) {
                  setState(() {
                    userprofile.username = value;
                  });
                },
              ),
              const SizedBox(height: 20),
              MyTextField(
                texttype: TextInputType.number,
                hinttext: "Phone Number",
                ispassword: false,
                onChangedCallback: (value) {
                  setState(() {
                    userprofile.phoneNumber = value;
                  });
                },
              ),
              const SizedBox(height: 20),
              MyTextField(
                texttype: TextInputType.text,
                hinttext: "Date Of Birth",
                ispassword: false,
                onChangedCallback: (value) {
                  setState(() {
                    userprofile.dateOfBirth = value;
                  });
                },
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
                  Navigator.push(
                    context,
                    MaterialPageRoute(builder: (context) => PetInfo(userprofile:userprofile)),
                  );
                },
                child: const Text(
                  'next',
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

import 'package:flutter/material.dart';
import 'package:petcare_p/PetInfo.dart';
import 'Shared/MyTextField.dart';

class PersonalInfo extends StatefulWidget{

 const PersonalInfo ([Key? key]) :super(key: key) ;

  @override
  State<PersonalInfo> createState() => _PersonalInfoState() ;

}

class _PersonalInfoState extends State<PersonalInfo> {

  final TextEditingController userNameController = TextEditingController();
  final TextEditingController phoneNumberController = TextEditingController();
  final TextEditingController dobController = TextEditingController();

@override

Widget build(BuildContext context ) {
  return Scaffold(
    appBar: AppBar(
      backgroundColor: Colors.blue,
      title: const Text('personal Information'),
    ),
    body: Container(
      padding: const EdgeInsets.symmetric(horizontal: 20,),
      width: MediaQuery.of(context).size.width,
      child:  SingleChildScrollView(
        child: Column(
          children: <Widget> [

            const SizedBox(height:150),
            MyTextField(
              texttype: TextInputType.text,
              hinttext:"User Name" ,
              ispassword: false,
            ),

           const  SizedBox(height:20),
            MyTextField(
              texttype: TextInputType.number,
              hinttext: "Phone Number",
              ispassword: false,
            ),

            const SizedBox(height:20),
            MyTextField(
              texttype: TextInputType.datetime,
              hinttext: "Date Of Birth",
              ispassword: false,
            ),

            const SizedBox(height:50),
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
                    builder: (context) => PetInfo()
                  ),
                );

                },
                child: const Text('next',
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
  
    
  






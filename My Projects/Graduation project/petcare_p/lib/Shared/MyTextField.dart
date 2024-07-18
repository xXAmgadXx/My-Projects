import 'package:flutter/material.dart';

class MyTextField extends StatelessWidget {
  final TextInputType texttype;
  final bool ispassword;
  final String hinttext;

  MyTextField({
    Key? key,
    required this.texttype,
    required this.ispassword,
    required this.hinttext,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: <Widget>[
        const SizedBox(height: 20),
        Text(
          hinttext,
          style: const TextStyle(fontWeight: FontWeight.bold),
        ),
        const SizedBox(height: 10),
        TextField(
          keyboardType: texttype,
          obscureText: ispassword,
          decoration: InputDecoration(
            hintText: hinttext,
            enabledBorder: OutlineInputBorder(
              borderRadius: BorderRadius.circular(20),
              borderSide: const BorderSide(
                color: Colors.blue, // Set your desired border color
                width: 1.0,
              ),
            ),
            focusedBorder: OutlineInputBorder(
              borderRadius: BorderRadius.circular(20),
              borderSide: const BorderSide(
                color: Colors.blue, // Set your desired border color
                width: 2.0, // Adjust the border width if needed
              ),
            ),
          ),
        ),
      ],
    );
  }
}

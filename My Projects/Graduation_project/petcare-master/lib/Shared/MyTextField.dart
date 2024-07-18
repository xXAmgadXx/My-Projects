import 'package:flutter/material.dart';

class MyTextField extends StatelessWidget {
  final TextInputType texttype;
  final bool ispassword;
  final String hinttext;

  final void Function(String) onChangedCallback;

  const MyTextField({
    Key? key,
    required this.texttype,
    required this.ispassword,
    required this.hinttext,
    required this.onChangedCallback,
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
          onChanged: (Value) {
            onChangedCallback(Value);
          },
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

class MyTextField2 extends StatefulWidget {
  final TextInputType texttype;
  final bool ispassword;
  final String hinttext;
  final IconData icon;
  final TextEditingController controller; // Add this line
  

  const MyTextField2({
    Key? key,
    required this.texttype,
    required this.ispassword,
    required this.hinttext,
    required this.icon,
    required this.controller, // Add this line
    
  }) : super(key: key);

  @override
  _MyTextField2State createState() => _MyTextField2State();
}

class _MyTextField2State extends State<MyTextField2> {
  bool _isPasswordVisible = false;

  @override
  Widget build(BuildContext context) {
    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: <Widget>[
        const SizedBox(height: 20),
        Text(
          widget.hinttext,
          style: const TextStyle(fontWeight: FontWeight.bold),
        ),
        const SizedBox(height: 10),
        TextField(
          controller: widget.controller, // Assign the controller

          keyboardType: widget.texttype,
          obscureText: widget.ispassword && !_isPasswordVisible,
          decoration: InputDecoration(
            prefixIcon: Icon(
              widget.icon,
              color: Colors.blue,
            ),
            suffixIcon: widget.ispassword
                ? IconButton(
                    icon: Icon(
                      _isPasswordVisible
                          ? Icons.visibility
                          : Icons.visibility_off,
                    ),
                    onPressed: () {
                      setState(() {
                        _isPasswordVisible = !_isPasswordVisible;
                      });
                    },
                  )
                : null,
            hintText: widget.hinttext,
            enabledBorder: OutlineInputBorder(
              borderRadius: BorderRadius.circular(20),
              borderSide: const BorderSide(
                color: Colors.blue,
                width: 1.0,
              ),
            ),
            focusedBorder: OutlineInputBorder(
              borderRadius: BorderRadius.circular(20),
              borderSide: const BorderSide(
                color: Colors.blue,
                width: 2.0,
              ),
            ),
          ),
        ),
      ],
    );
  }
}

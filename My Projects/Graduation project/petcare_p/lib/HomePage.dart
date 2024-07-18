import 'package:flutter/material.dart';
import 'package:petcare_p/LoginPage.dart';
import 'package:petcare_p/PetServices.dart';

class HomePage extends StatelessWidget {
  bool isHovered = false;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.blue,
        title: const Text('Pet Care App'),
      ),
      body: Stack(
        children: [
          Positioned(
            top: 50,
            left: 0,
            right: 0,
            child: Column(
              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
              children: [
                InkWell(
                  onTap: () {
                    // Handle tap for Explore Pet Supplies
                  },
                  onHover: (hovered) {
                    // Handle hover for Explore Pet Supplies
                  },
                  child: ElevatedButton(
                    onPressed: () {
                      // Handle press for Explore Pet Supplies
                    },
                    style: ElevatedButton.styleFrom(
                      primary: Colors.blue,
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(30),
                      ),
                      padding: const EdgeInsets.all(60),
                    ),
                    child: const Text(
                      'Explore Pet Supplies',
                      textAlign: TextAlign.center,
                      style: TextStyle(color: Colors.white),
                    ),
                  ),
                ),
                const SizedBox(height: 30),
                InkWell(
                  onTap: () {
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                        builder: (context) => const PetServices(title: 'pet services'),
                      ),
                    );
                    // Handle tap for Explore Pet Services
                  },
                  onHover: (hovered) {
                    // Handle hover for Explore Pet Services
                  },
                  child: ElevatedButton(
                    onPressed: () {
                      Navigator.push(
                        context,
                        MaterialPageRoute(
                          builder: (context) => const PetServices(title: 'pet services'),
                        ),
                      );
                    },
                    style: ElevatedButton.styleFrom(
                      primary: Colors.orange,
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(30),
                      ),
                      padding: const EdgeInsets.all(60),
                    ),
                    child: const Text(
                      'Explore Pet Services',
                      textAlign: TextAlign.center,
                      style: TextStyle(color: Colors.white),
                    ),
                  ),
                ),
              ],
            ),
          ),
          Positioned(
            bottom: 20,
            right: 20,
            child: MouseRegion(
              cursor: SystemMouseCursors.click,
              child: InkWell(
                onTap: () {
                  // Handle tap for Chat
                  Navigator.push(
                    context,
                    MaterialPageRoute(
                      builder: (context) => LoginPage(), // Replace YourDestinationPage with the actual destination page
                    ),
                  );
                },
                child: Container(
                  decoration: BoxDecoration(
                    color: isHovered ? Colors.deepPurple : Colors.purple, // Change color on hover
                    shape: BoxShape.rectangle,
                    borderRadius: BorderRadius.circular(20),
                    boxShadow: [
                      BoxShadow(
                        color: Colors.black.withOpacity(0.2),
                        spreadRadius: 2,
                        blurRadius: 4,
                        offset: const Offset(0, 2),
                      ),
                    ],
                  ),
                  padding: const EdgeInsets.all(20),
                  child: MouseRegion(
                    onEnter: (_) {
                      // Handle hover enter
                      isHovered = true;
                    },
                    onExit: (_) {
                      // Handle hover exit
                      isHovered = false;
                    },
                    child: const Text(
                      'Chat with Pet Expert',
                      textAlign: TextAlign.center,
                      style: TextStyle(color: Colors.white),
                    ),
                  ),
                ),
              ),
            ),
          ),
        ],
      ),
    );
  }
}

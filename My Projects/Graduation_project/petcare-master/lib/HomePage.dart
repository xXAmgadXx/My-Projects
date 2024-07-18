import 'package:cloud_firestore/cloud_firestore.dart';
import 'package:firebase_auth/firebase_auth.dart';
import 'package:flutter/material.dart';
import 'Commucity.dart';
import 'Products.dart';
import 'LoginPage';
import 'UserProfilePage';
import 'clinics.dart';
import 'personalInfo.dart';
import 'ChatBotPage.dart';
import 'PetMatch.dart';



class HomePage extends StatefulWidget {
  const HomePage({Key? key}) : super(key: key);

  @override
  _HomePageState createState() => _HomePageState();
}

class _HomePageState extends State<HomePage> {
  final GlobalKey<ScaffoldState> scaffoldKey = GlobalKey<ScaffoldState>();
  bool isHovered = false;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      key: scaffoldKey,
      appBar: AppBar(
        backgroundColor: Colors.blue,
        title: const Text('Pet Care App'),
        // Remove the extra icon on the right side
        actions: const [],
      ),
      body: Container(
        decoration: const BoxDecoration(
          image: DecorationImage(
            image: AssetImage('assets/HomePage_2.png'),
            fit: BoxFit.fill,
          ),
        ),
        child: Stack(
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
                      setState(() {
                        isHovered = hovered;
                      });
                    },
                    child: ElevatedButton(
                      onPressed: () {
                        Navigator.push(
                          context,
                          MaterialPageRoute(
                            builder: (context) => const ProductScreen(),
                          ),
                        );
                        // Handle press for Explore Pet Supplies
                      },
                      style: ElevatedButton.styleFrom(
                        backgroundColor: Colors.blue,
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
                          builder: (context) => const ProductScreen(),
                        ),
                      );
                    },
                    onHover: (hovered) {
                      setState(() {
                        isHovered = hovered;
                      });
                    },
                    child: ElevatedButton(
                      onPressed: () {
                        Navigator.push(
                          context,
                          MaterialPageRoute(
                            builder: (context) => VeterinaryClinicsPage(),
                          ),
                        );
                      },
                      style: ElevatedButton.styleFrom(
                        backgroundColor: Colors.orange,
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
                  const SizedBox(height: 30),
                  InkWell(
                    onTap: () {
                      Navigator.push(
                        context,
                        MaterialPageRoute(
                          builder: (context) =>  PetMatchPage(),
                        ),
                      );
                    },
                    onHover: (hovered) {
                      setState(() {
                        isHovered = hovered;
                      });
                    },
                    child: ElevatedButton(
                      onPressed: () {
                        Navigator.push(
                          context,
                          MaterialPageRoute(
                            builder: (context) =>  PetMatchPage(),
                          ),
                        );
                      },
                      style: ElevatedButton.styleFrom(
                        backgroundColor: Colors.green,
                        shape: RoundedRectangleBorder(
                          borderRadius: BorderRadius.circular(30),
                        ),
                        padding: const EdgeInsets.all(60),
                      ),
                      child: const Text(
                        'Pet Match',
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
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                        builder: (context) => const ChatBotPage(
                          title: '',
                        ),
                      ),
                    );
                  },
                  child: Container(
                    height: 110,
                    width: 110,
                    decoration: BoxDecoration(
                      color: isHovered ? Colors.deepPurple : Colors.purple,
                      shape: BoxShape.circle,
                      //borderRadius: BorderRadius.circular(20),
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
                        setState(() {
                          isHovered = true;
                        });
                      },
                      onExit: (_) {
                        setState(() {
                          isHovered = false;
                        });
                      },
                      child: const Center(
                         child : Text(
                        'Chat with Pet Expert',
                        textAlign: TextAlign.center,
                        style: TextStyle(color: Colors.white),
                         ),
                      ),
                    ),
                  ),
                ),
              ),
            ),
            Positioned(
              bottom: 20,
              left: 20,
              child: GestureDetector(
                onTap: () {
                  Navigator.push(
                    context,
                    MaterialPageRoute(
                      builder: (context) => CommunityPage(),
                    ),
                  );

                  // Navigate to the Community page
                  // Add your navigation logic here
                },
                child: Container(
                  width: 100,
                  height: 100,
                  decoration: BoxDecoration(
                    color: Colors.white, // Change color as needed
                    shape: BoxShape.circle,
                  ),
                  child: Center(
                    child: Text(
                      'Community',
                      style: TextStyle(
                        color: Colors.blue,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ),
                ),
              ),
            ),
          ],
        ),
      ),
      drawer: Drawer(
        child: ListView(
          padding: EdgeInsets.zero,
          children: [
            const DrawerHeader(
              decoration: BoxDecoration(
                color: Colors.blue,
              ),
              child: Text(
                'Main Menu',
                style: TextStyle(
                  color: Colors.white,
                  fontSize: 24,
                ),
              ),
            ),
            _buildDrawerButton('Profile', () {
              Navigator.pop(context);
              Navigator.push(
                  context,
                  MaterialPageRoute(
                      builder: (context) => const PersonalInfo()));
            },
                iconData: Icons
                    .person), // Assuming Icons.person is the icon you want to use

            /*_buildDrawerButton('Donation', () {
              Navigator.pop(context);
            }),
            _buildDrawerButton('Add Pet', () {
              Navigator.pop(context);
            }),
            _buildDrawerButton('Favorite', () {
              Navigator.pop(context);
            }),
            _buildDrawerButton('Messages', () {
              Navigator.pop(context);
            }),
            _buildDrawerButton('Profile', () {
              Navigator.pop(context);
            }),*/
            _buildDrawerButton('Log Out', () async {
              await FirebaseAuth.instance.signOut();
              Navigator.pop(context);
              Navigator.pushReplacement(
                context,
                MaterialPageRoute(
                    builder: (BuildContext context) =>
                        LoginPage()), // Pass the context here
              );
            }, iconData: Icons.exit_to_app),
          ],
        ),
      ),
    );
  }

  Widget _buildDrawerButton(String text, VoidCallback onTap,
      {IconData? iconData}) {
    return InkWell(
      onTap: () async {
        if (text == 'Profile') {
          // Check if the user is signed in
          User? user = FirebaseAuth.instance.currentUser;
          if (user != null) {
            // Check if the user has profile information
            // You need to replace 'yourFirestoreCollection' with the actual collection in your database
            DocumentSnapshot profileSnapshot = await FirebaseFirestore.instance
                .collection('users')
                .doc(user.uid)
                .get();

            if (profileSnapshot.exists) {
              // User has profile information, show the profile page
              // User has profile information, display it in the HomePage
              setState(() {
                _displayProfileInformation(profileSnapshot);
              });
            } else {
              // User doesn't have profile information, redirect to fill out the profile
              Navigator.pop(context); // Close the drawer
              // You can replace 'FillProfilePage' with the actual page to fill out the profile
              Navigator.push(
                context,
                MaterialPageRoute(
                  builder: (context) => const PersonalInfo(),
                ),
              );
            }
          } else {
            // User is not signed in, redirect to login page
            Navigator.pop(context); // Close the drawer
            Navigator.push(
              context,
              MaterialPageRoute(
                builder: (context) => LoginPage(),
              ),
            );
          }
        } else {
          // For other buttons, execute the provided onTap function
          onTap();
        }
      },
      child: ListTile(
        title: Text(text),
        leading: iconData != null ? Icon(iconData) : null,
      ),
    );
  }

  void _openDrawer() {
    scaffoldKey.currentState?.openDrawer();
  }

  void _displayProfileInformation(DocumentSnapshot profileSnapshot) async {
    // Explicitly cast the profileSnapshot to the correct type
    DocumentSnapshot<Map<String, dynamic>> typedProfileSnapshot =
        profileSnapshot as DocumentSnapshot<Map<String, dynamic>>;

    Navigator.push(
      context,
      MaterialPageRoute(
        builder: (context) =>
            UserProfilePage(profileSnapshot: typedProfileSnapshot),
      ),
    );
  }
}

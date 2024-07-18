import 'package:flutter/material.dart';
import 'package:cloud_firestore/cloud_firestore.dart';
import 'package:firebase_auth/firebase_auth.dart';

class CreatePostScreen extends StatefulWidget {
  @override
  _CreatePostScreenState createState() => _CreatePostScreenState();
}

class _CreatePostScreenState extends State<CreatePostScreen> {
  final TextEditingController _postController = TextEditingController();

  void _submitPost() async {
    try {
      // Get the current user
      User? user = FirebaseAuth.instance.currentUser;

      // Check if user is authenticated
      if (user != null) {
        // Get user ID
        String userId = user.uid;

        // Get the username
        String username = await getUsername();

        // Get current timestamp
        Timestamp timestamp = Timestamp.now();

        // Create a new document in the "posts" collection with user ID as document ID
        await FirebaseFirestore.instance.collection('posts').add({
          'userId': userId,
          'username': username,
          'timestamp': timestamp,
          'content': _postController.text,
        });

        // Navigate back to previous screen
        Navigator.pop(context);
      } else {
        // Handle the case where the user is not authenticated
        throw Exception('User not authenticated');
      }
    } catch (e) {
      // Handle any errors that occur during post creation
      print('Error creating post: $e');
      // Optionally, show an error message to the user
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text('Failed to create post: $e')),
      );
    }
  }

  Future<String> getUsername() async {
    User? user = FirebaseAuth.instance.currentUser;

    if (user == null) {
      throw Exception('No user is currently signed in');
    }

    DocumentSnapshot userDoc = await FirebaseFirestore.instance.collection('users').doc(user.uid).get();

    if (!userDoc.exists) {
      throw Exception('User document does not exist');
    }

    String username = userDoc.get('username');

    return username;
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Create Post'),
      ),
      body: Padding(
        padding: EdgeInsets.all(16.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.stretch,
          children: [
            TextField(
              controller: _postController,
              decoration: InputDecoration(
                hintText: 'Write your post here...',
              ),
              maxLines: null,
            ),
            SizedBox(height: 16.0),
            ElevatedButton(
              onPressed: _submitPost,
              child: Text('Submit'),
            ),
          ],
        ),
      ),
    );
  }
}

import 'dart:convert';
import 'dart:typed_data';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';
import 'package:faker/faker.dart';
import 'api_service.dart';

class PetMatchPage extends StatefulWidget {
  @override
  _PetMatchPageState createState() => _PetMatchPageState();
}

class _PetMatchPageState extends State<PetMatchPage> {
  Uint8List? _imageBytes;
  List<Map<String, dynamic>> _matches = [];
  final ApiService _apiService = ApiService();
  final faker = Faker();

  Future<void> _pickImage() async {
    final picker = ImagePicker();
    final pickedFile = await picker.getImage(source: ImageSource.gallery);
    if (pickedFile != null) {
      final imageBytes = await pickedFile.readAsBytes();
      setState(() {
        _imageBytes = imageBytes;
      });
      _getMatches(imageBytes);
    }
  }

  Future<void> _getMatches(Uint8List imageBytes) async {
    try {
      List<String> matchesBase64 = await _apiService.getTopMatches(imageBytes);
      setState(() {
        _matches = List<Map<String, dynamic>>.generate(matchesBase64.length, (index) {
          return {
            'image': base64Decode(matchesBase64[index]),
            'name': faker.person.name(),
            'contact': faker.phoneNumber.us()
          };
        });
      });
    } catch (e) {
      print(e);
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text('Pet Match'),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            _imageBytes == null
                ? Text('No image selected.')
                : Image.memory(_imageBytes!),
            ElevatedButton(
              onPressed: _pickImage,
              child: Text('Pick Image'),
            ),
            _matches.isNotEmpty ? Text('Top Matches:') : Container(),
            _matches.isNotEmpty
                ? Expanded(
                    child: ListView.builder(
                      itemCount: _matches.length,
                      itemBuilder: (context, index) {
                        final match = _matches[index];
                        return Column(
                          children: [
                            Image.memory(match['image']),
                            Text('Name: ${match['name']}'),
                            Text('Contact: ${match['contact']}'),
                          ],
                        );
                      },
                    ),
                  )
                : Container(),
          ],
        ),
      ),
    );
  }
}






















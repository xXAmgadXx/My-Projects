import 'dart:convert';
import 'dart:typed_data';
import 'package:http/http.dart' as http;
import 'package:http_parser/http_parser.dart';

class ApiService {
  static const String baseUrl = 'https://ad3c-41-42-13-111.ngrok-free.app';

  Future<List<String>> getTopMatches(Uint8List imageBytes) async {
    var request = http.MultipartRequest('POST', Uri.parse('$baseUrl/match'));

    var multipartFile = http.MultipartFile.fromBytes(
      'file',
      imageBytes,
      filename: 'uploaded_image.jpg',
      contentType: MediaType('image', 'jpeg'),
    );

    request.files.add(multipartFile);

    var response = await request.send();

    if (response.statusCode == 200) {
      var responseData = await response.stream.bytesToString();
      var json = jsonDecode(responseData);
      List<String> matches = List<String>.from(json['matches']);
      return matches;
    } else {
      throw Exception('Failed to load top matches');
    }
  }
}







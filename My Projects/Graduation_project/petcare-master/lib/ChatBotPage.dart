import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;

class ChatBotPage extends StatefulWidget {
  const ChatBotPage({Key? key, required String title}) : super(key: key);

  @override
  _ChatBotPageState createState() => _ChatBotPageState();
}

class _ChatBotPageState extends State<ChatBotPage> {
  final TextEditingController _textController = TextEditingController();
  final List<String> _messages = [];

  Future<List<dynamic>> _sendMessage(String message) async {
  try {
    final response = await http.post(
      Uri.parse('https://b2c2-105-196-20-95.ngrok-free.app/webhooks/rest/webhook'),
      headers: <String, String>{
        'Content-Type': 'application/json',
      },
      body: jsonEncode(<String, String>{
        'message': message,
      }),
    );

    if (response.statusCode == 200) {
      final jsonResponse = jsonDecode(response.body);
      return jsonResponse ;

    } else {
      throw Exception('Failed to send message. Status code: ${response.statusCode}');
    }
  } catch (e) {
    throw Exception('Failed to send message: $e');
  }
}

  Future<http.Response> getBotResponse( String message) {
  return http.post(
    Uri.parse('http://localhost:5005/webhooks/rest/webhook'),
    headers: <String, String>{
      'Content-Type': 'application/json; charset=UTF-8',
    },
    body: jsonEncode(<String, String>{
      
      'message': message,
    }),
  );

  

}

  void _handleSubmitted(String text) async {
    _textController.clear();
    setState(() {
      _messages.add('You: $text');
    });

    try {
      final botResponse = await _sendMessage(text);
      //final botResponse = await getBotResponse(text);
      setState(() {
        _messages.add('Bot: ${botResponse[0]['text']}');
      });
    } catch (e) {
      print('Error: $e');
      setState(() {
        _messages.add('Bot: Error occurred');
      });
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('ChatBot'),
      ),
      body: Column(
        children: <Widget>[
          Expanded(
            child: ListView.builder(
              itemCount: _messages.length,
              itemBuilder: (context, index) {
                return ListTile(
                  title: Text(_messages[index]),
                );
              },
            ),
          ),
          const Divider(height: 1.0),
          Container(
            decoration: BoxDecoration(
              color: Theme.of(context).cardColor,
            ),
            child: _buildTextComposer(),
          ),
        ],
      ),
    );
  }

  Widget _buildTextComposer() {
    return IconTheme(
      data: const IconThemeData(color: Colors.blue),
      child: Container(
        margin: const EdgeInsets.symmetric(horizontal: 8.0),
        child: Row(
          children: <Widget>[
            Flexible(
              child: TextField(
                controller: _textController,
                onSubmitted: _handleSubmitted,
                decoration: const InputDecoration.collapsed(
                  hintText: "Send a message",
                ),
              ),
            ),
            Container(
              margin: const EdgeInsets.symmetric(horizontal: 4.0),
              child: IconButton(
                icon: const Icon(Icons.send),
                onPressed: () => _handleSubmitted(_textController.text),
              ),
            ),
          ],
        ),
      ),
    );
  }
}



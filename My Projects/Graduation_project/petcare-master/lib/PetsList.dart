import 'package:flutter/material.dart';
import 'PetSupplies.dart';

class PetList extends StatefulWidget {
  const PetList({Key? key, required this.title}) : super(key: key);

  final String title;

  @override
  _PetListState createState() => _PetListState();
}

class _PetListState extends State<PetList> {
  int _selectedIndex = 1;
  static const TextStyle optionStyle = TextStyle(fontSize: 30, fontWeight: FontWeight.bold);
  static const List<Widget> _widgetOptions = <Widget>[
    Text(
      'Dog',
      style: optionStyle,
    ),
    Text(
      'Cat',
      style: optionStyle,
    ),
    Text(
      'Fish',
      style: optionStyle,
    ),
    Text(
      'Bird',
      style: optionStyle,
    ),
  ];

  void _onItemTapped(int index) {
    setState(() {
      _selectedIndex = index;
    });

    // Navigate to DogPage when the "Dog" option is selected
    if (_selectedIndex == 0) {
      _navigateToDogSupplies(context);
    }
  }

  void _navigateToDogSupplies(BuildContext context) {
    Navigator.push(
      context,
      MaterialPageRoute(builder: (context) => const PetSupplies()),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(title: Text(widget.title)),
      body: Center(
        child: _widgetOptions[_selectedIndex],
      ),
      drawer: Drawer(
        child: ListView(
          padding: EdgeInsets.zero,
          children: [
            const DrawerHeader(
              decoration: BoxDecoration(
                color: Colors.blue,
              ),
              child: Text('Pets List'),
            ),
            ListTile(
              title: const Text('Dog'),
              selected: _selectedIndex == 0,
              onTap: () {
                // Update the state of the app
                _onItemTapped(0);
                // Then close the drawer
                Navigator.pop(context);
              },
            ),
            ListTile(
              title: const Text('Cat'),
              selected: _selectedIndex == 1,
              onTap: () {
                _onItemTapped(1);
                Navigator.pop(context);
              },
            ),
            ListTile(
              title: const Text('Fish'),
              selected: _selectedIndex == 2,
              onTap: () {
                _onItemTapped(2);
                Navigator.pop(context);
              },
            ),
            ListTile(
              title: const Text('Bird'),
              selected: _selectedIndex == 3,
              onTap: () {
                _onItemTapped(3);
                Navigator.pop(context);
              },
            ),
          ],
        ),
      ),
    );
  }
}

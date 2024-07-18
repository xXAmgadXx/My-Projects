import 'package:flutter/material.dart';

class PetServices extends StatefulWidget {
  const PetServices({super.key, required this.title});

  final String title;

  @override
  State<PetServices> createState() => _PetServicesState();
}

class _PetServicesState extends State<PetServices> {
  int _selectedIndex = 0;
  static const TextStyle optionStyle =
  TextStyle(fontSize: 30, fontWeight: FontWeight.bold);
  static const List<Widget> _widgetOptions = <Widget>[
    Text(
      ' Pet Adopation',
      style: optionStyle,
    ),
    Text(
      ' PET SEARCH',
      style: optionStyle,
    ),
    Text(
      ' PET GIVEAWAY',
      style: optionStyle,
    ),
    Text(
      ' PET  MATCHING',
      style: optionStyle,
    ),
    Text(
      ' VET LOCATION',
      style: optionStyle,
    ),
    Text(
      ' PET RESCUE',
      style: optionStyle,
    ),
    Text(
      ' REPORT ANIMAL CONTROL',
      style: optionStyle,
    ),
    Text(
      ' REPORT ANIMAL RIGHTS VIOLATION',
      style: optionStyle,
    ),
    Text(
      ' MISSING PET',
      style: optionStyle,
    ),
    Text(
      ' PET SHOP LOCATION',
      style: optionStyle,
    ),
  ];

  void _onItemTapped(int index) {
    setState(() {
      _selectedIndex = index;
    });
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
              child: Text('PET SERVICES'),
            ),
            ListTile(
              title: const Text('PET ADOPATION'),
              selected: _selectedIndex == 0,
              onTap: () {
                // Update the state of the app
                _onItemTapped(0);
                // Then close the drawer
                Navigator.pop(context);
              },
            ),
            ListTile(
              title: const Text('PET SEARCH'),
              selected: _selectedIndex == 1,
              onTap: () {

                _onItemTapped(1);

                Navigator.pop(context);
              },
            ),
            ListTile(
              title: const Text('PET GIVEAWAY'),
              selected: _selectedIndex == 2,
              onTap: () {

                _onItemTapped(2);

                Navigator.pop(context);
              },
            ),
            ListTile(
              title: const Text('PET  MATCHING'),
              selected: _selectedIndex == 3,
              onTap: () {

                _onItemTapped(3);

                Navigator.pop(context);
              },
            ),
            ListTile(
              title: const Text(' VET LOCATION'),
              selected: _selectedIndex == 4,
              onTap: () {

                _onItemTapped(4);

                Navigator.pop(context);
              },
            ),
            ListTile(
              title: const Text('PET RESCUE'),
              selected: _selectedIndex == 5,
              onTap: () {

                _onItemTapped(5);

                Navigator.pop(context);
              },
            ),
            ListTile(
              title: const Text('REPORT ANIMAL CONTROL'),
              selected: _selectedIndex == 6,
              onTap: () {

                _onItemTapped(6);

                Navigator.pop(context);
              },
            ),
            ListTile(
              title: const Text('REPORT ANIMAL RIGHTS VIOLATION'),
              selected: _selectedIndex == 7,
              onTap: () {

                _onItemTapped(7);

                Navigator.pop(context);
              },
            ),
            ListTile(
              title: const Text(' MISSING PET'),
              selected: _selectedIndex == 8,
              onTap: () {

                _onItemTapped(8);

                Navigator.pop(context);
              },
            ),
            ListTile(
              title: const Text('PET SHOP LOCATION'),
              selected: _selectedIndex == 9,
              onTap: () {

                _onItemTapped(9);

                Navigator.pop(context);
              },
            ),
          ],
        ),
      ),
    );
  }
}
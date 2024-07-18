import 'package:flutter/material.dart';
import 'package:url_launcher/url_launcher.dart';

class VeterinaryClinicsPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Veterinary Clinics'),
      ),
      body: ListView.builder(
        itemCount: clinics.length,
        itemBuilder: (context, index) {
          return ClinicCard(clinic: clinics[index]);
        },
      ),
    );
  }
}

class Clinic {
  final String name;
  final String address;
  final String phoneNumber;
  final String websiteUrl;

  Clinic({
    required this.name,
    required this.address,
    required this.phoneNumber,
    required this.websiteUrl,
  });
}

final List<Clinic> clinics = [
  Clinic(
    name: 'Rafiki Pets Veterinary Clinic',
    address: '123 Main St',
    phoneNumber: '555-1234',
    websiteUrl:
        'https://rafikivet.com/?gad_source=1&gclid=CjwKCAjwrIixBhBbEiwACEqDJQQCXi_XpSm4tDcMbO2H3HmygY2zZEai4vtIn1MPqzTMTpKOVF8GFxoC72AQAvD_BwE',
  ),
  Clinic(
    name: 'scoobypetclinic',
    address:
        'شارع ١١ خلف سبينيس متفرع من ميدان النافورة بشارع, 9، المقطم، محافظة ',
    phoneNumber: '01094904381',
    websiteUrl:
        'https://scoobypetclinic.com/services/?gad_source=1&gclid=Cj0KCQjwltKxBhDMARIsAG8KnqWRh0c_U-FEfzBn7hZ6GHyuWUu2aVvCV_qDYChe3-7t59OdFFcUgvwaAu8QEALw_wcB',
  ),
  Clinic(
    name: 'VET HELP CLINIC',
    address: '45 Ahmed Oraby, Madinet Al Eelam, Agouza, Giza Governorate 12511',
    phoneNumber: '01126291657',
    websiteUrl:
        'https://vethelpclinic.carrd.co/?gad_source=1&gclid=Cj0KCQjwltKxBhDMARIsAG8KnqVE5TX_wU3qUXB2NuOjql9qYv-Xy1hOv_Y-642PhBiRCT0L6VSX94oaAqs2EALw_wcB',
  ),
  Clinic(
    name: 'zabeelvet',
    address:
        'Sheikh Zayed Rd - near MBG Centre : Molecular Biology - Zaabeel - Zaabeel 2 - Dubai - United Arab Emirates',
    phoneNumber: '+971 4 334 0011',
    websiteUrl: 'https://zabeelvet.com/ar/telemedicine/',
  ),
  Clinic(
    name: 'egyvet',
    address:
        '9 Zakareya Othman Street, next to Al Wafa Wal Amal and Al Serag Mall - Eighth District - Nasr City - Cairo.',
    phoneNumber: '01201207222',
    websiteUrl: 'https://www.egyvets.com/',
  ),
  Clinic(
    name: 'the 3vets',
    address:
        'Address: 17 Sheikh Ali Abdel Razek Street - Hegaz Square, parallel to Ammar Ibn Yasser - Heliopolis',
    phoneNumber: '+201068878877',
    websiteUrl:
        'https://thethreevets.com/%D8%AA%D9%88%D8%A7%D8%B5%D9%84-%D9%85%D8%B9%D9%86%D8%A7/',
  ),
  Clinic(
    name: 'alhamra vet',
    address:
        'Address: 17 Sheikh Ali Abdel Razek Street - Hegaz Square, parallel to Ammar Ibn Yasser - Heliopolis',
    phoneNumber: '00966545477883',
    websiteUrl: 'https://www.alhamravet.com/English/',
  ),
  Clinic(
    name:'British',
    address:'45 El Ansar St., off Mohi El Din Abou El Ezz St., Dokki, Giza',
    phoneNumber:'+201026441196',
    websiteUrl: 'https://britishanimalhospital.com/ar',
  ),
  Clinic(
    name:'New York Veterinary Clinics',
    address:'25 Ahmed Kamel St., off Lasilki - Maadi',
    phoneNumber:' 01101160688',
    websiteUrl: 'https://www.nyvetclinic.com/',
  ),
  Clinic(
    name:'Pet heaven veterinary Clinic',
    address:'49 Abdul Aziz Al saud,manial Al Rawda',
    phoneNumber:' 01062989899',
    websiteUrl: 'https://www.facebook.com/PHVC4',
  ),
  Clinic(
    name: 'Armed Forces Veterinary Hospital',
    address: 'Al-Nasr Road in front of Al-Ahly Club, Nasr City',
    phoneNumber: '24152661',
    websiteUrl: 'http://www.afvethosp.org.eg/ContactUs.aspx#Content',


  ),
];

class ClinicCard extends StatelessWidget {
  final Clinic clinic;

  ClinicCard({required this.clinic});

  @override
  Widget build(BuildContext context) {
    return Card(
      child: ListTile(
        title: Text(
          clinic.name,
          style: const TextStyle(
            color: Colors.blue,
          ),
        ),
        subtitle: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(clinic.address),
            Text(
              clinic.phoneNumber,
              style: TextStyle(color: Colors.purple),
            ), // Adding phone number here
          ],
        ),
        trailing: IconButton(
          icon: const Icon(Icons.open_in_browser),
          onPressed: () {
            _launchURL(clinic.websiteUrl);
          },
        ),
      ),
    );
  }

  void _launchURL(String url) async {
    if (await canLaunch(url)) {
      await launch(url);
    } else {
      throw 'Could not launch $url';
    }
  }
}

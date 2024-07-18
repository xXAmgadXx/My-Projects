import 'package:flutter/material.dart';
import 'package:cloud_firestore/cloud_firestore.dart';
import 'package:url_launcher/url_launcher.dart'; // Import url_launcher package
import 'package:flutter/foundation.dart' show kIsWeb;
import 'package:webview_flutter/webview_flutter.dart';

class ProductScreen extends StatelessWidget {
  const ProductScreen({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Products'),
      ),
      body: Center(
        child: ElevatedButton(
          onPressed: () {
            // Call the function to retrieve and display products
            getProducts(context);
          },
          child: const Text('Load Products'),
        ),
      ),
    );
  }

  // Function to retrieve and display products
  void getProducts(BuildContext context) {
    FirebaseFirestore.instance
        .collection('products')
        .get()
        .then((querySnapshot) {
      List<Product> products = [];
      for (var doc in querySnapshot.docs) {
        // Access the individual document using 'doc' variable
        String name = doc.data()['Name'] ?? ""; // Add null check and provide a default value
        String category = doc.data()['Category'] ?? ""; // Add null check and provide a default value
        String priceString = doc.data()['Price'] ?? ""; // Add null check and provide a default value
        double price = double.tryParse(priceString) ?? 0.0; // Convert price string to double, provide default value if conversion fails
        String description = doc.data()['Description'] ?? ""; // Add null check and provide a default value
        String productLink = doc.data()['Link'] ?? ""; // Retrieve product link
        String imageUrl = doc.data()['imageUrl'] ?? "";
        // Create Product object and add it to the list
        products.add(Product(name, category, price, description, productLink, imageUrl));
      }

      // Navigate to a new screen to display products
      Navigator.push(
        context,
        MaterialPageRoute(builder: (context) => ProductListScreen(products)),
      );
    }).catchError((error) {
      print('Error retrieving products: $error'); // Handle error if any
    });
  }
}

class Product {
  final String name;
  final String category;
  final double price; // Change the type to double
  final String description;
  final String productLink; // Add product link field
  final String imageUrl;

  Product(this.name, this.category, this.price, this.description, this.productLink, this.imageUrl);
}

class ProductListScreen extends StatelessWidget {
  final List<Product> products;

  const ProductListScreen(this.products, {Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Product List'),
      ),
      body: ListView.builder(
        itemCount: products.length,
        itemBuilder: (context, index) {
          return GestureDetector(
            onTap: () {
              if (kIsWeb) {
                launch(products[index].productLink);
              } else {
                Navigator.push(
                  context,
                  MaterialPageRoute(
                      builder: (context) => ProductDetailsScreen(products[index])),
                );
              }
            },
            child: ListTile(
              leading: Image.network(products[index].imageUrl, width: 50, height: 50, fit: BoxFit.cover),
              title: Text(products[index].name),
              subtitle: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    products[index].category,
                    style: TextStyle(color: Colors.blue), // Set category text color to blue
                  ),
                  Text(
                    products[index].description,
                    style: TextStyle(color: Colors.brown),
                  ),
                  Text(
                    'Price: ${products[index].price} EGP',
                    style: const TextStyle(
                        fontWeight: FontWeight.bold,
                        color: Color.fromARGB(255, 226, 55, 112)),
                  ),
                ],
              ),
              trailing: const Text('Go'),
            ),
          );
        },
      ),
    );
  }
}

class ProductDetailsScreen extends StatelessWidget {
  final Product product;

  const ProductDetailsScreen(this.product, {Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Product Details'),
      ),
      body: SingleChildScrollView(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Image.network(product.imageUrl, fit: BoxFit.cover),
            Padding(
              padding: const EdgeInsets.all(8.0),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(product.name, style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold)),
                  Text('Category: ${product.category}', style: TextStyle(fontSize: 18, color: Colors.blue)),
                  Text('Price: ${product.price} EGP', style: TextStyle(fontSize: 18, color: Colors.redAccent)),
                  SizedBox(height: 10),
                  Text(product.description, style: TextStyle(fontSize: 16)),
                  SizedBox(height: 10),
                  ElevatedButton(
                    onPressed: () async {
                      if (await canLaunch(product.productLink)) {
                        await launch(product.productLink);
                      } else {
                        print('Could not launch ${product.productLink}');
                        throw 'Could not launch ${product.productLink}';
                      }
                    },
                    child: Text('Buy Now'),
                  ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}

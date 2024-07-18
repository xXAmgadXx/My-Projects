import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';


class Product {
  final String name;
  final double price;
  final String imageUrl;

  Product({required this.name, required this.price, required this.imageUrl});
}

class PetSupplies extends StatefulWidget {
  const PetSupplies({super.key});

  @override
  _PetSuppliesState createState() => _PetSuppliesState();
}

class _PetSuppliesState extends State<PetSupplies> {
  late List<Product> products;

  @override
  void initState() {
    super.initState();
    // Initialize products with an empty list
    products = [];
  }

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        appBar: AppBar(
          title: const Text('Pet Supplies'),
        ),
        body: Padding(
          padding: const EdgeInsets.all(16.0),
          child: ProductGrid(products: products),
        ),
        floatingActionButton: FloatingActionButton(
          onPressed: () {
            showSearch(context: context, delegate: ProductSearchDelegate());
          },
          child: const Icon(Icons.search),
        ),
      ),
    );
  }
}

class ProductGrid extends StatelessWidget {
  final List<Product> products;

  const ProductGrid({super.key, required this.products});

  @override
  Widget build(BuildContext context) {
    return products.isEmpty
        ? const Center(child: Text('No products to display'))
        : GridView.builder(
            gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
              crossAxisCount: 2,
              crossAxisSpacing: 10,
              mainAxisSpacing: 10,
            ),
            itemCount: products.length,
            itemBuilder: (context, index) {
              final Product product = products[index];
              return ProductItem(product: product);
            },
          );
  }
}

class ProductItem extends StatelessWidget {
  final Product product;

  const ProductItem({super.key, required this.product});

  @override
  Widget build(BuildContext context) {
    return GestureDetector(
      onTap: () {
        Navigator.push(
          context,
          MaterialPageRoute(builder: (context) => ProductDetailsScreen(product: product)),
        );
      },
      child: Card(
        elevation: 4,
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Image.network(
              product.imageUrl,
              fit: BoxFit.cover,
              height: 150,
              width: double.infinity,
            ),
            Padding(
              padding: const EdgeInsets.all(8.0),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    product.name,
                    style: const TextStyle(fontSize: 16, fontWeight: FontWeight.bold),
                  ),
                  const SizedBox(height: 4),
                  Text(
                    '\$${product.price.toString()}',
                    style: const TextStyle(fontSize: 14, color: Colors.grey),
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

class ProductSearchDelegate extends SearchDelegate<void> {
  @override
  String get searchFieldLabel => 'Search for a product';

  @override
  ThemeData appBarTheme(BuildContext context) {
    final ThemeData theme = Theme.of(context);
    return theme.copyWith(
      inputDecorationTheme: InputDecorationTheme(
        hintStyle: const TextStyle(color: Colors.white),
        border: OutlineInputBorder(
          borderRadius: BorderRadius.circular(30), // Circular border radius
          borderSide: BorderSide.none, // No border side
        ),
        filled: true,
        fillColor: Colors.blue.withOpacity(0.7), // Blue with opacity
        contentPadding: const EdgeInsets.symmetric(horizontal: 20), // Padding for text
      ),
    );
  }

  @override
  List<Widget> buildActions(BuildContext context) {
    return [
      IconButton(
        icon: const Icon(Icons.clear),
        onPressed: () {
          query = '';
        },
      ),
    ];
  }

  @override
  Widget buildLeading(BuildContext context) {
    return IconButton(
      icon: const Icon(Icons.arrow_back),
      onPressed: () {
        close(context, null);
      },
    );
  }

  @override
  Widget buildResults(BuildContext context) {
    return _buildSearchResults(context);
  }

  @override
  Widget buildSuggestions(BuildContext context) {
    return _buildSearchResults(context);
  }

  Widget _buildSearchResults(BuildContext context) {
    if (query.isEmpty) {
      return const Center(child: Text('Please enter a search query'));
    }
    return FutureBuilder<List<Product>>(
      future: fetchData(query),
      builder: (context, snapshot) {
        if (snapshot.connectionState == ConnectionState.waiting) {
          return const Center(child: CircularProgressIndicator());
        } else if (snapshot.hasError) {
          return Center(child: Text('Error: ${snapshot.error}'));
        } else {
          final List<Product> products = snapshot.data ?? [];
          if (products.isEmpty) {
            return const Center(child: Text('No results found'));
          }
          return ListView.builder(
            itemCount: products.length,
            itemBuilder: (context, index) {
              final Product product = products[index];
              return ListTile(
                title: Text(product.name),
                subtitle: Text('\$${product.price.toString()}'),
                leading: Image.network(product.imageUrl),
                onTap: () {
                  // Handle tapping on the product
                  Navigator.push(
                    context,
                    MaterialPageRoute(builder: (context) => ProductDetailsScreen(product: product)),
                  );
                },
              );
            },
          );
        }
      },
    );
  }

  Future<List<Product>> fetchData(String query) async {
  // Modify the API URL to use the Open Food Facts API
  final String apiUrl =
      'https://world.openfoodfacts.org/api/v2/search?search_terms=$query&fields=product_name,brands,quantity,image_url';

  try {
    final response = await http.get(Uri.parse(apiUrl));
    if (response.statusCode == 200) {
      final Map<String, dynamic> jsonData = jsonDecode(response.body);
      if (jsonData['products'] != null) {
        final List<Product> products = (jsonData['products'] as List).map((data) {
          return Product(
            name: data['product_name'] ?? 'Unknown Product',
            price: data['quantity'] != null ? double.tryParse(data['quantity']) ?? 0.0 : 0.0,
            imageUrl: data['image_url'] ?? 'https://via.placeholder.com/150', // Placeholder image if no image URL is provided
          );
        }).toList();
        return products;
      } else {
        throw 'No products found';
      }
    } else {
      throw 'Request failed with status code ${response.statusCode}';
    }
  } catch (e) {
    throw 'Exception occurred: $e';
  }
}

}

class ProductDetailsScreen extends StatelessWidget {
  final Product product;

  const ProductDetailsScreen({super.key, required this.product});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: Text(product.name),
      ),
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text('Product Name: ${product.name}'),
            Text('Price: \$${product.price.toString()}'),
            Image.network(product.imageUrl),
            // Add more details about the product here as needed
          ],
        ),
      ),
    );
  }
}



Product product1 = new Product("iPhone 17", 1400m, 15);
Product product2 = new Product("MacBook Air", 1000m, 0);
Product product3 = new Product("iPad Air", 1250m, 25);
List<Product> products = new List<Product>();
products.Add(product1);
products.Add(product2);
products.Add(product3);
foreach(Product product in products){
	Console.WriteLine($"Product description: {product.Name} -- {product.Price} -- {product.Stock} \n");
}

foreach(Product product in products){
        Console.WriteLine($"Product description: {product.Name} -- {product.Price} -- {product.Stock} \n");
}

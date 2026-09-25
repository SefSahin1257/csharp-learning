int id = 1;
String name = "MacBook Pro M1Pro";
decimal stockQuantity = 3.0m;
bool isAvailable = true;
Console.WriteLine($"Product id:{id}");
Console.WriteLine($"Product name: {name}");
int secondId = 2;
String secondName = "iPhone 17";
decimal secondStock = 2.0m;
bool secondIsAvailable = false;
Console.WriteLine($"Second product name: {secondName}");
Console.WriteLine($"Second product stock: {secondStock}");


Product product1 = new Product();
product1.Name = "Macbook Pro";
product1.Price = 1350.0m;
product1.Stock = 23;
product1.isAvailable = true;
Console.WriteLine($"Product name : {product1.Name}");
Console.WriteLine($"Product price : {product1.Price}");
Console.WriteLine($"Product stock : {product1.Stock}");
Console.WriteLine($"Available : {product1.isAvailable}"); 

Product product2 = new Product();
product2.Name = "iPhone 17";
product2.Price = 1400.0m;
product2.Stock = 55;
product2.isAvailable = true;
Console.WriteLine($"Product name : {product2.Name}");
Console.WriteLine($"Product price: {product2.Price}");
Console.WriteLine($"Product stock : {product2.Stock}");
Console.WriteLine($"Available : {product2.isAvailable}");
List<Product> productList = new List<Product>();
productList.Add(product1);
productList.Add(product2);

foreach(Product product in productList){
	Console.WriteLine($"Products name : {product.Name}");
	Console.WriteLine($"Products price : {product.Price}");
}

var filteredProducts = productList.Where(product => product.Stock >= 30);
foreach(Product product in filteredProducts){
	Console.WriteLine($"Product name: {product.Name}");
}

var expensiveProducts = productList.Where(product => product.Price > 1350);
foreach(Product product in expensiveProducts){
	Console.WriteLine($"Product name and price : {product.Name}, {product.Price}");
}

var orderedProducts = productList.OrderBy(product => product.Price);
foreach(Product product in orderedProducts){
	Console.WriteLine($"Listed {product.Price}");
}

Product? foundProducts = productList.FirstOrDefault(product => product.Name == "iPhone 17");
Console.WriteLine($"Stock count : {foundProducts.Stock}");

public class Product{
	public String Name{get; set;}
	public decimal Price {get; set;}
	public int Stock {get; private set;}
	public bool IsAvailable => Stock > 0;
	
	public Product(string name, decimal price, int stock){
		Name = name;
		Price = price;
		if(stock < 0){
			throw new ArgumentException("Stock cannot be negative");
		}
		Stock = stock;
	}
	
	public void Sell(int quantity){
		if(quantity > Stock || quantity <= 0){
			throw new ArgumentException("Quantity cannot be higher than Stock");
		}
		if(Stock >= quantity){
			Stock -=  quantity;
		}
	}
}

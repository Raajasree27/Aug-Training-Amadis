using System;

public class ShoppingCart
{
    // 1. Add product by ID
    public void AddToCart(int productId)
    {
        Console.WriteLine($"Product with ID {productId} added to cart.");
    }

    // 2. Add product by ID and quantity
    public void AddToCart(int productId, int quantity)
    {
        Console.WriteLine($"Product with ID {productId} (x{quantity}) added to cart.");
    }

    // 3. Add product with full details
    public void AddToCart(string productName, double price, int quantity)
    {
        Console.WriteLine($"Added '{productName}' (x{quantity}) at ${price} each. Total: ${price * quantity}");
    }
}
public class Program
{
    public static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        cart.AddToCart(101);                             // Adds by product ID
        cart.AddToCart(102, 3);                          // Adds by product ID and quantity
        cart.AddToCart("Wireless Mouse", 25.99, 2);      // Adds by full product info
    }
}

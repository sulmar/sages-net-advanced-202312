
using ListExample;

Console.WriteLine("Hello, List!");

ShoppingCartTest();

static void ShoppingCartTest()
{
    ShoppingCart cart = new ShoppingCart();

    cart.AddItem(new CartItem("Product A", 1.99m, 4));
    cart.AddItem(new CartItem("Product B", 2.50m, 2));
    cart.AddItem(new CartItem("Product A", 1.99m, 1));
    
    cart.RemoveItem("Product B");

    var total = cart.CalculateTotal();

    Console.WriteLine($"{total:C2}");
}


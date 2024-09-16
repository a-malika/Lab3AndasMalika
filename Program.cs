//1 задание
public class OrderService
{
    public void CalculateOrder(string productName, int quantity, double price, int typeNotification)
    {
        double totalPrice = quantity * price;
        Notification.NotificationOrder(productName, typeNotification, totalPrice);
    }
}
public class Notification
{
    public static void NotificationOrder(string productName, int typeNotification, double totalPrice)
    {
        if (typeNotification == 1)
        {
            Console.WriteLine($"Order for {productName} created. Total: {totalPrice}");
        }
        else
        {
            Console.WriteLine($"Order for {productName} updated. New total: {totalPrice}");
        }
    }
}

//2 задание
public class Vehicle
{
    private string name;
    public Vehicle(string name)
    {
        this.name = name;
    }
    public void Start()
    {
        Console.WriteLine($"{name} is starting");
    }
    public void Stop()
    {
        Console.WriteLine($"{name} is stopping");
    }
}
public class Car : Vehicle
{
    public Car() : base("Car") { }
}
public class Truck : Vehicle
{
    public Truck() : base("Truck") { }
}

//3 задание
public class AdditionOperation
{
    public static void Execute(int a, int b)
    {
        Console.WriteLine(a + b);
    }
}

//4 задание
public class Client
{
    public void Execute()
    {
        Console.WriteLine("Doing something...");
    }
}

//5 задание
public class Circle
{
    public double CalculateAreaOfCircle(double radius)
    {
        return Math.PI * radius * radius;
    }
}
public class Square
{
    public double CalculateAreaOfSquare(double side)
    {
        return side * side;
    }
}

//6 задание
public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}



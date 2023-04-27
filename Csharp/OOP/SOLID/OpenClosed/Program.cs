// See https://aka.ms/new-console-template for more information
Customer customer = new Customer() { Name = "Türkay", CardType = new Premium() };

OrderManager orderManager = new OrderManager() { Customer = customer };
var result = orderManager.GetDiscountedPrice(1000);
Console.WriteLine(result);

/* Bir nesne gelişime AÇIK değişime KAPALI olmalıdır! */
public abstract class CardType
{
    public abstract double GetDiscountedPrice(double price);
}
public class Standard : CardType
{
    public override double GetDiscountedPrice(double price)
    {
        return price * .95;
    }
}

public class Silver : CardType
{
    public override double GetDiscountedPrice(double price)
    {
        return price * .90;
    }
}

public class Gold : CardType
{
    public override double GetDiscountedPrice(double price)
    {
        return price * .85;
    }
}
public class Customer
{
    public string Name { get; set; }
    public CardType CardType { get; set; }
}

public class Premium : CardType
{
    public override double GetDiscountedPrice(double price)
    {
        return price * .8;
    }
}

public class OrderManager
{
    public Customer Customer { get; set; }
    public double GetDiscountedPrice(double price)
    {

        double output = Customer.CardType.GetDiscountedPrice(price);
        return output;
    }
}
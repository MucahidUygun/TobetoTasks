internal class Program
{
    private static void Main(string[] args)
    {
        IProductService productService = new ProductManager(new CentralBankServiceAdapter());
        productService.Sell(
            new Product { Id = 1, Name = "Laptop", Price = 1000 },
            new Customer { Id = 1, Name = "Mücahid", DiscountForCustomer = new DiscountForCustomer { ID = 1, Name = "Öğrenci", Discount = (decimal)0.9 } }
            );
    }
}


interface IEntity
{
}

class DiscountForCustomer : IEntity
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Discount { get; set; }
}

class Product : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
}

class ProductManager : IProductService
{
    IBankService _bankService;

    public ProductManager(IBankService bankService)
    {
        _bankService = bankService;
    }

    public void Sell(Product product, Customer customer)
    {
        decimal price = product.Price;

        price = price * customer.DiscountForCustomer.Discount;


        price = _bankService.ConvertRate(new CurrencyRate { Currency = 1, Price = price });
        Console.WriteLine(price);
    }
}
internal interface IProductService
{
    void Sell(Product product, Customer customer);
}


class Customer : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DiscountForCustomer DiscountForCustomer { get; set; }
}


class FakeBankService : IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        return currencyRate.Price / (decimal)5.30;
    }
}

interface IBankService
{
    decimal ConvertRate(CurrencyRate currencyRate);
}

class CentralBankServiceAdapter : IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        CentralBankService centralBankService = new CentralBankService();
        return centralBankService.ConvertCurrency(currencyRate);
    }
}



class CentralBankService
{
    public decimal ConvertCurrency(CurrencyRate currencyRate)
    {
        return currencyRate.Price / (decimal)5.28;
    }
}

class CurrencyRate
{
    public decimal Price { get; set; }
    public int Currency { get; set; }
}

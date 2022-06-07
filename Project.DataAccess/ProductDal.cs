using Project.Entities;

namespace Project.DataAccess;

public class ProductDal : IProductDal
{
    List<Product> _products;
    public ProductDal()
    {
        _products = new List<Product>()
        {
            new Product(){ProductId=1,ProductName="Acer",QuantityPerUnit= "32 GB Ram",UnitPrice=10000,UnitsInStock= 2},
            new Product(){ProductId=2,ProductName="Monster",QuantityPerUnit= "16 GB Ram",UnitPrice=12000,UnitsInStock= 3},
            new Product(){ProductId=3,ProductName="Dell",QuantityPerUnit= "64 GB Ram",UnitPrice=8000,UnitsInStock= 0},
            new Product(){ProductId=4,ProductName="HP",QuantityPerUnit= "16 GB Ram",UnitPrice=9000,UnitsInStock= 5},
            new Product(){ProductId=5,ProductName="Asus",QuantityPerUnit= "16 GB Ram",UnitPrice=7000,UnitsInStock= 5}
        };
    }
    public void Add(Product product)
    {
        Console.WriteLine("product is added");
    }

    public void Delete(Product product)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        return _products;
    }

    public Product GetById(int Id)
    {
        throw new NotImplementedException();
    }

    public void Update(Product product)
    {
        throw new NotImplementedException();
    }
}

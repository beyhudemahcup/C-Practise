using Project.Entities;

namespace Project.DataAccess;

public class EFProductDal : IProductDal
{
    //List<Product> _products;
    public EFProductDal()
    {
        //_products = new List<Product>()
        //{
        //    new Product(){ProductId=1,ProductName="Acer EF",QuantityPerUnit= "32 GB Ram",UnitPrice=10000,UnitsInStock= 2},
        //    new Product(){ProductId=2,ProductName="Monster EF",QuantityPerUnit= "16 GB Ram",UnitPrice=12000,UnitsInStock= 3},
        //    new Product(){ProductId=3,ProductName="Dell EF",QuantityPerUnit= "64 GB Ram",UnitPrice=8000,UnitsInStock= 0},
        //    new Product(){ProductId=4,ProductName="HP EF",QuantityPerUnit= "16 GB Ram",UnitPrice=9000,UnitsInStock= 5},
        //    new Product(){ProductId=5,ProductName="Asus EF",QuantityPerUnit= "16 GB Ram",UnitPrice=7000,UnitsInStock= 5}
        //};
    }

    public void Add(Product product)
    {
        using (NorthwindContext northwindContext = new NorthwindContext())
        {
            northwindContext.Products.Add(product);
            northwindContext.SaveChanges();
        }
    }

    public void Delete(Product product)
    {
        using (NorthwindContext northwindContext = new NorthwindContext())
        {
            northwindContext.Products.Remove(northwindContext.Products.SingleOrDefault(p=>p.ProductId==product.ProductId));
            northwindContext.SaveChanges();
        }
    }

    public List<Product> GetAll()
    {
        using (NorthwindContext northwindContext = new NorthwindContext())
        {
            return northwindContext.Products.ToList();
        }
    }

    public Product GetById(int Id)
    {
        using (NorthwindContext northwindContext = new NorthwindContext())
        {
            return northwindContext.Products.SingleOrDefault(p => p.ProductId == Id);
            //we can use SingleOrDefault, if we want to return just one data.
        }
    }

    public void Update(Product product)
    {
        using (NorthwindContext northwindContext = new NorthwindContext())
        {
            var productToUpdate = northwindContext.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

            northwindContext.SaveChanges();

        }
    }
}

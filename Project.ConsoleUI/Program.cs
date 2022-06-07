using Project.Business;
using Project.DataAccess;
using Project.Entities;

namespace Project.ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EFProductDal());
            //we can change 'new reference' to achieve the other Dal classes.

            //productManager.Add(new Product {ProductName = "LapTone", CategoryId = 1, QuantityPerUnit = "16 gb Ram", UnitPrice = 12000, UnitsInStock = 11 });
            //productManager.Delete(new Product { ProductId = 80 });

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
            //we can see all products on the console with this code.

            PersonelManager personelManager = new PersonelManager(new EFPersonelDal());
            foreach (var personel in personelManager.GetAll())
            {
                Console.WriteLine("{0} / {1} / {2}", personel.Id,personel.Name,personel.Surname);
            }
        }
    }
}

namespace LinqProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName = "Bilgisayar" },
                new Category{CategoryId=2, CategoryName = "Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId= 1, CategoryId= 1 ,ProductName= "Acer", QuantityPerUnit= "32 GB RAM",UnitPrice= 10000,UnitsInStock= 3 },
                new Product{ProductId= 2, CategoryId= 1 ,ProductName= "Asus", QuantityPerUnit= "16 GB RAM",UnitPrice= 12000,UnitsInStock= 4 },
                new Product{ProductId= 3, CategoryId= 1 ,ProductName= "Hp", QuantityPerUnit= "8 GB RAM",UnitPrice= 15000,UnitsInStock= 5 },
                new Product{ProductId= 4, CategoryId= 2 ,ProductName= "Samsung", QuantityPerUnit= "64 GB RAM",UnitPrice= 6000,UnitsInStock= 6 },
                new Product{ProductId= 5, CategoryId= 2 ,ProductName= "Apple", QuantityPerUnit= "128 GB RAM",UnitPrice= 16000,UnitsInStock= 0 }
            };
        }

        //static List<Product> GetProducts()
        //{

        //}
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}

using Project.DataAccess;
using Project.Entities;

namespace Project.Business;

public class ProductManager : IProductService
{
    IProductDal _productDal;
    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public void Add(Product product)
    {
        _productDal.Add(product);
    }

    public void Delete(Product product)
    {
        _productDal.Delete(product);
    }

    public List<Product> GetAll()
    {
        //Business codes go to right here
        return _productDal.GetAll();
    }

    public Product GetById(int id)
    {
        return _productDal.GetById(id);
    }

    public void Update(Product product)
    {
        _productDal.Update(product);
    }
}

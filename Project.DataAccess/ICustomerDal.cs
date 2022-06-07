using Project.Entities;

namespace Project.DataAccess;

public interface ICustomerDal:IEntityRepository<Customer>
{
    //just sending Customer type to use all datas from entityRepository
}

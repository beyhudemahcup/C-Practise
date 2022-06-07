using Project.DataAccess;
using Project.Entities;

namespace Project.Business
{
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }
        public List<Personel> GetAll()
        {
            return _personelDal.GetAll();
        }

    }
}

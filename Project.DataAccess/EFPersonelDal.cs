using Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess
{
    public class EFPersonelDal : IPersonelDal
    {
        public void Add(Personel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Personel entity)
        {
            throw new NotImplementedException();
        }

        public List<Personel> GetAll()
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                return northwindContext.Personels.ToList();
            }
        }

        public Personel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Personel entity)
        {
            throw new NotImplementedException();
        }
    }
}

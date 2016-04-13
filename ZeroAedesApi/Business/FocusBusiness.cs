using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroAedes.Data.Entity;
using ZeroAedes.Repository;

namespace ZeroAedes.Business
{
    public class FocusBusiness
    {
        public IEnumerable<FocusEntity> Get()
        {
            FocusRepository repository = new FocusRepository();
            return repository.GetAll();
        }

        public void Create(FocusEntity entity)
        {
            FocusRepository repository = new FocusRepository();
            entity.Date = DateTime.Now;
            repository.Insert(entity);
            repository.Save();
        }
    }
}

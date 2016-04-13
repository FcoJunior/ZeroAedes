using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroAedes.Data.Entity;
using ZeroAedes.Repository;

namespace ZeroAedes.Business
{
    public class PhotoBusiness
    {
        public IEnumerable<PhotoEntity> Get(int focusId)
        {
            PhotoRepository repository = new PhotoRepository();
            return repository.GetPhotoByFocus(focusId);
        }

        public void Create(PhotoEntity entity)
        {
            PhotoRepository repository = new PhotoRepository();
            repository.Insert(entity);
            repository.Save();
        }
    }
}

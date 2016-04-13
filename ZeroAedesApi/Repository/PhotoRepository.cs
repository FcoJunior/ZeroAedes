using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ZeroAedes.Data.Entity;

namespace ZeroAedes.Repository
{
    public class PhotoRepository : Repository<PhotoEntity>
    {
        public IQueryable<PhotoEntity> GetPhotoByFocus(int focusId)
        {
            IQueryable<PhotoEntity> query = Context.Photo
                .Where(x => x.FocusId.Equals(focusId))
                .AsQueryable();
            return query;
        }
    }
}

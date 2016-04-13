using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Api.Util;
using ZeroAedes.Data.Entity;
using ZeroAedes.Business;

namespace Api.Controllers
{
    public class PhotoController : ApiController
    {
        // GET: api/Photo/
        public HttpResponseMessage Get(int id)
        {
            PhotoBusiness business = new PhotoBusiness();
            return Request.CreateResponse(HttpStatusCode.OK, business.Get(id));
        }

        // POST: api/Photo
        public HttpResponseMessage Post(PhotoEntity entity)
        {
            PhotoBusiness business = new PhotoBusiness();
            entity.Url = FileUpload.Upload();
            business.Create(entity);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}

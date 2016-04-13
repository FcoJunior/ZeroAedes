using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZeroAedes.Data.Entity;
using ZeroAedes.Business;

namespace Api.Controllers
{
    public class FocusController : ApiController
    {
        // GET: api/Focus
        public HttpResponseMessage Get()
        {
            FocusBusiness business = new FocusBusiness();
            return Request.CreateResponse(HttpStatusCode.OK, business.Get());
        }

        // POST: api/Focus
        public HttpResponseMessage Post([FromBody]FocusEntity entity)
        {
            FocusBusiness business = new FocusBusiness();
            business.Create(entity);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}

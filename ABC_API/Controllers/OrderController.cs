using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ABC_API.Models;

namespace ABC_API.Controllers
{
    public class OrderController : ApiController
    {
        private ABCEntities dbContext = new ABCEntities();

        [HttpGet]
        public ORDERS Get(int ID)
        {
            using(ABCEntities db = new ABCEntities())
            {
                return db.ORDERS.FirstOrDefault(x => x.ID == ID);
            }
        }
    }
}

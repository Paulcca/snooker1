using snooker1.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using snooker1.Models;

namespace snooker1.Controllers
{
    public class SnookerController : ApiController
    {


        public IHttpActionResult get()
        {
            SnookerContext db = new SnookerContext();



            return Json(db.Matches.ToList());                      
          

        }


       

        

    }
}

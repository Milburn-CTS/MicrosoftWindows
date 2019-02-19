using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIBasicAuth.Attributes;

namespace WebAPIBasicAuth.Controllers
{
    public class DefaultController : ApiController
    {
        // GET api/Default
        public string Get()
        {
            //System.Diagnostics.Process.Start("https://www.google.com/");
            return "Hello! Inside Get";
        }

        // POST api/Default
        [BasicAuthentication]
        public string Post()
        {
            //System.Diagnostics.Process.Start("https://www.google.com/");
            return "Hello! Insie Post";
        }

    }
}

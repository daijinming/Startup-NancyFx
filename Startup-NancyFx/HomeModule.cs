using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace Startup_NancyFx
{
    public class HomeModule:NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {   
                return this.Response.AsText("Hello Nancy", "text/html");
            }; 
        }
    }
}
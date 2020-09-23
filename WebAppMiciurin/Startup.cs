using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebAppMiciurin.Startup))]

namespace WebAppMiciurin
{
     public partial class Startup
     {
          public void Configuration(IAppBuilder app)
          {
               ConfigureAuth(app);
          }
     }
}

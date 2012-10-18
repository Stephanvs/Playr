using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Owin;
using Gate.Middleware;
using SignalR;
using SignalR.Hosting.Owin;

namespace Playr.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app
                .UseShowExceptions();
                
        }
    }
}

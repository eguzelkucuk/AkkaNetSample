using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace PlaceOrder.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static ActorSystem OrderPlacingActorSystem;
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            OrderPlacingActorSystem = ActorSystem.Create("OrderPlacingActorSystem");
        }
    }
}

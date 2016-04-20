using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace StartUpMentor.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapper.Mapper.Initialize(cfg =>
            {
                //Model layer mapping
                cfg.AddProfile<Model.AutoMapperModelLayerMapping.MappingConfiguration>();
                //WebAPI layer mapping
                cfg.AddProfile<App_Start.AutoMapperApiLayerMapping.Mappingconfiguration>();
            });
        }
    }
}

using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Applicaion.AppService.Drivers;
using TaxiApp.Application.Contracts.Entities.Drivers;

namespace TaxiApp.Applicaion.DependencyResolvers
{
  public class AutofacApplicationModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<DriverAppService>().As<IDriverAppService>();



    }
  }
}

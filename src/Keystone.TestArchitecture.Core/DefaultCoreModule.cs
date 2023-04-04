using Autofac;
using Keystone.TestArchitecture.Core.Interfaces;
using Keystone.TestArchitecture.Core.Interfaces.ServiceLearning;
using Keystone.TestArchitecture.Core.Services;
using Keystone.TestArchitecture.Core.Services.ServiceLearning;

namespace Keystone.TestArchitecture.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();

    builder.RegisterType<DeleteContributorService>()
        .As<IDeleteContributorService>().InstancePerLifetimeScope();

    builder.RegisterType<DeleteServiceActivityService>()
        .As<IDeleteServiceActivityService>().InstancePerLifetimeScope();
  }
}

using System;
using AutoMapper;
using SampleWithUnity.Infrastructure;
using SampleWithUnity.Repository;
using SampleWithUnity.Service;
using Unity;
using Unity.Lifetime;

namespace SampleWithUnity
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container

        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;

        #endregion Unity Container

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.

            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IProductRepository, ProductRepository>();

            // 更多 Mapping 設定 http://unitycontainer.org/tutorials/Composition/Mapping/implementation.html

            // The Service Itself
            // container.RegisterType<Foo>();
            // container.RegisterInstance(new Foo());

            // Mapping Contract to Implementation
            // container.RegisterType<IFoo, Foo>();
            // container.RegisterInstance<IFoo>(new Foo());

            // register factory singleton
            //var factory = new ServiceClientFactory(strategy);
            //container.RegisterInstance<IServiceClientFactory>(factory, InstanceLifetime.Singleton);

            // register factory factory for the singleton
            // container.RegisterFactory<IServiceClientFactory>((x) => new ServiceClientFactory(strategy), FactoryLifetime.Singleton);

            // AutoMapper DI

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ControllerProfile());
                cfg.AddProfile(new ServiceProfile());
            });

            container.RegisterInstance<IMapper>(
                config.CreateMapper(),
                new ContainerControlledLifetimeManager());
        }
    }
}
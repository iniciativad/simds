[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Simds.Mvc.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Simds.Mvc.App_Start.NinjectWebCommon), "Stop")]

namespace Simds.Mvc.App_Start
{
	using Microsoft.Web.Infrastructure.DynamicModuleHelper;
	using Ninject;
	using Ninject.Web.Common;
	using Simds.Application;
	using Simds.Application.Interfaces;
	using Simds.Domain.Interfaces;
	using Simds.Domain.Interfaces.Services;
	using Simds.Domain.Services;
	using Simds.Infra.Data.Repositories;
	using System;
	using System.Web;

	public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
			kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
			kernel.Bind<ICartaoAppService>().To<CartaoAppService>();
			kernel.Bind<IConjugeAppService>().To<ConjugeAppService>();
			kernel.Bind<IDependenteAppService>().To<DependenteAppService>();
			kernel.Bind<IEquipamentoPublicoAppService>().To<EquipamentoPublicoAppService>();
			kernel.Bind<IPessoaAppService>().To<PessoaAppService>();
			kernel.Bind<IPrefeituraAppService>().To<PrefeituraAppService>();





			kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
			kernel.Bind<ICartaoService>().To<CartaoService>();
			kernel.Bind<IDependenteService>().To<DependenteService>();
			kernel.Bind<IEquipamentoPublicoService>().To<EquipamentoPublicoService>();
			kernel.Bind<IPessoaService>().To<PessoaService>();
			kernel.Bind<IPrefeituraService>().To<PrefeituraService>();


			kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
			kernel.Bind<ICartaoRepository>().To<CartaoRepository>();
			kernel.Bind<IDependenteRepository>().To<DependenteRepository>();
			kernel.Bind<IEquipamentoPublicoRepository>().To<EquipamentoPublicoRepository>();
			kernel.Bind<IPessoaRepository>().To<PessoaRepository>();
			kernel.Bind<IPrefeituraRepository>().To<PrefeituraRepository>();
		}        
    }
}

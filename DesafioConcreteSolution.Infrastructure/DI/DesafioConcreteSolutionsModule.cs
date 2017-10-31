using DesafioConcreteSolution.Application.Interface.AppService;
using DesafioConcreteSolution.Application.Interface.Service;
using DesafioConcreteSolution.Application.Service;
using DesafioConcreteSolution.Domain.Factory;
using DesafioConcreteSolution.Domain.Interface.Factory;
using DesafioConcreteSolution.Domain.Interface.Infrastructure;
using DesafioConcreteSolution.Domain.Interface.Repository;
using DesafioConcreteSolution.Domain.Service;
using DesafioConcreteSolution.Infrastructure.Context;
using DesafioConcreteSolution.Infrastructure.Repository;
using DesafioConcreteSolution.Infrastructure.Service;
using Ninject.Modules;

namespace DesafioConcreteSolution.Infrastructure.DI
{
    public class DesafioConcreteSolutionsModule : NinjectModule
    {
        public override void Load()
        {
            // Context
            Bind<DesafioConcreteSolutionsContext>().ToSelf();
            Bind<SqlContext>().ToSelf();

            // Domain Service
            Bind<IUsuarioService>().To<UsuarioService>();

            // Repository
            Bind<IUsuarioRepository>().To<UsuarioRepository>();

            // Factory
            Bind<IUsuarioFactory>().To<UsuarioFactory>();

            // AppService
            Bind<IUsuarioAppService>().To<UsuarioAppService>();

            Bind<ISecurityService>().To<SecurityService>();
        }
    }
}
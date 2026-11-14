using Unity;
using Unity.Lifetime;
using TaskTrecker.Repositories;
using TaskTrecker.Repositories.Implementations;

namespace TaskTrecker
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<MainForm>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IClientRepository, ClientRepository>(new TransientLifetimeManager());
            container.RegisterType<IEmployeeRepository, EmployeeRepository>(new TransientLifetimeManager());
            container.RegisterType<IServiceRepository, ServiceRepository>(new TransientLifetimeManager());
            container.RegisterType<IContractRepository, ContractRepository>(new TransientLifetimeManager());

            return container;
        }
    }
}
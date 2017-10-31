using Ninject;

namespace DesafioConcreteSolution.Infrastructure.DI
{
    public class DesafioConcreteSolutionsKernel
    {
        private static IKernel _kernel;

        public DesafioConcreteSolutionsKernel(IKernel kernel)
        {
            _kernel = kernel;
        }

        public static T Get<T>()
        {
            return _kernel.Get<T>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Web.Mvc;
using database.Models;
using Moq;
using Ninject;
namespace HomeStore.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product> {
                new Product { Name = "Ceiling Fan", Price = 129.99M},
                new Product { Name = "Hammer", Price = 14.99M},
                new Product { Name = "Box of Nails", Price = 5.99M}
                });

            kernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }
    }
}
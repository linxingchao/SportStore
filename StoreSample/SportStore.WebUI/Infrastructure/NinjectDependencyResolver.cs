using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using SportStore.Domain.Abstract;
using SportStore.Domain.Entities;
using Moq;
using SportStore.Domain.Concrete;

namespace SportStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver:IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBinding();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object>GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBinding()
        {
            /*
            Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product> {
                new Product{Name = "Football",Price=25},
                new Product{ Name="Surf board",Price=179},
                new Product{Name="Running shoes",Price=95}
            });
            */
            kernel.Bind<IProductsRepository>().To<EFProductRepository>();
        }
    }
}
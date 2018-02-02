using System;
using System.Collections.Generic;
using System.Linq;
using Ninject;
using System.Web;
using System.Web.Mvc;
using Moq;
using DamianStore.Domain.Abstract;
using DamianStore.Domain.Entities;




namespace DamianStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel m_kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            m_kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return m_kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return m_kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            // Bindings go here
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product>
            {
                new Product {Name = "Exercise Plan", Price = 29},
                new Product {Name = "Diet Plan", Price = 39},
                new Product {Name = "Lifting Techniques", Price = 19 }
            });

            m_kernel.Bind<IProductRepository>().ToConstant(mock.Object);

            //m_kernel.Bind<IProductRepository>().To<EFProductRepository>();
        }
    }
}
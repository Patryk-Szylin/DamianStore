using System;
using System.Collections.Generic;
using System.Linq;
using DamianStore.Domain.Abstract;
using DamianStore.Domain.Entities;
using System.Web;
using System.Web.Mvc;

namespace DamianStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository m_repository;

        public ProductController(IProductRepository productRepository)
        {
            m_repository = productRepository;
        }

        public ViewResult List()
        {
            return View(m_repository.Products);
        }

    }
}
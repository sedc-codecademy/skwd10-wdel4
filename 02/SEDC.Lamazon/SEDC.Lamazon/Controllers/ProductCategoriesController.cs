﻿using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using SEDC.Lamazon.ViewModels.Models;

namespace SEDC.Lamazon.Controllers
{
    public class ProductCategoriesController : Controller
    {
        private IProductCategoriesService _productCategoriesService;

        public ProductCategoriesController(IProductCategoriesService productCategoriesService)
        {
            _productCategoriesService = productCategoriesService;
        }

        public IActionResult Index()
        {
            var productCategoryViewModels = _productCategoriesService.GetAllProductCategories();
            return View(productCategoryViewModels);
        }

        public IActionResult Create()
        {
            var productCategoryViewModel = new ProductCategoryViewModel();
            return View(productCategoryViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductCategoryViewModel productCategoryViewModel)
        {
            _productCategoriesService.CreateProductCategory(productCategoryViewModel);
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Edit(int? id)
        {
            if(id.HasValue)
            {
                var productCategoryViewModel = _productCategoriesService.GetProductCategoryById(id.Value);
                return View(productCategoryViewModel);
            }
            else
            {
                return new EmptyResult();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductCategoryViewModel productCategoryViewModel)
        {
            _productCategoriesService.UpdateProductCategory(productCategoryViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                var productCategoryViewModel = _productCategoriesService.GetProductCategoryById(id.Value);
                return View(productCategoryViewModel);
            }
            else
            {
                return new EmptyResult();
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            if (id.HasValue)
            {
                _productCategoriesService.DeleteProductCategoryById(id.Value);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return new EmptyResult();
            }
        }
    }
}

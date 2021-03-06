﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SportsStorePrism.Infrastructure;
using SportsStorePrism.Infrastructure.Abstract;
using SportsStorePrism.Infrastructure.Entities;
using Prism.Regions;
using System.Collections.ObjectModel;
using Prism.Commands;

namespace SportsStorePrism.Module.Products.ViewModels
{
   public class ProductViewModel : BindableBase
   {
      private IProductRepository _productRepository;
      private IRegionManager _regionManager;
      private ObservableCollection<Product> _products;
      private List<Product> _allProducts;
      public ObservableCollection<Product> Products
      {
         get
         {
            return _products;
         }

         set
         {
            SetProperty(ref _products, value);
         }
      }

      public ProductViewModel(IProductRepository productRepository, IRegionManager regionManager)
      {
         _productRepository = productRepository;
         _regionManager = regionManager;

         EditProductCommand = new DelegateCommand<Product>(OnEdit);
         DeleteProductCommand = new DelegateCommand<Product>(OnDeleteProduct);

         GetAllProducts();
         GetProducts();
      }

      private void GetProducts()
      {
         Products = new ObservableCollection<Product>(_allProducts);
      }

      private void GetAllProducts()
      {
         _allProducts = _productRepository.GetProductsAsync().Result;
      }

      private void OnDeleteProduct(Product product)
      {
         throw new NotImplementedException();
      }

      private void OnEdit(Product product)
      {
         throw new NotImplementedException();
      }

      public DelegateCommand<Product> EditProductCommand { get; set; }
      public event Action<Product> EditProductRequest = delegate { };

      public DelegateCommand<Product> DeleteProductCommand { get; set; }
       
   }
}

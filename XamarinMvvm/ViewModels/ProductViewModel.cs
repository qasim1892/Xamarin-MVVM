using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using XamarinMvvm.Models;
using XamarinMvvm.Repository;

namespace XamarinMvvm.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged

    {
        private readonly ProductRepository _productRepository;

        private List<ProductsResponse> _products;
        public List<ProductsResponse> Products
        {
            get { return _products; }
            set
            {
                if (_products!=value)
                {
                    _products = value;
                    OnPropertyChanged(nameof(Products));

                }
            }
        }
        public ProductViewModel()
        {
            _productRepository = new ProductRepository();
        }

        public async Task LoadDataAsync()
        {
            Products = await _productRepository.GetProductsAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

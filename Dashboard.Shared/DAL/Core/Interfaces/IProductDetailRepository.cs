using Dashboard.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Shared.DAL.Core.Interfaces
{
    public interface IProductDetailRepository
    {
       Task<ProductDetail> AddProductDetailAsync(ProductDetail productDetail);
        Task<ProductDetail> EditProductDetailAsync(ProductDetail productDetail);
    }
}

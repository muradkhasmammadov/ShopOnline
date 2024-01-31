﻿using ShopOnline.Api.Entities;
using System.Collections.Generic;

namespace ShopOnline.Api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<Product> GetItem();
        Task<ProductCategory> GetCategory();

    }
}

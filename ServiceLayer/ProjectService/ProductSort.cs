using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
namespace ServiceLayer.ProjectService
{
    public enum OrderByOptions
    {
        [Display(Name = "Sort by Name ↓...")]
        ByNameAsc = 0,
        [Display(Name = "Name ↑")]
        ByNameDesc,
        [Display(Name = "Price ↓")]
        ByPriceDesc,
        [Display(Name = "Price ↑")]
        ByPriceAsc
    }

    public static class ProductSort
    {
        public static IQueryable<Product> OrderProductsBy(this IQueryable<Product> products, OrderByOptions orderByOptions)
        {
            switch (orderByOptions)
            {
                case OrderByOptions.ByNameAsc:
                    return products.OrderBy(x => x.Name);
                case OrderByOptions.ByNameDesc:
                    return products.OrderByDescending(x => x.Name);
                case OrderByOptions.ByPriceDesc:
                    return products.OrderBy(x => x.Price);
                case OrderByOptions.ByPriceAsc:
                    return products.OrderByDescending(x => x.Price);
                default:
                    throw new ArgumentOutOfRangeException(nameof(orderByOptions), orderByOptions, null);
            }
        }

    }
}

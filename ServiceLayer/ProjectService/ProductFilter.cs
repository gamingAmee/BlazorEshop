using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using DataLayer.Entities;
using System.Threading;

namespace ServiceLayer.ProjectService
{
    public enum ProductsFilterBy
    {
        [Display(Name = "All")]
        NoFilter = 0,
        [Display(Name = "By Navn...")]
        ByName,
        [Display(Name = "By Pris...")]
        ByPrice
    }

    public static class ProductFilter
    {
        public static IQueryable<Product> FilterProductsBy(this IQueryable<Product> products, ProductsFilterBy filterBy, string filterValue)
        {
            if (string.IsNullOrEmpty(filterValue))
            {
                return products;
            }

            switch (filterBy)
            {
                case ProductsFilterBy.NoFilter:
                    return products;
                case ProductsFilterBy.ByName:
                    return products.Where(x => EF.Functions.Like(x.Name, $"%{filterValue}%"));
                case ProductsFilterBy.ByPrice:
                    return products.Where(x => x.Price <= int.Parse(filterValue));
                default:
                    throw new ArgumentOutOfRangeException(nameof(filterBy), filterBy, null);
            }
        }
    }
}

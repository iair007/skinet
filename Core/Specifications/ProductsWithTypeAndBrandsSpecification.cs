using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypeAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypeAndBrandsSpecification()
        {
            AddInclude(x=> x.ProductType);
            AddInclude(x=> x.ProductBrand);
        }

        public ProductsWithTypeAndBrandsSpecification(int id) : base(x=> x.Id == id)
        {
            AddInclude(x=> x.ProductType);
            AddInclude(x=> x.ProductBrand);
        }
    }
}
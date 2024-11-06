using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    products = context.Products.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public static Product GetProductById(int id)
        {
            Product product;
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    product = context.Products.FirstOrDefault(x => x.ProductId.Equals(id));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public static Product GetProductByUnitPrice(int unitPrice)
        {
            Product product;
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    product = context.Products.FirstOrDefault(x => x.UnitPrice.Equals(unitPrice));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public static Product GetProductByUnitInStock(int unitInStock)
        {
            Product product;
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    product = context.Products.FirstOrDefault(x => x.UnitsInStock.Equals(unitInStock));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        //public static List<Product> GetProductsByName(String name)
        //{
        //    Product product;
        //    try
        //    {
        //        using (var context = new SalemanagmentContext())
        //        {
        //            product = context.Products.FirstOrDefault(x => x.ProductName.IndexOf);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    return product;
        //}

        public static void CreateProducts(Product product)
        {
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteProducts(Product product)
        {
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    context.Products.Add(product);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Updatemember(Product product)
        {
            try
            {
                using (var context = new SalemanagmentContext())
                {
                    var a = context.Products.Update(product);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

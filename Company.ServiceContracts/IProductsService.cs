using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Company.DomainModels;

namespace Company.ServiceContracts
{
   
    public interface IProductsService 
    {
    List<Product> GetProducts();
    List<Product> SearchProducts(string ProductName);
    Product GetProductByProductID(long ProductID);
    void InerProduct(Product p);
    void UpdateProduct(Product p);
    void DeleteProduct(int ProductID);
    }
}

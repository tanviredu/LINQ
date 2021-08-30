using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQSamples
{
  public class SamplesViewModel
  {
    public List<Product> Products { get; set; }
        #region Constructor
    public SamplesViewModel()
    {
      // Load all Product Data
      Products = ProductRepository.GetAll();
    }
    #endregion

    #region Properties
    public bool UseQuerySyntax { get; set; }
    
    public string ResultText { get; set; }
    #endregion

    #region GetAllLooping
    /// <summary>
    /// Put all products into a collection via looping, no LINQ
    /// </summary>
    public void GetAllLooping()
    {
            //List<Product> list = new List<Product>();
            var list = new List<Product>(); // creating a  list to hold the Product
            foreach (var item in Products) {
                list.Add(item);
                
            }
        

     
      ResultText = $"Total Products: {list.Count}";
    }
    #endregion

    #region GetAll
    /// <summary>
    /// Put all products into a collection using LINQ
    /// </summary>
    public void GetAll()
    {
            // there are two get All method
            // one in Product repository
            // one in SamplesViewModel
      List<Product> list = new List<Product>();

      if (UseQuerySyntax) {
                list = (from prod in Products select prod).ToList();
                
                foreach(var item in list)
                {
                    Console.WriteLine(item);
                }
                
        
      }
      else {
                
                list = Products.Select(prod => prod).ToList();
                foreach(var item in list)
                {
                    Console.WriteLine(item);
                }

      }

      ResultText = $"Total Products: {list.Count}";
    }
    #endregion

    #region GetSingleColumn
    /// <summary>
    /// Select a single column
    /// </summary>
    public void GetSingleColumn()
    {
      StringBuilder sb = new StringBuilder(1024);
      List<string> list = new List<string>(); //list contains the Name of the products
                                               // so we take a List of string value

      if (UseQuerySyntax) {

                // if you want to add multiple element in
                //list you need to add addRange() method
                list.AddRange(from prod in Products select prod.Name);
                
      }
      else {
                // Method Syntax
                list.AddRange(Products.Select(prod => prod.Name));
      }

      foreach (string item in list) {
        sb.AppendLine(item);
      }

            //ResultText = $"Total Products: {list.Count}" + Environment.NewLine + sb.ToString();
            ResultText = sb.ToString();

      Products.Clear();
    }
    #endregion

    #region GetSpecificColumns
    /// <summary>
    /// Select a few specific properties from products and create new Product objects
    /// </summary>
    public void GetSpecificColumns()
    {
      if (UseQuerySyntax) {
                // Query Syntax
                var products = (from prod in Products
                                select new Product
                                {
                                    ProductID = prod.ProductID,
                                    Name = prod.Name,
                                    Size = prod.Size
                                }).ToList();
       
      }
      else {
                // Method Syntax
                var products = Products.Select(prod => new Product
                {
                    ProductID = prod.ProductID,
                    Name = prod.Name,
                    Size = prod.Size

                }).ToList();

                foreach (var item in products) {
                    Console.WriteLine(item.ProductID+" "+item.Name+" "+item.Size);
                }
       
      }

      ResultText = $"Total Products: {Products.Count}";
    }
    #endregion

    #region AnonymousClass
    /// <summary>
    /// Create an anonymous class from selected product properties
    /// </summary>
    public void AnonymousClass()
    {
      StringBuilder sb = new StringBuilder(2048);

      if (UseQuerySyntax) {
                // Query Syntax

                // Linq with anonemous class
                var products = (from prod in Products
                                select new
                                {
                                    Identifier = prod.ProductID,
                                    ProductName = prod.Name,
                                    ProductSize = prod.Size


                                });


                foreach(var item in Products)
                {
                    sb.AppendLine($"Product ID :   {item.ProductID}");
                    sb.AppendLine($"product Name:  {item.Name}");
                    sb.AppendLine($"Product Size:  { item.Size}");
                }
        
        // Loop through anonymous class
        //foreach (var prod in products) {
        //  sb.AppendLine($"Product ID: {prod.Identifier}");
        //  sb.AppendLine($"   Product Name: {prod.ProductName}");
        //  sb.AppendLine($"   Product Size: {prod.ProductSize}");
        //}
      }
      else {
                // Method Syntax
                // method with annonymous class

                var products = Products.Select(prod => new
                {

                    Identifier = prod.ProductID,
                    ProductName = prod.Name,
                    ProductSize = prod.Size
                });

                foreach(var prod in products)
                {
                    sb.AppendLine($"Product ID : {prod.Identifier}");
                    sb.AppendLine($"Product Name:{prod.ProductName}");
                    sb.AppendLine($"Product Size :{prod.ProductSize}");
                }




        // Loop through anonymous class
        //foreach (var prod in products) {
        //  sb.AppendLine($"Product ID: {prod.Identifier}");
        //  sb.AppendLine($"   Product Name: {prod.ProductName}");
        //  sb.AppendLine($"   Product Size: {prod.ProductSize}");
        //}
      }

      ResultText = sb.ToString();
      Products.Clear();
    }
    #endregion

    #region OrderBy
    /// <summary>
    /// Order products by Name
    /// </summary>
    public void OrderBy()
    {
      if (UseQuerySyntax) {
                var products = (from prod in Products orderby prod.Name  select prod).ToList();
                foreach (var item in products) {
                    // all the element will be order by Name
                    Console.WriteLine(item);

                }

      }
      else {
                // method syntax
                var products = Products.OrderBy(prod => prod.Name).ToList();
                // All the element will be order by Name

                foreach(var item in products)
                {
                    Console.WriteLine(item);
                }
      }

      ResultText = $"Total Products: {Products.Count}";
    }
    #endregion

    #region OrderByDescending Method
    /// <summary>
    /// Order products by name in descending order
    /// </summary>
    public void OrderByDescending()
    {
      if (UseQuerySyntax) {
                var products = (from prod in Products orderby prod.Name descending select prod).ToList();
                foreach (var item in products) {
                    Console.WriteLine(item);
                
                }
      }
      else {
                var products = Products.OrderByDescending(prod => prod.Name).ToList();
                foreach (var item in products) {
                    Console.WriteLine(item);
                
                }
      }

      ResultText = $"Total Products: {Products.Count}";
    }
    #endregion

    #region OrderByTwoFields Method
    /// <summary>
    /// Order products by Color descending, then Name
    /// </summary>
    public void OrderByTwoFields()
    {
      if (UseQuerySyntax) {
                // multiply orderby mathod
                var products = (from prod in Products orderby prod.Color descending, prod.Name select prod).ToList();
                foreach(var item in products)
                {
                    Console.WriteLine(item);
                }


      }
      else {
                var products = Products.OrderByDescending(prod => prod.Color).ThenBy(prod => prod.Name).ToList();
                foreach(var item in products)
                {
                    Console.WriteLine(item);
                }

      }

      ResultText = $"Total Products: {Products.Count}";
    }
    #endregion
  }
}

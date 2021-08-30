using System;

namespace LINQSamples
{
  class Program
  {
    static void Main(string[] args)
    {
            // Instantiate the Samples ViewModel
            SamplesViewModel vm = new SamplesViewModel
            {
                // Use Query or Method Syntax?
                UseQuerySyntax = false
      };

            // Call a sample method
            // vm.GetAllLooping();
            //vm.GetAll(); // it will be using the Linq Query and method Syntax it will execute the GetAll() method in the 
            // view Model
            //vm.GetSingleColumn();
            //vm.GetSpecificColumns();
            //vm.AnonymousClass();
            //vm.OrderBy();
            //vm.OrderByDescending();
            vm.OrderByTwoFields();

      // Display Product Collection
      //foreach (var item in vm.Products) {
      //  Console.Write(item.ToString());
      //}

      // Display Result Text
       Console.WriteLine(vm.ResultText);
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Customer
    {
        partial void PartialMethod()
        {
            Console.WriteLine("Partial Method Implement Diffrent cs file");
        }
    }
}

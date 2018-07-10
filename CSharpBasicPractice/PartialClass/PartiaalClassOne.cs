using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        partial void PartialMethod(); // here Only Declare .. it implement in Another cs file.
    }
    public class MyClass
    {

    }
    {

    }
}

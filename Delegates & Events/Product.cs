using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___Events
{
    public class Product
    {

        private Guid Id { get; set; }
        private string Name { get; set; }
        private Price Price { get; set; }
        private int Stock { get; set; }
        private Manufacturer Manufacturer { get; set; }

    }

}

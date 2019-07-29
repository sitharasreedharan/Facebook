using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Facebook.Test
{
    [TestFixture] 
    class UnitTests
    {

       // [Test, Order(2)]
      
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        [Test, Order(1)]
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
}

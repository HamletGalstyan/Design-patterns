using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTone
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTone singleTone = SingleTone.SingleObject();
        }
    }
}

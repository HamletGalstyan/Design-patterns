using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTone
{
    class SingleTone
    {
        public static SingleTone @object { get; set; }

        private SingleTone()
        {

        }

        public static SingleTone SingleObject()
        {
            if (@object == null)
            {
                @object = new SingleTone();
            }
            return @object;
        }
    }
}

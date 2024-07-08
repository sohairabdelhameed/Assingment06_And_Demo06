using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   
    internal class TypeB
    {
        //TypeB is internal
        //Which means Accessable within its project Scope only

        public TypeB()
        {
            //we can access the class TypeA 
            TypeA typeA = new TypeA();
            // Valid due the accessable TYPE 
            //Accessable within the its project

        }
    }
}

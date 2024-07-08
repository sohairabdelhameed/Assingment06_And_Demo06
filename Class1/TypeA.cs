using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    //We use library to store functions can be used by someone else 
    // like if we have common classes , functions,enum etc.. we will be able use it instead of repeating the code
    public class TypeA
    {   //What You Can Write Inside The Struct Or Class
        //1. Attributes[Fields] => Member Variable  
        //2. Functions[Constructor, Getter Setter, Method]
        //3. Properties[Full Property, Automatic Property, Indexer]
        //4. Events

        //PUBLIC IS THE WIDEST DATA TYPE 
        // We can access the public in its the project
        //or external project under one cindition: is that we need to import this library in the another project

        TypeB obj = new TypeB();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "first" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select first.svc or first.svc.cs at the Solution Explorer and start debugging.
    public class first : Ifirst
    {
        public Int32 addition(Int32 p1,Int32 p2)
        {
            return p1 + p2;
        }
        public Int32 subtraction(Int32 p1, Int32 p2)
        {
            return p1 + p2;
        }
        public Int32 multiplication(Int32 p1, Int32 p2)
        {
            return p1 + p2;
        }
        public Int32 divide(Int32 p1, Int32 p2)
        {
            return p1 + p2;
        } 
    }
}

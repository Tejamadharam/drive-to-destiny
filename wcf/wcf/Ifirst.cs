using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Ifirst" in both code and config file together.
    [ServiceContract]
    public interface Ifirst
    {
        [OperationContract]
        Int32 addition(Int32 p1, Int32 p2);
        Int32 subtraction(Int32 p1, Int32 p2);
        Int32 multiplication(Int32 p1, Int32 p2);
        Int32 divide(Int32 p1, Int32 p2);
    }
}

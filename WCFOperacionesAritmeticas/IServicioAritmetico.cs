using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFOperacionesAritmeticas
{
   
    [ServiceContract]
    public interface IServicioAritmetico
    {
        [OperationContract]
        double procesar(string ptipoOperacion, double pvalor1, double pvalor2);
       
    }
}

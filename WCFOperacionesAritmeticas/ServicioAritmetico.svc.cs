using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFOperacionesAritmeticas
{

    public class ServicioAritmetico : IServicioAritmetico
    {
        public double procesar(string ptipoOperacion, double pvalor1, double pvalor2)
        {
            Operacion op = new Operacion(ptipoOperacion, pvalor1, pvalor2);
            op = op.procesar(op);

            double resul = op.Resultado;

            return resul;
        }
    }
}

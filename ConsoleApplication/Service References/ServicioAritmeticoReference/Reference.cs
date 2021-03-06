﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication.ServicioAritmeticoReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioAritmeticoReference.IServicioAritmetico")]
    public interface IServicioAritmetico {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAritmetico/procesar", ReplyAction="http://tempuri.org/IServicioAritmetico/procesarResponse")]
        double procesar(string ptipoOperacion, double pvalor1, double pvalor2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioAritmetico/procesar", ReplyAction="http://tempuri.org/IServicioAritmetico/procesarResponse")]
        System.Threading.Tasks.Task<double> procesarAsync(string ptipoOperacion, double pvalor1, double pvalor2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioAritmeticoChannel : ConsoleApplication.ServicioAritmeticoReference.IServicioAritmetico, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioAritmeticoClient : System.ServiceModel.ClientBase<ConsoleApplication.ServicioAritmeticoReference.IServicioAritmetico>, ConsoleApplication.ServicioAritmeticoReference.IServicioAritmetico {
        
        public ServicioAritmeticoClient() {
        }
        
        public ServicioAritmeticoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioAritmeticoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioAritmeticoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioAritmeticoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double procesar(string ptipoOperacion, double pvalor1, double pvalor2) {
            return base.Channel.procesar(ptipoOperacion, pvalor1, pvalor2);
        }
        
        public System.Threading.Tasks.Task<double> procesarAsync(string ptipoOperacion, double pvalor1, double pvalor2) {
            return base.Channel.procesarAsync(ptipoOperacion, pvalor1, pvalor2);
        }
    }
}

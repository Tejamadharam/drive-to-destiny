﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace second.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.Ifirst")]
    public interface Ifirst {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ifirst/addition", ReplyAction="http://tempuri.org/Ifirst/additionResponse")]
        int addition(int p1, int p2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Ifirst/addition", ReplyAction="http://tempuri.org/Ifirst/additionResponse")]
        System.Threading.Tasks.Task<int> additionAsync(int p1, int p2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IfirstChannel : second.ServiceReference2.Ifirst, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IfirstClient : System.ServiceModel.ClientBase<second.ServiceReference2.Ifirst>, second.ServiceReference2.Ifirst {
        
        public IfirstClient() {
        }
        
        public IfirstClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IfirstClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IfirstClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IfirstClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int addition(int p1, int p2) {
            return base.Channel.addition(p1, p2);
        }
        
        public System.Threading.Tasks.Task<int> additionAsync(int p1, int p2) {
            return base.Channel.additionAsync(p1, p2);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceWeight.Weight1Soap")]
    public interface Weight1Soap {
        
        // CODEGEN: Generating message contract since element name from from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/calculateWeight", ReplyAction="*")]
        UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightResponse calculateWeight(UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/calculateWeight", ReplyAction="*")]
        System.Threading.Tasks.Task<UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightResponse> calculateWeightAsync(UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class calculateWeightRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="calculateWeight", Namespace="http://tempuri.org/", Order=0)]
        public UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightRequestBody Body;
        
        public calculateWeightRequest() {
        }
        
        public calculateWeightRequest(UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class calculateWeightRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double value;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string from;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string to;
        
        public calculateWeightRequestBody() {
        }
        
        public calculateWeightRequestBody(double value, string from, string to) {
            this.value = value;
            this.from = from;
            this.to = to;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class calculateWeightResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="calculateWeightResponse", Namespace="http://tempuri.org/", Order=0)]
        public UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightResponseBody Body;
        
        public calculateWeightResponse() {
        }
        
        public calculateWeightResponse(UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class calculateWeightResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double calculateWeightResult;
        
        public calculateWeightResponseBody() {
        }
        
        public calculateWeightResponseBody(double calculateWeightResult) {
            this.calculateWeightResult = calculateWeightResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Weight1SoapChannel : UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.Weight1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Weight1SoapClient : System.ServiceModel.ClientBase<UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.Weight1Soap>, UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.Weight1Soap {
        
        public Weight1SoapClient() {
        }
        
        public Weight1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Weight1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Weight1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Weight1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightResponse UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.Weight1Soap.calculateWeight(UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightRequest request) {
            return base.Channel.calculateWeight(request);
        }
        
        public double calculateWeight(double value, string from, string to) {
            UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightRequest inValue = new UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightRequest();
            inValue.Body = new UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightRequestBody();
            inValue.Body.value = value;
            inValue.Body.from = from;
            inValue.Body.to = to;
            UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightResponse retVal = ((UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.Weight1Soap)(this)).calculateWeight(inValue);
            return retVal.Body.calculateWeightResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightResponse> UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.Weight1Soap.calculateWeightAsync(UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightRequest request) {
            return base.Channel.calculateWeightAsync(request);
        }
        
        public System.Threading.Tasks.Task<UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightResponse> calculateWeightAsync(double value, string from, string to) {
            UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightRequest inValue = new UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightRequest();
            inValue.Body = new UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.calculateWeightRequestBody();
            inValue.Body.value = value;
            inValue.Body.from = from;
            inValue.Body.to = to;
            return ((UnitesWebConverterGroup_P14_1205_11181_2.ServiceReferenceWeight.Weight1Soap)(this)).calculateWeightAsync(inValue);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoWeb.ClientesWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CLIENTES", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class CLIENTES : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RUTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NOMBREField;
        
        private System.Nullable<decimal> TELEFONOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DIRECCIONField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string RUT {
            get {
                return this.RUTField;
            }
            set {
                if ((object.ReferenceEquals(this.RUTField, value) != true)) {
                    this.RUTField = value;
                    this.RaisePropertyChanged("RUT");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string NOMBRE {
            get {
                return this.NOMBREField;
            }
            set {
                if ((object.ReferenceEquals(this.NOMBREField, value) != true)) {
                    this.NOMBREField = value;
                    this.RaisePropertyChanged("NOMBRE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<decimal> TELEFONO {
            get {
                return this.TELEFONOField;
            }
            set {
                if ((this.TELEFONOField.Equals(value) != true)) {
                    this.TELEFONOField = value;
                    this.RaisePropertyChanged("TELEFONO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string DIRECCION {
            get {
                return this.DIRECCIONField;
            }
            set {
                if ((object.ReferenceEquals(this.DIRECCIONField, value) != true)) {
                    this.DIRECCIONField = value;
                    this.RaisePropertyChanged("DIRECCION");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClientesWS.ClientesWSSoap")]
    public interface ClientesWSSoap {
        
        // CODEGEN: Generating message contract since element name ListarResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        ProyectoWeb.ClientesWS.ListarResponse Listar(ProyectoWeb.ClientesWS.ListarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoWeb.ClientesWS.ListarResponse> ListarAsync(ProyectoWeb.ClientesWS.ListarRequest request);
        
        // CODEGEN: Generating message contract since element name cliente from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insertar", ReplyAction="*")]
        ProyectoWeb.ClientesWS.InsertarResponse Insertar(ProyectoWeb.ClientesWS.InsertarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insertar", ReplyAction="*")]
        System.Threading.Tasks.Task<ProyectoWeb.ClientesWS.InsertarResponse> InsertarAsync(ProyectoWeb.ClientesWS.InsertarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Listar", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoWeb.ClientesWS.ListarRequestBody Body;
        
        public ListarRequest() {
        }
        
        public ListarRequest(ProyectoWeb.ClientesWS.ListarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListarRequestBody {
        
        public ListarRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListarResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoWeb.ClientesWS.ListarResponseBody Body;
        
        public ListarResponse() {
        }
        
        public ListarResponse(ProyectoWeb.ClientesWS.ListarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ListarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoWeb.ClientesWS.CLIENTES[] ListarResult;
        
        public ListarResponseBody() {
        }
        
        public ListarResponseBody(ProyectoWeb.ClientesWS.CLIENTES[] ListarResult) {
            this.ListarResult = ListarResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Insertar", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoWeb.ClientesWS.InsertarRequestBody Body;
        
        public InsertarRequest() {
        }
        
        public InsertarRequest(ProyectoWeb.ClientesWS.InsertarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ProyectoWeb.ClientesWS.CLIENTES cliente;
        
        public InsertarRequestBody() {
        }
        
        public InsertarRequestBody(ProyectoWeb.ClientesWS.CLIENTES cliente) {
            this.cliente = cliente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProyectoWeb.ClientesWS.InsertarResponseBody Body;
        
        public InsertarResponse() {
        }
        
        public InsertarResponse(ProyectoWeb.ClientesWS.InsertarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class InsertarResponseBody {
        
        public InsertarResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ClientesWSSoapChannel : ProyectoWeb.ClientesWS.ClientesWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientesWSSoapClient : System.ServiceModel.ClientBase<ProyectoWeb.ClientesWS.ClientesWSSoap>, ProyectoWeb.ClientesWS.ClientesWSSoap {
        
        public ClientesWSSoapClient() {
        }
        
        public ClientesWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientesWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientesWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoWeb.ClientesWS.ListarResponse ProyectoWeb.ClientesWS.ClientesWSSoap.Listar(ProyectoWeb.ClientesWS.ListarRequest request) {
            return base.Channel.Listar(request);
        }
        
        public ProyectoWeb.ClientesWS.CLIENTES[] Listar() {
            ProyectoWeb.ClientesWS.ListarRequest inValue = new ProyectoWeb.ClientesWS.ListarRequest();
            inValue.Body = new ProyectoWeb.ClientesWS.ListarRequestBody();
            ProyectoWeb.ClientesWS.ListarResponse retVal = ((ProyectoWeb.ClientesWS.ClientesWSSoap)(this)).Listar(inValue);
            return retVal.Body.ListarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoWeb.ClientesWS.ListarResponse> ProyectoWeb.ClientesWS.ClientesWSSoap.ListarAsync(ProyectoWeb.ClientesWS.ListarRequest request) {
            return base.Channel.ListarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoWeb.ClientesWS.ListarResponse> ListarAsync() {
            ProyectoWeb.ClientesWS.ListarRequest inValue = new ProyectoWeb.ClientesWS.ListarRequest();
            inValue.Body = new ProyectoWeb.ClientesWS.ListarRequestBody();
            return ((ProyectoWeb.ClientesWS.ClientesWSSoap)(this)).ListarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProyectoWeb.ClientesWS.InsertarResponse ProyectoWeb.ClientesWS.ClientesWSSoap.Insertar(ProyectoWeb.ClientesWS.InsertarRequest request) {
            return base.Channel.Insertar(request);
        }
        
        public void Insertar(ProyectoWeb.ClientesWS.CLIENTES cliente) {
            ProyectoWeb.ClientesWS.InsertarRequest inValue = new ProyectoWeb.ClientesWS.InsertarRequest();
            inValue.Body = new ProyectoWeb.ClientesWS.InsertarRequestBody();
            inValue.Body.cliente = cliente;
            ProyectoWeb.ClientesWS.InsertarResponse retVal = ((ProyectoWeb.ClientesWS.ClientesWSSoap)(this)).Insertar(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProyectoWeb.ClientesWS.InsertarResponse> ProyectoWeb.ClientesWS.ClientesWSSoap.InsertarAsync(ProyectoWeb.ClientesWS.InsertarRequest request) {
            return base.Channel.InsertarAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProyectoWeb.ClientesWS.InsertarResponse> InsertarAsync(ProyectoWeb.ClientesWS.CLIENTES cliente) {
            ProyectoWeb.ClientesWS.InsertarRequest inValue = new ProyectoWeb.ClientesWS.InsertarRequest();
            inValue.Body = new ProyectoWeb.ClientesWS.InsertarRequestBody();
            inValue.Body.cliente = cliente;
            return ((ProyectoWeb.ClientesWS.ClientesWSSoap)(this)).InsertarAsync(inValue);
        }
    }
}

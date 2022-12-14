//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioWebWCF.Servicio {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws/", ConfigurationName="Servicio.WSOperaciones")]
    public interface WSOperaciones {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento usuario del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/WSOperaciones/loginRequest", ReplyAction="http://ws/WSOperaciones/loginResponse")]
        ServicioWebWCF.Servicio.loginResponse login(ServicioWebWCF.Servicio.loginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/WSOperaciones/loginRequest", ReplyAction="http://ws/WSOperaciones/loginResponse")]
        System.Threading.Tasks.Task<ServicioWebWCF.Servicio.loginResponse> loginAsync(ServicioWebWCF.Servicio.loginRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el espacio de nombres de partes de mensaje () no coincide con el valor predeterminado (http://ws/).
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/WSOperaciones/ProcesarPagoRequest", ReplyAction="http://ws/WSOperaciones/ProcesarPagoResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ServicioWebWCF.Servicio.ProcesarPagoResponse ProcesarPago(ServicioWebWCF.Servicio.ProcesarPagoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws/WSOperaciones/ProcesarPagoRequest", ReplyAction="http://ws/WSOperaciones/ProcesarPagoResponse")]
        System.Threading.Tasks.Task<ServicioWebWCF.Servicio.ProcesarPagoResponse> ProcesarPagoAsync(ServicioWebWCF.Servicio.ProcesarPagoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class loginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="login", Namespace="http://ws/", Order=0)]
        public ServicioWebWCF.Servicio.loginRequestBody Body;
        
        public loginRequest() {
        }
        
        public loginRequest(ServicioWebWCF.Servicio.loginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class loginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string contrasena;
        
        public loginRequestBody() {
        }
        
        public loginRequestBody(string usuario, string contrasena) {
            this.usuario = usuario;
            this.contrasena = contrasena;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class loginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="loginResponse", Namespace="http://ws/", Order=0)]
        public ServicioWebWCF.Servicio.loginResponseBody Body;
        
        public loginResponse() {
        }
        
        public loginResponse(ServicioWebWCF.Servicio.loginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class loginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool @return;
        
        public loginResponseBody() {
        }
        
        public loginResponseBody(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcesarPago", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class ProcesarPagoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int total;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public int pago;
        
        public ProcesarPagoRequest() {
        }
        
        public ProcesarPagoRequest(int total, int pago) {
            this.total = total;
            this.pago = pago;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcesarPagoResponse", WrapperNamespace="http://ws/", IsWrapped=true)]
    public partial class ProcesarPagoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public int @return;
        
        public ProcesarPagoResponse() {
        }
        
        public ProcesarPagoResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSOperacionesChannel : ServicioWebWCF.Servicio.WSOperaciones, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSOperacionesClient : System.ServiceModel.ClientBase<ServicioWebWCF.Servicio.WSOperaciones>, ServicioWebWCF.Servicio.WSOperaciones {
        
        public WSOperacionesClient() {
        }
        
        public WSOperacionesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSOperacionesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSOperacionesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSOperacionesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServicioWebWCF.Servicio.loginResponse ServicioWebWCF.Servicio.WSOperaciones.login(ServicioWebWCF.Servicio.loginRequest request) {
            return base.Channel.login(request);
        }
        
        public bool login(string usuario, string contrasena) {
            ServicioWebWCF.Servicio.loginRequest inValue = new ServicioWebWCF.Servicio.loginRequest();
            inValue.Body = new ServicioWebWCF.Servicio.loginRequestBody();
            inValue.Body.usuario = usuario;
            inValue.Body.contrasena = contrasena;
            ServicioWebWCF.Servicio.loginResponse retVal = ((ServicioWebWCF.Servicio.WSOperaciones)(this)).login(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioWebWCF.Servicio.loginResponse> ServicioWebWCF.Servicio.WSOperaciones.loginAsync(ServicioWebWCF.Servicio.loginRequest request) {
            return base.Channel.loginAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioWebWCF.Servicio.loginResponse> loginAsync(string usuario, string contrasena) {
            ServicioWebWCF.Servicio.loginRequest inValue = new ServicioWebWCF.Servicio.loginRequest();
            inValue.Body = new ServicioWebWCF.Servicio.loginRequestBody();
            inValue.Body.usuario = usuario;
            inValue.Body.contrasena = contrasena;
            return ((ServicioWebWCF.Servicio.WSOperaciones)(this)).loginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServicioWebWCF.Servicio.ProcesarPagoResponse ServicioWebWCF.Servicio.WSOperaciones.ProcesarPago(ServicioWebWCF.Servicio.ProcesarPagoRequest request) {
            return base.Channel.ProcesarPago(request);
        }
        
        public int ProcesarPago(int total, int pago) {
            ServicioWebWCF.Servicio.ProcesarPagoRequest inValue = new ServicioWebWCF.Servicio.ProcesarPagoRequest();
            inValue.total = total;
            inValue.pago = pago;
            ServicioWebWCF.Servicio.ProcesarPagoResponse retVal = ((ServicioWebWCF.Servicio.WSOperaciones)(this)).ProcesarPago(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioWebWCF.Servicio.ProcesarPagoResponse> ServicioWebWCF.Servicio.WSOperaciones.ProcesarPagoAsync(ServicioWebWCF.Servicio.ProcesarPagoRequest request) {
            return base.Channel.ProcesarPagoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioWebWCF.Servicio.ProcesarPagoResponse> ProcesarPagoAsync(int total, int pago) {
            ServicioWebWCF.Servicio.ProcesarPagoRequest inValue = new ServicioWebWCF.Servicio.ProcesarPagoRequest();
            inValue.total = total;
            inValue.pago = pago;
            return ((ServicioWebWCF.Servicio.WSOperaciones)(this)).ProcesarPagoAsync(inValue);
        }
    }
}

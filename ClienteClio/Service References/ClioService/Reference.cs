﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.296
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteClioLogic.ClioService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ClioWebService/", ConfigurationName="ClioService.ClioWebService")]
    public interface ClioWebService {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombrePC del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://ClioWebService/ClioWebService/registrarPCRequest", ReplyAction="http://ClioWebService/ClioWebService/registrarPCResponse")]
        ClienteClioLogic.ClioService.registrarPCResponse registrarPC(ClienteClioLogic.ClioService.registrarPCRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el espacio de nombres de partes de mensaje () no coincide con el valor predeterminado (http://ClioWebService/).
        [System.ServiceModel.OperationContractAttribute(Action="http://ClioWebService/ClioWebService/helloRequest", ReplyAction="http://ClioWebService/ClioWebService/helloResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClienteClioLogic.ClioService.helloResponse hello(ClienteClioLogic.ClioService.helloRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento username del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://ClioWebService/ClioWebService/registrarClienteClioRequest", ReplyAction="http://ClioWebService/ClioWebService/registrarClienteClioResponse")]
        ClienteClioLogic.ClioService.registrarClienteClioResponse registrarClienteClio(ClienteClioLogic.ClioService.registrarClienteClioRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento return del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://ClioWebService/ClioWebService/laboratoriosDisponiblesRequest", ReplyAction="http://ClioWebService/ClioWebService/laboratoriosDisponiblesResponse")]
        ClienteClioLogic.ClioService.laboratoriosDisponiblesResponse laboratoriosDisponibles(ClienteClioLogic.ClioService.laboratoriosDisponiblesRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento username del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://ClioWebService/ClioWebService/loginRequest", ReplyAction="http://ClioWebService/ClioWebService/loginResponse")]
        ClienteClioLogic.ClioService.loginResponse login(ClienteClioLogic.ClioService.loginRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento username del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://ClioWebService/ClioWebService/logoutRequest", ReplyAction="http://ClioWebService/ClioWebService/logoutResponse")]
        ClienteClioLogic.ClioService.logoutResponse logout(ClienteClioLogic.ClioService.logoutRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class registrarPCRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registrarPC", Namespace="http://ClioWebService/", Order=0)]
        public ClienteClioLogic.ClioService.registrarPCRequestBody Body;
        
        public registrarPCRequest() {
        }
        
        public registrarPCRequest(ClienteClioLogic.ClioService.registrarPCRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class registrarPCRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombrePC;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string idLab;
        
        public registrarPCRequestBody() {
        }
        
        public registrarPCRequestBody(string nombrePC, string idLab) {
            this.nombrePC = nombrePC;
            this.idLab = idLab;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class registrarPCResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registrarPCResponse", Namespace="http://ClioWebService/", Order=0)]
        public ClienteClioLogic.ClioService.registrarPCResponseBody Body;
        
        public registrarPCResponse() {
        }
        
        public registrarPCResponse(ClienteClioLogic.ClioService.registrarPCResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class registrarPCResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool @return;
        
        public registrarPCResponseBody() {
        }
        
        public registrarPCResponseBody(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="hello", WrapperNamespace="http://ClioWebService/", IsWrapped=true)]
    public partial class helloRequest {
        
        public helloRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="helloResponse", WrapperNamespace="http://ClioWebService/", IsWrapped=true)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public bool @return;
        
        public helloResponse() {
        }
        
        public helloResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class registrarClienteClioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registrarClienteClio", Namespace="http://ClioWebService/", Order=0)]
        public ClienteClioLogic.ClioService.registrarClienteClioRequestBody Body;
        
        public registrarClienteClioRequest() {
        }
        
        public registrarClienteClioRequest(ClienteClioLogic.ClioService.registrarClienteClioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class registrarClienteClioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string nombres;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string apellidos;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string matricula;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string cedula;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string facultad;
        
        public registrarClienteClioRequestBody() {
        }
        
        public registrarClienteClioRequestBody(string username, string password, string nombres, string apellidos, string matricula, string cedula, string email, string facultad) {
            this.username = username;
            this.password = password;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.matricula = matricula;
            this.cedula = cedula;
            this.email = email;
            this.facultad = facultad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class registrarClienteClioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registrarClienteClioResponse", Namespace="http://ClioWebService/", Order=0)]
        public ClienteClioLogic.ClioService.registrarClienteClioResponseBody Body;
        
        public registrarClienteClioResponse() {
        }
        
        public registrarClienteClioResponse(ClienteClioLogic.ClioService.registrarClienteClioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class registrarClienteClioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool @return;
        
        public registrarClienteClioResponseBody() {
        }
        
        public registrarClienteClioResponseBody(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class laboratoriosDisponiblesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="laboratoriosDisponibles", Namespace="http://ClioWebService/", Order=0)]
        public ClienteClioLogic.ClioService.laboratoriosDisponiblesRequestBody Body;
        
        public laboratoriosDisponiblesRequest() {
        }
        
        public laboratoriosDisponiblesRequest(ClienteClioLogic.ClioService.laboratoriosDisponiblesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class laboratoriosDisponiblesRequestBody {
        
        public laboratoriosDisponiblesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class laboratoriosDisponiblesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="laboratoriosDisponiblesResponse", Namespace="http://ClioWebService/", Order=0)]
        public ClienteClioLogic.ClioService.laboratoriosDisponiblesResponseBody Body;
        
        public laboratoriosDisponiblesResponse() {
        }
        
        public laboratoriosDisponiblesResponse(ClienteClioLogic.ClioService.laboratoriosDisponiblesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class laboratoriosDisponiblesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public laboratoriosDisponiblesResponseBody() {
        }
        
        public laboratoriosDisponiblesResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class loginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="login", Namespace="http://ClioWebService/", Order=0)]
        public ClienteClioLogic.ClioService.loginRequestBody Body;
        
        public loginRequest() {
        }
        
        public loginRequest(ClienteClioLogic.ClioService.loginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class loginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public loginRequestBody() {
        }
        
        public loginRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class loginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="loginResponse", Namespace="http://ClioWebService/", Order=0)]
        public ClienteClioLogic.ClioService.loginResponseBody Body;
        
        public loginResponse() {
        }
        
        public loginResponse(ClienteClioLogic.ClioService.loginResponseBody Body) {
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
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class logoutRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="logout", Namespace="http://ClioWebService/", Order=0)]
        public ClienteClioLogic.ClioService.logoutRequestBody Body;
        
        public logoutRequest() {
        }
        
        public logoutRequest(ClienteClioLogic.ClioService.logoutRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class logoutRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        public logoutRequestBody() {
        }
        
        public logoutRequestBody(string username) {
            this.username = username;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class logoutResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="logoutResponse", Namespace="http://ClioWebService/", Order=0)]
        public ClienteClioLogic.ClioService.logoutResponseBody Body;
        
        public logoutResponse() {
        }
        
        public logoutResponse(ClienteClioLogic.ClioService.logoutResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class logoutResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool @return;
        
        public logoutResponseBody() {
        }
        
        public logoutResponseBody(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ClioWebServiceChannel : ClienteClioLogic.ClioService.ClioWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClioWebServiceClient : System.ServiceModel.ClientBase<ClienteClioLogic.ClioService.ClioWebService>, ClienteClioLogic.ClioService.ClioWebService {
        
        public ClioWebServiceClient() {
        }
        
        public ClioWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClioWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClioWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClioWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteClioLogic.ClioService.registrarPCResponse ClienteClioLogic.ClioService.ClioWebService.registrarPC(ClienteClioLogic.ClioService.registrarPCRequest request) {
            return base.Channel.registrarPC(request);
        }
        
        public bool registrarPC(string nombrePC, string idLab) {
            ClienteClioLogic.ClioService.registrarPCRequest inValue = new ClienteClioLogic.ClioService.registrarPCRequest();
            inValue.Body = new ClienteClioLogic.ClioService.registrarPCRequestBody();
            inValue.Body.nombrePC = nombrePC;
            inValue.Body.idLab = idLab;
            ClienteClioLogic.ClioService.registrarPCResponse retVal = ((ClienteClioLogic.ClioService.ClioWebService)(this)).registrarPC(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteClioLogic.ClioService.helloResponse ClienteClioLogic.ClioService.ClioWebService.hello(ClienteClioLogic.ClioService.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public bool hello() {
            ClienteClioLogic.ClioService.helloRequest inValue = new ClienteClioLogic.ClioService.helloRequest();
            ClienteClioLogic.ClioService.helloResponse retVal = ((ClienteClioLogic.ClioService.ClioWebService)(this)).hello(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteClioLogic.ClioService.registrarClienteClioResponse ClienteClioLogic.ClioService.ClioWebService.registrarClienteClio(ClienteClioLogic.ClioService.registrarClienteClioRequest request) {
            return base.Channel.registrarClienteClio(request);
        }
        
        public bool registrarClienteClio(string username, string password, string nombres, string apellidos, string matricula, string cedula, string email, string facultad) {
            ClienteClioLogic.ClioService.registrarClienteClioRequest inValue = new ClienteClioLogic.ClioService.registrarClienteClioRequest();
            inValue.Body = new ClienteClioLogic.ClioService.registrarClienteClioRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            inValue.Body.nombres = nombres;
            inValue.Body.apellidos = apellidos;
            inValue.Body.matricula = matricula;
            inValue.Body.cedula = cedula;
            inValue.Body.email = email;
            inValue.Body.facultad = facultad;
            ClienteClioLogic.ClioService.registrarClienteClioResponse retVal = ((ClienteClioLogic.ClioService.ClioWebService)(this)).registrarClienteClio(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteClioLogic.ClioService.laboratoriosDisponiblesResponse ClienteClioLogic.ClioService.ClioWebService.laboratoriosDisponibles(ClienteClioLogic.ClioService.laboratoriosDisponiblesRequest request) {
            return base.Channel.laboratoriosDisponibles(request);
        }
        
        public string laboratoriosDisponibles() {
            ClienteClioLogic.ClioService.laboratoriosDisponiblesRequest inValue = new ClienteClioLogic.ClioService.laboratoriosDisponiblesRequest();
            inValue.Body = new ClienteClioLogic.ClioService.laboratoriosDisponiblesRequestBody();
            ClienteClioLogic.ClioService.laboratoriosDisponiblesResponse retVal = ((ClienteClioLogic.ClioService.ClioWebService)(this)).laboratoriosDisponibles(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteClioLogic.ClioService.loginResponse ClienteClioLogic.ClioService.ClioWebService.login(ClienteClioLogic.ClioService.loginRequest request) {
            return base.Channel.login(request);
        }
        
        public bool login(string username, string password) {
            ClienteClioLogic.ClioService.loginRequest inValue = new ClienteClioLogic.ClioService.loginRequest();
            inValue.Body = new ClienteClioLogic.ClioService.loginRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            ClienteClioLogic.ClioService.loginResponse retVal = ((ClienteClioLogic.ClioService.ClioWebService)(this)).login(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClienteClioLogic.ClioService.logoutResponse ClienteClioLogic.ClioService.ClioWebService.logout(ClienteClioLogic.ClioService.logoutRequest request) {
            return base.Channel.logout(request);
        }
        
        public bool logout(string username) {
            ClienteClioLogic.ClioService.logoutRequest inValue = new ClienteClioLogic.ClioService.logoutRequest();
            inValue.Body = new ClienteClioLogic.ClioService.logoutRequestBody();
            inValue.Body.username = username;
            ClienteClioLogic.ClioService.logoutResponse retVal = ((ClienteClioLogic.ClioService.ClioWebService)(this)).logout(inValue);
            return retVal.Body.@return;
        }
    }
}

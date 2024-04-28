﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimbradoService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.urbansa.com/", ConfigurationName="TimbradoService.TimbradoSoap")]
    public interface TimbradoSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.urbansa.com/TimbrarF", ReplyAction="*")]
        System.Threading.Tasks.Task<TimbradoService.TimbrarFResponse> TimbrarFAsync(TimbradoService.TimbrarFRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.urbansa.com/VerificarXML", ReplyAction="*")]
        System.Threading.Tasks.Task<TimbradoService.VerificarXMLResponse> VerificarXMLAsync(TimbradoService.VerificarXMLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.urbansa.com/TimbrarCP", ReplyAction="*")]
        System.Threading.Tasks.Task<TimbradoService.TimbrarCPResponse> TimbrarCPAsync(TimbradoService.TimbrarCPRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.urbansa.com/TimbrarN2", ReplyAction="*")]
        System.Threading.Tasks.Task<TimbradoService.TimbrarN2Response> TimbrarN2Async(TimbradoService.TimbrarN2Request request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TimbrarFRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TimbrarF", Namespace="http://ws.urbansa.com/", Order=0)]
        public TimbradoService.TimbrarFRequestBody Body;
        
        public TimbrarFRequest()
        {
        }
        
        public TimbrarFRequest(TimbradoService.TimbrarFRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class TimbrarFRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string StrXml;
        
        public TimbrarFRequestBody()
        {
        }
        
        public TimbrarFRequestBody(string Usuario, string Password, string StrXml)
        {
            this.Usuario = Usuario;
            this.Password = Password;
            this.StrXml = StrXml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TimbrarFResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TimbrarFResponse", Namespace="http://ws.urbansa.com/", Order=0)]
        public TimbradoService.TimbrarFResponseBody Body;
        
        public TimbrarFResponse()
        {
        }
        
        public TimbrarFResponse(TimbradoService.TimbrarFResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class TimbrarFResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] TimbrarFResult;
        
        public TimbrarFResponseBody()
        {
        }
        
        public TimbrarFResponseBody(byte[] TimbrarFResult)
        {
            this.TimbrarFResult = TimbrarFResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerificarXMLRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerificarXML", Namespace="http://ws.urbansa.com/", Order=0)]
        public TimbradoService.VerificarXMLRequestBody Body;
        
        public VerificarXMLRequest()
        {
        }
        
        public VerificarXMLRequest(TimbradoService.VerificarXMLRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class VerificarXMLRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string StrXml;
        
        public VerificarXMLRequestBody()
        {
        }
        
        public VerificarXMLRequestBody(string Usuario, string Password, string StrXml)
        {
            this.Usuario = Usuario;
            this.Password = Password;
            this.StrXml = StrXml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class VerificarXMLResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="VerificarXMLResponse", Namespace="http://ws.urbansa.com/", Order=0)]
        public TimbradoService.VerificarXMLResponseBody Body;
        
        public VerificarXMLResponse()
        {
        }
        
        public VerificarXMLResponse(TimbradoService.VerificarXMLResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class VerificarXMLResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string VerificarXMLResult;
        
        public VerificarXMLResponseBody()
        {
        }
        
        public VerificarXMLResponseBody(string VerificarXMLResult)
        {
            this.VerificarXMLResult = VerificarXMLResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TimbrarCPRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TimbrarCP", Namespace="http://ws.urbansa.com/", Order=0)]
        public TimbradoService.TimbrarCPRequestBody Body;
        
        public TimbrarCPRequest()
        {
        }
        
        public TimbrarCPRequest(TimbradoService.TimbrarCPRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class TimbrarCPRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Cadena;
        
        public TimbrarCPRequestBody()
        {
        }
        
        public TimbrarCPRequestBody(string Usuario, string Password, string Cadena)
        {
            this.Usuario = Usuario;
            this.Password = Password;
            this.Cadena = Cadena;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TimbrarCPResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TimbrarCPResponse", Namespace="http://ws.urbansa.com/", Order=0)]
        public TimbradoService.TimbrarCPResponseBody Body;
        
        public TimbrarCPResponse()
        {
        }
        
        public TimbrarCPResponse(TimbradoService.TimbrarCPResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class TimbrarCPResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] TimbrarCPResult;
        
        public TimbrarCPResponseBody()
        {
        }
        
        public TimbrarCPResponseBody(byte[] TimbrarCPResult)
        {
            this.TimbrarCPResult = TimbrarCPResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TimbrarN2Request
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TimbrarN2", Namespace="http://ws.urbansa.com/", Order=0)]
        public TimbradoService.TimbrarN2RequestBody Body;
        
        public TimbrarN2Request()
        {
        }
        
        public TimbrarN2Request(TimbradoService.TimbrarN2RequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class TimbrarN2RequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Usuario;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Cadena;
        
        public TimbrarN2RequestBody()
        {
        }
        
        public TimbrarN2RequestBody(string Usuario, string Password, string Cadena)
        {
            this.Usuario = Usuario;
            this.Password = Password;
            this.Cadena = Cadena;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TimbrarN2Response
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TimbrarN2Response", Namespace="http://ws.urbansa.com/", Order=0)]
        public TimbradoService.TimbrarN2ResponseBody Body;
        
        public TimbrarN2Response()
        {
        }
        
        public TimbrarN2Response(TimbradoService.TimbrarN2ResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://ws.urbansa.com/")]
    public partial class TimbrarN2ResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] TimbrarN2Result;
        
        public TimbrarN2ResponseBody()
        {
        }
        
        public TimbrarN2ResponseBody(byte[] TimbrarN2Result)
        {
            this.TimbrarN2Result = TimbrarN2Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface TimbradoSoapChannel : TimbradoService.TimbradoSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class TimbradoSoapClient : System.ServiceModel.ClientBase<TimbradoService.TimbradoSoap>, TimbradoService.TimbradoSoap
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public TimbradoSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(TimbradoSoapClient.GetBindingForEndpoint(endpointConfiguration), TimbradoSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TimbradoSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(TimbradoSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TimbradoSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(TimbradoSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TimbradoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TimbradoService.TimbrarFResponse> TimbradoService.TimbradoSoap.TimbrarFAsync(TimbradoService.TimbrarFRequest request)
        {
            return base.Channel.TimbrarFAsync(request);
        }
        
        public System.Threading.Tasks.Task<TimbradoService.TimbrarFResponse> TimbrarFAsync(string Usuario, string Password, string StrXml)
        {
            TimbradoService.TimbrarFRequest inValue = new TimbradoService.TimbrarFRequest();
            inValue.Body = new TimbradoService.TimbrarFRequestBody();
            inValue.Body.Usuario = Usuario;
            inValue.Body.Password = Password;
            inValue.Body.StrXml = StrXml;
            return ((TimbradoService.TimbradoSoap)(this)).TimbrarFAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TimbradoService.VerificarXMLResponse> TimbradoService.TimbradoSoap.VerificarXMLAsync(TimbradoService.VerificarXMLRequest request)
        {
            return base.Channel.VerificarXMLAsync(request);
        }
        
        public System.Threading.Tasks.Task<TimbradoService.VerificarXMLResponse> VerificarXMLAsync(string Usuario, string Password, string StrXml)
        {
            TimbradoService.VerificarXMLRequest inValue = new TimbradoService.VerificarXMLRequest();
            inValue.Body = new TimbradoService.VerificarXMLRequestBody();
            inValue.Body.Usuario = Usuario;
            inValue.Body.Password = Password;
            inValue.Body.StrXml = StrXml;
            return ((TimbradoService.TimbradoSoap)(this)).VerificarXMLAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TimbradoService.TimbrarCPResponse> TimbradoService.TimbradoSoap.TimbrarCPAsync(TimbradoService.TimbrarCPRequest request)
        {
            return base.Channel.TimbrarCPAsync(request);
        }
        
        public System.Threading.Tasks.Task<TimbradoService.TimbrarCPResponse> TimbrarCPAsync(string Usuario, string Password, string Cadena)
        {
            TimbradoService.TimbrarCPRequest inValue = new TimbradoService.TimbrarCPRequest();
            inValue.Body = new TimbradoService.TimbrarCPRequestBody();
            inValue.Body.Usuario = Usuario;
            inValue.Body.Password = Password;
            inValue.Body.Cadena = Cadena;
            return ((TimbradoService.TimbradoSoap)(this)).TimbrarCPAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TimbradoService.TimbrarN2Response> TimbradoService.TimbradoSoap.TimbrarN2Async(TimbradoService.TimbrarN2Request request)
        {
            return base.Channel.TimbrarN2Async(request);
        }
        
        public System.Threading.Tasks.Task<TimbradoService.TimbrarN2Response> TimbrarN2Async(string Usuario, string Password, string Cadena)
        {
            TimbradoService.TimbrarN2Request inValue = new TimbradoService.TimbrarN2Request();
            inValue.Body = new TimbradoService.TimbrarN2RequestBody();
            inValue.Body.Usuario = Usuario;
            inValue.Body.Password = Password;
            inValue.Body.Cadena = Cadena;
            return ((TimbradoService.TimbradoSoap)(this)).TimbrarN2Async(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.TimbradoSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.TimbradoSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.TimbradoSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://ws.urbansa.com/app/timbrado.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.TimbradoSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://ws.urbansa.com/app/timbrado.asmx");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            TimbradoSoap,
            
            TimbradoSoap12,
        }
    }
}
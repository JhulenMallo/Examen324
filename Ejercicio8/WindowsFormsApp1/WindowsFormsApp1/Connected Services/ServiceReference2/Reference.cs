//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference2 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GET", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GET();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GET", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GETAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INSERT", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string INSERT(int ci, string nombre, string fecha, string depto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INSERT", ReplyAction="*")]
        System.Threading.Tasks.Task<string> INSERTAsync(int ci, string nombre, string fecha, string depto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UPDATE", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string UPDATE(int id, int ci, string nombre, string fecha, string depto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UPDATE", ReplyAction="*")]
        System.Threading.Tasks.Task<string> UPDATEAsync(int id, int ci, string nombre, string fecha, string depto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DELETE", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string DELETE(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DELETE", ReplyAction="*")]
        System.Threading.Tasks.Task<string> DELETEAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WindowsFormsApp1.ServiceReference2.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference2.WebService1Soap>, WindowsFormsApp1.ServiceReference2.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataSet GET() {
            return base.Channel.GET();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GETAsync() {
            return base.Channel.GETAsync();
        }
        
        public string INSERT(int ci, string nombre, string fecha, string depto) {
            return base.Channel.INSERT(ci, nombre, fecha, depto);
        }
        
        public System.Threading.Tasks.Task<string> INSERTAsync(int ci, string nombre, string fecha, string depto) {
            return base.Channel.INSERTAsync(ci, nombre, fecha, depto);
        }
        
        public string UPDATE(int id, int ci, string nombre, string fecha, string depto) {
            return base.Channel.UPDATE(id, ci, nombre, fecha, depto);
        }
        
        public System.Threading.Tasks.Task<string> UPDATEAsync(int id, int ci, string nombre, string fecha, string depto) {
            return base.Channel.UPDATEAsync(id, ci, nombre, fecha, depto);
        }
        
        public string DELETE(int id) {
            return base.Channel.DELETE(id);
        }
        
        public System.Threading.Tasks.Task<string> DELETEAsync(int id) {
            return base.Channel.DELETEAsync(id);
        }
    }
}

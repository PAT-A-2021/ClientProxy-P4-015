﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientProxy_P4_20190140015.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Koordinat", Namespace="http://schemas.datacontract.org/2004/07/FirstWCFService_015")]
    [System.SerializableAttribute()]
    public partial class Koordinat : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int xField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int yField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int x {
            get {
                return this.xField;
            }
            set {
                if ((this.xField.Equals(value) != true)) {
                    this.xField = value;
                    this.RaisePropertyChanged("x");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int y {
            get {
                return this.yField;
            }
            set {
                if ((this.yField.Equals(value) != true)) {
                    this.yField = value;
                    this.RaisePropertyChanged("y");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMatematika")]
    public interface IMatematika {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Tambah", ReplyAction="http://tempuri.org/IMatematika/TambahResponse")]
        int Tambah(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Tambah", ReplyAction="http://tempuri.org/IMatematika/TambahResponse")]
        System.Threading.Tasks.Task<int> TambahAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kurang", ReplyAction="http://tempuri.org/IMatematika/KurangResponse")]
        int Kurang(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kurang", ReplyAction="http://tempuri.org/IMatematika/KurangResponse")]
        System.Threading.Tasks.Task<int> KurangAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kali", ReplyAction="http://tempuri.org/IMatematika/KaliResponse")]
        int Kali(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kali", ReplyAction="http://tempuri.org/IMatematika/KaliResponse")]
        System.Threading.Tasks.Task<int> KaliAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Bagi", ReplyAction="http://tempuri.org/IMatematika/BagiResponse")]
        int Bagi(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Bagi", ReplyAction="http://tempuri.org/IMatematika/BagiResponse")]
        System.Threading.Tasks.Task<int> BagiAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/tKoordinat", ReplyAction="http://tempuri.org/IMatematika/tKoordinatResponse")]
        ClientProxy_P4_20190140015.ServiceReference1.Koordinat tKoordinat(ClientProxy_P4_20190140015.ServiceReference1.Koordinat a, ClientProxy_P4_20190140015.ServiceReference1.Koordinat b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/tKoordinat", ReplyAction="http://tempuri.org/IMatematika/tKoordinatResponse")]
        System.Threading.Tasks.Task<ClientProxy_P4_20190140015.ServiceReference1.Koordinat> tKoordinatAsync(ClientProxy_P4_20190140015.ServiceReference1.Koordinat a, ClientProxy_P4_20190140015.ServiceReference1.Koordinat b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMatematikaChannel : ClientProxy_P4_20190140015.ServiceReference1.IMatematika, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MatematikaClient : System.ServiceModel.ClientBase<ClientProxy_P4_20190140015.ServiceReference1.IMatematika>, ClientProxy_P4_20190140015.ServiceReference1.IMatematika {
        
        public MatematikaClient() {
        }
        
        public MatematikaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MatematikaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatematikaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatematikaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Tambah(int a, int b) {
            return base.Channel.Tambah(a, b);
        }
        
        public System.Threading.Tasks.Task<int> TambahAsync(int a, int b) {
            return base.Channel.TambahAsync(a, b);
        }
        
        public int Kurang(int a, int b) {
            return base.Channel.Kurang(a, b);
        }
        
        public System.Threading.Tasks.Task<int> KurangAsync(int a, int b) {
            return base.Channel.KurangAsync(a, b);
        }
        
        public int Kali(int a, int b) {
            return base.Channel.Kali(a, b);
        }
        
        public System.Threading.Tasks.Task<int> KaliAsync(int a, int b) {
            return base.Channel.KaliAsync(a, b);
        }
        
        public int Bagi(int a, int b) {
            return base.Channel.Bagi(a, b);
        }
        
        public System.Threading.Tasks.Task<int> BagiAsync(int a, int b) {
            return base.Channel.BagiAsync(a, b);
        }
        
        public ClientProxy_P4_20190140015.ServiceReference1.Koordinat tKoordinat(ClientProxy_P4_20190140015.ServiceReference1.Koordinat a, ClientProxy_P4_20190140015.ServiceReference1.Koordinat b) {
            return base.Channel.tKoordinat(a, b);
        }
        
        public System.Threading.Tasks.Task<ClientProxy_P4_20190140015.ServiceReference1.Koordinat> tKoordinatAsync(ClientProxy_P4_20190140015.ServiceReference1.Koordinat a, ClientProxy_P4_20190140015.ServiceReference1.Koordinat b) {
            return base.Channel.tKoordinatAsync(a, b);
        }
    }
}

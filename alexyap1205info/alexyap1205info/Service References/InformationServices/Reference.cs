﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace alexyap1205info.InformationServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Education", Namespace="http://schemas.datacontract.org/2004/07/ProfileInformationService")]
    [System.SerializableAttribute()]
    public partial class Education : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InstitutionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SummaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearCompletedField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Institution {
            get {
                return this.InstitutionField;
            }
            set {
                if ((object.ReferenceEquals(this.InstitutionField, value) != true)) {
                    this.InstitutionField = value;
                    this.RaisePropertyChanged("Institution");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Summary {
            get {
                return this.SummaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SummaryField, value) != true)) {
                    this.SummaryField = value;
                    this.RaisePropertyChanged("Summary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int YearCompleted {
            get {
                return this.YearCompletedField;
            }
            set {
                if ((this.YearCompletedField.Equals(value) != true)) {
                    this.YearCompletedField = value;
                    this.RaisePropertyChanged("YearCompleted");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InformationServices.IInformationService")]
    public interface IInformationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformationService/GetEducations", ReplyAction="http://tempuri.org/IInformationService/GetEducationsResponse")]
        alexyap1205info.InformationServices.Education[] GetEducations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInformationService/GetEducations", ReplyAction="http://tempuri.org/IInformationService/GetEducationsResponse")]
        System.Threading.Tasks.Task<alexyap1205info.InformationServices.Education[]> GetEducationsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInformationServiceChannel : alexyap1205info.InformationServices.IInformationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InformationServiceClient : System.ServiceModel.ClientBase<alexyap1205info.InformationServices.IInformationService>, alexyap1205info.InformationServices.IInformationService {
        
        public InformationServiceClient() {
        }
        
        public InformationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InformationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InformationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InformationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public alexyap1205info.InformationServices.Education[] GetEducations() {
            return base.Channel.GetEducations();
        }
        
        public System.Threading.Tasks.Task<alexyap1205info.InformationServices.Education[]> GetEducationsAsync() {
            return base.Channel.GetEducationsAsync();
        }
    }
}
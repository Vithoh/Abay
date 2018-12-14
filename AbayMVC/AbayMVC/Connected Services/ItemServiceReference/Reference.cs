﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AbayMVC.ItemServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/Entities")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AbayMVC.ItemServiceReference.ItemCategory CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double InitialPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AbayMVC.ItemServiceReference.Bid[] OldBidsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AbayMVC.ItemServiceReference.User SellerUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AbayMVC.ItemServiceReference.Bid WinningBidField;
        
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
        public AbayMVC.ItemServiceReference.ItemCategory Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndDate {
            get {
                return this.EndDateField;
            }
            set {
                if ((this.EndDateField.Equals(value) != true)) {
                    this.EndDateField = value;
                    this.RaisePropertyChanged("EndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double InitialPrice {
            get {
                return this.InitialPriceField;
            }
            set {
                if ((this.InitialPriceField.Equals(value) != true)) {
                    this.InitialPriceField = value;
                    this.RaisePropertyChanged("InitialPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AbayMVC.ItemServiceReference.Bid[] OldBids {
            get {
                return this.OldBidsField;
            }
            set {
                if ((object.ReferenceEquals(this.OldBidsField, value) != true)) {
                    this.OldBidsField = value;
                    this.RaisePropertyChanged("OldBids");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AbayMVC.ItemServiceReference.User SellerUser {
            get {
                return this.SellerUserField;
            }
            set {
                if ((object.ReferenceEquals(this.SellerUserField, value) != true)) {
                    this.SellerUserField = value;
                    this.RaisePropertyChanged("SellerUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int State {
            get {
                return this.StateField;
            }
            set {
                if ((this.StateField.Equals(value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AbayMVC.ItemServiceReference.Bid WinningBid {
            get {
                return this.WinningBidField;
            }
            set {
                if ((object.ReferenceEquals(this.WinningBidField, value) != true)) {
                    this.WinningBidField = value;
                    this.RaisePropertyChanged("WinningBid");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemCategory", Namespace="http://schemas.datacontract.org/2004/07/Entities")]
    [System.SerializableAttribute()]
    public partial class ItemCategory : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Entities")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AbayMVC.ItemServiceReference.Token LoginTokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public bool Admin {
            get {
                return this.AdminField;
            }
            set {
                if ((this.AdminField.Equals(value) != true)) {
                    this.AdminField = value;
                    this.RaisePropertyChanged("Admin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AbayMVC.ItemServiceReference.Token LoginToken {
            get {
                return this.LoginTokenField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginTokenField, value) != true)) {
                    this.LoginTokenField = value;
                    this.RaisePropertyChanged("LoginToken");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bid", Namespace="http://schemas.datacontract.org/2004/07/Entities")]
    [System.SerializableAttribute()]
    public partial class Bid : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BuyerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ItemIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimestampField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool WinningField;
        
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
        public double Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BuyerName {
            get {
                return this.BuyerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BuyerNameField, value) != true)) {
                    this.BuyerNameField = value;
                    this.RaisePropertyChanged("BuyerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ItemId {
            get {
                return this.ItemIdField;
            }
            set {
                if ((this.ItemIdField.Equals(value) != true)) {
                    this.ItemIdField = value;
                    this.RaisePropertyChanged("ItemId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Timestamp {
            get {
                return this.TimestampField;
            }
            set {
                if ((this.TimestampField.Equals(value) != true)) {
                    this.TimestampField = value;
                    this.RaisePropertyChanged("Timestamp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Winning {
            get {
                return this.WinningField;
            }
            set {
                if ((this.WinningField.Equals(value) != true)) {
                    this.WinningField = value;
                    this.RaisePropertyChanged("Winning");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Token", Namespace="http://schemas.datacontract.org/2004/07/Entities")]
    [System.SerializableAttribute()]
    public partial class Token : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecureTokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public System.DateTime CreateDate {
            get {
                return this.CreateDateField;
            }
            set {
                if ((this.CreateDateField.Equals(value) != true)) {
                    this.CreateDateField = value;
                    this.RaisePropertyChanged("CreateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecureToken {
            get {
                return this.SecureTokenField;
            }
            set {
                if ((object.ReferenceEquals(this.SecureTokenField, value) != true)) {
                    this.SecureTokenField = value;
                    this.RaisePropertyChanged("SecureToken");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ItemServiceReference.IItemService")]
    public interface IItemService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/CreateItem", ReplyAction="http://tempuri.org/IItemService/CreateItemResponse")]
        int CreateItem(string name, string description, double initialPrice, int CategoryId, string token, int duration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/CreateItem", ReplyAction="http://tempuri.org/IItemService/CreateItemResponse")]
        System.Threading.Tasks.Task<int> CreateItemAsync(string name, string description, double initialPrice, int CategoryId, string token, int duration);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/DeleteItem", ReplyAction="http://tempuri.org/IItemService/DeleteItemResponse")]
        bool DeleteItem(int id, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/DeleteItem", ReplyAction="http://tempuri.org/IItemService/DeleteItemResponse")]
        System.Threading.Tasks.Task<bool> DeleteItemAsync(int id, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/UpdateItem", ReplyAction="http://tempuri.org/IItemService/UpdateItemResponse")]
        bool UpdateItem(int itemId, string userToken, string name, string description, int catId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/UpdateItem", ReplyAction="http://tempuri.org/IItemService/UpdateItemResponse")]
        System.Threading.Tasks.Task<bool> UpdateItemAsync(int itemId, string userToken, string name, string description, int catId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/SearchItems", ReplyAction="http://tempuri.org/IItemService/SearchItemsResponse")]
        AbayMVC.ItemServiceReference.Item[] SearchItems(string value, int categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/SearchItems", ReplyAction="http://tempuri.org/IItemService/SearchItemsResponse")]
        System.Threading.Tasks.Task<AbayMVC.ItemServiceReference.Item[]> SearchItemsAsync(string value, int categoryId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetItemById", ReplyAction="http://tempuri.org/IItemService/GetItemByIdResponse")]
        AbayMVC.ItemServiceReference.Item GetItemById(int itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetItemById", ReplyAction="http://tempuri.org/IItemService/GetItemByIdResponse")]
        System.Threading.Tasks.Task<AbayMVC.ItemServiceReference.Item> GetItemByIdAsync(int itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetAllCategories", ReplyAction="http://tempuri.org/IItemService/GetAllCategoriesResponse")]
        AbayMVC.ItemServiceReference.ItemCategory[] GetAllCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetAllCategories", ReplyAction="http://tempuri.org/IItemService/GetAllCategoriesResponse")]
        System.Threading.Tasks.Task<AbayMVC.ItemServiceReference.ItemCategory[]> GetAllCategoriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetAllActiveItemsByCategory", ReplyAction="http://tempuri.org/IItemService/GetAllActiveItemsByCategoryResponse")]
        AbayMVC.ItemServiceReference.Item[] GetAllActiveItemsByCategory(int catId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetAllActiveItemsByCategory", ReplyAction="http://tempuri.org/IItemService/GetAllActiveItemsByCategoryResponse")]
        System.Threading.Tasks.Task<AbayMVC.ItemServiceReference.Item[]> GetAllActiveItemsByCategoryAsync(int catId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetAllItems", ReplyAction="http://tempuri.org/IItemService/GetAllItemsResponse")]
        AbayMVC.ItemServiceReference.Item[] GetAllItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetAllItems", ReplyAction="http://tempuri.org/IItemService/GetAllItemsResponse")]
        System.Threading.Tasks.Task<AbayMVC.ItemServiceReference.Item[]> GetAllItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetAllBidsByItem", ReplyAction="http://tempuri.org/IItemService/GetAllBidsByItemResponse")]
        AbayMVC.ItemServiceReference.Bid[] GetAllBidsByItem(int itemId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetAllBidsByItem", ReplyAction="http://tempuri.org/IItemService/GetAllBidsByItemResponse")]
        System.Threading.Tasks.Task<AbayMVC.ItemServiceReference.Bid[]> GetAllBidsByItemAsync(int itemId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IItemServiceChannel : AbayMVC.ItemServiceReference.IItemService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ItemServiceClient : System.ServiceModel.ClientBase<AbayMVC.ItemServiceReference.IItemService>, AbayMVC.ItemServiceReference.IItemService {
        
        public ItemServiceClient() {
        }
        
        public ItemServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ItemServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItemServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItemServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int CreateItem(string name, string description, double initialPrice, int CategoryId, string token, int duration) {
            return base.Channel.CreateItem(name, description, initialPrice, CategoryId, token, duration);
        }
        
        public System.Threading.Tasks.Task<int> CreateItemAsync(string name, string description, double initialPrice, int CategoryId, string token, int duration) {
            return base.Channel.CreateItemAsync(name, description, initialPrice, CategoryId, token, duration);
        }
        
        public bool DeleteItem(int id, string token) {
            return base.Channel.DeleteItem(id, token);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteItemAsync(int id, string token) {
            return base.Channel.DeleteItemAsync(id, token);
        }
        
        public bool UpdateItem(int itemId, string userToken, string name, string description, int catId) {
            return base.Channel.UpdateItem(itemId, userToken, name, description, catId);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateItemAsync(int itemId, string userToken, string name, string description, int catId) {
            return base.Channel.UpdateItemAsync(itemId, userToken, name, description, catId);
        }
        
        public AbayMVC.ItemServiceReference.Item[] SearchItems(string value, int categoryId) {
            return base.Channel.SearchItems(value, categoryId);
        }
        
        public System.Threading.Tasks.Task<AbayMVC.ItemServiceReference.Item[]> SearchItemsAsync(string value, int categoryId) {
            return base.Channel.SearchItemsAsync(value, categoryId);
        }
        
        public AbayMVC.ItemServiceReference.Item GetItemById(int itemId) {
            return base.Channel.GetItemById(itemId);
        }
        
        public System.Threading.Tasks.Task<AbayMVC.ItemServiceReference.Item> GetItemByIdAsync(int itemId) {
            return base.Channel.GetItemByIdAsync(itemId);
        }
        
        public AbayMVC.ItemServiceReference.ItemCategory[] GetAllCategories() {
            return base.Channel.GetAllCategories();
        }
        
        public System.Threading.Tasks.Task<AbayMVC.ItemServiceReference.ItemCategory[]> GetAllCategoriesAsync() {
            return base.Channel.GetAllCategoriesAsync();
        }
        
        public AbayMVC.ItemServiceReference.Item[] GetAllActiveItemsByCategory(int catId) {
            return base.Channel.GetAllActiveItemsByCategory(catId);
        }
        
        public System.Threading.Tasks.Task<AbayMVC.ItemServiceReference.Item[]> GetAllActiveItemsByCategoryAsync(int catId) {
            return base.Channel.GetAllActiveItemsByCategoryAsync(catId);
        }
        
        public AbayMVC.ItemServiceReference.Item[] GetAllItems() {
            return base.Channel.GetAllItems();
        }
        
        public System.Threading.Tasks.Task<AbayMVC.ItemServiceReference.Item[]> GetAllItemsAsync() {
            return base.Channel.GetAllItemsAsync();
        }
        
        public AbayMVC.ItemServiceReference.Bid[] GetAllBidsByItem(int itemId) {
            return base.Channel.GetAllBidsByItem(itemId);
        }
        
        public System.Threading.Tasks.Task<AbayMVC.ItemServiceReference.Bid[]> GetAllBidsByItemAsync(int itemId) {
            return base.Channel.GetAllBidsByItemAsync(itemId);
        }
    }
}

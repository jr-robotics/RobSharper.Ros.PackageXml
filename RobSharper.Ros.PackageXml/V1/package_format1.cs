﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.7.3081.0.
// 
namespace RobSharper.Ros.PackageXml.V1 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class package {
        
        private string nameField;
        
        private string versionField;
        
        private DescriptionType descriptionField;
        
        private PersonWithEmailType[] maintainerField;
        
        private string[] licenseField;
        
        private UrlType[] urlField;
        
        private PersonWithOptionalEmailType[] authorField;
        
        private DependencyType[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        private ExportType exportField;
        
        private string formatField;
        
        public package() {
            this.formatField = "1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DescriptionType description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("maintainer", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PersonWithEmailType[] maintainer {
            get {
                return this.maintainerField;
            }
            set {
                this.maintainerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("license", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="token")]
        public string[] license {
            get {
                return this.licenseField;
            }
            set {
                this.licenseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("url", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UrlType[] url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("author", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PersonWithOptionalEmailType[] author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("build_depend", typeof(DependencyType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("buildtool_depend", typeof(DependencyType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("conflict", typeof(DependencyType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("replace", typeof(DependencyType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("run_depend", typeof(DependencyType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("test_depend", typeof(DependencyType), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public DependencyType[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ExportType export {
            get {
                return this.exportField;
            }
            set {
                this.exportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DescriptionType {
        
        private System.Xml.XmlNode[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ExportType {
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DependencyType {
        
        private string version_ltField;
        
        private string version_lteField;
        
        private string version_eqField;
        
        private string version_gteField;
        
        private string version_gtField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string version_lt {
            get {
                return this.version_ltField;
            }
            set {
                this.version_ltField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string version_lte {
            get {
                return this.version_lteField;
            }
            set {
                this.version_lteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string version_eq {
            get {
                return this.version_eqField;
            }
            set {
                this.version_eqField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string version_gte {
            get {
                return this.version_gteField;
            }
            set {
                this.version_gteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string version_gt {
            get {
                return this.version_gtField;
            }
            set {
                this.version_gtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="token")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PersonWithOptionalEmailType {
        
        private string emailField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="token")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UrlType {
        
        private UrlTypeEnum typeField;
        
        private string valueField;
        
        public UrlType() {
            this.typeField = UrlTypeEnum.website;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(UrlTypeEnum.website)]
        public UrlTypeEnum type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="anyURI")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    public enum UrlTypeEnum {
        
        /// <remarks/>
        website,
        
        /// <remarks/>
        bugtracker,
        
        /// <remarks/>
        repository,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PersonWithEmailType {
        
        private string emailField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="token")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        /// <remarks/>
        build_depend,
        
        /// <remarks/>
        buildtool_depend,
        
        /// <remarks/>
        conflict,
        
        /// <remarks/>
        replace,
        
        /// <remarks/>
        run_depend,
        
        /// <remarks/>
        test_depend,
    }
}

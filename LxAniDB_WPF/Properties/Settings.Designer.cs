﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LxAniDB_WPF.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string username {
            get {
                return ((string)(this["username"]));
            }
            set {
                this["username"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string password {
            get {
                return ((string)(this["password"]));
            }
            set {
                this["password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("api.anidb.net")]
        public string remoteServer {
            get {
                return ((string)(this["remoteServer"]));
            }
            set {
                this["remoteServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9000")]
        public int remotePort {
            get {
                return ((int)(this["remotePort"]));
            }
            set {
                this["remotePort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7119")]
        public int localPort {
            get {
                return ((int)(this["localPort"]));
            }
            set {
                this["localPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public int delay {
            get {
                return ((int)(this["delay"]));
            }
            set {
                this["delay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool watchedChecked {
            get {
                return ((bool)(this["watchedChecked"]));
            }
            set {
                this["watchedChecked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool deleteChecked {
            get {
                return ((bool)(this["deleteChecked"]));
            }
            set {
                this["deleteChecked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(PortableSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int selectedState {
            get {
                return ((int)(this["selectedState"]));
            }
            set {
                this["selectedState"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>avi</string>
  <string>mp4</string>
  <string>mkv</string>
  <string>mpg</string>
  <string>wmv</string>
  <string>ogm</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection acceptedExtensions {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["acceptedExtensions"]));
            }
        }
    }
}

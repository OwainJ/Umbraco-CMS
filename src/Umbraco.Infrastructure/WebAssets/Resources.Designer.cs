﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Umbraco.Web.WebAssets {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Umbraco.Infrastructure.WebAssets.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string JsInitialize {
            get {
                return ResourceManager.GetString("JsInitialize", resourceCulture);
            }
        }
        
        internal static string Main {
            get {
                return ResourceManager.GetString("Main", resourceCulture);
            }
        }
        
        internal static string PreviewInitialize {
            get {
                return ResourceManager.GetString("PreviewInitialize", resourceCulture);
            }
        }
        
        internal static string ServerVariables {
            get {
                return ResourceManager.GetString("ServerVariables", resourceCulture);
            }
        }
        
        internal static string TinyMceInitialize {
            get {
                return ResourceManager.GetString("TinyMceInitialize", resourceCulture);
            }
        }
    }
}
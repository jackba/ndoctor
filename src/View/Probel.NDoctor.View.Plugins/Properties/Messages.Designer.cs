﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Probel.NDoctor.View.Plugins.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Probel.NDoctor.View.Plugins.Properties.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The plugin you try to show is deactivated..
        /// </summary>
        internal static string Ex_DeactivatedPluginException {
            get {
                return ResourceManager.GetString("Ex_DeactivatedPluginException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration of the runtime context of nDoctor is invalid.
        /// </summary>
        internal static string Ex_NDoctorConfigurationException {
            get {
                return ResourceManager.GetString("Ex_NDoctorConfigurationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The plugin validator is not set. Please configure a validator for all the plugins.
        /// </summary>
        internal static string Ex_NullPluginValidatorException {
            get {
                return ResourceManager.GetString("Ex_NullPluginValidatorException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration of the plugins is incorrect. Maybe the configuration files are badly written..
        /// </summary>
        internal static string Ex_PluginConfigurationException {
            get {
                return ResourceManager.GetString("Ex_PluginConfigurationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured in a plugins..
        /// </summary>
        internal static string Ex_PluginException {
            get {
                return ResourceManager.GetString("Ex_PluginException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This plugin doesn&apos;t have validation rules..
        /// </summary>
        internal static string Ex_PluginException_NoValidator {
            get {
                return ResourceManager.GetString("Ex_PluginException_NoValidator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than one plugin that override the default start page are loaded. Only one can be activated..
        /// </summary>
        internal static string Ex_PluginException_SeveralStartPages {
            get {
                return ResourceManager.GetString("Ex_PluginException_SeveralStartPages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directory of the plugin &apos;{0}&apos; doesn&apos;t exist.
        ///Path: {1}.
        /// </summary>
        internal static string Ex_PluginNotFoundException {
            get {
                return ResourceManager.GetString("Ex_PluginNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The plugins aren&apos;t loaded in memory. Please execute the plugin loader before..
        /// </summary>
        internal static string Ex_PluginNotLoadedException {
            get {
                return ResourceManager.GetString("Ex_PluginNotLoadedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The data context of the item is not at the expected type..
        /// </summary>
        internal static string Ex_WrongDataContextException {
            get {
                return ResourceManager.GetString("Ex_WrongDataContextException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are not granted to execute this feature.
        /// </summary>
        internal static string Msg_ErrorAuthorisation {
            get {
                return ResourceManager.GetString("Msg_ErrorAuthorisation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Managers.
        /// </summary>
        internal static string Msg_GroupManager {
            get {
                return ResourceManager.GetString("Msg_GroupManager", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter &apos;{0}&apos; is not set in the configuration file. Please set it up..
        /// </summary>
        internal static string Msg_MissingParameterInConfiguration {
            get {
                return ResourceManager.GetString("Msg_MissingParameterInConfiguration", resourceCulture);
            }
        }
    }
}

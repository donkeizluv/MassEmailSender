﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MassEmailSender.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MassEmailSender.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon birdy {
            get {
                object obj = ResourceManager.GetObject("birdy", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;head&gt;&lt;meta http-equiv=Content-Type content=&quot;text/html; charset=unicode&quot;&gt;&lt;/head&gt;.
        /// </summary>
        internal static string HeadHTML {
            get {
                return ResourceManager.GetString("HeadHTML", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;td style=&quot;border:1px solid black; padding: 0in 6pt 0in 6pt;height:.5in&apos;&quot;&gt;.
        /// </summary>
        internal static string OpenCellHTML {
            get {
                return ResourceManager.GetString("OpenCellHTML", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;html xmlns:v=&quot;urn:schemas-microsoft-com:vml&quot;
        ///xmlns:o=&quot;urn:schemas-microsoft-com:office:office&quot;
        ///xmlns:w=&quot;urn:schemas-microsoft-com:office:word&quot;
        ///xmlns:m=&quot;http://schemas.microsoft.com/office/2004/12/omml&quot;
        ///xmlns=&quot;http://www.w3.org/TR/REC-html40&quot;&gt;.
        /// </summary>
        internal static string OpenHTML {
            get {
                return ResourceManager.GetString("OpenHTML", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;table style=&quot;border:1px solid black;border-collapse:collapse;&quot;&gt;.
        /// </summary>
        internal static string OpenTableHTML {
            get {
                return ResourceManager.GetString("OpenTableHTML", resourceCulture);
            }
        }
    }
}

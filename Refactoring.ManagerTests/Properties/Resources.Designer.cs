﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Refactoring.ManagerTests.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Refactoring.ManagerTests.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;H1&gt;Rental Record for &lt;EM&gt;Gern Blansten&lt;/EM&gt;&lt;/H1&gt;&lt;P&gt;
        ///
        ///Jaws 2&lt;BR&gt;
        ///Star Wars 3.5&lt;BR&gt;
        ///Toy Story 3&lt;BR&gt;
        ///Wall-E 1.5&lt;BR&gt;
        ///Thor 3&lt;BR&gt;
        ///Superman 6&lt;BR&gt;
        ///
        ///&lt;P&gt;Amount owed is &lt;EM&gt;19&lt;/EM&gt;&lt;P&gt;
        ///
        ///You have earned &lt;EM&gt;7&lt;/EM&gt; frequent renter points.
        /// </summary>
        internal static string SampleHtmlStatement {
            get {
                return ResourceManager.GetString("SampleHtmlStatement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rental Record for Gern Blansten
        ///
        ///Jaws 2
        ///Star Wars 3.5
        ///Toy Story 3
        ///Wall-E 1.5
        ///Thor 3
        ///Superman 6
        ///
        ///Amount owed is 19
        ///
        ///You have earned 7 frequent renter points.
        /// </summary>
        internal static string SampleStatement {
            get {
                return ResourceManager.GetString("SampleStatement", resourceCulture);
            }
        }
    }
}

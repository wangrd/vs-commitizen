﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vs_commitizen.vs {
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
    internal class VSPackage {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal VSPackage() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("vs_commitizen.vs.VSPackage", typeof(VSPackage).Assembly);
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
        ///   Looks up a localized string similar to Commit.
        /// </summary>
        internal static string ButtonCommit {
            get {
                return ResourceManager.GetString("ButtonCommit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Proceed.
        /// </summary>
        internal static string ButtonProceed {
            get {
                return ResourceManager.GetString("ButtonProceed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Git_icon_svg {
            get {
                object obj = ResourceManager.GetObject("Git_icon_svg", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provide a longer description of the change (optional).
        /// </summary>
        internal static string HintBody {
            get {
                return ResourceManager.GetString("HintBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List any breaking changes (optional).
        /// </summary>
        internal static string HintBreakingChanges {
            get {
                return ResourceManager.GetString("HintBreakingChanges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List any issues affected by this change (optional). E.g.: &apos;fix #123&apos;, &apos;re #123&apos;.
        /// </summary>
        internal static string HintIssues {
            get {
                return ResourceManager.GetString("HintIssues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Denote the scope of this change (optional).
        /// </summary>
        internal static string HintScope {
            get {
                return ResourceManager.GetString("HintScope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Write a short, imperative tense description of the change.
        /// </summary>
        internal static string HintSubject {
            get {
                return ResourceManager.GetString("HintSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Body :.
        /// </summary>
        internal static string LabelBody {
            get {
                return ResourceManager.GetString("LabelBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Breaking changes :.
        /// </summary>
        internal static string LabelBreakingChanges {
            get {
                return ResourceManager.GetString("LabelBreakingChanges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type of changes :.
        /// </summary>
        internal static string LabelCommitType {
            get {
                return ResourceManager.GetString("LabelCommitType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Closes :.
        /// </summary>
        internal static string LabelIssues {
            get {
                return ResourceManager.GetString("LabelIssues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scope :.
        /// </summary>
        internal static string LabelScope {
            get {
                return ResourceManager.GetString("LabelScope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subject :.
        /// </summary>
        internal static string LabelSubject {
            get {
                return ResourceManager.GetString("LabelSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Proceed to &apos;Changes&apos; view and commit.
        /// </summary>
        internal static string TooltipCommit {
            get {
                return ResourceManager.GetString("TooltipCommit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Proceed to &apos;Changes&apos; view.
        /// </summary>
        internal static string TooltipProceed {
            get {
                return ResourceManager.GetString("TooltipProceed", resourceCulture);
            }
        }
    }
}

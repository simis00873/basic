﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearningBasic {
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
    internal class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LearningBasic.ErrorMessages", typeof(ErrorMessages).Assembly);
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
        ///   Looks up a localized string similar to You must specify at least one variable in the INPUT statement.
        /// </summary>
        internal static string EmptyVariableListInInput {
            get {
                return ResourceManager.GetString("EmptyVariableListInInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can&apos;t specify a semicolon in the PRINT statement without parameters.
        /// </summary>
        internal static string InvalidSemicolonInPrint {
            get {
                return ResourceManager.GetString("InvalidSemicolonInPrint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid list of variables in the INPUT statement.
        /// </summary>
        internal static string InvalidVariableListInInput {
            get {
                return ResourceManager.GetString("InvalidVariableListInInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The line number must belong to the range of 1 to 99999.
        /// </summary>
        internal static string LineNumberOutOfRange {
            get {
                return ResourceManager.GetString("LineNumberOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing array&apos;s dimensions and bounds.
        /// </summary>
        internal static string MissingArray {
            get {
                return ResourceManager.GetString("MissingArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing assignment.
        /// </summary>
        internal static string MissingAssignment {
            get {
                return ResourceManager.GetString("MissingAssignment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing condition.
        /// </summary>
        internal static string MissingCondition {
            get {
                return ResourceManager.GetString("MissingCondition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing expression.
        /// </summary>
        internal static string MissingExpression {
            get {
                return ResourceManager.GetString("MissingExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing variable or reference to an array element.
        /// </summary>
        internal static string MissingLValue {
            get {
                return ResourceManager.GetString("MissingLValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing relation operator =, &lt;&gt;, &lt;, &gt;, &lt;=, &gt;=.
        /// </summary>
        internal static string MissingRelationOperator {
            get {
                return ResourceManager.GetString("MissingRelationOperator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing statement.
        /// </summary>
        internal static string MissingStatement {
            get {
                return ResourceManager.GetString("MissingStatement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected character &apos;{0}&apos;.
        /// </summary>
        internal static string UnexpectedCharacter {
            get {
                return ResourceManager.GetString("UnexpectedCharacter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected end of file.
        /// </summary>
        internal static string UnexpectedEndOfFile {
            get {
                return ResourceManager.GetString("UnexpectedEndOfFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Token &apos;{0}&apos; is expected, token &apos;{1}&apos; is read actually.
        /// </summary>
        internal static string UnexpectedToken {
            get {
                return ResourceManager.GetString("UnexpectedToken", resourceCulture);
            }
        }
    }
}

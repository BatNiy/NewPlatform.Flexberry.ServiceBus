﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ServiceBus.IntegratedTests {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NewPlatform.Flexberry.ServiceBus.IntegratedTests.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to /*
        ///
        ///Create tables.
        ///Create user Administrator (login=admin, password=admin).
        ///Create permissions for Administrator.
        ///
        ///*/
        ///
        ///CREATE TABLE [SubStatisticsMonitor] (
        ///
        ///	 [primaryKey] UNIQUEIDENTIFIER  NOT NULL,
        ///
        ///	 [Код] INT  NOT NULL,
        ///
        ///	 [Категория] VARCHAR(255)  NULL,
        ///
        ///	 [Наименование] VARCHAR(255)  NULL,
        ///
        ///	 [CreateTime] DATETIME  NULL,
        ///
        ///	 [Creator] VARCHAR(255)  NULL,
        ///
        ///	 [EditTime] DATETIME  NULL,
        ///
        ///	 [Editor] VARCHAR(255)  NULL,
        ///
        ///	 [Подписка] UNIQUEIDENTIFIER  NOT NULL,
        ///
        ///	 [StatisticsMonitor] UNIQUEIDENTIFIER  NOT  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MssqlScript {
            get {
                return ResourceManager.GetString("MssqlScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*
        ///
        ///Create tables.
        ///Create user Administrator (login=admin, password=admin).
        ///Create permissions for Administrator.
        ///
        ///*/
        ///
        ///CREATE TABLE SubStatisticsMonitor (
        ///
        /// primaryKey UUID NOT NULL,
        ///
        /// Код INT NOT NULL,
        ///
        /// Категория VARCHAR(255) NULL,
        ///
        /// Наименование VARCHAR(255) NULL,
        ///
        /// CreateTime TIMESTAMP(3) NULL,
        ///
        /// Creator VARCHAR(255) NULL,
        ///
        /// EditTime TIMESTAMP(3) NULL,
        ///
        /// Editor VARCHAR(255) NULL,
        ///
        /// Подписка UUID NOT NULL,
        ///
        /// StatisticsMonitor UUID NOT NULL,
        ///
        /// PRIMARY KEY (primaryKey));
        ///
        ///
        ///CREATE TABLE Шина (
        ///
        /// primaryKey  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PostgresScript {
            get {
                return ResourceManager.GetString("PostgresScript", resourceCulture);
            }
        }
    }
}

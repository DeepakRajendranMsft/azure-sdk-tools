﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.DataFactories.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.DataFactories.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to The data factory object provided is invalid. Use Get-AzureDataFactory to retrieve a specific data factory object, or use New-AzureDataFactory to create a new data factory object..
        /// </summary>
        internal static string DataFactoryArgumentInvalid {
            get {
                return ResourceManager.GetString("DataFactoryArgumentInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /// <summary>
        ///   Looks up a localized string similar to A gateway with the name {0} already exsits in the data factory {1}. 
        ///Continuing execution may overwrite the exisiting one. 
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string DataFactoryGatewayExists
        {
            get
            {
                return ResourceManager.GetString("DataFactoryGatewayExists", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the gateway &apos;{0}&apos; in the data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string DataFactoryGatewayConfirmationMessage
        {
            get
            {
                return ResourceManager.GetString("DataFactoryGatewayConfirmationMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Removing the gateway &apos;{0}&apos; in the data factory &apos;{1}&apos;..
        /// </summary>
        internal static string DataFactoryGatewayRemoving
        {
            get
            {
                return ResourceManager.GetString("DataFactoryGatewayRemoving", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove data factory &apos;{0}&apos; in resource group &apos;{1}&apos;?.
        /// </summary>
        internal static string DataFactoryConfirmationMessage {
            get {
                return ResourceManager.GetString("DataFactoryConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating data factory &apos;{0}&apos; in resource group &apos;{1}&apos;..
        /// </summary>
        internal static string DataFactoryCreating {
            get {
                return ResourceManager.GetString("DataFactoryCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A data factory with the name {0} in the resource group {1} exists. 
        ///Continuing execution may overwrite the exisiting one. 
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string DataFactoryExists {
            get {
                return ResourceManager.GetString("DataFactoryExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data factory &apos;{0}&apos; does not exist in the resource group &apos;{1}&apos;..
        /// </summary>
        internal static string DataFactoryNotFound {
            get {
                return ResourceManager.GetString("DataFactoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing data factory &apos;{0}&apos; in resource group &apos;{1}&apos;..
        /// </summary>
        internal static string DataFactoryRemoving {
            get {
                return ResourceManager.GetString("DataFactoryRemoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument set for download method is incomplete..
        /// </summary>
        internal static string DownloadCredentialsNull {
            get {
                return ResourceManager.GetString("DownloadCredentialsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Download failed. Please check if you have write permission to the path {0} or the url {1} is valid. .
        /// </summary>
        internal static string DownloadFailed {
            get {
                return ResourceManager.GetString("DownloadFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Download of the log is completed. Please find it in the directory {0}..
        /// </summary>
        internal static string DownloadLogCompleted {
            get {
                return ResourceManager.GetString("DownloadLogCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} name provided using -Name switch: &apos;{1}&apos; in cmdlet doesn&apos;t match with {0} name: &apos;{2}&apos; in JSON file. {0} will be created with name: &apos;{1}&apos;.
        /// </summary>
        internal static string ExtractedNameFromJsonMismatchWarning {
            get {
                return ResourceManager.GetString("ExtractedNameFromJsonMismatchWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HTTP Status Code: {0}
        ///Error Code: {1}
        ///Error Message: {2}
        ///Request Id: {3}
        ///Timestamp (Utc):{4}.
        /// </summary>
        internal static string FormattedCloudExceptionMessageTemplate {
            get {
                return ResourceManager.GetString("FormattedCloudExceptionMessageTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove hub &apos;{0}&apos; in data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string HubConfirmationMessage {
            get {
                return ResourceManager.GetString("HubConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating hub &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string HubCreating {
            get {
                return ResourceManager.GetString("HubCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A hub with the name {0} in the data factory {1} exists. 
        ///Continuing execution may overwrite the exisiting one. 
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string HubExists {
            get {
                return ResourceManager.GetString("HubExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hub &apos;{0}&apos; does not exist in the data factory &apos;{1}&apos;..
        /// </summary>
        internal static string HubNotFound {
            get {
                return ResourceManager.GetString("HubNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing hub &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string HubRemoving {
            get {
                return ResourceManager.GetString("HubRemoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove linked service &apos;{0}&apos; in data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string LinkedServiceConfirmationMessage {
            get {
                return ResourceManager.GetString("LinkedServiceConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating linked service &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string LinkedServiceCreating {
            get {
                return ResourceManager.GetString("LinkedServiceCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A linked service with the name {0} in the data factory {1} exists. 
        ///Continuing execution may overwrite the exisiting one. 
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string LinkedServiceExists {
            get {
                return ResourceManager.GetString("LinkedServiceExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Linked service &apos;{0}&apos; does not exist in the data factory &apos;{1}&apos;..
        /// </summary>
        internal static string LinkedServiceNotFound {
            get {
                return ResourceManager.GetString("LinkedServiceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing linked service &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string LinkedServiceRemoving {
            get {
                return ResourceManager.GetString("LinkedServiceRemoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No access to write for the specified directory {0}..
        /// </summary>
        internal static string NoWriteAccessToDirectory {
            get {
                return ResourceManager.GetString("NoWriteAccessToDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove pipeline &apos;{0}&apos; in data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string PipelineConfirmationMessage {
            get {
                return ResourceManager.GetString("PipelineConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating pipeline &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string PipelineCreating {
            get {
                return ResourceManager.GetString("PipelineCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A pipeline with the name {0} in the data factory {1} exists. 
        ///Continuing execution may overwrite the exisiting one. 
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string PipelineExists {
            get {
                return ResourceManager.GetString("PipelineExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pipeline &apos;{0}&apos; does not exist in the data factory &apos;{1}&apos;..
        /// </summary>
        internal static string PipelineNotFound {
            get {
                return ResourceManager.GetString("PipelineNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing pipeline &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string PipelineRemoving {
            get {
                return ResourceManager.GetString("PipelineRemoving", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource group name cannot be null..
        /// </summary>
        internal static string ResourceGroupNameCannotBeEmpty {
            get {
                return ResourceManager.GetString("ResourceGroupNameCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove table &apos;{0}&apos; in data factory &apos;{1}&apos;?.
        /// </summary>
        internal static string TableConfirmationMessage {
            get {
                return ResourceManager.GetString("TableConfirmationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating table &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string TableCreating {
            get {
                return ResourceManager.GetString("TableCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A table with the name {0} in the data factory {1} already exists. 
        ///Continuing execution will overwrite the exisiting one. 
        ///Are you sure you want to continue?.
        /// </summary>
        internal static string TableExists {
            get {
                return ResourceManager.GetString("TableExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Table &apos;{0}&apos; does not exist in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string TableNotFound {
            get {
                return ResourceManager.GetString("TableNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing table &apos;{0}&apos; in data factory &apos;{1}&apos;..
        /// </summary>
        internal static string TableRemoving {
            get {
                return ResourceManager.GetString("TableRemoving", resourceCulture);
            }
        }
    }
}

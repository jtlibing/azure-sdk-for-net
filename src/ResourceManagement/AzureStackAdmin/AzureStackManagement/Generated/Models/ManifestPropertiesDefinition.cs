// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management.Models
{
    /// <summary>
    /// The resource provider registration definition.
    /// </summary>
    public partial class ManifestPropertiesDefinition
    {
        private string _displayName;
        
        /// <summary>
        /// Optional. Gets or sets the display name.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private bool? _enabled;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating whether this resource
        /// provider is enabled.
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }
        
        private string _extensionName;
        
        /// <summary>
        /// Optional. Gets or sets the name of the extension.
        /// </summary>
        public string ExtensionName
        {
            get { return this._extensionName; }
            set { this._extensionName = value; }
        }
        
        private IList<Extension> _extensions;
        
        /// <summary>
        /// Optional. Gets or sets the extensions.
        /// </summary>
        public IList<Extension> Extensions
        {
            get { return this._extensions; }
            set { this._extensions = value; }
        }
        
        private string _extensionUri;
        
        /// <summary>
        /// Optional. Gets or sets the extension endpoint.
        /// </summary>
        public string ExtensionUri
        {
            get { return this._extensionUri; }
            set { this._extensionUri = value; }
        }
        
        private ResourceProviderEndpoint _manifestEndpoint;
        
        /// <summary>
        /// Optional. Gets or sets the manifest endpoint.
        /// </summary>
        public ResourceProviderEndpoint ManifestEndpoint
        {
            get { return this._manifestEndpoint; }
            set { this._manifestEndpoint = value; }
        }
        
        private string _namespace;
        
        /// <summary>
        /// Optional. Gets or sets the namespace.
        /// </summary>
        public string Namespace
        {
            get { return this._namespace; }
            set { this._namespace = value; }
        }
        
        private ResourceProviderAuthorization _providerAuthorization;
        
        /// <summary>
        /// Optional. This configuration advertises to ARM that the resource
        /// provider requires RBAC access on tenant subscriptions to perform
        /// operations on their behalf.
        /// </summary>
        public ResourceProviderAuthorization ProviderAuthorization
        {
            get { return this._providerAuthorization; }
            set { this._providerAuthorization = value; }
        }
        
        private string _providerLocation;
        
        /// <summary>
        /// Optional. Gets or sets the location.
        /// </summary>
        public string ProviderLocation
        {
            get { return this._providerLocation; }
            set { this._providerLocation = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets the provisioning state.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private IList<ResourceType> _resourceTypes;
        
        /// <summary>
        /// Optional. Gets or sets the resource types.
        /// </summary>
        public IList<ResourceType> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }
        
        private ResourceManagerType _routingResourceManagerType;
        
        /// <summary>
        /// Optional. Gets or sets the resource manager type.
        /// </summary>
        public ResourceManagerType RoutingResourceManagerType
        {
            get { return this._routingResourceManagerType; }
            set { this._routingResourceManagerType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ManifestPropertiesDefinition
        /// class.
        /// </summary>
        public ManifestPropertiesDefinition()
        {
            this.Extensions = new LazyList<Extension>();
            this.ResourceTypes = new LazyList<ResourceType>();
        }
    }
}

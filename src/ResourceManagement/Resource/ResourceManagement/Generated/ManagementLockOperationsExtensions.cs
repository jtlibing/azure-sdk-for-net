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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Resources.Models;

namespace Microsoft.Azure.Management.Resources
{
    public static partial class ManagementLockOperationsExtensions
    {
        /// <summary>
        /// Create or update a management lock at the resource group level.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name.
        /// </param>
        /// <param name='lockName'>
        /// Required. The lock name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The management lock parameters.
        /// </param>
        /// <returns>
        /// Management lock information.
        /// </returns>
        public static ManagementLockReturnResult CreateOrUpdateAtResourceGroupLevel(this IManagementLockOperations operations, string resourceGroupName, string lockName, ManagementLockProperties parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagementLockOperations)s).CreateOrUpdateAtResourceGroupLevelAsync(resourceGroupName, lockName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update a management lock at the resource group level.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name.
        /// </param>
        /// <param name='lockName'>
        /// Required. The lock name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The management lock parameters.
        /// </param>
        /// <returns>
        /// Management lock information.
        /// </returns>
        public static Task<ManagementLockReturnResult> CreateOrUpdateAtResourceGroupLevelAsync(this IManagementLockOperations operations, string resourceGroupName, string lockName, ManagementLockProperties parameters)
        {
            return operations.CreateOrUpdateAtResourceGroupLevelAsync(resourceGroupName, lockName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Create or update a management lock at the resource level or any
        /// level below resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <param name='lockName'>
        /// Required. The name of lock.
        /// </param>
        /// <param name='parameters'>
        /// Required. Create or update management lock parameters.
        /// </param>
        /// <returns>
        /// Management lock information.
        /// </returns>
        public static ManagementLockReturnResult CreateOrUpdateAtResourceLevel(this IManagementLockOperations operations, string resourceGroupName, ResourceIdentity identity, string lockName, ManagementLockProperties parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagementLockOperations)s).CreateOrUpdateAtResourceLevelAsync(resourceGroupName, identity, lockName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update a management lock at the resource level or any
        /// level below resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <param name='lockName'>
        /// Required. The name of lock.
        /// </param>
        /// <param name='parameters'>
        /// Required. Create or update management lock parameters.
        /// </param>
        /// <returns>
        /// Management lock information.
        /// </returns>
        public static Task<ManagementLockReturnResult> CreateOrUpdateAtResourceLevelAsync(this IManagementLockOperations operations, string resourceGroupName, ResourceIdentity identity, string lockName, ManagementLockProperties parameters)
        {
            return operations.CreateOrUpdateAtResourceLevelAsync(resourceGroupName, identity, lockName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Create or update a management lock at the subscription level.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='lockName'>
        /// Required. The name of lock.
        /// </param>
        /// <param name='parameters'>
        /// Required. The management lock parameters.
        /// </param>
        /// <returns>
        /// Management lock information.
        /// </returns>
        public static ManagementLockReturnResult CreateOrUpdateAtSubscriptionLevel(this IManagementLockOperations operations, string lockName, ManagementLockProperties parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagementLockOperations)s).CreateOrUpdateAtSubscriptionLevelAsync(lockName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update a management lock at the subscription level.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='lockName'>
        /// Required. The name of lock.
        /// </param>
        /// <param name='parameters'>
        /// Required. The management lock parameters.
        /// </param>
        /// <returns>
        /// Management lock information.
        /// </returns>
        public static Task<ManagementLockReturnResult> CreateOrUpdateAtSubscriptionLevelAsync(this IManagementLockOperations operations, string lockName, ManagementLockProperties parameters)
        {
            return operations.CreateOrUpdateAtSubscriptionLevelAsync(lockName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes the management lock of a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='resourceGroup'>
        /// Required. The resource group names.
        /// </param>
        /// <param name='lockName'>
        /// Required. The name of lock.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse DeleteAtResourceGroupLevel(this IManagementLockOperations operations, string resourceGroup, string lockName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagementLockOperations)s).DeleteAtResourceGroupLevelAsync(resourceGroup, lockName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes the management lock of a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='resourceGroup'>
        /// Required. The resource group names.
        /// </param>
        /// <param name='lockName'>
        /// Required. The name of lock.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAtResourceGroupLevelAsync(this IManagementLockOperations operations, string resourceGroup, string lockName)
        {
            return operations.DeleteAtResourceGroupLevelAsync(resourceGroup, lockName, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes the management lock of a resource or any level below
        /// resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <param name='lockName'>
        /// Required. The name of lock.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse DeleteAtResourceLevel(this IManagementLockOperations operations, string resourceGroupName, ResourceIdentity identity, string lockName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagementLockOperations)s).DeleteAtResourceLevelAsync(resourceGroupName, identity, lockName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes the management lock of a resource or any level below
        /// resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <param name='lockName'>
        /// Required. The name of lock.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAtResourceLevelAsync(this IManagementLockOperations operations, string resourceGroupName, ResourceIdentity identity, string lockName)
        {
            return operations.DeleteAtResourceLevelAsync(resourceGroupName, identity, lockName, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes the management lock of a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='lockName'>
        /// Required. The name of lock.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse DeleteAtSubscriptionLevel(this IManagementLockOperations operations, string lockName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagementLockOperations)s).DeleteAtSubscriptionLevelAsync(lockName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes the management lock of a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='lockName'>
        /// Required. The name of lock.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAtSubscriptionLevelAsync(this IManagementLockOperations operations, string lockName)
        {
            return operations.DeleteAtSubscriptionLevelAsync(lockName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the management lock of a scope.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='lockName'>
        /// Required. Name of the management lock.
        /// </param>
        /// <returns>
        /// Management lock information.
        /// </returns>
        public static ManagementLockReturnResult Get(this IManagementLockOperations operations, string lockName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagementLockOperations)s).GetAsync(lockName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the management lock of a scope.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='lockName'>
        /// Required. Name of the management lock.
        /// </param>
        /// <returns>
        /// Management lock information.
        /// </returns>
        public static Task<ManagementLockReturnResult> GetAsync(this IManagementLockOperations operations, string lockName)
        {
            return operations.GetAsync(lockName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets all the management locks of a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If empty is passed returns all locks
        /// at, above or below the resource group.
        /// </param>
        /// <returns>
        /// List of management locks.
        /// </returns>
        public static ManagementLockListResult ListAtResourceGroupLevel(this IManagementLockOperations operations, string resourceGroupName, ManagementLockGetQueryParameter parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagementLockOperations)s).ListAtResourceGroupLevelAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets all the management locks of a resource group.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If empty is passed returns all locks
        /// at, above or below the resource group.
        /// </param>
        /// <returns>
        /// List of management locks.
        /// </returns>
        public static Task<ManagementLockListResult> ListAtResourceGroupLevelAsync(this IManagementLockOperations operations, string resourceGroupName, ManagementLockGetQueryParameter parameters)
        {
            return operations.ListAtResourceGroupLevelAsync(resourceGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets all the management locks of a resource or any level below
        /// resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If empty is passed returns all locks at
        /// or below the resource.If atScope() is passed returns all locks at
        /// the resource level.
        /// </param>
        /// <returns>
        /// List of management locks.
        /// </returns>
        public static ManagementLockListResult ListAtResourceLevel(this IManagementLockOperations operations, string resourceGroupName, ResourceIdentity identity, ManagementLockGetQueryParameter parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagementLockOperations)s).ListAtResourceLevelAsync(resourceGroupName, identity, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets all the management locks of a resource or any level below
        /// resource.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group. The name is case
        /// insensitive.
        /// </param>
        /// <param name='identity'>
        /// Required. Resource identity.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If empty is passed returns all locks at
        /// or below the resource.If atScope() is passed returns all locks at
        /// the resource level.
        /// </param>
        /// <returns>
        /// List of management locks.
        /// </returns>
        public static Task<ManagementLockListResult> ListAtResourceLevelAsync(this IManagementLockOperations operations, string resourceGroupName, ResourceIdentity identity, ManagementLockGetQueryParameter parameters)
        {
            return operations.ListAtResourceLevelAsync(resourceGroupName, identity, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets all the management locks of a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If empty is passed returns all locks
        /// at, above or below the subscription.
        /// </param>
        /// <returns>
        /// List of management locks.
        /// </returns>
        public static ManagementLockListResult ListAtSubscriptionLevel(this IManagementLockOperations operations, ManagementLockGetQueryParameter parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagementLockOperations)s).ListAtSubscriptionLevelAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets all the management locks of a subscription.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='parameters'>
        /// Optional. Query parameters. If empty is passed returns all locks
        /// at, above or below the subscription.
        /// </param>
        /// <returns>
        /// List of management locks.
        /// </returns>
        public static Task<ManagementLockListResult> ListAtSubscriptionLevelAsync(this IManagementLockOperations operations, ManagementLockGetQueryParameter parameters)
        {
            return operations.ListAtSubscriptionLevelAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Get a list of management locks at resource level or below.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of management locks.
        /// </returns>
        public static ManagementLockListResult ListNext(this IManagementLockOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagementLockOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Get a list of management locks at resource level or below.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IManagementLockOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. NextLink from the previous successful call to List
        /// operation.
        /// </param>
        /// <returns>
        /// List of management locks.
        /// </returns>
        public static Task<ManagementLockListResult> ListNextAsync(this IManagementLockOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
    }
}

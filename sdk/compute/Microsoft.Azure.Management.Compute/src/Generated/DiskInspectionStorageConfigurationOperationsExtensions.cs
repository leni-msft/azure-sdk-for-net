// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DiskInspectionStorageConfigurationOperations.
    /// </summary>
    public static partial class DiskInspectionStorageConfigurationOperationsExtensions
    {
            /// <summary>
            /// Register a storageAccount for a subscription used for DiskInspection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location used to execute the diagnostic operation.
            /// </param>
            /// <param name='storageAccountId'>
            /// Qualified name of the storage account
            /// </param>
            public static void Register(this IDiskInspectionStorageConfigurationOperations operations, string location, string storageAccountId)
            {
                operations.RegisterAsync(location, storageAccountId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Register a storageAccount for a subscription used for DiskInspection
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location used to execute the diagnostic operation.
            /// </param>
            /// <param name='storageAccountId'>
            /// Qualified name of the storage account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task RegisterAsync(this IDiskInspectionStorageConfigurationOperations operations, string location, string storageAccountId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.RegisterWithHttpMessagesAsync(location, storageAccountId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Validate if a storageAccount configuration exists for a subscription used
            /// for DiskInspection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location used to execute the diagnostic operation.
            /// </param>
            public static StorageConfigurationResponse Validate(this IDiskInspectionStorageConfigurationOperations operations, string location)
            {
                return operations.ValidateAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validate if a storageAccount configuration exists for a subscription used
            /// for DiskInspection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location used to execute the diagnostic operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageConfigurationResponse> ValidateAsync(this IDiskInspectionStorageConfigurationOperations operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidateWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

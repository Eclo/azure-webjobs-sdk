﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.IO;
using Microsoft.Azure.WebJobs.Host.Bindings;
using Microsoft.WindowsAzure.Storage.Table;

namespace Microsoft.Azure.WebJobs.Host.Tables
{
    /// <summary>
    /// Defines an argument binding for <see cref="CloudTable"/> arguments.
    /// </summary>
    [CLSCompliant(false)]
    public interface ITableArgumentBinding : IArgumentBinding<CloudTable>
    {
        /// <summary>
        /// Gets the <see cref="FileAccess"/> that defines the storage operations the
        /// binding supports.
        /// </summary>
        FileAccess Access { get; }
    }
}

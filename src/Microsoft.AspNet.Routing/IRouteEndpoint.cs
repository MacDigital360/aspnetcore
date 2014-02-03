﻿﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.AspNet.Abstractions;

namespace Microsoft.AspNet.Routing
{
    public interface IRouteEndpoint
    {
        Task Invoke(HttpContext context);
    }
}

// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.Tools.Internal;

namespace Microsoft.DotNet.Watcher.Tools
{
    public class DotNetWatchContext
    {
        public IReporter Reporter { get; set; } = NullReporter.Singleton;

        public ProcessSpec ProcessSpec { get; set; }

        public FileSet FileSet { get; set; }

        public int Iteration { get; set; }

        public FileItem? ChangedFile { get; set; }

        public bool RequiresMSBuildRevaluation { get; set; }

        public bool SuppressMSBuildIncrementalism { get; set; }

        public bool SuppressApplicationRestart { get; set; }

        public BrowserRefreshServer BrowserRefreshServer { get; set; }
    }
}

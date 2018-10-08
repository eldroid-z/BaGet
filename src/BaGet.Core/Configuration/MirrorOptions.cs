﻿using System;

namespace BaGet.Core.Configuration
{
    public class MirrorOptions
    {
        /// <summary>
        /// If true, packages that aren't found locally will be indexed
        /// using the upstream source.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// The v3 index that will be mirrored.
        /// </summary>
        public Uri UpstreamIndex { get; set; }

        /// <summary>
        /// The time before a download from the package source times out.
        /// </summary>
        public int PackageDownloadTimeoutSeconds { get; set; } = 600;

        /// <summary>
        /// Root directory to store cached files.
        /// </summary>
        /// <value></value>
        public string PackagesPath { get; set; }
    }
}

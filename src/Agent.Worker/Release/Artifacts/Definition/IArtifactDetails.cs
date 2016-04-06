﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IArtifactDetails.cs" company="Microsoft Corporation">
//   2012-2023, All rights reserved.
// </copyright>
// <summary>
//   Defines the IArtifactDetails type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Agent.Worker.Release.Artifacts.Definition
{
    public interface IArtifactDetails
    {
        string RelativePath { get; set; }
    }
}
using System;

using R5T.T0131;
using R5T.T0252;
using R5T.T0252.Extensions;


namespace R5T.Z0044.Z001.Raw
{
    [ValuesMarker]
    [Obsolete("See R5T.Z0072.Z001.IFileExtensions")]
    public partial interface IFileExtensions : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// cs - C# code file.
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.cs")]
        public IFileExtension cs => "cs".ToFileExtension();

        /// <summary>
        /// csproj - Visual Studio C# project.
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.csproj")]
        public IFileExtension csproj => "csproj".ToFileExtension();

        /// <summary>
        /// resx - Resource file (XML format when used with .NET).
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.resx")]
        public IFileExtension resx => "resx".ToFileExtension();

        /// <summary>
        /// sln - Visual Studio solution.
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.sln")]
        public IFileExtension sln => "sln".ToFileExtension();

#pragma warning restore IDE1006 // Naming Styles
    }
}

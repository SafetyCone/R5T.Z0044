using System;

using R5T.T0131;
using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.Z0044.Z001.Raw
{
    [ValuesMarker]
    public partial interface IFileExtensions : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// cs - C# code file.
        /// </summary>
        public IFileExtension cs => "cs".ToFileExtension();

        /// <summary>
        /// csproj - Visual Studio C# project.
        /// </summary>
        public IFileExtension csproj => "csproj".ToFileExtension();

        /// <summary>
        /// resx - Resource file (XML format when used with .NET).
        /// </summary>
        public IFileExtension resx => "resx".ToFileExtension();

        /// <summary>
        /// sln - Visual Studio solution.
        /// </summary>
        public IFileExtension sln => "sln".ToFileExtension();

#pragma warning restore IDE1006 // Naming Styles
    }
}

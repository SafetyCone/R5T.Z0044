using System;

using R5T.T0131;
using R5T.T0252;


namespace R5T.Z0044.Z001
{
    [ValuesMarker]
    [Obsolete("See R5T.Z0072.Z004.IFileExtensions")]
    public partial interface IFileExtensions : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private static Raw.IFileExtensions _Raw => Raw.FileExtensions.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IFileExtensions.cs"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.CSharpCodeFile")]
        public IFileExtension CSharpCodeFile => _Raw.cs;

        /// <inheritdoc cref="Raw.IFileExtensions.csproj"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.CSharpProjectFile")]
        public IFileExtension CSharpProjectFile => _Raw.csproj;

        /// <summary>
        /// Chooses C# projects as the default.
        /// <para>
        /// <inheritdoc cref="Raw.IFileExtensions.csproj" path="/summary"/>
        /// </para>
        /// </summary>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.ProjectFile")]
        public IFileExtension ProjectFile => _Raw.csproj;

        /// <inheritdoc cref="Raw.IFileExtensions.resx"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.ResourceFile")]
        public IFileExtension ResourceFile => _Raw.resx;

        /// <inheritdoc cref="Raw.IFileExtensions.sln"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.SolutionFile")]
        public IFileExtension SolutionFile => _Raw.sln;
    }
}

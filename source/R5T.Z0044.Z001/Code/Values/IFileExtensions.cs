using System;

using R5T.T0131;
using R5T.T0180;

namespace R5T.Z0044.Z001
{
    [ValuesMarker]
    public partial interface IFileExtensions : IValuesMarker
    {
        private static Raw.IFileExtensions Raw => Z001.Raw.FileExtensions.Instance;


        /// <inheritdoc cref="Raw.IFileExtensions.cs"/>
        public IFileExtension CSharpCodeFile => Raw.cs;

        /// <inheritdoc cref="Raw.IFileExtensions.csproj"/>
        public IFileExtension CSharpProjectFile => Raw.csproj;

        /// <summary>
        /// Chooses C# projects as the default.
        /// <para>
        /// <inheritdoc cref="Raw.IFileExtensions.csproj" path="/summary"/>
        /// </para>
        /// </summary>
        public IFileExtension ProjectFile => Raw.csproj;

        /// <inheritdoc cref="Raw.IFileExtensions.resx"/>
        public IFileExtension ResourceFile => Raw.resx;

        /// <inheritdoc cref="Raw.IFileExtensions.sln"/>
        public IFileExtension SolutionFile => Raw.sln;
    }
}

using System;

using R5T.T0131;
using R5T.T0252;


namespace R5T.Z0044
{
    [ValuesMarker]
    [Obsolete("See R5T.Z0072.IFileExtensions")]
    public partial interface IVisualStudioFileExtensions : IValuesMarker
    {
        /// <inheritdoc cref="Z001.IFileExtensions.SolutionFile"/>
        [Obsolete("See R5T.Z0072.IFileExtensions")]
        public IFileExtension SolutionFile => Instances.FileExtensions.SolutionFile;
    }
}

using System;

using R5T.T0131;
using R5T.T0180;


namespace R5T.Z0044
{
    [ValuesMarker]
    public partial interface IVisualStudioFileExtensions : IValuesMarker
    {
        /// <inheritdoc cref="Z001.IFileExtensions.SolutionFile"/>
        public IFileExtension SolutionFile => Instances.FileExtensions.SolutionFile;
    }
}

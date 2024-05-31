using System;

using R5T.T0131;
using R5T.T0252;


namespace R5T.Z0044
{
    [ValuesMarker]
    [Obsolete("See R5T.Z0072.IFileExtensions")]
    public partial interface IImageFileExtensions : IValuesMarker
    {
        [Obsolete("See R5T.Z0072.IFileExtensions")]
        public IFileExtension Bitmap => Instances.FileExtensions.Bitmap;
    }
}

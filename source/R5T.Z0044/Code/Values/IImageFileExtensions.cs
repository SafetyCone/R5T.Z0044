using System;

using R5T.T0131;
using R5T.T0180;


namespace R5T.Z0044
{
    [ValuesMarker]
    public partial interface IImageFileExtensions : IValuesMarker
    {
        public IFileExtension Bitmap => Instances.FileExtensions.Bitmap;
    }
}

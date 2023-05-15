using System;

using R5T.T0131;
using R5T.T0180;


namespace R5T.Z0044.Z000
{
    public partial interface IFileExtensions : IValuesMarker
    {
        /// <inheritdoc cref="Raw.IFileExtensions.bmp"/>
        public IFileExtension Bitmap => Raw.bmp;

        /// <inheritdoc cref="Raw.IFileExtensions.jpeg"/>
        public IFileExtension Jpeg => Raw.jpeg;

        /// <inheritdoc cref="Raw.IFileExtensions.jpg"/>
        public IFileExtension Jpg => Raw.jpg;

        /// <inheritdoc cref="Raw.IFileExtensions.png"/>
        public IFileExtension Png => Raw.png;
    }
}

using System;

using R5T.T0131;
using R5T.T0252;


namespace R5T.Z0044.Z000
{
    public partial interface IFileExtensions : IValuesMarker
    {
        /// <inheritdoc cref="Raw.IFileExtensions.bmp"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.Bitmap")]
        public IFileExtension Bitmap => Raw.bmp;

        /// <inheritdoc cref="Raw.IFileExtensions.jpeg"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.Jpeg")]
        public IFileExtension Jpeg => Raw.jpeg;

        /// <inheritdoc cref="Raw.IFileExtensions.jpg"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.Jpg")]
        public IFileExtension Jpg => Raw.jpg;

        /// <inheritdoc cref="Raw.IFileExtensions.png"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.Png")]
        public IFileExtension Png => Raw.png;
    }
}

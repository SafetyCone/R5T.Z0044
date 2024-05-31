using System;

using R5T.T0252;
using R5T.T0252.Extensions;


namespace R5T.Z0044.Z000.Raw
{
    public partial interface IFileExtensions
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// bmp - Bitmap.
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.bmp")]
        public IFileExtension bmp => "bmp".ToFileExtension();

        /// <summary>
        /// jpeg - JPEG, Joint Photographic Experts Group (same as jpg).
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.jpeg")]
        public IFileExtension jpeg => "jpeg".ToFileExtension();

        /// <summary>
        /// jpg - JPEG, Joint Photographic Experts Group (same as jpeg).
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.jpg")]
        public IFileExtension jpg => "jpg".ToFileExtension();

        /// <summary>
        /// png - PNG, Portable Network Graphics.
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.png")]
        public IFileExtension png => "png".ToFileExtension();

#pragma warning restore IDE1006 // Naming Styles
    }
}

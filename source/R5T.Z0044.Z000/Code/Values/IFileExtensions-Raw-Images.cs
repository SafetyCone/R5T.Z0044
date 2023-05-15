using System;

using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.Z0044.Z000.Raw
{
    public partial interface IFileExtensions
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// bmp - Bitmap.
        /// </summary>
        public IFileExtension bmp => "bmp".ToFileExtension();

        /// <summary>
        /// jpeg - JPEG, Joint Photographic Experts Group (same as jpg).
        /// </summary>
        public IFileExtension jpeg => "jpeg".ToFileExtension();

        /// <summary>
        /// jpg - JPEG, Joint Photographic Experts Group (same as jpeg).
        /// </summary>
        public IFileExtension jpg => "jpg".ToFileExtension();

        /// <summary>
        /// png - PNG, Portable Network Graphics.
        /// </summary>
        public IFileExtension png => "png".ToFileExtension();

#pragma warning restore IDE1006 // Naming Styles
    }
}

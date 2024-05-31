using System;

using R5T.T0131;
using R5T.T0252;
using R5T.T0252.Extensions;


namespace R5T.Z0044.Z000.Raw
{
    /// <summary>
    /// Basic, raw file extensions (like .txt, .tmp, etc.).
    /// </summary>
    [ValuesMarker]
    [Obsolete("See R5T.Z0072.Z001.IFileExtensions")]
    public partial interface IFileExtensions : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// bin - Binary.
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.bin")]
        public IFileExtension bin => "bin".ToFileExtension();

        /// <summary>
        /// dat - Data.
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.dat")]
        public IFileExtension dat => "dat".ToFileExtension();

        /// <summary>
        /// dll - Dynamic Link Library.
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.dll")]
        public IFileExtension dll => "dll".ToFileExtension();

        /// <summary>
        /// json - JSON, JavaScript Object Notation.
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.json")]
        public IFileExtension json => "json".ToFileExtension();

        /// <summary>
        /// tmp - Temporary.
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.tmp")]
        public IFileExtension tmp => "tmp".ToFileExtension();

        /// <summary>
        /// txt - Text.
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.txt")]
        public IFileExtension txt => "txt".ToFileExtension();

        /// <summary>
        /// xml - XML, eXtensible Markup Language.
        /// </summary>
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions.xml")]
        public IFileExtension xml => "xml".ToFileExtension();

#pragma warning restore IDE1006 // Naming Styles
    }
}

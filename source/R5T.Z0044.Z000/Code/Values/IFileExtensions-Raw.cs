using System;

using R5T.T0131;
using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.Z0044.Z000.Raw
{
    /// <summary>
    /// Basic, raw file extensions (like .txt, .tmp, etc.).
    /// </summary>
    [ValuesMarker]
    public partial interface IFileExtensions : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <summary>
        /// bin - Binary.
        /// </summary>
        public IFileExtension bin => "bin".ToFileExtension();

        /// <summary>
        /// dat - Data.
        /// </summary>
        public IFileExtension dat => "dat".ToFileExtension();

        /// <summary>
        /// dll - Dynamic Link Library.
        /// </summary>
        public IFileExtension dll => "dll".ToFileExtension();

        /// <summary>
        /// json - JSON, JavaScript Object Notation.
        /// </summary>
        public IFileExtension json => "json".ToFileExtension();

        /// <summary>
        /// tmp - Temporary.
        /// </summary>
        public IFileExtension tmp => "tmp".ToFileExtension();

        /// <summary>
        /// txt - Text.
        /// </summary>
        public IFileExtension txt => "txt".ToFileExtension();

        /// <summary>
        /// xml - XML, eXtensible Markup Language.
        /// </summary>
        public IFileExtension xml => "xml".ToFileExtension();

#pragma warning restore IDE1006 // Naming Styles
    }
}

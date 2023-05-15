using System;

using R5T.T0131;
using R5T.T0180;


namespace R5T.Z0044.Z000
{
    [ValuesMarker]
    public partial interface IFileExtensions : IValuesMarker
    {
        private static Raw.IFileExtensions Raw => Z000.Raw.FileExtensions.Instance;


        /// <inheritdoc cref="Raw.IFileExtensions.dll"/>
        public IFileExtension Assembly => Raw.dll;

        /// <inheritdoc cref="Raw.IFileExtensions.bin"/>
        public IFileExtension Binary => Raw.bin;

        /// <inheritdoc cref="Raw.IFileExtensions.dat"/>
        public IFileExtension Data => Raw.dat;

        /// <inheritdoc cref="Raw.IFileExtensions.dll"/>
        public IFileExtension DynamicLinkLibrary => Raw.dll;

        /// <inheritdoc cref="Raw.IFileExtensions.json"/>
        public IFileExtension Json => Raw.json;

        /// <inheritdoc cref="Raw.IFileExtensions.txt"/>
        public IFileExtension Text => Raw.txt;

        /// <inheritdoc cref="Raw.IFileExtensions.tmp"/>
        public IFileExtension Temporary => Raw.tmp;

        /// <inheritdoc cref="Raw.IFileExtensions.xml"/>
        public IFileExtension Xml => Raw.xml;
    }
}

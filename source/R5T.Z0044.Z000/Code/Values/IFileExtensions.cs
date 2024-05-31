using System;

using R5T.T0131;
using R5T.T0252;


namespace R5T.Z0044.Z000
{
    [ValuesMarker]
    [Obsolete("See R5T.Z0072.Z004.IFileExtensions")]
    public partial interface IFileExtensions : IValuesMarker
    {
        private static Raw.IFileExtensions Raw => Z000.Raw.FileExtensions.Instance;


        /// <inheritdoc cref="Raw.IFileExtensions.dll"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.Assembly")]
        public IFileExtension Assembly => Raw.dll;

        /// <inheritdoc cref="Raw.IFileExtensions.bin"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.Binary")]
        public IFileExtension Binary => Raw.bin;

        /// <inheritdoc cref="Raw.IFileExtensions.dat"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.Data")]
        public IFileExtension Data => Raw.dat;

        /// <inheritdoc cref="Raw.IFileExtensions.dll"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.DynamicLinkLibrary")]
        public IFileExtension DynamicLinkLibrary => Raw.dll;

        /// <inheritdoc cref="Raw.IFileExtensions.json"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.Json")]
        public IFileExtension Json => Raw.json;

        /// <inheritdoc cref="Raw.IFileExtensions.txt"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.Text")]
        public IFileExtension Text => Raw.txt;

        /// <inheritdoc cref="Raw.IFileExtensions.tmp"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.Temporary")]
        public IFileExtension Temporary => Raw.tmp;

        /// <inheritdoc cref="Raw.IFileExtensions.xml"/>
        [Obsolete("See R5T.Z0072.Z004.IFileExtensions.Xml")]
        public IFileExtension Xml => Raw.xml;
    }
}

using System;


namespace R5T.Z0044.Z000.Raw
{
    [Obsolete("See R5T.Z0072.Z000.IFileExtensions")]
    public class FileExtensions : IFileExtensions
    {
        #region Infrastructure

        public static IFileExtensions Instance { get; } = new FileExtensions();


        private FileExtensions()
        {
        }

        #endregion
    }
}

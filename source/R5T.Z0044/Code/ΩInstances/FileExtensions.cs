using System;


namespace R5T.Z0044
{
    [Obsolete("See R5T.Z0072.IFileExtensions")]
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

using System;


namespace R5T.Z0044
{
    public class ImageFileExtensions : IImageFileExtensions
    {
        #region Infrastructure

        public static IImageFileExtensions Instance { get; } = new ImageFileExtensions();


        private ImageFileExtensions()
        {
        }

        #endregion
    }
}

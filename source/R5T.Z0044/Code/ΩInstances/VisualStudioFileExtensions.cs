using System;


namespace R5T.Z0044
{
    [Obsolete("See R5T.Z0072.IFileExtensions")]
    public class VisualStudioFileExtensions : IVisualStudioFileExtensions
    {
        #region Infrastructure

        public static IVisualStudioFileExtensions Instance { get; } = new VisualStudioFileExtensions();


        private VisualStudioFileExtensions()
        {
        }

        #endregion
    }
}

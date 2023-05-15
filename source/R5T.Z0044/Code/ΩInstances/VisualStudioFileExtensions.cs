using System;


namespace R5T.Z0044
{
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

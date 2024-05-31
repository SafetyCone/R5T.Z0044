using System;


namespace R5T.Z0044.Z000
{
    public static class Instances
    {
        [Obsolete("See R5T.Z0072.Z001.IFileExtensions")]
        public static IFileExtensions FileExtensions => Z000.FileExtensions.Instance;
        [Obsolete("See R5T.Z0072.Z000.IFileExtensions")]
        public static Raw.IFileExtensions FileExtensions_Raw => Raw.FileExtensions.Instance;
    }
}
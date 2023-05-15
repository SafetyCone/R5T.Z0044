using System;


namespace R5T.Z0044.Z000
{
    public static class Instances
    {
        public static IFileExtensions FileExtensions => Z000.FileExtensions.Instance;
        public static Raw.IFileExtensions FileExtensions_Raw => Raw.FileExtensions.Instance;
    }
}
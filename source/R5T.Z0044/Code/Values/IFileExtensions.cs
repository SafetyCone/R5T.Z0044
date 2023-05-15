using System;

using R5T.T0131;


namespace R5T.Z0044
{
    [ValuesMarker]
    public partial interface IFileExtensions : IValuesMarker,
        Z000.IFileExtensions,
        Z001.IFileExtensions
    {

    }
}

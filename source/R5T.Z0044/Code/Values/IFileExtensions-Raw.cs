using System;

using R5T.T0131;


namespace R5T.Z0044.Raw
{
    [ValuesMarker]
    public partial interface IFileExtensions : IValuesMarker,
        Z000.Raw.IFileExtensions,
        Z001.Raw.IFileExtensions
    {

    }
}

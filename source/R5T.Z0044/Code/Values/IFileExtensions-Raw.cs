using System;

using R5T.T0131;


namespace R5T.Z0044.Raw
{
    [ValuesMarker]
    [Obsolete("See R5T.Z0072.IFileExtensions")]
    public partial interface IFileExtensions : IValuesMarker,
        Z000.Raw.IFileExtensions,
        Z001.Raw.IFileExtensions
    {

    }
}

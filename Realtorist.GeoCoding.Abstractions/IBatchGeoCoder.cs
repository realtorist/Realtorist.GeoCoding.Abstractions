using Realtorist.Models.Listings.Details;
using Realtorist.Models.Geo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Realtorist.GeoCoding.Abstractions
{
    /// <summary>
    /// Describes geo coder to work with large amount of addresses
    /// </summary>
    public interface IBatchGeoCoder
    {
        /// <summary>
        /// Geocodes list of addresses and call <paramref name="callback"/> for each after getting the results
        /// </summary>
        /// <param name="addresses">Map of address - unique ID (i.e. listing id)</param>
        /// <param name="callback">Callback function to be called on each successfully processed address</param>
        /// <param name="failledCallback">Callback function to be called on list of failed to process addresses</param>
        Task GeoCodeAddressesAsync(IDictionary<Guid, Address> addresses, Func<Guid, Coordinates, Task> callback, Func<IEnumerable<Guid>, Task> failledCallback);
    }
}

using Realtorist.Models.Listings.Details;
using Realtorist.Models.Models;
using System.Threading.Tasks;

namespace Realtorist.GeoCoding.Abstractions
{
    /// <summary>
    /// Describes methods used for geo coding
    /// </summary>
    public interface IGeoCoder
    {
        /// <summary>
        /// Gets coordinates from address
        /// </summary>
        /// <param name="address">Address</param>
        /// <returns>Coordinates of the address</returns>
        Task<Coordinates> GetCoordinatesAsync(Address address);

        /// <summary>
        /// Gets coordinates from address
        /// </summary>
        /// <param name="query">String representation of address</param>
        /// <returns>Coordinates of the address</returns>
        Task<Coordinates> GetCoordinatesAsync(string query);

        /// <summary>
        /// Gets address from coordinates
        /// </summary>
        /// <param name="coordinates">Coordinates</param>
        /// <returns>Address of the coordinates</returns>
        Task<Address> GetAddressAsync(Coordinates coordinates);

        /// <summary>
        /// Gets suggestions for autocomplete based on query
        /// </summary>
        /// <param name="query">Search query</param>
        /// <returns>Autocomplete suggestions</returns>
        Task<string[]> GetAddressSuggestionsAsync(string query);
    }
}

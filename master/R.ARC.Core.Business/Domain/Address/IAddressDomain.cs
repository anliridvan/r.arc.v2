using R.ARC.Common.Helper.Paging;
using R.ARC.Common.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R.ARC.Core.Business
{
    public interface IAddressDomain
    {
        Task<AddressBasicModel> GetAddressesAsync(int accountId);
        Task<int> SaveAddressAsync(AddressModel model);
        Task<int> DeleteAddressAsync( int addressId);

        IEnumerable<AddressMappingModel> GetAddressMapping();
    }
}

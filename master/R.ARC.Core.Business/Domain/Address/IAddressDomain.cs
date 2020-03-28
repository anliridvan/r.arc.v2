using R.ARC.Common.Helper.Paging;
using R.ARC.Common.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace R.ARC.Core.Business
{
    public interface IAddressDomain
    {
        Task<AddressBasicModel> GetAddressesAsync(Guid accountId);
        Task<Guid> SaveAddressAsync(AddressModel model);
        Task<Guid> DeleteAddressAsync(Guid addressId);

        IEnumerable<AddressMappingModel> GetAddressMapping();
    }
}

using Microsoft.Extensions.DependencyInjection;
using R.ARC.Common.Contract;
using R.ARC.Core.DataLayer.Repositories;
using R.ARC.Core.DataLayer.UnitOfWork;
using R.ARC.Core.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R.ARC.Core.Business
{
    public class AddressDomain : DomainBase<AddressDomain>, IAddressDomain
    {
        private readonly IAddressRepository _addressRep;
        private readonly IAddressMappingRepository _addressMappingRep;
        private readonly IDatabaseUnitOfWork _uow;

        public AddressDomain(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _addressRep = serviceProvider.GetService<IAddressRepository>();
            _addressMappingRep = serviceProvider.GetService<IAddressMappingRepository>();
            _uow = serviceProvider.GetService<IDatabaseUnitOfWork>();
        }

        public async Task<AddressBasicModel> GetAddressesAsync(int addressId)
        {
            return await _addressRep.FirstOrDefaultAsync<AddressBasicModel>(m => m.Id == addressId);
        }

        public async Task<int> SaveAddressAsync(AddressModel model)
        {
            AddressEntity addressEntity = await _addressRep.FirstOrDefaultAsync(m => m.Id == model.Id);

            using (Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction trs = await _uow.BeginTransactionAsync())
            {
                if (addressEntity == null)
                {
                    //yeni kayit
                    addressEntity = Mapper.Map<AddressModel, AddressEntity>(model);

                    await _addressRep.AddAsync(addressEntity);
                    await _uow.SaveChangesAsync();

                }
                else
                {
                    //güncelleme
                    Mapper.Map(model, addressEntity);

                    await _addressRep.UpdateAsync(addressEntity);
                    await _uow.SaveChangesAsync();

                }

                trs.Commit();
            }

            return addressEntity.Id;
        }


        public IEnumerable<AddressMappingModel> GetAddressMapping()
        {
            return _addressMappingRep.List<AddressMappingModel>();
        }

        public async Task<int> DeleteAddressAsync(int addressId)
        {
            AddressEntity addressEntity = await _addressRep.FirstOrDefaultAsync(m => m.Id == addressId);

            if (addressEntity != null)
            {
                await _addressRep.DeleteAsync(m => m.Id == addressId);
                await _uow.SaveChangesAsync();
                return addressId;
            }

            return 0;
        }

    }
}

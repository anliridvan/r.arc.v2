using System;
using Microsoft.AspNetCore.Mvc;
using R.ARC.Core.Business.Application;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using R.ARC.Common.Contract;
using R.ARC.Common.Helper.Enums;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;

namespace R.ARC.Web.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AddressController : BaseController<AddressController>
    {
        private IUserTaskApplication _AccountApp { get; }

        public AddressController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _AccountApp = serviceProvider.GetService<IUserTaskApplication>();
        }

        //[Route("{accountId}")]
        //[HttpGet]
        //public async Task<IActionResult> Account(int accountId)
        //{
        //    return Ok(await _AccountApp.GetAccountAddressesAsync(accountId));
        //}

        //[HttpPost]
        //public async Task<IActionResult> Account(AccountAddressModel model)
        //{
        //    return Ok(await _AccountApp.SaveAccountAddressAsync(model));
        //}

        //[Route("{addressId}")]
        //[HttpDelete]
        //public async Task<IActionResult> AccountAddressSil(int addressId)
        //{
        //    return Ok(await _AccountApp.DeleteAccountAddressAsync(addressId));
        //}

        //[Route("{contactId}")]
        //[HttpGet]
        //public async Task<IActionResult> Contact(int contactId)
        //{
        //    return Ok(await _AccountApp.GetContactAddressesAsync(contactId));
        //}

        //[HttpPost]
        //public async Task<IActionResult> Contact(ContactAddressModel model)
        //{
        //    return Ok(await _AccountApp.SaveContactAddressAsync(model));
        //}

        //[Route("{addressId}")]
        //[HttpDelete]
        //public async Task<IActionResult> ContactAddressSil(int addressId)
        //{
        //    return Ok(await _AccountApp.DeleteContactAddressAsync(addressId));
        //}

        [HttpGet]
        public IActionResult Mapping()
        {
            MemoryCache.TryGetValue(CacheKeys.AddressMapping, out IEnumerable<AddressMappingModel> addressMappingList);
            return Ok(addressMappingList);
        }
    }
}
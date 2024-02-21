using FirstCRUDwithENTITY.Models;
using FirstCRUDwithENTITY.PhoneServise;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstCRUDwithENTITY.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        private readonly IPhoneServise _phoneServise;
        public PhoneController(IPhoneServise phoneServise)
        {
            _phoneServise = phoneServise;
        }
        [HttpGet]
        public List<Phone> GetPhones()
        {
            return _phoneServise.GetPhones();
        }
        [HttpGet]
        public Phone GetPhone(int id)
        {
            return _phoneServise.GetPhone(id);
        }
        [HttpPost]
        public Phone GetPhone(Phone phone)
        {
            return _phoneServise.Post(phone);
        }
        [HttpPut]
        public Phone PutPhone(Phone phone,int id)
        {
            return _phoneServise.Put(phone,id);
        }
        [HttpDelete]
        public string DeletePhone(int id)
        {
            return _phoneServise.Delete(id);
        }
    }
}

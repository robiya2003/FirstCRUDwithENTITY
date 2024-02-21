using FirstCRUDwithENTITY.Models;

namespace FirstCRUDwithENTITY.PhoneServise
{
    public interface IPhoneServise
    {
        public List<Phone> GetPhones();
        public Phone GetPhone(int id);
        public string Delete(int id);
        public Phone Post(Phone phone);
        public Phone Put(Phone phone, int id);
    }
}

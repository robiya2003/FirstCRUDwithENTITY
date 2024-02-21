using FirstCRUDwithENTITY.Infastructures;
using FirstCRUDwithENTITY.Models;

namespace FirstCRUDwithENTITY.PhoneServise
{
    public class PhoneServise1 : IPhoneServise
    {
        private readonly ApplicationDbContext _context;
        public PhoneServise1(ApplicationDbContext context)
        {
            _context = context;
        }

        public string Delete(int id)
        {
            _context.Remove(_context.phones.FirstOrDefault(x=>x.phoneId==id));
            _context.SaveChanges();
            return $"{id} ochirildi";
        }

        public Phone GetPhone(int id)
        {
            return _context.phones.FirstOrDefault(x=>x.phoneId==id);
        }

        public List<Phone> GetPhones()
        {
            return _context.phones.ToList();
        }

        public Phone Post(Phone phone)
        {
            _context.phones.Add(phone);
            _context.SaveChanges();
            return phone;
        }

        public Phone Put(Phone phone, int id)
        {
            var p=_context.phones.FirstOrDefault(x=>x.phoneId==id);
            p.phoneName = phone.phoneName;
            p.description = phone.description;
            _context.SaveChanges();
            return p;
        }
    }
}

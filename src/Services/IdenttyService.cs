using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IidentityService
    {
        Task<string> LoginService(LoginDto login);
    }
    public class IdenttyService: IidentityService
    {
        private readonly IdentityServiceDbContext _db;
        public IdenttyService(IdentityServiceDbContext db)
        {
            _db = db;
        }


        public async Task<string> LoginService(LoginDto login)
        {
            
                var user = await _db.Users.Where(x => x.Mail == login.Mail && x.Password == login.Password).FirstOrDefaultAsync();
                if(user == null)
                {
                    throw new Exception("User wasn't found..");
                }
                return "User was found with successfully";
          
        }
    }
}

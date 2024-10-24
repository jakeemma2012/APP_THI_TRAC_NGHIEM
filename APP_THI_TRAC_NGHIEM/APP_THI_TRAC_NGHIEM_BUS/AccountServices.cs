using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APP_THI_TRAC_NGHIEM_DAL.Model;
namespace App_Thi_Trac_Nghiem_BUS
{
    public class AccountServices
    {
        public Model1 context = Services.getInstance().context;

        public static AccountServices instance;

        public static AccountServices gI()
        {
            if (instance == null)
            {
                instance = new AccountServices();
            }
            return instance;
        }

        public Account getAccountLogin(string user)
        {
            return context.Accounts.FirstOrDefault(
                p => p.Username.CompareTo(user) == 0);
        }

        public List<Account> getAllAccount()
        {
            return context.Accounts.ToList();
        }

        public Account getAccountByIDUSer(int idUS)
        {
            return context.Accounts.FirstOrDefault(p => p.UserID == idUS);
        }
    }
}

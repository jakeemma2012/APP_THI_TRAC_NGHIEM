using APP_THI_TRAC_NGHIEM_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Thi_Trac_Nghiem_BUS
{
    public class Services
    {
        public static Services instance;

        public static Services getInstance()
        {
            if (instance == null)
            {
                instance = new Services();
            }
            return instance;
        }

        public Model1 context = new Model1();


    }
}

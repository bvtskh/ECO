using ECO_DX_For_PUR.DATA.Bussiness.Interface;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECO_DX_For_PUR.DATA.Bussiness.SQLHelper
{
    public class LoginHelper : ILOGIN
    {
        public string GetCurrentVersion()
        {
            using(var context = new DBContext())
            {
                return context.Versions.OrderByDescending(o => o.VERSION1).FirstOrDefault().VERSION1;
            }
        }

        public bool IsOldVersion(string current)
        {
            int currentverDB = ConvertVersion(GetCurrentVersion());
            int currentVer = ConvertVersion(current);
            if ( currentVer < currentverDB) return true;
            return false;
        }

        private int ConvertVersion(string ver)
        {
            // Remove periods from the string
            string numberString = ver.Replace(".", "");

            // Parse the resulting string as an integer
            if (!int.TryParse(numberString, out int versionInt))
            {
                throw new ArgumentException("Invalid version string format.");
            }

            return versionInt;
        }

        public void SaveNewVersion(Versions version)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Versions.Add(version);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

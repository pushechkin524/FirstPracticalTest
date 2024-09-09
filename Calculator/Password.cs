using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTestFir
{
    public class Password
    {
        public int PasswordValidation(string pswrd)
        {
            int res = 0;
            var validation = pswrd.Any(char.IsDigit);
            if (validation)
            {
                res = res + 1;
            }

            validation = pswrd.Any(char.IsLower);
            if (validation)
            {
                res = res + 1;
            }

            validation = pswrd.Any(char.IsUpper);
            if (validation)
            {
                res = res + 1;
            }

            validation = pswrd.Any(a => !char.IsLetterOrDigit(a));
            if (validation)
            {
                res = res + 1;
            }

            if (pswrd.Length > 10)
            {
                res = res + 1;
            }

            return res;
        }
    }
}

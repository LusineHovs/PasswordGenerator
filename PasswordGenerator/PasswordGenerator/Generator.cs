using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordGenerator
{
    public class Generator
    {
        public static string PasswordGenerator(int length)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var data = new byte[16];
                rng.GetBytes(data);
                var seed = BitConverter.ToInt32(data, 0);
                var rnd = new Random(seed);

                string password = string.Empty;

                for (int i = 0; i < length; i++)
                {
                    if (rnd.Next(1, 4) == 1)
                        password += (char)rnd.Next(48, 57);
                    else if (rnd.Next(1, 4) == 2)
                        password += (char)rnd.Next(65, 90);
                    else
                        password += (char)rnd.Next(97, 122);
                }
                return password;
            }
        }
    }
}

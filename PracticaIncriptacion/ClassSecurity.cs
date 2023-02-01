using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracticaIncriptacion
{
    internal class ClassSecurity
    {

        public static string sha1Digest(string txt)
        {
            string digest = string.Empty;
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            // 1 paso crear bytes
            Byte[] bytes = Encoding.Default.GetBytes(txt);
            //2 paso convertir en bytes a hash
            Byte[] hashBytes = sha1.ComputeHash(bytes);
            digest = BitConverter.ToString(hashBytes);
            //quitar -
            digest = digest.Replace("-", String.Empty);
            return digest;
        }
        public static string MD5Digest(string txt) {
            string digest = string.Empty;
            MD5 md5 = MD5CryptoServiceProvider.Create();
            //1 paso crear bytes
            Byte[] bytes = Encoding .Default.GetBytes(txt);
            //2 paso convertir bytes a hash
            Byte[] hashBytes =md5.ComputeHash(bytes);
            digest = BitConverter.ToString(hashBytes);
            //quitar -
            digest = digest.Replace("-",String.Empty);

            return digest;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Application.Security
{
    public class PasswordHelper : IPasswordHelper
    {
        public string EncodePasswordMd5(string password)
        {
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;
            //Instatiate MD%CryptoServiceProvider, get bytes for original password and compute hash (encode password)\
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(password);
            encodedBytes = md5.ComputeHash(originalBytes);
            //Convert encoded bytes back to a 'readable' string
            return BitConverter.ToString(encodedBytes);
        }
    }
}

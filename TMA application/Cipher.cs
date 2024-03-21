using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMA_application
{
    internal class Cipher
    {
        public static string CipherIn(string password)
        {
            byte[] encData_byte = new byte[password.Length];
            encData_byte = Encoding.UTF8.GetBytes(password);
            string encodedData = Convert.ToBase64String(encData_byte);
            return encodedData;
        }
        public static string CipherOut(string password) 
        {

            UTF8Encoding encoding = new UTF8Encoding();
            Decoder decoder = encoding.GetDecoder();
            byte[] tocode = Convert.FromBase64String(password);
            int charCount = decoder.GetCharCount(tocode, 0, tocode.Length);
            char[] decoded = new char[charCount];
            decoder.GetChars(tocode, 0, tocode.Length, decoded, 0);
            string result = new string(decoded);
            return result;
        }
         
    }
}

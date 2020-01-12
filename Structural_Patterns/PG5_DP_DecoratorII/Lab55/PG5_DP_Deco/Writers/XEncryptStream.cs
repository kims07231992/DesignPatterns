using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Deco.Writers
{
    public class XEncryptStream : IWriter
    {
        private IWriter _writer;

        public XEncryptStream(IWriter writer)
        {
            this._writer = writer;
            using (var aes = Aes.Create())
            {
                this.EncryptionKey = aes.Key;
            }
        }

        private byte[] EncryptionKey
        {
            get
            {
                var stringValue = ConfigurationManager.AppSettings[nameof(this.EncryptionKey)];
                var bytesValue = Convert.FromBase64String(stringValue); // string to byte[]
                return bytesValue;
            }
            set
            {
                var stringValue = Convert.ToBase64String(value); // byte[] to string
                ConfigurationManager.AppSettings[nameof(this.EncryptionKey)] = stringValue;
            }
        }

        public void WriteData(byte[] data)
        {
            byte[] IV;

            using (var aes = Aes.Create())
            {
                IV = aes.IV;
            }
            var encryptedData = EncryptBytes(data, this.EncryptionKey, IV);
            this._writer.WriteData(encryptedData);
        }

        private static byte[] EncryptBytes(byte[] inputData, byte[] Key, byte[] IV)
        {
            byte[] encrypted;

            using (var aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, 
                        encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(
                            csEncrypt))
                        {
                            swEncrypt.Write(inputData); // Write encrypted data
                            swEncrypt.WriteLine(" IV={0}", aes.IV); // Write IV
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }
    }
}

using System;

namespace Crypto
{
    public class XOR : CryptoAlgorithm
    {
        public XOR()
        {
        }
        
        public byte[] Key { get; set; }
        
        public override byte[] Encrypt(byte[] data)
        {
            if (data == null) throw new ArgumentNullException();
            if (Key == null) throw new NullReferenceException();
            return Encrypt(data, Key);
        }

        public override byte[] Encrypt(byte[] data, byte[] key)
        {
            if (data == null) throw new ArgumentNullException();
            if (key == null) throw new NullReferenceException();
            
            var length = data.Length;
            byte[] encryptedData = new byte[length];

            for (int i = 0; i < length; i++)
            {
                encryptedData[i] = Convert.ToByte(data[i] ^ key[i % key.Length]);
            }

            return encryptedData;

        }

        public override byte[] Decrypt(byte[] encryptedData)
        {
            if (encryptedData == null) throw new ArgumentNullException();
            if (Key == null) throw new NullReferenceException();
            return Decrypt(encryptedData, Key);
        }

        public override byte[] Decrypt(byte[] encryptedData, byte[] key)
        {
            return Encrypt(encryptedData, key);
        }
    }
}
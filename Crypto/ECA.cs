using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace Crypto
{
    /// <summary>
    /// An elliptic curve algorythm
    /// </summary>
    public class ECA : CryptoAlgorithm
    {
        EllipticCurve _curve;
        public ECA(int a = -1, int b = 1)
        {
            _curve = new EllipticCurve(a,b);
        }

        public override byte[] Decrypt(byte[] encryptedData, byte[] key)
        {
            throw new NotImplementedException();
        }

        public override byte[] Encrypt(byte[] data, byte[] key)
        {
            throw new NotImplementedException();
        }
    }
}

namespace Crypto
{
    public abstract class CryptoAlgorithm
    {
        public abstract byte[] Encrypt(byte[] data);
        public abstract byte[] Encrypt(byte[] data, byte[] key);
        
        public abstract byte[] Decrypt(byte[] encryptedData);
        public abstract byte[] Decrypt(byte[] encryptedData, byte[] key);
    }
}
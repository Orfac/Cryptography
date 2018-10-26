using System;
using System.IO;
using System.Text;
using Crypto;

namespace CryptoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input file path to ecnrypt");
            string sourcePath = Console.ReadLine();

            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("File doesn't exist");
                return;
            }
            
            CryptoAlgorithm xor = new XOR();
            byte[] sourceData = File.ReadAllBytes(sourcePath);
            byte[] key = new byte[]{1,2,3,4,5};
            byte[] encryptedData = xor.Encrypt(sourceData, key);

            var destFilePath = new StringBuilder();
            destFilePath.Append(Path.GetDirectoryName(sourcePath));
            destFilePath.Append("\\");
            destFilePath.Append(Path.GetFileNameWithoutExtension(sourcePath));
            destFilePath.Append("_encrypted");
            destFilePath.Append( Path.GetExtension(sourcePath));
            
            Console.WriteLine($"Your encrypted file is stored here: {destFilePath}");
            File.WriteAllBytes(destFilePath.ToString(), encryptedData);
            

        }
    }
}
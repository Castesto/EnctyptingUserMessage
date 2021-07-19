using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class EncryptingMessage
    {
        const int blockSize = 1;

        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        public EncryptingMessage()
        {
            byte[] randomNumber = new byte[1];
            rng.GetBytes(randomNumber);
        }

        private static SymmetricAlgorithm _cryptoService = new TripleDESCryptoServiceProvider();

        public string SymmetricEncript(string text, int userKey)
        {

            byte[] key = new byte[blockSize];
            rng.GetBytes(key);
            byte[] iv = new byte[blockSize];
            rng.GetBytes(iv);

        }
    }
}

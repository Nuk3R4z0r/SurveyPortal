using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Security.Cryptography;

    public class RNG
    {

        private Random rnd;
        private RNGCryptoServiceProvider rngCrypt;

        public RNG()
        {
            rnd = new Random();
            rngCrypt = new RNGCryptoServiceProvider();
        }

        public int NextRandom(bool allowNegative)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] bytes = new byte[4];
            rng.GetNonZeroBytes(bytes);

            int number = BitConverter.ToInt32(bytes, 0);
            if (!allowNegative)
            {
                if (number < 0)
                {
                    number = -number;
                }
            }

            return number;
        }

        public int NextRandom(int minValue, int maxValue)
        {
            int range = (maxValue - minValue) + 1;
            bool isNegative = false;

            if(minValue < 0)
            {
                isNegative = true;
            }

            int final = minValue + (NextRandom(isNegative) % range);
            return final;
        }
    }

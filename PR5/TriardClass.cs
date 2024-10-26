using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TriardClass
{
    class Triard
    {
        public int onePositiveNumber;
        public int twoPositiveNumber;
        public int threePositiveNumber;
        public int OnePositiveNumber
        { 
            get 
            { 
                return onePositiveNumber;
            }
            set
            {
                if (value > 0) onePositiveNumber = value;
            }
        }
        public int TwoPositiveNumber
        {
            get
            {
                return twoPositiveNumber;
            }
            set
            {
                if (value > 0) twoPositiveNumber = value;
            }
        }
        public int ThreePositiveNumber
        {
            get
            {
                return threePositiveNumber;
            }
            set
            {
                if (value > 0) threePositiveNumber = value;
            }
        }
        public int SumNumber()
        {
            return OnePositiveNumber + TwoPositiveNumber + ThreePositiveNumber;
        }
        public void SetParams(int oneSetParams, int twoSetParams, int threeSetParams)
        {
            OnePositiveNumber = oneSetParams;
            TwoPositiveNumber = twoSetParams;
            ThreePositiveNumber = threeSetParams;
        }
        public void SetParams(int oneSetParams, int twoSetParams)
        {
            OnePositiveNumber = oneSetParams;
            TwoPositiveNumber = twoSetParams;
            ThreePositiveNumber = oneSetParams + twoSetParams;
        }
        public void SetParams(int oneSetParams)
        {
            OnePositiveNumber = oneSetParams;
            TwoPositiveNumber = oneSetParams;
            ThreePositiveNumber = oneSetParams;
        }
    }
}

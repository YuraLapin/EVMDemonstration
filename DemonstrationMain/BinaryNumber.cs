namespace DemonstrationMain
{
    internal struct BinaryNumberResult
    {
        public BinaryNumber res;
        public bool ov;
        public bool z;

        public BinaryNumberResult(BinaryNumber res, bool ov, bool z)
        {
            this.res = res;
            this.ov = ov;
            this.z = z;
        }
    }

    internal class BinaryNumber
    {
        public const int SIZE = 16;
        private int[] bools = new int[SIZE];

        public BinaryNumber()
        {

        }

        public BinaryNumber(string binaryStr)
        {
            Set(binaryStr);
        }

        public int this[int index]
        {
            get
            {
                return bools[index];
            }
            set
            {
                bools[index] = value;
            }
        }

        public void Set(string binaryStr)
        {
            int strSize = binaryStr.Length;

            if (SIZE != strSize)
            {
                throw new Exception("String size do not match!");
            }

            for (int i = 0; i < strSize; i++)
            {
                if (binaryStr[i] == '0')
                {
                    bools[i] = 0;
                }

                else if (binaryStr[i] == '1')
                {
                    bools[i] = 1;
                }

                else
                {
                    throw new Exception("Wrong string format!");
                }
            }
        }

        public override string ToString()
        {
            string res = "";

            for (int i = 0; i < SIZE; ++i)
            {
                if (bools[i] == 1)
                {
                    res += '1';
                }

                else
                {
                    res += '0';
                }
            }

            return res;
        }

        public bool IsZero()
        {
            for (int i = 0; i < SIZE; ++i)
            {
                if (bools[i] == 1)
                {
                    return false;   
                }
            }

            return true;
        }

        public BinaryNumberResult Equality(BinaryNumber another)
        {
            var res = new BinaryNumber();

            for (int i = 0; i < SIZE; ++i)
            {
                if (this[i] == another[i])
                {
                    res[i] = 1;
                }

                else
                {
                    res[i] = 0;
                }
            }

            return new BinaryNumberResult(res, false, res.IsZero());
        }

        private void SetZero()
        {
            for (int i = 0; i < SIZE; ++i)
            {
                this[i] = 0;
            }
        }

        private BinaryNumber ConvertToAdd()
        {
            var res = new BinaryNumber();

            if (this[0] == 1)
            {
                res.bools = bools;
                res[0] = 0;
                var max = new int[SIZE + 1];
                max[0] = 1;

                for (int i = SIZE - 1; i >= 0; --i)
                {
                    int tmp = max[i + 1] - res[i];

                    while (tmp < 0)
                    {
                        max[i + 1] += 2;
                        max[i]--;
                        tmp = max[i + 1] - res[i];
                    }

                    res[i] = tmp;
                }

                return res;
            }

            else
            {
                res.bools = bools;
            }

            return res;
        }

        private BinaryNumber ConvertToStraight()
        {
            var res = new BinaryNumber();

            if (this[0] == 1)
            {
                res.bools = bools;
                var max = new int[SIZE + 1];
                max[0] = 1;

                for (int i = SIZE - 1; i >= 0; --i)
                {
                    int tmp = max[i + 1] - res[i];

                    while (tmp < 0)
                    {
                        max[i + 1] += 2;
                        max[i]--;
                        tmp = max[i + 1] - res[i];
                    }

                    res[i] = tmp;
                }

                res[0] = 1;
                return res;
            }

            else
            {
                res.bools = bools;
            }

            return res;
        }

        public BinaryNumberResult Plus(BinaryNumber another)
        {
            var dop1 = ConvertToAdd();
            var dop2 = another.ConvertToAdd();

            int mem = 0;
            var res = new BinaryNumber();

            for (int i = SIZE - 1; i >= 0; --i)
            {
                int tmp = dop1[i] + dop2[i] + mem;
                res[i] = tmp % 2;
                mem = tmp / 2;
            }

            bool ov = false;
            bool z = res.IsZero();

            if (dop1[0] == dop2[0] && (mem != 0 || dop1[0] != res[0]))
            {
                ov = true;
                z = false;
                res.SetZero();
            }

            res = res.ConvertToStraight();

            return new BinaryNumberResult(res, ov, z);
        }
    }
}

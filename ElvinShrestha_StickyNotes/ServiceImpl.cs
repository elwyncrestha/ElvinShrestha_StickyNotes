using System;

namespace ElvinShrestha_StickyNotes
{
    class ServiceImpl : Service
    {
        public override String getRandomCode(int codeSize)
        {
            //codeSize = size of generated code

            char[] chars = new char[62]; // sum of letters and numbers

            int i = 0;

            for (char c = 'a'; c <= 'z'; c++)
            { // for small letters
                chars[i++] = c;
            }

            for (char c = '0'; c <= '9'; c++)
            { // for numbers
                chars[i++] = c;
            }

            for (char c = 'A'; c <= 'Z'; c++)
            { // for capital letters
                chars[i++] = c;
            }

            String code = "";
            Random random = new Random();
            for (i = 0; i < codeSize; i++)
            {
                double baseValue = random.NextDouble();

                char c = chars[(int)(baseValue * chars.Length)];
                code = code + c;
            }

            return code;
        }
    }
}

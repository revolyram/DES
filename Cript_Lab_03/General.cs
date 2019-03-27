using System;
using System.IO;
using System.Windows.Forms;

namespace Cript_Lab_03
{
    public partial class General : Form
    {
        private string s;

        private string k;

        private const int sizeOfBlock = 128; //128 в DES размер блока 64 бит, но поскольку в unicode символ в два раза длинее, то увеличим блок тоже в два раза

        private const int sizeOfChar = 16; //размер одного символа (in Unicode 16 bit)

        private const int shiftKey = 2; //сдвиг ключа 

        private const int quantityOfRounds = 16; //количество раундов

        static string[] Blocks; //сами блоки в двоичном формате

        private static string XOR(string s1, string s2)
        {
            string result = "";

            for (int i = 0; i < s1.Length; i++)
            {
                bool a = Convert.ToBoolean(Convert.ToInt32(s1[i].ToString()));
                bool b = Convert.ToBoolean(Convert.ToInt32(s2[i].ToString()));

                if (a ^ b)
                    result += "1";
                else
                    result += "0";
            }
            return result;
        }

        private static string StringToRightLength(string input)
        {
            while (((input.Length * sizeOfChar) % sizeOfBlock) != 0)
                input += " ";
            return input;
        }

        private static void CutStringIntoBlocks(string input)
        {
            Blocks = new string[(input.Length * sizeOfChar) / sizeOfBlock];           
            int lengthOfBlock = input.Length / Blocks.Length;
            for (int i = 0; i < Blocks.Length; i++)
            {
                Blocks[i] = input.Substring(i * lengthOfBlock, lengthOfBlock);
                Blocks[i] = StringToBinaryFormat(Blocks[i]);
            }
        }

        private static void CutBinaryStringIntoBlocks(string input)
        {
            Blocks = new string[input.Length / sizeOfBlock];
            int lengthOfBlock = input.Length / Blocks.Length;
            for (int i = 0; i < Blocks.Length; i++)
                Blocks[i] = input.Substring(i * lengthOfBlock, lengthOfBlock);
        }

        private static string StringToBinaryFormat(string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                string char_binary = Convert.ToString(input[i], 2);

                while (char_binary.Length < sizeOfChar)
                    char_binary = "0" + char_binary;

                output += char_binary;
            }

            return output;
        }

        private static string CorrectKeyWord(string input, int lengthKey)
        {
            if (input.Length > lengthKey)
                input = input.Substring(0, lengthKey);
            else
                while (input.Length < lengthKey)
                    input = "0" + input;

            return input;
        }

        private static string EncodeDES_One_Round(string input, string key)
        {
            string L = input.Substring(0, input.Length / 2);
            string R = input.Substring(input.Length / 2, input.Length / 2);

            return (R + XOR(L, f(R, key)));
        }

        private static string DecodeDES_One_Round(string input, string key)
        {
            string L = input.Substring(0, input.Length / 2);
            string R = input.Substring(input.Length / 2, input.Length / 2);

            return (XOR(f(L, key), R) + L);
        }

        private static string f(string s1, string s2)
        {
            return XOR(s1, s2);
        }

        private static string KeyToNextRound(string key)
        {
            for (int i = 0; i < shiftKey; i++)
            {
                key = key[key.Length - 1] + key;
                key = key.Remove(key.Length - 1);
            }
            return key;
        }

        private static string KeyToPrevRound(string key)
        {
            for (int i = 0; i < shiftKey; i++)
            {
                key = key + key[0];
                key = key.Remove(0, 1);
            }
            return key;
        }

        private static string StringFromBinaryToNormalFormat(string input)
        {
            string output = "";
            while (input.Length > 0)
            {
                string char_binary = input.Substring(0, sizeOfChar);
                input = input.Remove(0, sizeOfChar);

                int a = 0;
                int degree = char_binary.Length - 1;

                foreach (char c in char_binary)
                    a += Convert.ToInt32(c.ToString()) * (int)Math.Pow(2, degree--);

                output += ((char)a).ToString();
            }
            return output;
        }

        public General()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            s = input.Text;
        }

        private void key_ValueChanged(object sender, EventArgs e)
        {
            k = Convert.ToString(key.Value);
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            try
            {
                string k2;
                s = StringToRightLength(s);
                CutStringIntoBlocks(s);
                k = CorrectKeyWord(k, s.Length / (2 * Blocks.Length));
                k = StringToBinaryFormat(k);
                for (int j = 0; j < quantityOfRounds; j++)
                {
                    for (int i = 0; i < Blocks.Length; i++)
                        Blocks[i] = EncodeDES_One_Round(Blocks[i], k);
                    k = KeyToNextRound(k);
                }
                k = KeyToPrevRound(k);
                k2 = StringFromBinaryToNormalFormat(k);
                string rez = "";
                for (int i = 0; i < Blocks.Length; i++)
                    rez += Blocks[i];
                rezult.Text = StringFromBinaryToNormalFormat(rez);
            }
            catch { }
        }

        private void Decode_Click(object sender, EventArgs e)
        {
            try
            {
                s = StringToRightLength(s);
                CutStringIntoBlocks(s);
                for (int j = 0; j < quantityOfRounds; j++)
                {
                    for (int i = 0; i < Blocks.Length; i++)
                        Blocks[i] = DecodeDES_One_Round(Blocks[i], k);
                    k = KeyToPrevRound(k);
                }
                k = KeyToNextRound(k);
                string rez = "";
                for (int i = 0; i < Blocks.Length; i++)
                    rez += Blocks[i];
                rezult.Text = StringFromBinaryToNormalFormat(rez);
            }
            catch { }
        }
    }
}

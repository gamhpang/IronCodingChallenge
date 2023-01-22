using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OldPhonePad("33#"));
            Console.WriteLine(OldPhonePad("227*#"));
            Console.WriteLine(OldPhonePad("4433555 555666#"));
            Console.WriteLine(OldPhonePad("8 88777444666*664#"));
            Console.WriteLine(OldPhonePad("222 2 22#"));
        }

        public static String PreProcess(string str)
        {

            char[] ch = str.ToCharArray();
            int removeCount = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '*')
                {
                    if (i != 0)
                    {
                        str = str.Remove(i - 1 - removeCount, 2).Insert(i - 1, " ");
                        removeCount += 1;
                    }
                    else
                    {
                        str = str.Remove(i, 1);
                        removeCount += 1;
                    }
                }
            }

            return str;

        }

        public static String OldPhonePad(string input)
        {
            String result = "";

            input = PreProcess(input);

            String[] splitted = input.Split(' ');

            foreach (var item in splitted)
            {
                char[] temp = item.ToCharArray();



                int c = 0;
                char w = ' ';
                int count = 0;

                while (c < temp.Length)
                {

                    if (c == 0)
                    {
                        w = temp[c];
                        count = 1;

                    }
                    else
                    {

                        if (w == temp[c])
                        {
                            count += 1;
                        }
                        else
                        {
                            switch (w)
                            {
                                case '1':
                                    int cc = count % 4;
                                    if (cc == 1)
                                    {
                                        result = result + "&";
                                    }
                                    else if (cc == 2)
                                    {
                                        result = result + "'";
                                    }
                                    else
                                    {
                                        result = result + "(";
                                    }
                                    break;
                                case '2':
                                    cc = count % 4;
                                    if (cc == 1)
                                    {
                                        result = result + "A";
                                    }
                                    else if (cc == 2)
                                    {
                                        result = result + "B";
                                    }
                                    else
                                    {
                                        result = result + "C";
                                    }
                                    break;
                                case '3':
                                    cc = count % 4;
                                    if (cc == 1)
                                    {
                                        result = result + "D";
                                    }
                                    else if (cc == 2)
                                    {
                                        result = result + "E";
                                    }
                                    else
                                    {
                                        result = result + "F";
                                    }
                                    break;
                                case '4':
                                    cc = count % 4;
                                    if (cc == 1)
                                    {
                                        result = result + "G";
                                    }
                                    else if (cc == 2)
                                    {
                                        result = result + "H";
                                    }
                                    else
                                    {
                                        result = result + "I";
                                    }
                                    break;
                                case '5':
                                    cc = count % 4;
                                    if (cc == 1)
                                    {
                                        result = result + "J";
                                    }
                                    else if (cc == 2)
                                    {
                                        result = result + "K";
                                    }
                                    else
                                    {
                                        result = result + "L";
                                    }
                                    break;
                                case '6':
                                    cc = count % 4;
                                    if (cc == 1)
                                    {
                                        result = result + "M";
                                    }
                                    else if (cc == 2)
                                    {
                                        result = result + "N";
                                    }
                                    else
                                    {
                                        result = result + "O";
                                    }
                                    break;

                                case '7':
                                    cc = count % 5;
                                    if (cc == 1)
                                    {
                                        result = result + "P";
                                    }
                                    else if (cc == 2)
                                    {
                                        result = result + "Q";
                                    }
                                    else if (cc == 3)
                                    {
                                        result = result + "R";
                                    }
                                    else
                                    {
                                        result = result + "S";
                                    }
                                    break;
                                case '8':
                                    cc = count % 4;
                                    if (cc == 1)
                                    {
                                        result = result + "T";
                                    }
                                    else if (cc == 2)
                                    {
                                        result = result + "U";
                                    }
                                    else
                                    {
                                        result = result + "V";
                                    }
                                    break;

                                case '9':
                                    cc = count % 5;
                                    if (cc == 1)
                                    {
                                        result = result + "W";
                                    }
                                    else if (cc == 2)
                                    {
                                        result = result + "X";
                                    }
                                    else if (cc == 3)
                                    {
                                        result = result + "Y";
                                    }
                                    else
                                    {
                                        result = result + "Z";
                                    }
                                    break;
                                case '0':
                                    for (var j = 0; j < count; j++)
                                        result = result + " ";
                                    break;

                                case '#':
                                    return result;

                            }


                            w = temp[c];
                            count = 1;

                        }
                    }


                    c++;

                }

                switch (w)
                {
                    case '1':
                        int cc = count % 4;
                        if (cc == 1)
                        {
                            result = result + "&";
                        }
                        else if (cc == 2)
                        {
                            result = result + "'";
                        }
                        else
                        {
                            result = result + "(";
                        }
                        break;
                    case '2':
                        cc = count % 4;
                        if (cc == 1)
                        {
                            result = result + "A";
                        }
                        else if (cc == 2)
                        {
                            result = result + "B";
                        }
                        else
                        {
                            result = result + "C";
                        }
                        break;
                    case '3':
                        cc = count % 4;
                        if (cc == 1)
                        {
                            result = result + "D";
                        }
                        else if (cc == 2)
                        {
                            result = result + "E";
                        }
                        else
                        {
                            result = result + "F";
                        }
                        break;
                    case '4':
                        cc = count % 4;
                        if (cc == 1)
                        {
                            result = result + "G";
                        }
                        else if (cc == 2)
                        {
                            result = result + "H";
                        }
                        else
                        {
                            result = result + "I";
                        }
                        break;
                    case '5':
                        cc = count % 4;
                        if (cc == 1)
                        {
                            result = result + "J";
                        }
                        else if (cc == 2)
                        {
                            result = result + "K";
                        }
                        else
                        {
                            result = result + "L";
                        }
                        break;
                    case '6':
                        cc = count % 4;
                        if (cc == 1)
                        {
                            result = result + "M";
                        }
                        else if (cc == 2)
                        {
                            result = result + "N";
                        }
                        else
                        {
                            result = result + "O";
                        }
                        break;

                    case '7':
                        cc = count % 5;
                        if (cc == 1)
                        {
                            result = result + "P";
                        }
                        else if (cc == 2)
                        {
                            result = result + "Q";
                        }
                        else if (cc == 3)
                        {
                            result = result + "R";
                        }
                        else
                        {
                            result = result + "S";
                        }
                        break;
                    case '8':
                        cc = count % 4;
                        if (cc == 1)
                        {
                            result = result + "T";
                        }
                        else if (cc == 2)
                        {
                            result = result + "U";
                        }
                        else
                        {
                            result = result + "V";
                        }
                        break;

                    case '9':
                        cc = count % 5;
                        if (cc == 1)
                        {
                            result = result + "W";
                        }
                        else if (cc == 2)
                        {
                            result = result + "X";
                        }
                        else if (cc == 3)
                        {
                            result = result + "Y";
                        }
                        else
                        {
                            result = result + "Z";
                        }
                        break;
                    case '0':
                        for (var j = 0; j < count; j++)
                            result = result + " ";
                        break;
                    case '#':
                        return result;

                }



            }


            return result;
        }
    }
}

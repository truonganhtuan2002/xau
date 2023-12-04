using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi : ");
            string x = Console.ReadLine();
            // dem so tu cua 1 chuoi 
            int dem = 1, i = 0;
            while (i <= x.Length - 1)
            {
                if(x[i] ==' ')
                {
                    dem++;
                }
                i++;
            }
            Console.Write("So tu co trong chuoi la : "+dem);

            // tachs chuoi thanh cac ki tu va viet ho chu cai dau
            Console.WriteLine();
            char[] mangchar = x.ToCharArray();
            bool foundSpace = true;
            for (i = 0; i < mangchar.Length; i++)
            {
                if (char.IsLetter(mangchar[i]))
                {
                    if (foundSpace)
                    {
                        mangchar[i] = char.ToUpper(mangchar[i]);
                        foundSpace = false;
                    }
                }
                else foundSpace = true;

            }
            x = new string(mangchar);
            Console.Write(" " + x);

            Console.ReadKey();
        }
    }
}

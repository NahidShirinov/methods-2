using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] names = { "Revan", "Nahid", "Araz", "Nicat" };
            Array.Resize(ref names, names.Length +1);
            names[names.Length - 1] = "Sadig";
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }*/




            //string metodlari
            //1.Endwith ve Startwith
            //string str = "bu bir string metodudur";


            /* Console.WriteLine(str.EndsWith("metodudur"));
            Console.WriteLine(str.StartsWith("bir"));*/

            //2.Contains(muqayise) bool metodludur.
            /*Console.WriteLine(str.Contains("balaca"));
            Console.WriteLine(str.Contains("bu"));*/

            //Contains metyodunun daha fergli isledilmesi

            /* string[] str3 = { "Nahid", "Araz", "Sadig" };
             foreach(string s in str3)
             {
                 if (s.Contains('z'))
                 {

                 Console.WriteLine(s);
                 }

             }*/


            //3.Tolower ve Toupper 
            /*string str2 = "Bura Bakidir";
            Console.WriteLine(str2.ToLower());
            Console.WriteLine(str.ToUpper());*/

            //4.Replace
            /*Console.WriteLine(str.Replace("bu","Bunlar"));*/

            //5.Concat ve Join
            /* // create string
             string str1 = "C# ";
             Console.WriteLine("string str1: " + str1);

             // create string
             string str2 = "Programming";
             Console.WriteLine("string str2: " + str2);

             // join two strings
             string joinedString = string.Concat(str1, str2);
             Console.WriteLine("Joined string: " + joinedString);*/


            /* Console.WriteLine(string.Concat(str.Concat("okay")));*/

            //6.IndexOf 
            /*
            Console.WriteLine(str.IndexOf("bir"));
            Console.WriteLine(str.IndexOf("bal"));*/


            /*string fruit = "balaca ayi";
            int index = 0;
            while (fruit.IndexOf('a',index)!= -1) 
            {
                Console.WriteLine(fruit.IndexOf('a',index));
                index= fruit.IndexOf('a',index) + 1;
            }*/


            //7.substring bu metodlacumledeki sozlerin verilmis indekslere ygun olarag hansi sozun oldugunu vermek mumkundur           
            /*Console.WriteLine(str.Substring(6,12));
            Console.WriteLine(str.Substring(7));*/



            /* string str = "Nahidsirinov033@gmail.com";           
             int index = str.LastIndexOf('.');
             Console.WriteLine(str.Substring(index+1,str.Length-index-1)); */





            /* string str = "Nahidsirinov033@gmail.com";
             string str2 = "Nahidsrnv@166.az";
             int startindex = str.IndexOf("@");
             int Lastindex = str.LastIndexOf(".");
             int startindex2 = str2.IndexOf("@");
             int Lastindex2 = str2.LastIndexOf(".");
             Console.WriteLine(str.Substring(startindex + 1,Lastindex-1-startindex));
             Console.WriteLine(str2.Substring(startindex2 + 1, Lastindex2 - startindex2 - 1));*/



            int startindex = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            string str = "nahidsirinov@gmail.com";

            Console.WriteLine(str.Substring(startindex,length+startindex));









        
        /*static string substr(string str,int startindex,int length)
        {
            string newstr = "";
            if (length == 0)
            {
                newstr = str;
            }
            for(int i = 0; i < str.Length; i++)
            {
                if (startindex <= i && i < startindex + length)
                {

                newstr += str[i];
                }
            }
            return newstr; */


        }

    }
}
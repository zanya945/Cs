using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;
namespace Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("ab");
            list.Sort();
  



            StringBuilder sb = new StringBuilder("Hello",50);
            sb.ToString();
            sb.Append(new String(" world"));
            sb.AppendFormat(" Hello");//
            sb.Replace('H','h');//替換前面參數是要替換的字
            Console.WriteLine(list.Capacity);
            sb.Insert(0,"owo ");//插入
            foreach(string i in list){
            Console.WriteLine(i);
            }
            
        }
    }
}

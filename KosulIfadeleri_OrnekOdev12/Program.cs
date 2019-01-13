using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulIfadeleri_OrnekOdev12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan doğum yılı ay ve gün bilgisi alınız.
            //Kullanıcının burcunu ekrana Switch case yazdırınız. 

            int yil = DateTime.Now.Year;
            int ay = DateTime.Now.Month;
            int gun = DateTime.Now.Day;
            Console.WriteLine(yil.ToString());
            Console.WriteLine(ay.ToString());
            Console.WriteLine(gun.ToString());

            Console.ReadKey();

        }
    }
}

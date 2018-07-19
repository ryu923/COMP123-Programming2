using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide14
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass class1 = new MyClass(100, 1000);
            class1.DisplayNumbers();

            Console.WriteLine("------------------------");

            UserInfo user1 = new UserInfo("David", "30", DateTime.Now, "8123412");
            user1.DisplayUserInfo();

            Console.WriteLine("------------------------");

            CarInfo car1 = new CarInfo("Mercedez-Benz", "1 Yonge", "Sedan");
            car1.DisplayCarInfo();
        }
    }
}

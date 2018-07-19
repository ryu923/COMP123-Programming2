using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide14
{
    public class UserInfo
    {
        // FIELDS (Instance Variables)
        public string Name;
        public string Age;
        public DateTime BirthDay;
        private string UserID;

        // PROPERTIES for Private Accessibility Modifier
        public string USERID
        {
            get
            {
                return UserID;
            }
            set
            {
                UserID = value;
            }
        }

        // CONSTRUCTOR
        public UserInfo(string name, string age, DateTime birthday, string userID)
        {
            this.Name = name;
            this.Age = age;
            this.BirthDay = birthday;
            this.UserID = userID;
        }

        // Display Method
        public void DisplayUserInfo()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Birthday: {0}", BirthDay);
            Console.WriteLine("UserID: {0}", USERID);
        }
    }
}

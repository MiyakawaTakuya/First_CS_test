using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Constructor  //コンストラクターについてのLearn
{
    class Program
    { 
       static void Main(string[] args)
       {
            Person defaultPerson = new Person();
            Console.WriteLine(defaultPerson.GetFullnameWithAge()); //Taro Domyoji 26

            Person person1 = new Person("Takuya", "Miyakawa");
            Console.WriteLine(person1.GetFullnameWithAge()); //Takuya Miyakawa  26
            Console.WriteLine(person1.GetFullnameWithAge(18)); //Hikari Amamiya  18

            Person person2 = new Person("Hikari", "Amamiya");
            Console.WriteLine(person2.GetFullnameWithAge());  //Hikari Amamiya  26
            Console.WriteLine(person2.GetFullnameWithAge(18));  //Hikari Amamiya  18

            Person person3 = new Person("Hikari", 32);
            Console.WriteLine(person3.GetFullnameWithAge()); //Hikari 32
            Console.WriteLine(person3.GetFullnameWithAge(18));  //Hikari 18

            Person person4 = new Person("Takuya", "Miyakawa",35);
            Console.WriteLine(person4.GetFullnameWithAge());  //Takuya Miyakawa  35
            Console.WriteLine(person4.GetFullnameWithAge(26));  //Takuya Miyakawa 26
        }
    }
}

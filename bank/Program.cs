using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Bank
    {
        public Client []Clients { get; set; }

    }

    class BankCard
    {
        public string Bankname { get; set; }
        public string Username { get; set; }
        public string Pan { get; set; }
        public string Pin { get; set; }
        public string Cvc { get; set; }
        public DateTime  ExpiredDate { get; set; }
        public int Balance { get; set; }
        public BankCard(int balance,string bankname,string username,string pan,string pin,string cvc,DateTime expireddate)
        {

            Balance = balance;
            Bankname = bankname;
            Username = username;
            Pan = pan;
            Pin = pin;
            Cvc = cvc;
            ExpiredDate = expireddate;
        }
        public void Show()
        {
            Console.WriteLine($"pan : {Pan}");
            Console.WriteLine($"Pin : {Pin }");
            Console.WriteLine($" Cvc : {Cvc } ");
            Console.WriteLine($" Expired date : {ExpiredDate  } ");
            Console.WriteLine($" username : {Username  } ");
            Console.WriteLine($" bank name : {Bankname  } ");
            Console.WriteLine($" balance : {Balance  } ");
        }


        //PAN (kartin uzerindeki 16 reqemli kod) //string
        //PIN( karti bankamata daxil ederken yazdiginiz 4 reqemli kod) string
        //CVC(kartin arxasindaki 3 reqemli kod) / string 100-999(random)
        //ExpireDate (06/2023)
    }
    class Client
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public  string Surname{ get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public BankCard Bankcard { get; set; }
        public Client(int id,string name,string surname,int age,int salary,BankCard bankcard)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            Bankcard = bankcard; 
        }
        


        public void Show()
        {
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($" Surname : {Surname } ");
            Console.WriteLine($" Age : {Age } ");
            Console.WriteLine($" salary : {Salary } ");
            Console.WriteLine($" bankcard : {Bankcard  } ");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Random randomcvc = new Random();
            var datacvc = randomcvc.Next(100, 999);
            Random randombalance = new Random();
            var databalance = randombalance.Next(100, 900);
            Console.WriteLine("include pin");
            bool isIntPin =int.TryParse(Console.ReadLine(), out int pin);
            Console.WriteLine("include pan");
            bool isIntPan = int.TryParse(Console.ReadLine(), out int pan);
            Console.WriteLine("include cvc");
            bool isIntCvc = int.TryParse(Console.ReadLine(), out int cvc);
            if (isIntPin && isIntPan&&isIntCvc )
            {


               if( !Helper.Control(pin.ToString (), pan.ToString(),cvc.ToString ()))
                {
                    Console.WriteLine("please try again");
                    throw new Exception();
                }
                else
                {
                    BankCard bc = new BankCard(databalance, "bank", c.Name)
            Client c=new Client (2,"anara","ugurlu",18,2000,bc)
                }
            }
        }
    }
}

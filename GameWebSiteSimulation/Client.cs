using System;
namespace GameWebSiteSimulation
{
    public class Client
    {
        public string firstName=" ";
        public string name=" ";
        public string TCNo=" ";
        public int year=-1;

        public Client(string firstname,string name, string tcno, int year)
        {
            setFirstName(firstname);
            setName(name);
            setTCNo(tcno);
            setYear(year);
        }
        public string getFirstName() {
            return this.firstName;
        }
        public string getName()
        {
            return this.name;
        }
        public string getTCNo()
        {
            return this.TCNo;
        }
        public int getYear()
        {
            return this.year;
        }
        public int getAge() {
            return 2021 - this.year;
        }

        public void setFirstName(String firstname)
        {
            foreach (char letter in firstname) {
                if (Char.IsDigit(letter)) {
                    Console.WriteLine("name can not contain numbers!");
                    Environment.Exit(0);
                }
            }

            if (firstname.Length > 2)
                this.firstName = firstname;
            else
                Console.WriteLine("Name can not shorter than 2 letter!");
        }

        public void setName(String name)
        {
            foreach (char letter in name)
            {
                if (Char.IsDigit(letter))
                {
                    Console.WriteLine("name can not contain numbers!");
                    Environment.Exit(0);
                }
            }

            if (name.Length > 2)
                this.name = name;
            else
                Console.WriteLine("Name can not shorter than 2 letter!");
        }

        public void setTCNo(string tcno)
        {
            foreach (char number in tcno)
            {
                if (!Char.IsDigit(number))
                {
                    Console.WriteLine("TCNo can not contain letters!");
                    Environment.Exit(0);
                }
            }

            if (tcno.Length == 11)
                this.TCNo = tcno;
            else
                Console.WriteLine("Please enter your 11-stage TCNo");
        }

        public void setYear(int year)
        {
            if (year >= 1900 && year <= 2021)
                this.year = year;
            else
                Console.WriteLine("Please enter a year in use");
        }
    }


}


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
      
        public int getAge() {
            return 2021 - this.year;
        }

        public Boolean setFirstName(String firstname)
        {
            foreach (char letter in firstname) {
                if (Char.IsDigit(letter)) {
                    Console.WriteLine("name can not contain numbers!");
                    return false;
                }
            }

            if (firstname.Length > 2)
                this.firstName = firstname;
            else
            {
                Console.WriteLine("Name can not shorter than 2 letter!");
                return false;
            }

            return true;
        }

        public Boolean setName(String name)
        {
            foreach (char letter in name)
            {
                if (Char.IsDigit(letter))
                {
                    Console.WriteLine("name can not contain numbers!");
                    return false;
                }
            }

            if (name.Length > 2)
                this.name = name;
            else
            {
                Console.WriteLine("Name can not shorter than 2 letter!");
                return false;
            }
            return true;
        }

        public Boolean setTCNo(string tcno)
        {
            foreach (char number in tcno)
            {
                if (!Char.IsDigit(number))
                {
                    Console.WriteLine("TCNo can not contain letters!");
                    return false;
                }
            }

            if (tcno.Length == 11)
                this.TCNo = tcno;
            else {
                Console.WriteLine("Please enter your 11-stage TCNo");
                return false;
            }
            return true;
        }

        public Boolean setYear(int year)
        {
            if (year >= 1900 && year <= 2021)
                this.year = year;
            else
            {
                Console.WriteLine("Please enter a year in use");
                return false;
            }
            return true;
        }
        public Boolean ifReal() {
            return setFirstName(firstName) && setName(name) && setTCNo(TCNo) && setYear(year);    
        }
    }


}


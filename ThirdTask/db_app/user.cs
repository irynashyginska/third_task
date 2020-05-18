using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Data.Common;
using System.Text.RegularExpressions;
namespace db_app
{
    public class User
    {
        private int id;
        public int Id { get { return this.id; } set { this.id = numbsint(value.ToString()); } }
        private string first_name;
        public string First_name { get { return this.first_name; } set { this.first_name = words(value); } }
        private string last_name;
        public string Last_name { get { return this.last_name; } set { this.last_name = words(value); } }
        private string email;
        public string Email { get { return this.email; } set { this.email = check_email(value); } }
        private string password;
        public string Password { set { this.password = check_password(value); } }
        private string role;
        public string Role { get { return this.role; } set { this.role = check_role(value); } }

        public User(int id = 0, string f = "none", string l = "none", string e = "email@gmail.com",string p = "Sh7000&",string r = "seller")
        {
            this.id = id;
            this.first_name = f;
            this.last_name = l;
            this.email = e;
            this.password = p;
            this.role = r;
        }
        public string check_email(string w)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            while (true)
            {
                if (Regex.IsMatch(w, pattern, RegexOptions.IgnoreCase))
                {
                    return w;
                }
                else
                {
                    Console.WriteLine("incorrect email");
                    Console.WriteLine("Input new email ");
                    w = Console.ReadLine();
                }
            }
        }
        public static Boolean isAlpha(string strToCheck)
        {
            Regex rg = new Regex(@"^[a-zA-Z\s,]*$");
            return rg.IsMatch(strToCheck);
        }
        public string words(string word)
        {
            while (word.All(Char.IsLetter) == false)
            {
                Console.WriteLine("Error. Wrong word in object with name ", this.first_name, " ");
                Console.WriteLine("Enter another word ");
                word = Console.ReadLine();
            }
            return word;
        }
        public double numbs(string num)
        {
            while (isfloat(num) == false || num[0].Equals("-") == true)
            {
                Console.WriteLine("Error. Wrong number in object with name ", this.first_name, " ");
                Console.WriteLine("Enter another number ");
                num = Console.ReadLine();
            }
            return double.Parse(num);
        }

        public Boolean isfloat(string num)
        {
            try
            {
                double n = double.Parse(num);
                return true;
            }
            catch
            {
                return false;
            }


        }
        public int numbsint(string num)
        {
            while (num.All(Char.IsDigit) == false)
            {
                Console.WriteLine("Error. Wrong number in object with name ", this.first_name, " ");
                Console.WriteLine("Enter another number ");
                num = Console.ReadLine();

            }
            return int.Parse(num);
        }
        public string check_role(string w)
        {
            while (true) {
                if (w.Equals("seller") || w.Equals("buyer"))
                {
                    return w;
                }
                else
                {
                    Console.WriteLine("Error. Wrong role in object with name ", this.first_name, " ");
                    Console.WriteLine("Enter another role(seller or buyer) ");
                    w = Console.ReadLine();
                }
            }
        }
        public string check_password(string p)
        {
            string p1 = @"\d";
            string p2 = @"\W";
            string p3 = @"[A-Z]";
            while(true)
            {
                if (Regex.IsMatch(p, p1) && Regex.IsMatch(p, p2) && Regex.IsMatch(p, p3))
                    return p;
                else
                {
                    Console.WriteLine("Error. Wrong password in object with name ", this.first_name, " ");
                    Console.WriteLine("Enter another password ");
                    p = Console.ReadLine();
                }
            }
        }
        public void inp_from_file(string line)
        {
            string[] a = line.Split();
            this.id = numbsint(a[0]);
            this.first_name = words(a[1]);
            this.last_name = words(a[2]);
            this.email = check_email(a[3]);
            this.password = check_password(a[4]);
            this.role = check_role(a[5]);
        }
        public int add_to_bd(NpgsqlConnection con)
        {
            string command = String.Format("INSERT INTO user_t(id, first_name, last_name, email, password, role) VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}'); ", this.id, this.first_name, this.last_name, this.email, this.password, this.role);
            NpgsqlCommand insert = new NpgsqlCommand(command, con);
            int count = insert.ExecuteNonQuery();
            if (count == 1)
            {
                return count;
            }
            else return 0;
        }
        
    }
}

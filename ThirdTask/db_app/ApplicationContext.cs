using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.Common;
namespace db_app
{
    public class ApplicationContext
    {
        public string connectionStr;
        public List<Ship> l;
        public ApplicationContext(string s = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=postgres;Database=ship_db;")
        {
            this.connectionStr = s;
            
            
        }
        public NpgsqlConnection create_connection(string command)
        {
            return new NpgsqlConnection(command);
        }
        public string select_all_users()
        {
            NpgsqlConnection c = create_connection(this.connectionStr);
            c.Open();
            NpgsqlCommand sel = new NpgsqlCommand("SELECT * FROM user_t", c);
            NpgsqlDataReader read = sel.ExecuteReader();
            string str = "";
            if (read.HasRows)
            {

                foreach (DbDataRecord data in read)
                    str += data["id"] + " " + data["first_name"] + "\n";
            }
            else
                str = "error\n";
            c.Close();
            return str;
        }
        public User find_user( string text1, string text2)
        {
            NpgsqlConnection c = create_connection(this.connectionStr);
            c.Open();
                string command = String.Format("SELECT * FROM user_t WHERE (user_t.email = '{0}' AND user_t.password = '{1}');", text1, text2);
                NpgsqlCommand find = new NpgsqlCommand(command, c);
                NpgsqlDataReader read = find.ExecuteReader();
                string str = "";
                User u = null;
                if (read.HasRows)
                {
                    foreach (DbDataRecord data in read)
                    {
                        str += data["id"] + " " + data["first_name"] + " " + data["last_name"] + " " + data["email"] + " " + data["password"] + " " + data["role"];
                        string[] a = str.Split();
                        u = new User(int.Parse(a[0]), a[1], a[2], a[3], a[4], a[5]);

                    }

                }
            c.Close();
                return u;
            

        }
        public List<Ship> Find_ship(int id)
        {
            NpgsqlConnection c = create_connection(this.connectionStr);
            c.Open();
            string command = String.Format("SELECT ship_t.id, ship_t.name, ship_t.registration, ship_t.freight, ship_t.departure, ship_t.personnel FROM user_ship JOIN user_t ON user_ship.user_id = user_t.id JOIN ship_t ON user_ship.ship_id = ship_t.id WHERE user_t.id = {0}; ", id.ToString());
            NpgsqlCommand find_sh = new NpgsqlCommand(command, c);
            NpgsqlDataReader read_sh = find_sh.ExecuteReader();
            
            this.l = null;
            if (read_sh.HasRows)
            {
                this.l = new List<Ship>();
                foreach (DbDataRecord data in read_sh)
                {
                    string str = "";
                    str += data["id"] + " " + data["name"] + " " + data["registration"] + " " + data["freight"] + " " + data["departure"] + " " + data["personnel"];
                    string[] a = str.Split();
                    this.l.Add( new Ship(int.Parse(a[0]), a[1], a[2], double.Parse(a[3]), a[4], int.Parse(a[5])));

                }

            }
            c.Close();
            return this.l;


        }
        public int update_bd(Ship sh)
        {
            NpgsqlConnection c = create_connection(this.connectionStr);
            c.Open();
            string command = String.Format("UPDATE ship_t SET id = {0}, name = '{1}', registration = '{2}', freight = '{3}', departure = '{4}', personnel = '{5}' WHERE id = {0}; ", sh.Id, sh.Name, sh.Registration, sh.Freight.ToString(), sh.Departure, sh.Personnel.ToString());
            NpgsqlCommand update = new NpgsqlCommand(command, c);
            int count = update.ExecuteNonQuery();
            if (count == 1)
            {
                return count;
            }
            else return 0;
        }
        public List<Ship> select_all_ships()
        {
            NpgsqlConnection c = create_connection(this.connectionStr);
            c.Open();
            string command = String.Format("SELECT ship_t.id, ship_t.name, ship_t.registration, ship_t.freight, ship_t.departure, ship_t.personnel FROM ship_t");
            NpgsqlCommand find_sh = new NpgsqlCommand(command, c);
            NpgsqlDataReader read_sh = find_sh.ExecuteReader();

            this.l = null;
            if (read_sh.HasRows)
            {
                this.l = new List<Ship>();
                foreach (DbDataRecord data in read_sh)
                {
                    string str = "";
                    str += data["id"] + " " + data["name"] + " " + data["registration"] + " " + data["freight"] + " " + data["departure"] + " " + data["personnel"];
                    string[] a = str.Split();
                    this.l.Add(new Ship(int.Parse(a[0]), a[1], a[2], double.Parse(a[3]), a[4], int.Parse(a[5])));

                }

            }
            c.Close();
            return this.l;
        }
        public Ship find_obj(int id)
        {
            int m = 0;
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].Id == id)
                { 
                    return l[i];
                }
                m += 1;
            }
            
             return null; 
        }
        public int delete_ship(Ship sh)
        {
            NpgsqlConnection c = create_connection(this.connectionStr);
            c.Open();
            string command = String.Format("DELETE FROM ship_t WHERE id = {0}; ", sh.Id);
            NpgsqlCommand insert = new NpgsqlCommand(command, c);
            int count = insert.ExecuteNonQuery();
            if (count == 1)
            {
                return count;
            }
            else return 0;
        }
        public int add_to_bd(Ship sh)
        {
            NpgsqlConnection c = create_connection(this.connectionStr);
            c.Open();
            string command = String.Format("INSERT INTO ship_t(id, name, registration, freight, departure, personnel) VALUES({0}, '{1}', '{2}', '{3}', '{4}', '{5}'); ", sh.Id, sh.Name, sh.Registration, sh.Freight, sh.Departure, sh.Personnel);
            NpgsqlCommand insert = new NpgsqlCommand(command, c);
            int count = insert.ExecuteNonQuery();
            if (count == 1)
            {
                return count;
            }
            else return 0;
        }
    }
}


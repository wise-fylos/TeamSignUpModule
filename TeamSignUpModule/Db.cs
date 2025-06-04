using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSignUpModule
{
    internal class Db
    {
        private String strConn = "Data Source = ;" + "Database=; Uid=; Pwd=; CharSet = utf8;";

        public void sendData(string name, string nickname, string id, string pw, int dep, string address, string team, string imgPath)
        {
            //send userData to DB

            int team_id = getTeamId(team);

            String query = "INSERT INTO EMPLOYEE_TABLE VALUES ('" + id + "', AES_ENCRYPT('" + pw + "', SHA2('key', 512)), '" + name + "', '" + nickname + "', '" + address + "', '" + dep + "', '" + team_id + "',  0)";
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
            }

            if (imgPath == "") return;

            byte[] imgBt = null;
            FileStream fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imgBt = br.ReadBytes((int)fs.Length);

            query = "INSERT INTO PROFILE_TABLE(employee_id, profile_nickname, profile_image, multi_profile_id) VALUES ('" + id + "', '" + nickname + "', @IMG, 0)";
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add(new MySqlParameter("@IMG", imgBt));
                MySqlDataReader reader = cmd.ExecuteReader();
                connection.Close();
            }
        }

        public bool avCheck(string id)
        {
            //get id data form DB and compare redundancy
            String result = "";
            String query = "SELECT EXISTS (select employee_id from EMPLOYEE_TABLE where employee_id = '" + id + "' limit 1) as success;";
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                result = rdr[0].ToString();
                rdr.Close();
                connection.Close();
            }
            if (result == "1") return false;
            return true;
        }

        public List<String> getDep()
        {
            List<String> values = new List<String>();
            //get department data(obj) form DB
            String query = "SELECT department_name FROM DEPARTMENT_TABLE";
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    String obj = rdr[0].ToString();
                    values.Add(obj);
                }
                rdr.Close();
                connection.Close();
            }
            return values;
        }

        public List<String> getTeam(int index)
        {
            List<String> values = new List<String>();
            String query = "SELECT team_name FROM TEAM_TABLE where department_id = " + index;
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    String obj = rdr[0].ToString();
                    values.Add(obj);
                }
                rdr.Close();
                connection.Close();
            }
            return values;
        }

        public int getTeamId(String team)
        {
            int id = 0;
            String query = "SELECT team_id FROM TEAM_TABLE where team_name = '" + team + "';";
            using (MySqlConnection connection = new MySqlConnection(strConn))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                id = Int32.Parse(rdr[0].ToString());
                rdr.Close();
                connection.Close();
            }
            return id;
        }
    }
}

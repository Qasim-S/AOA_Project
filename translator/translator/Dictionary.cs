using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace translator
{
    public class Dictionary
    {
        private List<Tuple<string, string, string>> dict = new List<Tuple<string, string, string>>();

        public Dictionary()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MOAT4VF\SQLEXPRESS01;Initial Catalog=Translator;Integrated Security=True");
            string sql = "select * from dictionary";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string word = dr["word"].ToString();
                string translation = dr["translation"].ToString();
                string partOfSpeech = dr["part-of-speech"].ToString();
                var record = Tuple.Create(word, translation, partOfSpeech);
                dict.Add(record);
            }

        }
        
        private int linearSearch(string word)
        {
            for (int i = 0; i < dict.Count; ++i)
            {
                if (dict[i].Item1 == word)
                {
                    return i;
                }
            }
            return -1;
        }
        public string[] search(string word)
        {
            word = word.ToLower();
            string[] translated = new string[2];
            translated[0] = "";
            translated[1] = "";
            int key = linearSearch(word);
            if(key == -1)
            {
                return translated;
            }
            translated[0] = dict[key].Item2;
            translated[1] = dict[key].Item3;
            return translated;
        }
    }
}
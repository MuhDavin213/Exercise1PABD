using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            while (true)
            {
                try
                {
                    Console.WriteLine("koneksi ke database\n");
                    Console.WriteLine("Masukkan User ID :");
                    String user = Console.ReadLine();
                    Console.WriteLine("masukkan password");
                    string pass = Console.ReadLine();
                    Console.WriteLine("masukkan database tujuan");
                    string db = Console.ReadLine();
                    Console.Write("\nKetik K untuk terhubung ke Database: ");
                    char chr = Convert.ToChar(Console.ReadLine());
                    switch (chr)
                    {
                        case 'K':
                            {
                                SqlConnection conn = null;
                                string strKoneksi = "data source = MUHDAVIN\\MUHDAVIN;" +
                                    "initial catalog = {0}; " + "User ID {1}; password = {2}";
                                conn = new SqlConnection(string.Format(strKoneksi, db, user, pass));
                                conn.Open();
                                Console.Clear();
                                while (true)
                                {

                                }
                            }
                    }
                }
            }
        }
    }
}

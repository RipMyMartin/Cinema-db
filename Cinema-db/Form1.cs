using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class Form1 : Form
{
    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ripmy\source\repos\Cinema-db\cinemadb.mdf;Integrated Security=True");
    public Form1()
    {

    }
}

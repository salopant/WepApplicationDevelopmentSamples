using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Import namespace OleDb for databases
using System.Data.OleDb;
//System.Data for command object
using System.Data;

namespace DatabaseExample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //In class method(s), create and open connection
            //This can be done either once (e.g. Page_Load) for each
            //page request, or only when required
            String connstr;
            String projectPath = @"C:\Users\salopant\asalo\Web App Development\2014\WebSites\WepApplicationDevelopmentSamples\DatabaseExample";
            connstr = "Provider = Microsoft.Jet.OLEDB.4.0;" +
                @"Data Source = "+ projectPath +@"\Data\CustomerOrders2014.mdb;";
            //OleDbConnection requires namespace System.Data.OleDb
            OleDbConnection myConnection = new OleDbConnection();
            
            myConnection.ConnectionString = connstr;
            myConnection.Open();
            //Now that connection is open we can make SQL request 
 
            //Build command object
            OleDbCommand myCommand = new OleDbCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "SELECT CustID, Name FROM Customer";
            //CommandType requires namespace System.Data
            myCommand.CommandType = CommandType.Text ;

            //Execute the SQL request command and store the output in myReader object
            OleDbDataReader myReader;
            myReader = myCommand.ExecuteReader();

            //This method allows to control the reading of database response rows
            bool notEoF;
            //read first row from database
            notEoF = myReader.Read();
            //read row by row until the last row
            while (notEoF)
            {
                //add new item on list box
                ListBox1.Items.Add(myReader["name"].ToString());
                ListBox1.Items[ListBox1.Items.Count - 1].Value = myReader["Custid"].ToString();
                //read next row
                notEoF = myReader.Read();
            }

            ////This data binding method reads all rows
            ////no possibility to control the read process 
            //ListBox1.DataSource = myReader;
            //ListBox1.DataTextField = "Name";
            //ListBox1.DataValueField = "CustID";
            //ListBox1.DataBind();

            myReader.Close();
            myConnection.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connstr;
            String projectPath = @"C:\Users\salopant\asalo\Web App Development\2014\WebSites\WepApplicationDevelopmentSamples\DatabaseExample";
            connstr = "Provider = Microsoft.Jet.OLEDB.4.0;" +
                @"Data Source = "+ projectPath +@"\Data\CustomerOrders2014.mdb;";
            //OleDbConnection requires namespace System.Data.OleDb
            OleDbConnection myConnection = new OleDbConnection();
            
            myConnection.ConnectionString = connstr;
            
            //Now that connection is open we can make SQL request 
            OleDbCommand myCommand = new OleDbCommand();
            myCommand.Connection = myConnection;
            myCommand.CommandText = "INSERT INTO Customer(CustID, Name,Area, Balance ) " + 
                    "VALUES ('" + CustID_text.Text + "','" + Name_text.Text + 
                    "','" + area_text.Text + "'," + balance_text.Text + ")";

            myConnection.Open();
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            //In class method(s), create and open connection
            //This can be done either once (e.g. Page_Load) for each
            //page request, or only when required

            myConnection.ConnectionString = connstr;
            myConnection.Open();
            //Now that connection is open we can make SQL request 

            myCommand.Connection = myConnection;
            myCommand.CommandText = "SELECT CustID, Name FROM Customer";
            //CommandType requires namespace System.Data
            myCommand.CommandType = CommandType.Text;

            //Execute the SQL request command and store the output in myReader object
            OleDbDataReader myReader;
            myReader = myCommand.ExecuteReader();

            //This method allows to control the reading of database response rows
            bool notEoF;
            ListBox1.Items.Clear();
            //read first row from database
            notEoF = myReader.Read();
            //read row by row until the last row
            while (notEoF)
            {
                //add new item on list box
                ListBox1.Items.Add(myReader["name"].ToString());
                ListBox1.Items[ListBox1.Items.Count - 1].Value = myReader["Custid"].ToString();
                //read next row
                notEoF = myReader.Read();
            }

            ////This data binding method reads all rows
            ////no possibility to control the read process 
            //ListBox1.DataSource = myReader;
            //ListBox1.DataTextField = "Name";
            //ListBox1.DataValueField = "CustID";
            //ListBox1.DataBind();

            myReader.Close();
            myConnection.Close();


        }
    }
}
/*
 * Created by SharpDevelop.
 * User: MADARA UCHIHA (Ahmad Rizal Afani - http://calonpresident.blogspot.com)
 * Date: 23/04/2013
 * Time: 20:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.OleDb;

namespace crud_access
{
	public class Connection
	{
		public Connection()
		{
			try
			{
				alamat = "Provider=Microsoft.ace.Oledb.12.0; Data Source=database.accdb";
            	koneksi = new OleDbConnection(alamat);
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString());
			}
		}
		
		private string alamat;
        private OleDbConnection koneksi;
        private OleDbCommand perintah;
        private OleDbDataAdapter adapter;
        private DataSet ds;
        private static Connection connection = null;
        
        public static Connection GetInstance(){
        	if(Connection.connection == null){
        		Connection.connection = new Connection();
        	}        	
        	return Connection.connection;
        }
        
        private DataSet GetData(string query)
        {
            try
            {
                ds = new DataSet();
                koneksi.Open();
                perintah = new OleDbCommand(query, koneksi);
                adapter = new OleDbDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private int ManipulasiData(string query)
        {
            try
            {
                int res = 0;
                koneksi.Open();
                perintah = new OleDbCommand(query, koneksi);
                adapter = new OleDbDataAdapter(perintah);
                res = perintah.ExecuteNonQuery();
                koneksi.Close();
                return res;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        
        public DataSet GetContact(){
        	return GetData("select * from phonebook");
        }
        
        public DataSet GetContact(string contact_name){
        	return GetData("select * from phonebook where contact_name = '"+contact_name+"';");
        }
        
        public int TambahContact(string name,string number,string address){
        	return ManipulasiData("insert into phonebook values ('"+name+"','"+number+"','"+address+"');");
        }
        
        public int UbahContact(string name,string number,string address){
        	return ManipulasiData("update phonebook set contact_number = '"+number+"', address = '"+address+"' where contact_name = '"+name+"';");
        }
        
        public int DeleteContact(string name){
        	return ManipulasiData("delete from phonebook where contact_name = '"+name+"';");
        }
	}
}

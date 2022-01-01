using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace finalProgact
{
    class DataManagementProduct
    {
        public List<List<String>> SelectData() {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "SELECT * FROM [product]";
            
            List<List<String>> data = new List<List<String>>() ; 
            
            using( OleDbConnection con = new OleDbConnection(connectionString)){

            OleDbCommand command = new OleDbCommand(strSQL, con);
            con.Open();
            OleDbDataReader reader = command.ExecuteReader();

            while(reader.Read() ){
                Console.WriteLine("SELECT: {0} {1}", reader["ID"].ToString(), reader["Pname"].ToString());
                data.Add(new List<string> { reader["ID"].ToString(), reader["Pname"].ToString(), reader["manufacturer"].ToString(), reader["price"].ToString(), reader["qouta"].ToString(), reader["availabitity"].ToString(), reader["image"].ToString() });
                }
            con.Close();
            }
            return data;    
        }

        public List<String> SelectUserData()
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "SELECT * FROM [product] WHERE id=(SELECT MAX(id) FROM [product]);";

            List<String> data = new List<String>();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);
                
                con.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("SELECT USER: {0} {1}", reader["Pname"].ToString(), reader["manufacturer"].ToString());
                    data =  new List<string> { reader["ID"].ToString(), reader["Pname"].ToString(), reader["manufacturer"].ToString(), reader["price"].ToString(), reader["qouta"].ToString(), reader["availabitity"].ToString(), reader["image"].ToString() };
                }
                con.Close();
            }
            return data;
        }

        public List<String> InsertData(String Pname, String manufacturer, int price, int qouta,String availabitity, String image)
        {

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "INSERT INTO [product]([Pname],[manufacturer],[price],[qouta],[availabitity],[image]) VALUES(@Pname,@Manufacturer,@Price,@Qouta,@Availabitity,@Image)";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);
                command.Parameters.Add(new OleDbParameter("@Pname", Pname));
                command.Parameters.Add(new OleDbParameter("@Manufacturer", manufacturer));
                command.Parameters.Add(new OleDbParameter("@Price", price));
                command.Parameters.Add(new OleDbParameter("@Qouta", qouta));
                command.Parameters.Add(new OleDbParameter("@Availabitity", availabitity));
                command.Parameters.Add(new OleDbParameter("@Image", image));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                List<String> dataUSer =  SelectUserData();

                

                return dataUSer;
            }
        }

        public void UpdateData(int ID, String Pname, String manufacturer, int price, int qouta, String availabitity, String image)
        {

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "UPDATE [product] SET [Pname] = @Pname,[manufacturer] = @Manufacturer,[price] = @Price,[qouta] = @Qouta,[availabitity] = @Availabitity,[image]=@Image   WHERE ID=@ID";


            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);
                command.Parameters.Add(new OleDbParameter("@Pname", Pname));
                command.Parameters.Add(new OleDbParameter("@Manufacturer", manufacturer));
                command.Parameters.Add(new OleDbParameter("@Price", price));
                command.Parameters.Add(new OleDbParameter("@Qouta", qouta));
                command.Parameters.Add(new OleDbParameter("@Availabitity", availabitity));
                command.Parameters.Add(new OleDbParameter("@Image", image));
                command.Parameters.Add(new OleDbParameter("@ID", ID));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        public void DeleteData(int ID)
        {

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";


            string strSQL = "DELETE FROM [product] WHERE ID =@ID";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);
                
                command.Parameters.Add(new OleDbParameter("@ID", ID));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                
            }
        }

        public List<List<String>> SerchProdect(String prodect)
        {
            Console.WriteLine("SerchProdect: "+ prodect);
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "SELECT * FROM [product] WHERE [Pname] LIKE '%" + prodect + "%'" + "OR [manufacturer] LIKE '%" + prodect + "%';"; // or [manufacturer] LIKE * @Manufacturer *";
            

            List<List<String>> data = new List<List<String>>();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);

                con.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("Search:" + reader["Pname"].ToString());
                    data.Add(new List<string> { reader["ID"].ToString(), reader["Pname"].ToString(), reader["manufacturer"].ToString(), reader["price"].ToString(), reader["qouta"].ToString(), reader["availabitity"].ToString(), reader["image"].ToString() });
                }
                con.Close();
            }
            return data;
        }
        public List<List<String>> SerchAvailabitity(int cheack)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL= "SELECT * FROM [product]";
            if (cheack == 0)
                strSQL = "SELECT * FROM [product] WHERE  availabitity='Available';";
            else if (cheack == 1)
                strSQL = "SELECT * FROM [product] WHERE  availabitity='UnAvailable';";


            List<List<String>> data = new List<List<String>>();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);

                con.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("Search:" + reader["Pname"].ToString());
                    data.Add(new List<string> { reader["ID"].ToString(), reader["Pname"].ToString(), reader["manufacturer"].ToString(), reader["price"].ToString(), reader["qouta"].ToString(), reader["availabitity"].ToString(), reader["image"].ToString() });
                }
                con.Close();
            }
            return data;
        }
    }

    class DataManagementMember
    {
        public List<List<String>> SelectData()
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "SELECT * FROM [member]";

            List<List<String>> data = new List<List<String>>();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);
                con.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("SELECT: {0} {1}", reader["ID"].ToString(), reader["MName"].ToString());
                    data.Add(new List<string> { reader["ID"].ToString(), reader["MName"].ToString(), reader["surname"].ToString(), reader["phone"].ToString(), reader["image"].ToString(), reader["userName"].ToString(), reader["password"].ToString() });
                }
                con.Close();
            }
            return data;
        }

        public List<String> SelectUserData()
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "SELECT * FROM [member] WHERE id=(SELECT MAX(id) FROM [member]);";

            List<String> data = new List<String>();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);

                con.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data = new List<string> { reader["ID"].ToString(), reader["MName"].ToString(), reader["surname"].ToString(), reader["phone"].ToString(), reader["image"].ToString(), reader["userName"].ToString(), reader["password"].ToString() };
                }
                con.Close();
            }
            return data;
        }

        public List<String> InsertData(String MName, String Surname, String Phone, String Image, String UserName, String Password)
        {

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            


            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                con.Open();

                string strSQL = "SELECT userName FROM [member] WHERE userName=@UserName;";
                OleDbCommand command0 = new OleDbCommand(strSQL, con);
                command0.Parameters.Add(new OleDbParameter("@UserName", UserName));
                OleDbDataReader reader = command0.ExecuteReader();

                while (reader.Read())
                {
                    
                    String data = reader["userName"].ToString();
                    Console.WriteLine("Data: "+ data);
                    if (data != "" && data != null){
                        System.Windows.Forms.MessageBox.Show("Username already exists !!!");
                        return new List<String>{};
                    }
                }

                
                strSQL = "INSERT INTO [member]([MName],[surname],[phone],[image],[userName],[password]) VALUES(@MName,@Surname,@Phone,@Image,@UserName,@Password)";
                OleDbCommand command = new OleDbCommand(strSQL, con);
                command.Parameters.Add(new OleDbParameter("@MName", MName));
                command.Parameters.Add(new OleDbParameter("@Surname", Surname));
                command.Parameters.Add(new OleDbParameter("@Phone", Phone));
                command.Parameters.Add(new OleDbParameter("@Image", Image));
                command.Parameters.Add(new OleDbParameter("@UserName", UserName));
                command.Parameters.Add(new OleDbParameter("@Password", Password));
                
                command.ExecuteNonQuery();
                con.Close();
                List<String> dataUSer = SelectUserData();


                return dataUSer;
            }
        }

        public void UpdateData(int ID, String MName, String Surname, String Phone, String Image, String UserName, String Password)
        {

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "UPDATE [member] SET [MName] = @MName,[surname] = @Surname,[phone] = @Phone,[image] = @Image,[userName] = @UserName,[password]=@Password   WHERE ID=@ID";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);
                command.Parameters.Add(new OleDbParameter("@MName", MName));
                command.Parameters.Add(new OleDbParameter("@Surname", Surname));
                command.Parameters.Add(new OleDbParameter("@Phone", Phone));
                command.Parameters.Add(new OleDbParameter("@Image", Image));
                command.Parameters.Add(new OleDbParameter("@UserName", UserName));
                command.Parameters.Add(new OleDbParameter("@Password", Password));
                command.Parameters.Add(new OleDbParameter("@ID", ID));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

            }
        }

        public void DeleteData(int ID)
        {

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";


            string strSQL = "DELETE FROM [member] WHERE ID =@ID";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);

                command.Parameters.Add(new OleDbParameter("@ID", ID));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

            }
        }

        public List<List<String>> SerchMember(String prodect)
        {
            Console.WriteLine("SerchMember: " + prodect);
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "SELECT * FROM [member] WHERE [MName] LIKE '%" + prodect + "%'" + "OR [phone] LIKE '%" + prodect + "%'" + "OR [userName] LIKE '%" + prodect + "%'" + "OR [surname] LIKE '%" + prodect + "%';"; 


            List<List<String>> data = new List<List<String>>();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);

                con.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data.Add(new List<string> { reader["ID"].ToString(), reader["MName"].ToString(), reader["surname"].ToString(), reader["phone"].ToString(), reader["image"].ToString(), reader["userName"].ToString(), reader["password"].ToString() });
                }
                con.Close();
            }
            return data;
        }
    }

    class DataManagementSellings {
        public List<String> GetData (){ 
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";

            List<String> data = new List<String>();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                string strSQL = "SELECT count(ID)as Id FROM [product]";
                OleDbCommand command = new OleDbCommand(strSQL, con);
                
                con.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("DataManagementSellings: " + reader["Id"].ToString());
                    data.Add( reader["Id"].ToString());
                }
                
                strSQL = "SELECT count(ID) as Id FROM member";
                command = new OleDbCommand(strSQL, con);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("DataManagementSellings: " + reader["Id"].ToString());
                    data.Add(reader["Id"].ToString());
                }

                strSQL = "SELECT SUM(qoutity) as q, SUM(amount) as a FROM sellings";
                command = new OleDbCommand(strSQL, con);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("DataManagementSellings: " + reader["q"].ToString());
                    data.Add(reader["q"].ToString());
                    data.Add(reader["a"].ToString());
                }

                con.Close();
            }
            return data;
        }
        
        public int GetPrice(int ID) {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "SELECT price FROM product WHERE ID=@ID";

            int data = 1;
            Console.WriteLine(" ID: " + ID);
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);
                command.Parameters.Add(new OleDbParameter("@ID", ID));
                con.Open();
                
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("price: " + reader["price"].ToString());
                    data = int.Parse( reader["price"].ToString());
                }
                con.Close();
            }
            return data;
        }

        public int InserConfirm(String productName, int productId, String memberName, int memberID, int quantity, int amount)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "INSERT INTO [sellings] ([productId],[memberId],qoutity,amount)VALUES(@ProductId,@MemberID,@Quantity,@Amount)";

            Console.WriteLine("productName: " + productName);
            Console.WriteLine("productId: " + productId);
            Console.WriteLine("memberName: " + memberName);
            Console.WriteLine("memberID: " + memberID);
            Console.WriteLine("quantity: " + quantity);
            Console.WriteLine("amount: " + amount);
            int qouta = 0;

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);
                command.Parameters.Add(new OleDbParameter("@ProductId", productId));
                command.Parameters.Add(new OleDbParameter("@MemberID", memberID));
                command.Parameters.Add(new OleDbParameter("@Quantity", quantity));
                command.Parameters.Add(new OleDbParameter("@Amount", amount));
                con.Open();


                command.ExecuteNonQuery();
                
                strSQL = "SELECT  qouta FROM product WHERE ID=@ID";
                command = new OleDbCommand(strSQL, con);
                command.Parameters.Add(new OleDbParameter("@ID", productId));

                OleDbDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    qouta = int.Parse(reader["qouta"].ToString());
                }
                con.Close();
            }

            qoutaUpdata(qouta, quantity, productId);
                
            
            return 0;
        }

        void qoutaUpdata(int qouta,int quantity, int id)
        {

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            String strSQL = "UPDATE [product] set qouta=@Qouta,availabitity='UnAvailable' WHERE ID=@ID";
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                if (quantity == qouta)
                {
                    
                    OleDbCommand command = new OleDbCommand(strSQL, con);
                    command.Parameters.Add(new OleDbParameter("@ID", id));
                    command.Parameters.Add(new OleDbParameter("@Qouta", 0));
                    con.Open();
                    command.ExecuteNonQuery();
                    
                }
                else
                {

                    int newQouta = qouta - quantity;
                    Console.WriteLine("qouta : " + qouta);
                    Console.WriteLine("newQouta : " + newQouta);

                    strSQL = "UPDATE [product] SET [qouta]= " + newQouta + " WHERE ID = "+ id;
                    OleDbCommand command1 = new OleDbCommand(strSQL, con);

                    con.Open();
                    command1.ExecuteNonQuery();

                    strSQL = "SELECT  qouta FROM product WHERE ID=@ID";
                    command1 = new OleDbCommand(strSQL, con);
                    command1.Parameters.Add(new OleDbParameter("@ID", id));

                    OleDbDataReader reader = command1.ExecuteReader();

                    while (reader.Read())
                    {
                        int qoutaa = int.Parse(reader["qouta"].ToString());
                        Console.WriteLine("qoutaa:" + qoutaa);
                    }

                    con.Close();
                    
                }

            }
        }
        
    }

    class DataManagementLogin
    {

        public List<String> DataLogin(String username, String password)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "SELECT * FROM [member] WHERE userName=@UserName AND password = @Password";

            List<String> data = new List<String>();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);
                command.Parameters.Add(new OleDbParameter("@UserName", username));
                command.Parameters.Add(new OleDbParameter("@Password", password));
                con.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data.AddRange( new List<String>(){ reader["ID"].ToString(), reader["MName"].ToString(), reader["surname"].ToString(), reader["phone"].ToString(), reader["image"].ToString(), reader["userName"].ToString(), reader["password"].ToString() });
                }
                con.Close();
            }
            return data;
        }
    }

    class DataManagementSaveLogin
    {
        public void SetSave(String username, String password)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "DELETE FROM [saveLogin]";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, con);
                con.Open();
                command.ExecuteNonQuery();
                
                strSQL = "INSERT INTO [saveLogin]([username],[password])VALUES(@Username,@Password)";
                command = new OleDbCommand(strSQL, con);
                command.Parameters.Add(new OleDbParameter("@Username", username));
                command.Parameters.Add(new OleDbParameter("@Password", password));


                command.ExecuteNonQuery();
                con.Close();
            }
        }
        
        public void deleteSave()
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "DELETE FROM [saveLogin]";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
        }

        public List<String> IsSave()
        {

            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            string strSQL = "SELECT * FROM [saveLogin]";

            List<String> data = new List<String>();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {

                OleDbCommand command = new OleDbCommand(strSQL, con);
                con.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data.AddRange(new List<String> { reader["username"].ToString(), reader["password"].ToString() });
                    
                }
                con.Close();
                return data;
            }
        }
    }

    class runQuery {
        public void resetData()
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ProductMungerDB.mdb";
            

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                //reset product
                string strSQL = "DELETE FROM product;";
                OleDbCommand command = new OleDbCommand(strSQL, con);
                con.Open();
                command.ExecuteNonQuery();


                strSQL = "ALTER TABLE product ALTER COLUMN ID COUNTER(1,1);";
                command = new OleDbCommand(strSQL, con);
                command.ExecuteNonQuery();

                //reset sellings
                strSQL = "DELETE FROM sellings;";
                command = new OleDbCommand(strSQL, con);
                command.ExecuteNonQuery();

                strSQL = "ALTER TABLE sellings ALTER COLUMN ID COUNTER(1,1);";
                command = new OleDbCommand(strSQL, con);
                command.ExecuteNonQuery();


                //reset saveLogin
                strSQL = "DELETE FROM saveLogin;";
                command = new OleDbCommand(strSQL, con);
                command.ExecuteNonQuery();

                strSQL = "ALTER TABLE saveLogin ALTER COLUMN ID COUNTER(1,1);";
                command = new OleDbCommand(strSQL, con);
                command.ExecuteNonQuery();

                //reset saveLogin
                strSQL = "DELETE FROM member;";
                command = new OleDbCommand(strSQL, con);
                command.ExecuteNonQuery();

                strSQL = "ALTER TABLE member ALTER COLUMN ID COUNTER(1,1);";
                command = new OleDbCommand(strSQL, con);
                command.ExecuteNonQuery();

                strSQL = "INSERT INTO [member]([MName],[surname],[phone],[image],[userName],[password]) VALUES(@MName,@Surname,@Phone,@Image,@UserName,@Password)";
                command = new OleDbCommand(strSQL, con);
                command.Parameters.Add(new OleDbParameter("@MName", "Admin"));
                command.Parameters.Add(new OleDbParameter("@Surname", ""));
                command.Parameters.Add(new OleDbParameter("@Phone", ""));
                command.Parameters.Add(new OleDbParameter("@Image", ""));
                command.Parameters.Add(new OleDbParameter("@UserName", "Admin"));
                command.Parameters.Add(new OleDbParameter("@Password", "Admin"));
                command.ExecuteNonQuery();


                con.Close();
            }
        }
    }
}

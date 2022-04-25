using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CoreApplication
{
    public class wow
    {
        public int bb()
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-7MGGRB4; database= Sql15 ;user id= sa; password =P@ssword");
            Console.WriteLine("Enter the number of products to be purchased");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("Please choose a product id:");
                int prodid = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd = new SqlCommand("select Price,ProdName,ProdId from product_table where ProdId =" + prodid + "", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int price = (int)dr[0];


                Console.WriteLine("Enter the  quantity of the product:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Item: " + dr[1] + "  Quantity: " + n + "  Price: Rs." + dr[0]);
                con.Close();
                price = price * n;
                sum = sum + price;

            }
            Console.WriteLine("Total amount is Rs." + sum);
            return sum;

        }
    }
    public class Product
    {
        public void Productdisplay()
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-7MGGRB4; database= Sql15 ;user id= sa; password =P@ssword");
            SqlCommand cmd = new SqlCommand("select ProdId,ProdName,Price,ManDate,Expirydate from product_table", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("ProdID : " + dr[0] + "|" + " ProdName : " + dr[1] + "| " + "Price: " + dr[2] + " | " + "ManDate : " + dr[3] + " | " + "Expirydate: " + dr[4]);
            }
            con.Close();
        }
        public void Purchasetable(int CustId, string Name, decimal total)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-7MGGRB4; database= Sql15;user id= sa; password =P@ssword");
            SqlCommand cmd = new SqlCommand("insert  Purchase_tableee(CustId,Name,total) values (" + CustId + ",'" + Name + "'," + total+ ")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void BillView()
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-7MGGRB4; database= Sql15 ;user id= sa; password =P@ssword");
            SqlCommand cmd = new SqlCommand("select  BillNo,CustId,Name,total from Purchase_tableee order by BillNo desc", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("\n\n" + " BillNo : " + dr[0] + "|" + " CustId : " + dr[1] + "| " + " Name: " + dr[2] + " | " + " total : " + dr[3] + " | " );
            }
            con.Close();

        }

    }

    public class Customer : Product
    {
        public int ValidateID(string name)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-7MGGRB4; database= Sql15;user id= sa; password =P@ssword");
            SqlCommand cmd = new SqlCommand("select CustId,Name,Gender,ContactNo,EmailId,DoB from Customer_Table1 where Name = '" + name + "'", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int custid = (int)dr[0];
            con.Close();
            return custid;
        }
        public void newCust()
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-7MGGRB4; database=Sql15 ;user id= sa; password =P@ssword");
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Gender :M or F");
            string gen = Console.ReadLine();
            Console.WriteLine("Please Enter your Contact.No:");
            string mob = Console.ReadLine();
            Console.WriteLine("Enter your mailid");
            string mailid = Console.ReadLine();
            Console.WriteLine("Enter your Date of birth ");
            string dob = Console.ReadLine();
            Console.WriteLine("Choose from the cities Below:\n 1.Chennai.\n 2.Mumbai. \n 3.Trichy.\n 4.ooty.....");
            string city = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("insert Customer_Table1 values ('" + name + "','" + gen + "','" + mob + "','" + mailid + "','" + dob + "','" + city + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Info inserted successfully without fail");
        }
    }
    class program
    {
        //SqlConnection con = new SqlConnection("Data source = DESKTOP-7MGGRB4; database= Sql15 ;user id= sa; password =P@ssword");
        public static void Main()
        {
            Customer nobj = new Customer();
            wow bobj = new wow();
            Console.WriteLine("Press 1:(If you are an existing customer) ");
            Console.WriteLine("Press 2:(If you are a new customer)");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Enter your Fullname:");
                        string name = Console.ReadLine();
                        int custid = nobj.ValidateID(name);
                  
                         nobj.Productdisplay();
                        decimal sum = bobj.bb();
                        nobj.Purchasetable(custid, name, sum);
                        nobj.BillView();
                        break;

                    }
                case 2:
                    {
                        nobj.newCust();
                        break;

                    }
            }


        }
    }
}

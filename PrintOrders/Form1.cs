using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintOrders
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=NORTHWIND;Integrated Security=True;");
        string constr = "Data Source=.;Initial Catalog=NORTHWIND;User Id=sa;Password=P@ssw0rd;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            using (IDbConnection db = new SqlConnection(constr))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                //Execute query to get customer data
                string query = "select o.OrderID, c.CustomerID, c.ContactName, c.Address, c.PostalCode, c.City, c.Phone, o.OrderDate" +
                                 " from Orders o inner join Customers c on o.CustomerID = c.CustomerID" +
                                $" where o.OrderDate between '{dtFromDate.Value}' and '{dtToDate.Value}'";
                ordersBindingSource.DataSource = db.Query<Orders>(query, commandType: CommandType.Text);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Orders obj = ordersBindingSource.Current as Orders;
            if (obj != null)
            {
                //using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                using (IDbConnection db = new SqlConnection(constr))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    //Execute query to get orders
                    string query = "select d.OrderID, p.ProductName, d.Quantity, d.Discount, d.UnitPrice from [Order Details] d inner join Products p on d.ProductID = p.ProductID" +
                                    $" where d.OrderID = '{obj.OrderID}'";
                    List<OrderDetail> list = db.Query<OrderDetail>(query, commandType: CommandType.Text).ToList();
                    using (frmPrint frm = new frmPrint(obj, list))
                    {
                        frm.ShowDialog();
                    }
                }
            }
        }
    }
}

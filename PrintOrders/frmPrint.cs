using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintOrders
{
    public partial class frmPrint : Form
    {
        List<OrderDetail> _list;
        Orders _orders;
        public frmPrint(Orders orders, List<OrderDetail> list)
        {
            InitializeComponent();
            _orders = orders;
            _list = list;
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {

            //Init crystal report
            
                rptOrders1.SetDataSource(_list);
                rptOrders1.SetParameterValue("pOrderID", _orders.OrderID);
                rptOrders1.SetParameterValue("pDate", _orders.OrderDate.ToString("MM/dd/yyyy"));
                rptOrders1.SetParameterValue("pContactName", _orders.ContactName);
                rptOrders1.SetParameterValue("pPostalCode", _orders.PostalCode);
                rptOrders1.SetParameterValue("pAddress", _orders.Address);
                rptOrders1.SetParameterValue("pCity", _orders.City);
                rptOrders1.SetParameterValue("pPhone", _orders.Phone);
                crystalReportViewer.ReportSource = rptOrders1;
                crystalReportViewer.Refresh();
    
        }

        private void rptOrders1_InitReport(object sender, EventArgs e)
        {

        }
    }
}

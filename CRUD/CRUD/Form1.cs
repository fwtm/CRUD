using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlConnectionLibrary;

namespace CRUD
{
    public partial class Form1 : Form
    {
        SqlConnectionLibrary.SqlConnections con = new SqlConnections();
        public Form1()
        {
            InitializeComponent();
            LlenarCombo(cbProvincias);
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            dgbData.DataSource = con.SelectDataTableByQuery("select * from Ciudad");
        }

        private void LlenarCombo(ComboBox cb)
        {
           cb.DisplayMember = "Nombre";
           cb.ValueMember = "Id_Pro";
           cb.DataSource = con.SelectDataTableByQuery("select Id_Pro, Nombre from Provincia order by 2 asc");
        }
    }
}

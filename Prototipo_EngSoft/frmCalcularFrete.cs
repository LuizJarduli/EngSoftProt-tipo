using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Protótipo_EngSoft
{
    public partial class frmCalcularFrete : Form
    {
        public frmCalcularFrete()
        {
            InitializeComponent();
        }

        private void frmCalcularFrete_Load(object sender, EventArgs e)
        {
            DirectoryInfo directory = new FileInfo("../../planilhas/").Directory;
            //MessageBox.Show("" + directory);
            String name = "Planilha3";
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            directory +
                            "/Tabela_rotas.xlsx;Extended Properties='Excel 12.0 XML;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }
    }
}

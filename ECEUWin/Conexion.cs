using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;


namespace ECEUWin
{

    public partial class Conexion : Form
    {
        public string Mbd;
        public Conexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ECEUWin oEceuWin = new ECEUWin();
            oEceuWin.Show();

            switch (Mbd.ToString())
            {
                case "SQL SERVER":
                    SQLDataAcces oData = new SQLDataAcces();
                    oData.ObtieneTablas(listBox1);
                    oData = null;
                    break;
                case "MYSQL":
                    MYSQLDataAcces oDatas = new MYSQLDataAcces();
                    oDatas.ObtieneTablas(listBox1);
                    oDatas = null;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* DataConnectionDialog dcd = new Microsoft.Data.ConnectionUI.DataConnectionDialog();
            DataSource.AddStandardDataSources(dcd);
            if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
            {
                string cons = dcd.ConnectionString;
            }*/
        }

        private void Conexion_Load(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECEUWin.wsECEU;
using ECEUWin.Properties;
using System.Xml;

namespace ECEUWin
{
    public partial class Mapeo : Form
    {

        public string Mbd;
        public Mapeo()
        {
            InitializeComponent();
            
        }

        private void Mapeo_Load(object sender, EventArgs e)
        {
            switch (Mbd.ToString())
            {
                case "SQL SERVER":
                    SQLDataAcces oData = new SQLDataAcces();
                    oData.ObtieneTablas(lst_tablas);
                    oData = null;
                    break;
                case "MYSQL":
                    MYSQLDataAcces oDatas = new MYSQLDataAcces();
                    oDatas.ObtieneTablas(lst_tablas);
                    oDatas = null;
                    break;

            }
        }

        private void btn_mapea_Click(object sender, EventArgs e)
        {

            Xml oXml = new Xml();
            oXml._crearXml("Mapeo.xml", "Laboratorio",lst_tablas.Text);

            if (oXml.Agrega_Nodo("Mapeo/"+lst_tablas.Text+"/"+lst_camporequerido.Text, lst_camporequerido.Text, lst_columnas.Text))
            {
                MessageBox.Show("se agrego nodo");
            }
            else MessageBox.Show("no se agrego nodo, por: "+oXml.ErrorXml);
        }

        private void lst_tablas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (Mbd.ToString())
            {
                case "SQL SERVER":
                    SQLDataAcces oData = new SQLDataAcces();
                    oData.Obtienecampos(lst_columnas, lst_tablas.Text);
                    oData = null;
                    break;
                case "MYSQL":
                    MYSQLDataAcces oDatas = new MYSQLDataAcces();
                    oDatas.Obtienecampos(lst_columnas, lst_tablas.Text);
                    oDatas = null;
                    break;

            }
        }

    }
}

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
using System.Configuration;
using UDL;

namespace ECEUWin
{
    public partial class ECEUWin : Form
    {
        public ECEUWin()
        {
            InitializeComponent();
        }
        private void ECEUWin_Load(object sender, EventArgs e)
        {
             chb_autenticacionwin.Enabled = false;
        }

        private void chb_autenticacionwin_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_autenticacionwin.Checked)
            {
                txt_contraseña.Text = "";
                txt_usuario.Text = "";
                txt_contraseña.Enabled = false;
                txt_usuario.Enabled = false;
            }
            else
            {
                txt_contraseña.Text = "";
                txt_usuario.Text = "";
                txt_contraseña.Enabled = true;
                txt_usuario.Enabled = true;
            }
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            
            string cadenaconexion = "",sProvider="";

            switch (cbo_rdbms.Text)
            {
                case "SQL SERVER":
                    if (chb_autenticacionwin.Checked)cadenaconexion = "Data Source="+txt_instancia.Text+";Initial Catalog="+txt_bd.Text+";Integrated Security=True";
                    else cadenaconexion = "Data Source=" + txt_instancia.Text + ";Initial Catalog=" + txt_bd.Text + ";user id="+txt_usuario.Text+";pwd="+txt_contraseña.Text+"";
                    sProvider = "SQLNCLI10";
                    break;
                case "MYSQL":
                    cadenaconexion = "Server="+txt_instancia.Text+";Database="+txt_bd.Text+";Uid="+txt_usuario.Text+";Pwd="+txt_contraseña.Text+"";
                    sProvider = "";
                    break;
                
            }
            if (ChangeConnectionString("Laboratorio", cadenaconexion, sProvider, "ECEUWin"))
            {
                // ConfigurationManager.RefreshSection("configuration");
                cadenaconexion = ConfigurationManager.ConnectionStrings["Laboratorio"].ConnectionString;

            }

            Mapeo oMapeo = new Mapeo();
            oMapeo.Mbd = cbo_rdbms.Text;
            oMapeo.Show();
        }
        public void ventanas()
        {
            Mapeo oMapeo = new Mapeo();
            oMapeo.Mbd = cbo_rdbms.Text;
            oMapeo.Show();
        }
                
        public static bool ChangeConnectionString(string Name, string value, string providerName, string AppName)
         {
            bool retVal = false;
            try
            {

                string FILE_NAME = string.Concat(Application.StartupPath, "\\", AppName.Trim(), ".exe.Config"); //the application configuration file name
                XmlTextReader reader = new XmlTextReader(FILE_NAME);
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);
                reader.Close();
                string nodeRoute = string.Concat("connectionStrings/add");

                XmlNode cnnStr = null;
                XmlElement root = doc.DocumentElement;
                XmlNodeList Settings = root.SelectNodes(nodeRoute);

                for (int i = 0; i < Settings.Count; i++)
                {
                    cnnStr = Settings[i];
                    if (cnnStr.Attributes["name"].Value.Equals(Name))
                        break;
                    cnnStr = null;
                }

                cnnStr.Attributes["connectionString"].Value = value;
                if (cnnStr.Attributes["providerName"]!=null)cnnStr.Attributes["providerName"].Value = providerName;
                doc.Save(FILE_NAME);
                retVal = true;
            }
            catch (Exception ex)
            {
                retVal = false;
                //Handle the Exception as you like
            }
            return retVal;
        }
        
        private void btn_sinc_Click(object sender, EventArgs e)
        {
            /*wsECEU.WebService sinc = new wsECEU.WebService();
            string ws = sinc.Intercambio("", "", "", "", "", "", "", "","");
            MessageBox.Show(ws);*/
            ConnectionStringDialog fd = new ConnectionStringDialog();
            //fd.ValidateConnections = false;
            //fd.Provider = txProvider.Text;
            //fd.ConnectionString = txConnString.Text;

            if (fd.ShowDialog(this) != DialogResult.OK)
                return;

            //txProvider.Text = fd.Provider;
            //txConnString.Text = fd.ConnectionString;

        }

        private void cbo_rdbms_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbo_rdbms.Text == "SQL_SERVER") chb_autenticacionwin.Enabled = true;
            else chb_autenticacionwin.Enabled = false;
        }
    }
}

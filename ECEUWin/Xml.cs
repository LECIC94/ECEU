using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XmlConfiguration;
using System.Xml.Linq;
using System.Xml.Resolvers;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;
using ECEUWin.Properties;
using ECEUWin;

namespace ECEUWin
{
    public class Xml
    {

        public XmlDocument doc;
        public string rutaXml;
        private XmlNode bd;
        public string ErrorXml="";

        public void _crearXml(string ruta, string nodoRaiz, string tabla)
        {
            this.rutaXml = ruta;
            doc = new XmlDocument();
            if (!System.IO.File.Exists(ruta))
            {
                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlNode root = doc.DocumentElement;
                doc.InsertBefore(xmlDeclaration, root);
                XmlNode element1 = doc.CreateElement(nodoRaiz);
                doc.AppendChild(element1);
                bd = doc.CreateElement(string.Empty, tabla, string.Empty);
                element1.AppendChild(bd);
                doc.Save(ruta);
            }
            else
            {

                doc.Load(rutaXml);
                bd = doc.SelectSingleNode("Laboratorio/" + tabla);
                if (bd == null)
                {
                    XmlNode element1 = doc.SelectSingleNode("Laboratorio" );
                    bd = doc.CreateElement(string.Empty, tabla, string.Empty);
                    element1.AppendChild(bd);
                }
            }
            
        }

        public void _Añadir(string ID, string FECHA_DE_LA_CITA, string SERVICIO, string PRESCRIPCION, string DOMICILIO, 
                            string OCUPACION, string SEGURIDAD_SOCIAL, string GENERO,string EDAD)
        {
            doc.Load(rutaXml);
            XmlNode Persona = _Crear_Persona(ID,FECHA_DE_LA_CITA, SERVICIO, PRESCRIPCION, DOMICILIO, OCUPACION, SEGURIDAD_SOCIAL, GENERO, EDAD);
            XmlNode nodoRaiz = doc.DocumentElement;
            nodoRaiz.InsertAfter(Persona, nodoRaiz.LastChild);
            doc.Save(rutaXml);
        }
        public bool Agrega_Nodo( string rutaxml, string camporequerido, string campobd)
        {
            bool resultado=false;
            try
            {
                if (doc.SelectSingleNode(rutaxml)==null)
                {
                    XmlElement xid = doc.CreateElement(camporequerido);
                    xid.InnerText = campobd;
                    bd.AppendChild(xid);
                }
                else
                {
                    doc.SelectSingleNode(rutaxml).InnerText = campobd;
                }
                if (System.IO.File.Exists(rutaXml)) System.IO.File.Delete(rutaXml);
                doc.Save(rutaXml);
                resultado = true;
            }
            catch(Exception e)
            {
                ErrorXml = e.Message;
                resultado = false;
            }
            return resultado;
        }
        private XmlNode _Crear_Persona(string ID , string FECHA_DE_LA_CITA, string SERVICIO, string PRESCRIPCION, 
                                       string DOMICILIO, string OCUPACION, string SEGURIDAD_SOCIAL, string GENERO, string EDAD)
        {
            XmlNode persona = doc.CreateElement("Paciente");

            XmlElement xid = doc.CreateElement("ID mapeoID");
            xid.InnerText = ID;
            persona.AppendChild(xid);

            XmlElement xfecha = doc.CreateElement("FECHA");
            xfecha.InnerText = FECHA_DE_LA_CITA;
            persona.AppendChild(xfecha);

            XmlElement xservicio = doc.CreateElement("SERVICIO");
            xservicio.InnerText = SERVICIO;
            persona.AppendChild(xservicio);

            XmlElement xprescripcion = doc.CreateElement("PRESCRIPCION");
            xprescripcion.InnerText = PRESCRIPCION;
            persona.AppendChild(xprescripcion);

            XmlElement xdomicilio = doc.CreateElement("DOMICILIO");
            xdomicilio.InnerText = DOMICILIO;
            persona.AppendChild(xdomicilio);

            XmlElement xocupacion = doc.CreateElement("OCUPACION");
            xocupacion.InnerText = OCUPACION;
            persona.AppendChild(xocupacion);

            XmlElement xsegurosocial = doc.CreateElement("SEGURIDAD_SOCIAL");
            xsegurosocial.InnerText = SEGURIDAD_SOCIAL;
            persona.AppendChild(xsegurosocial);

            XmlElement xgenero = doc.CreateElement("GENERO");
            xgenero.InnerText = GENERO;
            persona.AppendChild(xgenero);

            XmlElement xedad = doc.CreateElement("EDAD");
            xedad.InnerText = EDAD;
            persona.AppendChild(xedad);

            return persona;
        }

        public void _Mapea(string ID, string FECHA_DE_LA_CITA, string SERVICIO, string PRESCRIPCION,
                                       string DOMICILIO, string OCUPACION, string SEGURIDAD_SOCIAL, string GENERO, string EDAD)
        {
            XmlElement paciente = doc.DocumentElement;
            XmlNodeList lista = doc.SelectNodes("Persona/Paciente");
            XmlNode datos = _Crear_Persona(ID, FECHA_DE_LA_CITA, SERVICIO, PRESCRIPCION, DOMICILIO, OCUPACION, SEGURIDAD_SOCIAL, GENERO, EDAD);
            
            foreach (XmlNode item in lista)
            {

               
                    XmlNode nodoOld = item;
                    paciente.ReplaceChild(datos, nodoOld);

                
            }

            doc.Save(rutaXml);
        }

        public void _ReadXml()
        {
            doc.Load(rutaXml);
           /* XmlNodeList listaPacientes = doc.SelectNodes("Persona/paciente");
            XmlNode unPaciente;
            for (int i = 0; i < listaPacientes.Count; i++)
            {
                unPaciente = listaPacientes.Item(i);
                string ID = unPaciente.SelectSingleNode("ID").InnerText;
                string FECHA_DE_LA_CITA = unPaciente.SelectSingleNode("FECHA_DE_LA_CITA").InnerText;
                string SERVICIO = unPaciente.SelectSingleNode("SERVICIO").InnerText;
                string PRESCRIPCION = unPaciente.SelectSingleNode("PRESCRIPCION").InnerText;
                string DOMICILIO = unPaciente.SelectSingleNode("DOMICILIO").InnerText;
                string OCUPACION = unPaciente.SelectSingleNode("OCUPACION").InnerText;
                string SEGURIDAD_SOCIAL = unPaciente.SelectSingleNode("SEGURIDAD_SOCIAL").InnerText;
                string GENERO = unPaciente.SelectSingleNode("GENERO").InnerText;
                string EDAD = unPaciente.SelectSingleNode("EDAD").InnerText;

            }*/
        }


    }
}

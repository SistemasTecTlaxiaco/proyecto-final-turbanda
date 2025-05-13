using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  //para hacer conexion con base de datos
namespace BIENES_RAICES
{
    public partial class Form_consulta : Form
    {
        public Form_consulta()
        {
            InitializeComponent();
        }
        static string conexion_base_datos = "SERVER=127.0.0.1;PORT=3306;DATABASE=inmobiliaria;UID=root;PASSWORD=;";
        MySqlConnection con = new MySqlConnection(conexion_base_datos);
        private void Form_consulta_Load(object sender, EventArgs e)
        {
            Contenido_Base.DataSource = Contenido();
        }

        public DataTable Contenido()
        {
            con.Open();
            DataTable datos = new DataTable();
            //String contenido = "SELECT *FROM TERRENO TE JOIN T_TERRENO TI WHERE TE.ID_TIPO_TERRENO=TI.ID";
            //String contenido = "select P.Nombre,P.Ap_paterno,P.AP_Materno,t.tipo,t.metros_cuadrados,t.precio ,c.tipo,c.precio,v.fecha_venta,v.enganche, pa.forma, pl.plazo , a.amortizacion from venta v, Datos_Personales p, terreno t,casa c,F_pago pa, Plazo pl, amortizacion a where V.Id_persona=P.Id AND V.Id_producto_terreno=t.ID AND V.Id_producto_casa=c.id and v.id_forma_pago=pa.id and v.id_plazo=pl.id and v.id_amortizacion=a.id";
            String contenido = "select * from venta v, Datos_Personales p, terreno t,casa c,F_pago pa, Plazo pl, amortizacion a where V.Id_persona=P.Id AND V.Id_producto_terreno=t.ID AND V.Id_producto_casa=c.id and v.id_forma_pago=pa.id and v.id_plazo=pl.id and v.id_amortizacion=a.id";

            MySqlCommand cmd = new MySqlCommand(contenido, con);
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(datos);
            con.Close();
            return datos;
        }
        private void cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

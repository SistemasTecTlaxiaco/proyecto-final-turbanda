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
    public partial class Form_ventas : Form
    {
        public Form_ventas()
        {
            InitializeComponent();
        }
        static string conexion_base_datos = "SERVER=127.0.0.1;PORT=3306;DATABASE=inmobiliaria;UID=root;PASSWORD=;";
        MySqlConnection con = new MySqlConnection(conexion_base_datos);
        DataTable data_Datos_Personales = new DataTable();
        DataTable data_terreno = new DataTable();
        DataTable datos_casa = new DataTable();
        DataTable datos_f_pago = new DataTable();
        DataTable datos_plazo = new DataTable();
        DataTable datos_amor = new DataTable();
        int id_tipo_terreno;
        private void Form_ventas_Load(object sender, EventArgs e)
        {
            Contenido_Base.DataSource = Contenido();

            con.Open();
            String contenido = "SELECT *FROM Datos_Personales";
            MySqlCommand cmd = new MySqlCommand(contenido, con);
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(data_Datos_Personales);

            String contenido2 = "SELECT *FROM Terreno";
            MySqlCommand cmd2 = new MySqlCommand(contenido2, con);
            MySqlDataAdapter dat2 = new MySqlDataAdapter(cmd2);
            dat2.Fill(data_terreno);

            String contenido3 = "SELECT *FROM Casa";
            MySqlCommand cmd3 = new MySqlCommand(contenido3, con);
            MySqlDataAdapter dat3 = new MySqlDataAdapter(cmd3);
            dat3.Fill(datos_casa);

            String contenido4 = "SELECT *FROM F_pago";
            MySqlCommand cmd4 = new MySqlCommand(contenido4, con);
            MySqlDataAdapter dat4 = new MySqlDataAdapter(cmd4);
            dat4.Fill(datos_f_pago);

            String contenido5 = "SELECT *FROM Plazo";
            MySqlCommand cmd5 = new MySqlCommand(contenido5, con);
            MySqlDataAdapter dat5 = new MySqlDataAdapter(cmd5);
            dat5.Fill(datos_plazo);

            String contenido6 = "SELECT *FROM Amortizacion";
            MySqlCommand cmd6 = new MySqlCommand(contenido6, con);
            MySqlDataAdapter dat6 = new MySqlDataAdapter(cmd6);
            dat6.Fill(datos_amor);

            con.Close();


            //list_tipo_terreno.Items.Add(" "); //**************agega a la lista
            for (int i = 0; i < data_Datos_Personales.Rows.Count; i++)
            {
                list_persona.Items.Add(data_Datos_Personales.Rows[i].ItemArray[1]+ " "+data_Datos_Personales.Rows[i].ItemArray[2]);
            }
            //****************terreno************
            for (int i = 0; i < data_terreno.Rows.Count; i++)
            {
                list_terreno.Items.Add(data_terreno.Rows[i].ItemArray[1]);
            }
            //************casa*************
            for (int i = 0; i < datos_casa.Rows.Count; i++)
            {
                list_casa.Items.Add(datos_casa.Rows[i].ItemArray[1]);
            }
            //*************forma de pago,
            for (int i = 0; i < datos_f_pago.Rows.Count; i++)
            {
                list_pago.Items.Add(datos_f_pago.Rows[i].ItemArray[1]);
            }
            //*************
            for (int i = 0; i < datos_plazo.Rows.Count; i++)
            {
                list_plazo.Items.Add(datos_plazo.Rows[i].ItemArray[1]);
            }
            //****************
            for (int i = 0; i < datos_amor.Rows.Count; i++)
            {
                list_amor.Items.Add(datos_amor.Rows[i].ItemArray[1]);
            }

        }
        //realiza la consulta
        public DataTable Contenido()
        {
            con.Open();
            DataTable datos = new DataTable();
            //String contenido = "SELECT *FROM TERRENO TE JOIN T_TERRENO TI WHERE TE.ID_TIPO_TERRENO=TI.ID";
            String contenido = "select V.id, P.Nombre,P.Ap_paterno,P.AP_Materno,t.tipo,t.metros_cuadrados,t.precio ,c.tipo,c.precio,v.fecha_venta,v.enganche, pa.forma, pl.plazo , a.amortizacion from venta v, Datos_Personales p, terreno t,casa c,F_pago pa, Plazo pl, amortizacion a where V.Id_persona=P.Id AND V.Id_producto_terreno=t.ID AND V.Id_producto_casa=c.id and v.id_forma_pago=pa.id and v.id_plazo=pl.id and v.id_amortizacion=a.id";
            MySqlCommand cmd = new MySqlCommand(contenido, con);
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(datos);
            con.Close();
            return datos;
        }

        // *************************mensajes ****************************
        public void mensajes()
        {
            MessageBox.Show("Datos Guradados con exito");
        }

        public void repetido()
        {
            MessageBox.Show("El terrono ya existen ");
        }

        public int pregunta_cambio()
        {

            string message = "¿Seguro que quieres realizar cambios?";
            string title = "¡¡ADVERTENCIA!!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                return 1;
            }
            else
            {
                return 0;
            }

        }

        //***************************************************************************


        //***********************al seleccionar una celda de la base, se guarda en el cuadro de texto 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            id_ac.Text = Contenido_Base.CurrentRow.Cells[0].Value.ToString();
            list_persona.SelectedItem = Contenido_Base.CurrentRow.Cells[1].Value.ToString()+" "+Contenido_Base.CurrentRow.Cells[2].Value.ToString();
            list_terreno.SelectedItem = Contenido_Base.CurrentRow.Cells[4].Value.ToString();
            list_casa.SelectedItem = Contenido_Base.CurrentRow.Cells[7].Value.ToString();
            fecha.Text = Contenido_Base.CurrentRow.Cells[9].Value.ToString();
            enganche.Text = Contenido_Base.CurrentRow.Cells[10].Value.ToString();
            list_pago.SelectedItem = Contenido_Base.CurrentRow.Cells[11].Value.ToString();
            list_plazo.SelectedItem = Contenido_Base.CurrentRow.Cells[12].Value.ToString();
            list_amor.SelectedItem = Contenido_Base.CurrentRow.Cells[13].Value.ToString();
        }

        //*********************************************busca si ya existe el terreno en la base de datos*****************
        
        /*private int buscar()
        {
            int contador;
            int i;
            // **********buscando el id
            for (i = 0; i < datos_id_tipo_terreno.Rows.Count; i++)
            {
                if (datos_id_tipo_terreno.Rows[i].ItemArray[1].Equals(list_tipo_terreno.SelectedItem))
                {
                    id_tipo_terreno = i;
                    break;
                }
                //list_tipo_terreno.Items.Add(datos_id_tipo_terreno.Rows[i].ItemArray[1]);
            }

            con.Open();
            DataTable datos = new DataTable();
            string bus = "SELECT *FROM TERRENO  WHERE  TIPO=@tipo AND METROS_CUADRADOS=@metros_cuadrados AND ID_TIPO_TERRENO=@id_tipo_terreno AND PRECIO=@precio AND DIRECCION=@direccion ";
            MySqlCommand cmd = new MySqlCommand(bus, con);
            cmd.Parameters.AddWithValue("@tipo", tipo.Text);
            cmd.Parameters.AddWithValue("@metros_cuadrados", metros.Text);
            cmd.Parameters.AddWithValue("@id_tipo_terreno", datos_id_tipo_terreno.Rows[i].ItemArray[0]);
            cmd.Parameters.AddWithValue("@precio", precio.Text);
            cmd.Parameters.AddWithValue("@direccion", Dire.Text);
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(datos);
            //MessageBox.Show(Convert.ToString(datos.Rows.Count)); //imprime número de repetidos
            contador = datos.Rows.Count; //guarda número de repetidosf
            con.Close();
            return contador; //retorna la cantidad de repetidos
        }
        */
        //************************************** botón de insertar un nuevo elementó a la tabla**********************
        private void Inser_Click(object sender, EventArgs e)
        {
            int blanco;
            int repetidos;
            blanco = elentos_vacio(); //verifica que los texbox no estén vacíos
            /*
            if (blanco == 0)  //si es cero no esta en blanco y si es uno esta en blanco
            {
                repetidos = buscar(); //busca los repetidos

                if (repetidos == 0) //verifica si no hay repetidos, si no hay repetidos realiza la inserción 
                {

                    //inserta nuevo terreno
                    con.Open();


                    string insercion = "INSERT INTO TERRENO(TIPO,METROS_CUADRADOS,ID_TIPO_TERRENO,PRECIO,DIRECCION)VALUES(@tipo,@metros_cuadrados,@id_tipo_terreno,@precio,@direccion )";
                    MySqlCommand cmd = new MySqlCommand(insercion, con);
                    cmd.Parameters.AddWithValue("@tipo", tipo.Text);
                    cmd.Parameters.AddWithValue("@metros_cuadrados", metros.Text);
                    cmd.Parameters.AddWithValue("@id_tipo_terreno", datos_id_tipo_terreno.Rows[id_tipo_terreno].ItemArray[0]);
                    cmd.Parameters.AddWithValue("@precio", precio.Text);
                    cmd.Parameters.AddWithValue("@direccion", Dire.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    limpiar(); // limpia los texbox
                    Contenido_Base.DataSource = Contenido();
                    mensajes(); //llama a la funcion mensaje

                }
                else //si hay repetidos manda mensaje
                {
                    repetido();
                }
            }
            */
        }


        // ***************************************botón de modificar elementos de tabla*******************************
        private void Modi_Click(object sender, EventArgs e)
        {
            int blanco;
            int repetidos;
            int pregunta;
            
            blanco = elentos_vacio(); //verifica que los texbox no estén vacíos
            /*
            if (blanco == 0)  //si es cero no esta en blanco y si es uno esta en blanco
            {
                repetidos = buscar(); //busca los repetidos

                if (repetidos == 0) //verifica si no hay repetidos, si no hay repetidos realiza la inserción 
                {

                    pregunta = pregunta_cambio(); // Muestra el cuadro de dialogo donde pregunta si está seguro de los cambios
                    if (pregunta == 1)
                    {
                        con.Open();

                        string actualiza = "UPDATE TERRENO SET  TIPO = @tipo, METROS_CUADRADOS = @metros_cuadrados,ID_TIPO_TERRENO = @id_tipo_terreno,PRECIO = @precio,DIRECCION = @direccion WHERE ID=@id";
                        MySqlCommand cmd = new MySqlCommand(actualiza, con);
                        cmd.Parameters.AddWithValue("@id", id_ac.Text);
                        cmd.Parameters.AddWithValue("@tipo", tipo.Text);
                        cmd.Parameters.AddWithValue("@metros_cuadrados", metros.Text);
                        cmd.Parameters.AddWithValue("@id_tipo_terreno", datos_id_tipo_terreno.Rows[id_tipo_terreno].ItemArray[0]);
                        cmd.Parameters.AddWithValue("@precio", precio.Text);
                        cmd.Parameters.AddWithValue("@direccion", Dire.Text);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        limpiar(); // limpia los texbox
                                   //muestra de nuevo el contenido, con los valores actulizados
                        Contenido_Base.DataSource = Contenido();
                        mensajes(); //llama a la funcion mensaje
                    }
                }
                else //si hay repetidos manda mensaje
                {
                    repetido();
                }
            }
            */
        }
        // ******************* botón de eliminar *********************************
        private void DEl_Click(object sender, EventArgs e)
        {
            int pregunta;
            // ****primero verifica si existe el elemento a eliminar
            int contador = 0;
                /*
            if (id_ac.TextLength > 0) //verifica que si ya selecciono un elemento
            {
                con.Open();
                DataTable datos = new DataTable();
                string bus = "SELECT* FROM TERRENO WHERE  TIPO=@tipo AND METROS_CUADRADOS=@metros_cuadrados AND ID_TIPO_TERRENO=@id_tipo_terreno AND PRECIO=@precio AND DIRECCION=@direccion";
                MySqlCommand cmd2 = new MySqlCommand(bus, con);
                cmd2.Parameters.AddWithValue("@tipo", tipo.Text);
                cmd2.Parameters.AddWithValue("@metros_cuadrados", metros.Text);
                cmd2.Parameters.AddWithValue("@id_tipo_terreno", datos_id_tipo_terreno.Rows[id_tipo_terreno].ItemArray[0]);
                cmd2.Parameters.AddWithValue("@precio", precio.Text);
                cmd2.Parameters.AddWithValue("@direccion", Dire.Text);
                MySqlDataAdapter dat = new MySqlDataAdapter(cmd2);
                dat.Fill(datos);
                //MessageBox.Show(Convert.ToString(datos.Rows.Count)); //imprime número de repetidos
                //MessageBox.Show(Convert.ToString(list_Genero.SelectedItem)); 
                contador = datos.Rows.Count; //guarda número de repetidos
                con.Close();
            }
            if (contador > 0 && elentos_vacio() == 0)
            {


                pregunta = pregunta_cambio(); // Muestra el cuadro de dialogo donde pregunta si está seguro de los cambios
                if (pregunta == 1)
                {
                    con.Open();
                    string delete = "DELETE FROM TERRENO WHERE ID=@id";
                    MySqlCommand cmd = new MySqlCommand(delete, con);
                    cmd.Parameters.AddWithValue("@id", id_ac.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //muestra de nuevo el contenido, con los valores actulizados
                    Contenido_Base.DataSource = Contenido();
                    limpiar(); // limpia los texbox
                    mensajes(); //llama a la funcion mensaje
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un elemento");
            }
                */
        }
        //****************************botón de salir**************************
        private void cerrar_Click(object sender, EventArgs e)
        {

            string message = "¿Seguro que quieres salir de la aplicación?";
            string title = "¡¡ADVERTENCIA!!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();

            }

        }

        private void cerrar_Click_1(object sender, EventArgs e)
        {

        }

        private void list_plazo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_pago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_terreno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_persona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void list_amor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_casa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void enganche_TextChanged(object sender, EventArgs e)
        {

        }

        private void fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void id_ac_TextChanged(object sender, EventArgs e)
        {

        }
        //******************************limpia los texbox***************
        /*
        private void limpiar()
        {
            id_ac.Clear();
            tipo.Clear();
            metros.Clear();
            list_tipo_terreno.ClearSelected();
            precio.Clear();
            Dire.Clear();
            //Lista_genero = 0;
        }
        */
        //******************************verifica texto vacío 
        private int elentos_vacio()
        {
            int vacio = 0; //cero indica que no está vacío
            if (list_persona.SelectedIndex == -1)
            {
                MessageBox.Show("EL campo persona esta vacío ");
                vacio = 1;
            }


            if (list_terreno.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un terreno ");
                vacio = 1;
            }

            if (list_casa.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una casa ");
                vacio = 1;
            }

            if (enganche.TextLength == 0)
            {
                MessageBox.Show("EL campo enganche esta vacío, si no hay enganche poner el 0 ");
                vacio = 1;
            }

            if (fecha.TextLength == 0)
            {
                MessageBox.Show("EL campo fecha esta vacío ");
                vacio = 1;
            }
            if (list_pago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una forma de pago ");
                vacio = 1;
            }
            if (list_plazo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un plazo ");
                vacio = 1;
            }
            if (list_amor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una forma de Amortizacion ");
                vacio = 1;
            }


            //if(list_Genero.SelectedItem!='m')
            return vacio;
        }
       


    }
}
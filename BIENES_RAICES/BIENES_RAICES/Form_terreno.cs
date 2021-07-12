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
    public partial class Form_terreno : Form
    {
        public Form_terreno()
        {
            InitializeComponent();
        }
        static string conexion_base_datos = "SERVER=127.0.0.1;PORT=3306;DATABASE=inmobiliaria;UID=root;PASSWORD=;";
        MySqlConnection con = new MySqlConnection(conexion_base_datos);
        DataTable datos_id_tipo_terreno = new DataTable();

        int id_tipo_terreno;
        private void Form_terreno_Load(object sender, EventArgs e)
        {
            Contenido_Base.DataSource = Contenido();

            con.Open();
            //DataTable datos = new DataTable();
            String contenido = "SELECT *FROM T_TERRENO";
            MySqlCommand cmd = new MySqlCommand(contenido, con);
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(datos_id_tipo_terreno);
            con.Close();


            //list_tipo_terreno.Items.Add(" "); //**************agega a la lista
            for (int i = 0; i < datos_id_tipo_terreno.Rows.Count; i++)
            {
                list_tipo_terreno.Items.Add(datos_id_tipo_terreno.Rows[i].ItemArray[1]);
            }



        }
        //realiza la consulta
        public DataTable Contenido()
        {
            con.Open();
            DataTable datos = new DataTable();
            //String contenido = "SELECT *FROM TERRENO TE JOIN T_TERRENO TI WHERE TE.ID_TIPO_TERRENO=TI.ID";
            String contenido = "SELECT TE.ID,TE.TIPO, TE.METROS_CUADRADOS,TI.TIPO_TERRENO,TE.PRECIO,TE.DIRECCION,TI.ID  FROM TERRENO TE JOIN T_TERRENO TI WHERE TE.ID_TIPO_TERRENO=TI.ID";
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
            /*
            //********* saca el id ********
            con.Open();
            DataTable datos = new DataTable();
            String contenido = "SELECT *FROM T_TERRENO WHERE TIPO_TERRENO=@tipo_terreno";
            MySqlCommand cmd = new MySqlCommand(contenido, con);
            cmd.Parameters.AddWithValue("@tipo_terreno", Contenido_Base.CurrentRow.Cells[3].Value.ToString());
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(datos);
            con.Close();
            */

            id_ac.Text = Contenido_Base.CurrentRow.Cells[0].Value.ToString();
            tipo.Text = Contenido_Base.CurrentRow.Cells[1].Value.ToString();
            metros.Text = Contenido_Base.CurrentRow.Cells[2].Value.ToString();
            list_tipo_terreno.SelectedItem = Contenido_Base.CurrentRow.Cells[3].Value.ToString();
            precio.Text = Contenido_Base.CurrentRow.Cells[4].Value.ToString();
            //tipo.Text  = datos.Rows[0].ItemArray[0].ToString(); // guarda el ID   para poder hacer la actulizacion
            Dire.Text = Contenido_Base.CurrentRow.Cells[5].Value.ToString();



        }

        //*********************************************busca si ya existe el terreno en la base de datos*****************
        private int buscar()
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
            contador = datos.Rows.Count; //guarda número de repetidos
            con.Close();
            return contador; //retorna la cantidad de repetidos
        }
        //************************************** botón de insertar un nuevo elementó a la tabla**********************
        private void Inser_Click(object sender, EventArgs e)
        {
            int blanco;
            int repetidos;
            blanco = elentos_vacio(); //verifica que los texbox no estén vacíos
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
        }


        // ***************************************botón de modificar elementos de tabla*******************************
        private void Modi_Click(object sender, EventArgs e)
        {
            int blanco;
            int repetidos;
            int pregunta;
            blanco = elentos_vacio(); //verifica que los texbox no estén vacíos
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
        }
        // ******************* botón de eliminar *********************************
        private void DEl_Click(object sender, EventArgs e)
        {
            int pregunta;
            // ****primero verifica si existe el elemento a eliminar
            int contador = 0;

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
        //******************************limpia los texbox***************
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
        //******************************verifica texto vacío 
        private int elentos_vacio()
        {
            int vacio = 0; //cero indica que no está vacío
            if (tipo.TextLength == 0)
            {
                MessageBox.Show("EL campo Tipo esta vacío ");
                vacio = 1;
            }
            if (metros.TextLength == 0)
            {
                MessageBox.Show("EL campo Metros cuadrados esta vacío ");
                vacio = 1;
            }

            if (list_tipo_terreno.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo terreno ");
                vacio = 1;
            }

            if (precio.TextLength == 0)
            {
                MessageBox.Show("EL campo Precio esta vacío ");
                vacio = 1;
            }

            if (Dire.TextLength == 0)
            {
                MessageBox.Show("EL campo Dirección esta vacío ");
                vacio = 1;
            }
            //if(list_Genero.SelectedItem!='m')
            return vacio;
        }


        private void cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Form_tipo_plazo : Form
    {
        public Form_tipo_plazo()
        {
            InitializeComponent();
        }

        private void Form_tipo_plazo_Load(object sender, EventArgs e)
        {
            data_tipo_terreno.DataSource = Contenido();
        }
        static string conexion_base_datos = "SERVER=127.0.0.1;PORT=3306;DATABASE=inmobiliaria;UID=root;PASSWORD=genaro;";
        
        MySqlConnection con = new MySqlConnection(conexion_base_datos);


        public DataTable Contenido()
        {
            con.Open();
            DataTable datos = new DataTable();
            String cont_tipo_terreno = "select* from Plazo";
            MySqlCommand cmd = new MySqlCommand(cont_tipo_terreno, con);
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(datos);
            con.Close();
            return datos;
        }
        //*********************************************busca si ya existe el usuario en la base de datos*****************
        private int buscar()
        {
            int contador;
            con.Open();
            DataTable datos = new DataTable();
            string bus = "SELECT* FROM PLAZO WHERE PLAZO=@plazo ";
            MySqlCommand cmd = new MySqlCommand(bus, con);
            cmd.Parameters.AddWithValue("@plazo", t_plazo.Text);
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(datos);

            contador = datos.Rows.Count; //guarda número de repetidos
            con.Close();
            return contador; //retorna la cantidad de repetidos
        }
        //************************************** botón de insertar un nuevo elementó a la tabla**********************

        private void Agegar_Click(object sender, EventArgs e)
        {
            int blanco;
            int repetidos;
            blanco = elentos_vacio(); //verifica que los texbox no estén vacíos
            if (blanco == 0)  //si es cero no esta en blanco y si es uno esta en blanco
            {
                repetidos = buscar(); //busca los repetidos

                if (repetidos == 0) //verifica si no hay repetidos, si no hay repetidos realiza la inserción 
                {

                    //inserta nuevo usuario
                    con.Open();
                    string insercion = "INSERT INTO  PLAZO (PLAZO)VALUES(@plazo)";
                    MySqlCommand cmd = new MySqlCommand(insercion, con);
                    cmd.Parameters.AddWithValue("@plazo", t_plazo.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    limpiar(); // limpia los texbox
                    data_tipo_terreno.DataSource = Contenido();
                    mensajes(); //llama a la funcion mensaje

                }
                else //si hay repetidos manda mensaje
                {
                    repetido();
                }
            }
        }

        // *************************mensajes ****************************
        public void mensajes()
        {
            MessageBox.Show("Datos Guradados con exito");
        }

        public void repetido()
        {
            MessageBox.Show("El tipo de plazo ya existen ");
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
        //******************************verifica texto vacío 
        private int elentos_vacio()
        {
            int vacio = 0; //cero indica que no está vacío
            if (t_plazo.TextLength == 0)
            {
                MessageBox.Show("EL campo  esta vacío ");
                vacio = 1;
            }
            return vacio;
        }
        //******************************limpia los texbox***************
        private void limpiar()
        {
            id_ac.Clear();
            t_plazo.Clear();
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
                        string actualiza = "UPDATE PLAZO SET  PLAZO =@plazo WHERE ID=@id";
                        MySqlCommand cmd = new MySqlCommand(actualiza, con);

                        cmd.Parameters.AddWithValue("@id", id_ac.Text);
                        cmd.Parameters.AddWithValue("@plazo", t_plazo.Text);

                        //MessageBox.Show(id_ac.Text);
                        //MessageBox.Show(t_terreno.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        limpiar(); // limpia los texbox
                        data_tipo_terreno.DataSource = Contenido();
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
                string bus = "SELECT* FROM PLAZO WHERE ID=@id AND PLAZO =@plazo";
                MySqlCommand cmd2 = new MySqlCommand(bus, con);
                cmd2.Parameters.AddWithValue("@id", id_ac.Text);
                cmd2.Parameters.AddWithValue("@plazo", t_plazo.Text);

                MySqlDataAdapter dat = new MySqlDataAdapter(cmd2);
                dat.Fill(datos);

                contador = datos.Rows.Count; //guarda número de repetidos
                con.Close();
            }
            if (contador > 0 && elentos_vacio() == 0)
            {


                pregunta = pregunta_cambio(); // Muestra el cuadro de dialogo donde pregunta si está seguro de los cambios
                if (pregunta == 1)
                {
                    con.Open();
                    string delete = "DELETE FROM plazo WHERE ID=@id";
                    MySqlCommand cmd = new MySqlCommand(delete, con);
                    cmd.Parameters.AddWithValue("@id", id_ac.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //muestra de nuevo el contenido, con los valores actulizados
                    data_tipo_terreno.DataSource = Contenido();
                    limpiar(); // limpia los texbox
                    mensajes(); //llama a la funcion mensaje
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un elemento");
            }

        }
        //***********************al seleccionar una celda de la base, se guarda en el cuadro de texto 
        private void data_tipo_terreno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            id_ac.Text = data_tipo_terreno.CurrentRow.Cells[0].Value.ToString();
            t_plazo.Text = data_tipo_terreno.CurrentRow.Cells[1].Value.ToString();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
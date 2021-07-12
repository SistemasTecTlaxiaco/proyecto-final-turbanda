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
    public partial class Form_Casa : Form
    {
        public Form_Casa()
        {
            InitializeComponent();
        }
        static string conexion_base_datos = "SERVER=127.0.0.1;PORT=3306;DATABASE=inmobiliaria;UID=root;PASSWORD=genaro;";
        MySqlConnection con = new MySqlConnection(conexion_base_datos);
        private void Form_Casa_Load(object sender, EventArgs e)
        {
            Contenido_Base.DataSource = Contenido();
        }
        //realiza la consulta
        public DataTable Contenido()
        {
            con.Open();
            DataTable datos = new DataTable();
            String contenido = "SELECT *FROM CASA";
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
            MessageBox.Show("El Casa ya existen ");
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
            tipo.Text = Contenido_Base.CurrentRow.Cells[1].Value.ToString();
            list_sala.SelectedItem = Contenido_Base.CurrentRow.Cells[2].Value.ToString();
            list_comedor.SelectedItem = Contenido_Base.CurrentRow.Cells[3].Value.ToString();
            list_banio.SelectedItem = Contenido_Base.CurrentRow.Cells[4].Value.ToString();
            list_recamara.SelectedItem = Contenido_Base.CurrentRow.Cells[5].Value.ToString();
            list_cosina.SelectedItem = Contenido_Base.CurrentRow.Cells[6].Value.ToString();
            list_jardin.SelectedItem = Contenido_Base.CurrentRow.Cells[7].Value.ToString();
            list_cochera.SelectedItem = Contenido_Base.CurrentRow.Cells[8].Value.ToString();
            precio.Text = Contenido_Base.CurrentRow.Cells[9].Value.ToString();



        }

        //*********************************************busca si ya existe el terreno en la base de datos*****************
        private int buscar()
        {
            int contador;

            con.Open();
            DataTable datos = new DataTable();
            string bus = "SELECT *FROM CASA  WHERE  TIPO=@tipo AND SALA=@sala AND COMEDOR=@comedor AND BANIOs=@banios AND RECAMAS=@recamas AND COCINA=@cocina AND JARDIN=@jardin AND COCHERA=@cochera AND PRECIO=@precio ";
            MySqlCommand cmd = new MySqlCommand(bus, con);
            cmd.Parameters.AddWithValue("@tipo", tipo.Text);
            cmd.Parameters.AddWithValue("@sala", list_sala.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@comedor", list_comedor.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@banios", list_banio.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@recamas", list_recamara.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@cocina", list_cosina.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@jardin", list_jardin.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@cochera", list_cochera.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@precio", precio.Text);
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
                    

                    string insercion = "INSERT INTO CASA(TIPO,SALA,COMEDOR,BANIOS,RECAMAS,COCINA,JARDIN,COCHERA,PRECIO)VALUES(@tipo,@sala,@comedor,@banios,@recamas,@cocina,@jardin,@cochera,@precio )";
                    MySqlCommand cmd = new MySqlCommand(insercion, con);
                    cmd.Parameters.AddWithValue("@tipo", tipo.Text);
                    cmd.Parameters.AddWithValue("@sala", list_sala.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@comedor", list_comedor.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@banios", list_banio.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@recamas", list_recamara.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@cocina", list_cosina.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@jardin", list_jardin.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@cochera", list_cochera.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@precio", precio.Text);

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

                        string actualiza = "UPDATE CASA SET  TIPO=@tipo, SALA=@sala, COMEDOR=@comedor, BANIOS=@banios, RECAMAS=@recamas, COCINA=@cocina, JARDIN=@jardin, COCHERA=@cochera, PRECIO=@precio  WHERE ID=@id";
                        MySqlCommand cmd = new MySqlCommand(actualiza, con);
                        cmd.Parameters.AddWithValue("@id", id_ac.Text);
                        cmd.Parameters.AddWithValue("@tipo", tipo.Text);
                        cmd.Parameters.AddWithValue("@sala", list_sala.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@comedor", list_comedor.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@banios", list_banio.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@recamas", list_recamara.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@cocina", list_cosina.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@jardin", list_jardin.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@cochera", list_cochera.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@precio", precio.Text);

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
                string bus = "SELECT *FROM CASA  WHERE  TIPO=@tipo AND SALA=@sala AND COMEDOR=@comedor AND BANIOS=@banios AND RECAMAS=@recamas AND COCINA=@cocina AND JARDIN=@jardin AND COCHERA=@cochera AND PRECIO=@precio ";
                MySqlCommand cmd2 = new MySqlCommand(bus, con);
                cmd2.Parameters.AddWithValue("@tipo", tipo.Text);
                cmd2.Parameters.AddWithValue("@sala", list_sala.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@comedor", list_comedor.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@banios", list_banio.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@recamas", list_recamara.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@cocina", list_cosina.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@jardin", list_jardin.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@cochera", list_cochera.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@precio", precio.Text);
                MySqlDataAdapter dat = new MySqlDataAdapter(cmd2);
                dat.Fill(datos);; 
                contador = datos.Rows.Count; //guarda número de repetidos
                con.Close();
            }
            if (contador > 0 && elentos_vacio() == 0)
            {


                pregunta = pregunta_cambio(); // Muestra el cuadro de dialogo donde pregunta si está seguro de los cambios
                if (pregunta == 1)
                {
                    con.Open();
                    string delete = "DELETE FROM CASA WHERE ID=@id";
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
            list_sala.ClearSelected();
            list_comedor.ClearSelected();
            list_banio.ClearSelected();
            list_recamara.ClearSelected();
            list_cosina.ClearSelected();
            list_jardin.ClearSelected();
            list_cochera.ClearSelected();
            precio.Clear();
            
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
            
            if (list_sala.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la cantidad de salas ");
                vacio = 1;
            }
            if (list_comedor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la cantidad de comedres ");
                vacio = 1;
            }
            if (list_banio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la cantidad de baños ");
                vacio = 1;
            }
            if (list_recamara.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la cantidad de recamaras ");
                vacio = 1;
            }
            if (list_cosina.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la cantidad de cocinas ");
                vacio = 1;
            }
            if (list_jardin.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la cantidad de jardines ");
                vacio = 1;
            }
            if (list_cochera.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la cantidad de cocheras ");
                vacio = 1;
            }
            if (precio.TextLength == 0)
            {
                MessageBox.Show("EL campo Precio esta vacío ");
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
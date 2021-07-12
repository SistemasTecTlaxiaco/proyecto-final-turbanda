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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        static string conexion_base_datos = "SERVER=127.0.0.1;PORT=3306;DATABASE=inmobiliaria;UID=root;PASSWORD=genaro;";
        //static string conexion_base_datos = "Server=127.0.0.1;Database=topicos;User Id=root;Password=genaro;";
        MySqlConnection con = new MySqlConnection(conexion_base_datos);

        //int Lista_genero;

        private void Clientes_Load(object sender, EventArgs e)
        {
            Contenido_Base.DataSource = Contenido();
                //**********opcion 2*******
            //list_Genero.Items.Add("H");
            //list_Genero.Items.Add("M");
            //Lista_genero = 0 ;
        }


        public DataTable Contenido()
        {
            con.Open();
            DataTable datos = new DataTable();
            String contenido = "select* from Datos_personales";
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
            MessageBox.Show("Los datos de la persona ya existen ");
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

        public int Verifica_edad()
        {
            double numero;
            numero = Convert.ToDouble(Edad.Text);
            if (numero <18|| numero>100) {
                MessageBox.Show("Edad erronea ");
                return 1;
            }

            return 0;
        }
        public int verifica_tam_telefono() {
            if (N_telefono.TextLength != 10) {
                MessageBox.Show("Número telefónico tiene que ser de 10 dígitos");
                return 1;
            }
            return 0;
        }
        //***************************************************************************


        //***********************al seleccionar una celda de la base, se guarda en el cuadro de texto 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            id_ac.Text = Contenido_Base.CurrentRow.Cells[0].Value.ToString();
            //Id_actualizar = Contenido_Base.CurrentRow.Cells[0].Value.ToString();
            Nom.Text = Contenido_Base.CurrentRow.Cells[1].Value.ToString();
            Apellido_p.Text = Contenido_Base.CurrentRow.Cells[2].Value.ToString();
            Apellido_M.Text = Contenido_Base.CurrentRow.Cells[3].Value.ToString();
            Edad.Text = Contenido_Base.CurrentRow.Cells[5].Value.ToString();
            N_telefono.Text = Contenido_Base.CurrentRow.Cells[6].Value.ToString();
            list_Genero.SelectedItem = Contenido_Base.CurrentRow.Cells[4].Value.ToString();

            Dire.Text = Contenido_Base.CurrentRow.Cells[7].Value.ToString();
            //MessageBox.Show(Id_actualizar);
            //MessageBox.Show(Contenido_Base.CurrentRow.Cells[2].Value.ToString());


        }

        //*********************************************busca si ya existe el usuario en la base de datos*****************
        private int buscar()
        {
            int contador;
            con.Open();
            DataTable datos = new DataTable();
            //string bus = "SELECT* FROM Datos_personales WHERE  NOMBRE=@nombre AND AP_PATERNO=@ap_paterno AND AP_MATERNO=@ap_materno AND DIRECCION=@direccion ";
            string bus = "SELECT* FROM Datos_personales WHERE  NOMBRE=@nombre AND AP_PATERNO=@ap_paterno AND AP_MATERNO=@ap_materno AND GENERO=@genero ";
            MySqlCommand cmd = new MySqlCommand(bus, con);
            cmd.Parameters.AddWithValue("@nombre", Nom.Text);
            cmd.Parameters.AddWithValue("@ap_paterno", Apellido_p.Text);
            cmd.Parameters.AddWithValue("@ap_materno", Apellido_M.Text);
            cmd.Parameters.AddWithValue("@genero", list_Genero.SelectedItem.ToString());
            //cmd.Parameters.AddWithValue("@direccion", Dire.Text);


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
                    if (Verifica_edad() == 0 && verifica_tam_telefono()==0) //verifica que la edad y el telefono tenga 10 digitos
                    { 
                        //inserta nuevo usuario
                        con.Open();
                        string insercion = "INSERT INTO Datos_personales(NOMBRE,AP_PATERNO,AP_MATERNO,GENERO,EDAD,TELEFONO,DIRECCION)VALUES(@nombre,@ap_paterno,@ap_materno,@genero,@edad,@telefono,@direccion)";
                        MySqlCommand cmd = new MySqlCommand(insercion, con);
                        cmd.Parameters.AddWithValue("@nombre", Nom.Text);
                        cmd.Parameters.AddWithValue("@ap_paterno", Apellido_p.Text);
                        cmd.Parameters.AddWithValue("@ap_materno", Apellido_M.Text);
                        //var text = (list_Genero.SelectedItem as DataRowView)["columnName"].ToString();
                        //string text = list_Genero.SelectedItem.ToString();
                        //MessageBox.Show(text);
                        cmd.Parameters.AddWithValue("@genero", list_Genero.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@edad", Edad.Text);
                        cmd.Parameters.AddWithValue("@telefono", N_telefono.Text);
                        cmd.Parameters.AddWithValue("@direccion", Dire.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        limpiar(); // limpia los texbox
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
                        string actualiza = "UPDATE Datos_personales SET  NOMBRE=@nombre, AP_PATERNO=@ap_paterno,AP_MATERNO=@ap_materno,GENERO=@genero,EDAD=@edad,TELEFONO=@telefono,DIRECCION=@direccion WHERE ID=@id";
                        MySqlCommand cmd = new MySqlCommand(actualiza, con);

                        cmd.Parameters.AddWithValue("@id", id_ac.Text);
                        //cmd.Parameters.AddWithValue("@id", Id_actualizar);
                        cmd.Parameters.AddWithValue("@nombre", Nom.Text);
                        cmd.Parameters.AddWithValue("@ap_paterno", Apellido_p.Text);
                        cmd.Parameters.AddWithValue("@ap_materno", Apellido_M.Text);
                        cmd.Parameters.AddWithValue("@genero", list_Genero.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@edad", Edad.Text);
                        cmd.Parameters.AddWithValue("@telefono", N_telefono.Text);
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
                string bus = "SELECT* FROM Datos_personales WHERE ID=@id AND NOMBRE =@nombre AND AP_PATERNO=@ap_paterno AND AP_MATERNO=@ap_materno AND GENERO=@genero AND EDAD=@edad AND TELEFONO=@telefono AND DIRECCION=@direccion ";
                MySqlCommand cmd2 = new MySqlCommand(bus, con);
                cmd2.Parameters.AddWithValue("@id", id_ac.Text);
                cmd2.Parameters.AddWithValue("@nombre", Nom.Text);
                cmd2.Parameters.AddWithValue("@ap_paterno", Apellido_p.Text);
                cmd2.Parameters.AddWithValue("@ap_materno", Apellido_M.Text);
                cmd2.Parameters.AddWithValue("@genero", list_Genero.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@edad", Edad.Text);
                cmd2.Parameters.AddWithValue("@telefono", N_telefono.Text);
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
                    string delete = "DELETE FROM Datos_personales WHERE ID=@id";
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
            Nom.Clear();
            Apellido_p.Clear();
            Apellido_M.Clear();
            list_Genero.ClearSelected();
            Edad.Clear();
            N_telefono.Clear();
            Dire.Clear();
            //Lista_genero = 0;
        }
        //******************************verifica texto vacío 
        private int elentos_vacio()
        {
            int vacio = 0; //cero indica que no está vacío
            if (Nom.TextLength == 0)
            {
                MessageBox.Show("EL campo Nombre esta vacío ");
                vacio = 1;
            }
            if (Apellido_p.TextLength == 0)
            {
                MessageBox.Show("EL campo Apellido Paterno esta vacío ");
                vacio = 1;
            }
            if (Apellido_M.TextLength == 0)
            {
                MessageBox.Show("EL campo Apellido Materno esta vacío ");
                vacio = 1;
            }

            //if (list_Genero.SelectedItem.Equals("H") || list_Genero.SelectedItem.Equals("M"))
           // if (Lista_genero == 0)
            if(list_Genero.SelectedIndex==-1)
            {
                 MessageBox.Show("Seleccione un genero ");
                vacio = 1;
            }


            if (N_telefono.TextLength == 0) {
                MessageBox.Show("EL campo Edad esta vacío ");
                vacio = 1;
            }
            //if(list_Genero.SelectedItem!='m')
            return vacio;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void list_Genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lista_genero = 1;
        }

        private void cerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

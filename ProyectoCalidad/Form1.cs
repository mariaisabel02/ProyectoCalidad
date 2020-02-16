using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCalidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'base_calidadDataSet.Vuelos' table. You can move, or remove it, as needed.
            this.vuelosTableAdapter.Fill(this.base_calidadDataSet.Vuelos);
            // TODO: This line of code loads data into the 'base_calidadDataSet.Aeropuerto' table. You can move, or remove it, as needed.
            this.aeropuertoTableAdapter.Fill(this.base_calidadDataSet.Aeropuerto);

            //nada seleccionado al iniciar
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox2.Clear();
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
        }

        private void btn_consultar_vuelos_Click(object sender, EventArgs e)
        {
            try
            {
                System.DateTime primeraFecha = DateTime.Parse(maskedTextBox2.Text);
                System.DateTime segundaFecha = DateTime.Parse(maskedTextBox3.Text);
                string tipo = comboBox7.SelectedText;
                string diaSemana = comboBox6.SelectedText;
                string aeropuerto = comboBox8.SelectedText;

                string filtro = "";
                DataRow[] resultadoBusqueda = base_calidadDataSet.Vuelos.Select(filtro);
                dataGridView1.DataSource = resultadoBusqueda;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_agregar_vuelo_Click(object sender, EventArgs e)
        {
            try
            {
                //tomar valores del formulario
                string codigoVuelo = textBox1.Text;
                string companiaAerea = comboBox1.Text;
                string pais = comboBox2.Text;
                decimal capacidad = decimal.Parse(textBox2.Text);
                System.DateTime fecha = DateTime.Parse(maskedTextBox1.Text);
                string diaSemana = comboBox3.Text;
                string arrivalDeparture = comboBox4.Text;
                string aeropuerto = (string)comboBox5.SelectedValue;

                //construcción del query
                base_calidadDataSetTableAdapters.VuelosTableAdapter vuelosTableAdapter = new base_calidadDataSetTableAdapters.VuelosTableAdapter();
                vuelosTableAdapter.Insert(codigoVuelo, companiaAerea, diaSemana, pais, arrivalDeparture, capacidad, fecha, aeropuerto);

                //limpia del formulario
                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                textBox2.Clear();
                comboBox3.SelectedIndex = -1;
                comboBox4.SelectedIndex = -1;
                comboBox5.SelectedIndex = -1;

                //refresca el grid
                this.vuelosTableAdapter.Fill(this.base_calidadDataSet.Vuelos);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

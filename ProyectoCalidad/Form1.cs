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
            // TODO: This line of code loads data into the 'base_calidadDataSet.RegistroDiarioVuelos' table. You can move, or remove it, as needed.
            this.registroDiarioVuelosTableAdapter.Fill(this.base_calidadDataSet.RegistroDiarioVuelos);
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
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
        }

        
        //agregar vuelo (genérico)
        private void btn_agregar_vuelo_Click(object sender, EventArgs e)
        {
            try
            {
                //tomar valores del formulario
                string codigoVuelo = textBox1.Text;
                string companiaAerea = comboBox1.Text;
                string pais = comboBox2.Text;
                decimal capacidad = decimal.Parse(textBox2.Text);
               // System.DateTime fecha = DateTime.Parse(maskedTextBox1.Text);
               // string diaSemana = comboBox3.Text;
                string arrivalDeparture = comboBox4.Text;
                string aeropuerto = (string)comboBox5.SelectedValue;

                //construcción del query
                base_calidadDataSetTableAdapters.VuelosTableAdapter vuelosTableAdapter = new base_calidadDataSetTableAdapters.VuelosTableAdapter();
                vuelosTableAdapter.Insert(codigoVuelo, companiaAerea, pais, arrivalDeparture, capacidad, aeropuerto);

                //limpia del formulario
                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                textBox2.Clear();
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

        //editar un vuelo
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //construcción del query
                base_calidadDataSetTableAdapters.VuelosTableAdapter vuelosTableAdapter = new base_calidadDataSetTableAdapters.VuelosTableAdapter();
                this.Validate();
                this.vuelosBindingSource.EndEdit();
                this.vuelosTableAdapter.Update(this.base_calidadDataSet);

                //refresca el grid
                this.vuelosTableAdapter.Fill(this.base_calidadDataSet.Vuelos);
                comboBox9.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //borrar un registro de vuelo (genérico)
        //se borra el vuelo seleccionado en el grid
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //borra el registro que está seleccionado en el grid
                DataGridViewRow row = dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex];
                vuelosTableAdapter.Delete(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), decimal.Parse(row.Cells[4].Value.ToString()), row.Cells[5].Value.ToString());
                
                //refresca el grid
                this.vuelosTableAdapter.Fill(this.base_calidadDataSet.Vuelos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        
        //consulta de registro de vuelos diarios
        private void btn_consultar_vuelos_Click(object sender, EventArgs e)
        {
            try
            {
                //toma los valores del formulario
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

        //agregar un aeropuerto
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //tomar valores del formulario
                string codigoAeropuerto = textBox4.Text;
                string nombreAeropuerto = textBox5.Text;
                string direccion = textBox6.Text;
                int habilitado = checkBox1.Checked ? 1 : 0;
               
                //construcción del query
                base_calidadDataSetTableAdapters.AeropuertoTableAdapter aeropuertoTableAdapter = new base_calidadDataSetTableAdapters.AeropuertoTableAdapter();
                aeropuertoTableAdapter.Insert(codigoAeropuerto,nombreAeropuerto,direccion,habilitado);

                //limpia del formulario
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                checkBox1.Checked = false;

                //refresca el grid
                this.aeropuertoTableAdapter.Fill(this.base_calidadDataSet.Aeropuerto);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //borrar un aeropuerto
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //borra el registro seleccionado en el grid
                DataGridViewRow row = dataGridView3.Rows[this.dataGridView3.CurrentCell.RowIndex];
                aeropuertoTableAdapter.Delete(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), int.Parse(row.Cells[3].Value.ToString()));

                //refresca el grid
                this.aeropuertoTableAdapter.Fill(this.base_calidadDataSet.Aeropuerto);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //editar un aeropuerto
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //construcción del query
                base_calidadDataSetTableAdapters.AeropuertoTableAdapter aeropuertoTableAdapter = new base_calidadDataSetTableAdapters.AeropuertoTableAdapter();
                this.Validate();
                this.aeropuertoBindingSource.EndEdit();
                this.aeropuertoTableAdapter.Update(this.base_calidadDataSet);

                //refresca el grid
                this.aeropuertoTableAdapter.Fill(this.base_calidadDataSet.Aeropuerto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //agregar registro diario de vuelo
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //tomar valores del formulario
                string codigoVuelo = comboBox9.Text;
                System.DateTime fechaVuelo = DateTime.Parse(maskedTextBox1.Text);
                string diaDeLaSemana = comboBox3.Text;
                int cantidadPasajeros = int.Parse(textBox3.Text);
                
                //consulta si la capacidad máxima se excede o no
                DataTable consulta_capacidad = base_calidadDataSet.Tables["VUELOS"];
                DataRow[] resultado = consulta_capacidad.Select("CodigoVuelo = '" + codigoVuelo + "'");

                if ( Convert.ToUInt32(resultado[0]["CapacidadMaxima"]) >= cantidadPasajeros)
                {
                    //construcción del query
                    base_calidadDataSetTableAdapters.RegistroDiarioVuelosTableAdapter registroDiarioVuelosTableAdapter = new base_calidadDataSetTableAdapters.RegistroDiarioVuelosTableAdapter();
                    registroDiarioVuelosTableAdapter.Insert(codigoVuelo, diaDeLaSemana, fechaVuelo, (byte?)cantidadPasajeros);

                    //limpia del formulario
                    comboBox9.SelectedIndex = -1;
                    maskedTextBox1.Clear();
                    comboBox3.SelectedIndex = -1;
                    textBox3.Clear();

                    //refresca el grid
                    this.registroDiarioVuelosTableAdapter.Fill(this.base_calidadDataSet.RegistroDiarioVuelos);

                }
                else
                {
                    MessageBox.Show("La cantidad de pasajeros debe ser menor o igual a "+ Convert.ToUInt32(resultado[0]["CapacidadMaxima"]));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

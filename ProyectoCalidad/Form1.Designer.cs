namespace ProyectoCalidad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_agregar_vuelo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.btn_consultar_vuelos = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.aeropuertoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.base_calidadDataSet = new ProyectoCalidad.base_calidadDataSet();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoVueloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companiaAereaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadMaximaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAeropuertoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aeropuertoTableAdapter = new ProyectoCalidad.base_calidadDataSetTableAdapters.AeropuertoTableAdapter();
            this.vuelosTableAdapter = new ProyectoCalidad.base_calidadDataSetTableAdapters.VuelosTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.fKVuelosCodigoAe31EC6D26BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_calidadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVuelosCodigoAe31EC6D26BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LemonChiffon;
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.maskedTextBox1);
            this.tabPage1.Controls.Add(this.btn_agregar_vuelo);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.comboBox5);
            this.tabPage1.Controls.Add(this.comboBox4);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1132, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro de vuelos";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(192, 26);
            this.label16.TabIndex = 2;
            this.label16.Text = "Registro de vuelos";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(105, 203);
            this.maskedTextBox1.Mask = "00-00-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 22;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // btn_agregar_vuelo
            // 
            this.btn_agregar_vuelo.Location = new System.Drawing.Point(130, 335);
            this.btn_agregar_vuelo.Name = "btn_agregar_vuelo";
            this.btn_agregar_vuelo.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar_vuelo.TabIndex = 17;
            this.btn_agregar_vuelo.Text = "Agregar";
            this.btn_agregar_vuelo.UseVisualStyleBackColor = true;
            this.btn_agregar_vuelo.Click += new System.EventHandler(this.btn_agregar_vuelo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.maskedTextBox3);
            this.panel1.Controls.Add(this.maskedTextBox2);
            this.panel1.Controls.Add(this.btn_consultar_vuelos);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.comboBox8);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.comboBox7);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(224, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 553);
            this.panel1.TabIndex = 16;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(137, 56);
            this.maskedTextBox3.Mask = "00-00-0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBox3.TabIndex = 24;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(55, 56);
            this.maskedTextBox2.Mask = "00-00-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(58, 20);
            this.maskedTextBox2.TabIndex = 23;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // btn_consultar_vuelos
            // 
            this.btn_consultar_vuelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar_vuelos.Location = new System.Drawing.Point(799, 54);
            this.btn_consultar_vuelos.Name = "btn_consultar_vuelos";
            this.btn_consultar_vuelos.Size = new System.Drawing.Size(86, 25);
            this.btn_consultar_vuelos.TabIndex = 21;
            this.btn_consultar_vuelos.Text = "Consultar";
            this.btn_consultar_vuelos.UseVisualStyleBackColor = true;
            this.btn_consultar_vuelos.Click += new System.EventHandler(this.btn_consultar_vuelos_Click);
            // 
            // label14
            // 
            this.label14.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(119, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "y";
            // 
            // comboBox8
            // 
            this.comboBox8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox8.DataSource = this.aeropuertoBindingSource;
            this.comboBox8.DisplayMember = "Codigo";
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(680, 56);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(100, 21);
            this.comboBox8.TabIndex = 18;
            // 
            // aeropuertoBindingSource
            // 
            this.aeropuertoBindingSource.DataMember = "Aeropuerto";
            this.aeropuertoBindingSource.DataSource = this.base_calidadDataSet;
            // 
            // base_calidadDataSet
            // 
            this.base_calidadDataSet.DataSetName = "base_calidadDataSet";
            this.base_calidadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(602, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Aeropuerto";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "A",
            "D"});
            this.comboBox7.Location = new System.Drawing.Point(339, 56);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(34, 21);
            this.comboBox7.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(217, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "Arrival/Departure";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.comboBox6.Location = new System.Drawing.Point(503, 57);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(93, 21);
            this.comboBox6.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(388, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Día de la semana";
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Entre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Consulta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoVueloDataGridViewTextBoxColumn,
            this.companiaAereaDataGridViewTextBoxColumn,
            this.diaDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.arrivalDepartureDataGridViewTextBoxColumn,
            this.capacidadMaximaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.codigoAeropuertoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vuelosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // codigoVueloDataGridViewTextBoxColumn
            // 
            this.codigoVueloDataGridViewTextBoxColumn.DataPropertyName = "CodigoVuelo";
            this.codigoVueloDataGridViewTextBoxColumn.HeaderText = "Código Vuelo";
            this.codigoVueloDataGridViewTextBoxColumn.Name = "codigoVueloDataGridViewTextBoxColumn";
            // 
            // companiaAereaDataGridViewTextBoxColumn
            // 
            this.companiaAereaDataGridViewTextBoxColumn.DataPropertyName = "CompaniaAerea";
            this.companiaAereaDataGridViewTextBoxColumn.HeaderText = "Compañía Aerea";
            this.companiaAereaDataGridViewTextBoxColumn.Name = "companiaAereaDataGridViewTextBoxColumn";
            // 
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "Dia";
            this.diaDataGridViewTextBoxColumn.HeaderText = "Día";
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "País";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            // 
            // arrivalDepartureDataGridViewTextBoxColumn
            // 
            this.arrivalDepartureDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDeparture";
            this.arrivalDepartureDataGridViewTextBoxColumn.HeaderText = "Arrival/Departure";
            this.arrivalDepartureDataGridViewTextBoxColumn.Name = "arrivalDepartureDataGridViewTextBoxColumn";
            // 
            // capacidadMaximaDataGridViewTextBoxColumn
            // 
            this.capacidadMaximaDataGridViewTextBoxColumn.DataPropertyName = "CapacidadMaxima";
            this.capacidadMaximaDataGridViewTextBoxColumn.HeaderText = "Capacidad Máxima";
            this.capacidadMaximaDataGridViewTextBoxColumn.Name = "capacidadMaximaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // codigoAeropuertoDataGridViewTextBoxColumn
            // 
            this.codigoAeropuertoDataGridViewTextBoxColumn.DataPropertyName = "CodigoAeropuerto";
            this.codigoAeropuertoDataGridViewTextBoxColumn.HeaderText = "Aeropuerto";
            this.codigoAeropuertoDataGridViewTextBoxColumn.Name = "codigoAeropuertoDataGridViewTextBoxColumn";
            // 
            // vuelosBindingSource
            // 
            this.vuelosBindingSource.DataMember = "Vuelos";
            this.vuelosBindingSource.DataSource = this.base_calidadDataSet;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.aeropuertoBindingSource;
            this.comboBox5.DisplayMember = "Codigo";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(105, 289);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 21);
            this.comboBox5.TabIndex = 15;
            this.comboBox5.ValueMember = "Codigo";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "A",
            "D"});
            this.comboBox4.Location = new System.Drawing.Point(105, 262);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(100, 21);
            this.comboBox4.TabIndex = 14;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.comboBox3.Location = new System.Drawing.Point(105, 231);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Costa Rica",
            "Estados Unidos",
            "Guatemala",
            "El Salvador",
            "Panamá",
            "México",
            "España",
            "Perú"});
            this.comboBox2.Location = new System.Drawing.Point(105, 148);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "American",
            "Volaris",
            "Spirit",
            "Avianca",
            "Copa",
            "InterJet",
            "United",
            "Iberia"});
            this.comboBox1.Location = new System.Drawing.Point(105, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Aeropuerto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Arrival/Departure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Día de la semana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "País";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compañía aérea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de vuelo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1132, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // aeropuertoTableAdapter
            // 
            this.aeropuertoTableAdapter.ClearBeforeFill = true;
            // 
            // vuelosTableAdapter
            // 
            this.vuelosTableAdapter.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(318, 31);
            this.label15.TabIndex = 1;
            this.label15.Text = "Sistema de Aviación Civil";
            // 
            // fKVuelosCodigoAe31EC6D26BindingSource
            // 
            this.fKVuelosCodigoAe31EC6D26BindingSource.DataMember = "FK__Vuelos__CodigoAe__31EC6D26";
            this.fKVuelosCodigoAe31EC6D26BindingSource.DataSource = this.aeropuertoBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 562);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Sistema de Aviación Civil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aeropuertoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_calidadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVuelosCodigoAe31EC6D26BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private base_calidadDataSet base_calidadDataSet;
        private System.Windows.Forms.BindingSource aeropuertoBindingSource;
        private base_calidadDataSetTableAdapters.AeropuertoTableAdapter aeropuertoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vuelosBindingSource;
        private base_calidadDataSetTableAdapters.VuelosTableAdapter vuelosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoVueloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companiaAereaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadMaximaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAeropuertoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_agregar_vuelo;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_consultar_vuelos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource fKVuelosCodigoAe31EC6D26BindingSource;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label16;
    }
}


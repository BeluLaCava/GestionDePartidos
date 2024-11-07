namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbDeporte = new ComboBox();
            txtEquipoLocal = new TextBox();
            dateFechaPartido = new DateTimePicker();
            btnGuardar = new Button();
            dgvPartidos = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtEquipoVisitante = new TextBox();
            label10 = new Label();
            label11 = new Label();
            btnEliminar = new Button();
            txtIdPartidoEliminar = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtMarcadorVisitante = new TextBox();
            label14 = new Label();
            txtMarcadorLocal = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            txtIdPartidoModificar = new TextBox();
            btnModificar = new Button();
            btnLimpiarBorrador = new Button();
            btnAgregarAlBorrador = new Button();
            btnGuardarBorrador = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 42);
            label1.Name = "label1";
            label1.Size = new Size(368, 54);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Partidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 96);
            label2.Name = "label2";
            label2.Size = new Size(571, 38);
            label2.TabIndex = 1;
            label2.Text = "Aplicación para gestionar eventos deportivos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 184);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 2;
            label3.Text = "Nuevo Partido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 229);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Deporte:";
            // 
            // cmbDeporte
            // 
            cmbDeporte.FormattingEnabled = true;
            cmbDeporte.Location = new Point(31, 265);
            cmbDeporte.Name = "cmbDeporte";
            cmbDeporte.Size = new Size(151, 28);
            cmbDeporte.TabIndex = 4;
            // 
            // txtEquipoLocal
            // 
            txtEquipoLocal.Location = new Point(214, 265);
            txtEquipoLocal.Name = "txtEquipoLocal";
            txtEquipoLocal.Size = new Size(125, 27);
            txtEquipoLocal.TabIndex = 5;
            // 
            // dateFechaPartido
            // 
            dateFechaPartido.Location = new Point(538, 266);
            dateFechaPartido.Name = "dateFechaPartido";
            dateFechaPartido.Size = new Size(250, 27);
            dateFechaPartido.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(280, 324);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvPartidos
            // 
            dgvPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidos.Location = new Point(280, 442);
            dgvPartidos.Name = "dgvPartidos";
            dgvPartidos.RowHeadersWidth = 51;
            dgvPartidos.Size = new Size(894, 188);
            dgvPartidos.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(378, 229);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 11;
            label7.Text = "Equipo Visitante:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(538, 229);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 12;
            label8.Text = "Fecha del Partido:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(214, 229);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 13;
            label9.Text = "Equipo Local:";
            // 
            // txtEquipoVisitante
            // 
            txtEquipoVisitante.Location = new Point(378, 265);
            txtEquipoVisitante.Name = "txtEquipoVisitante";
            txtEquipoVisitante.Size = new Size(125, 27);
            txtEquipoVisitante.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sylfaen", 100.200005F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(760, 133);
            label10.Name = "label10";
            label10.Size = new Size(134, 220);
            label10.TabIndex = 15;
            label10.Text = "|";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(844, 229);
            label11.Name = "label11";
            label11.Size = new Size(103, 20);
            label11.TabIndex = 19;
            label11.Text = "ID del Partido:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(875, 324);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtIdPartidoEliminar
            // 
            txtIdPartidoEliminar.Location = new Point(844, 265);
            txtIdPartidoEliminar.Name = "txtIdPartidoEliminar";
            txtIdPartidoEliminar.Size = new Size(125, 27);
            txtIdPartidoEliminar.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(844, 184);
            label12.Name = "label12";
            label12.Size = new Size(150, 28);
            label12.TabIndex = 16;
            label12.Text = "Eliminar Partido";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(1356, 232);
            label13.Name = "label13";
            label13.Size = new Size(137, 20);
            label13.TabIndex = 21;
            label13.Text = "Marcador Visitante:";
            // 
            // txtMarcadorVisitante
            // 
            txtMarcadorVisitante.Location = new Point(1356, 268);
            txtMarcadorVisitante.Name = "txtMarcadorVisitante";
            txtMarcadorVisitante.Size = new Size(125, 27);
            txtMarcadorVisitante.TabIndex = 20;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(1198, 232);
            label14.Name = "label14";
            label14.Size = new Size(115, 20);
            label14.TabIndex = 23;
            label14.Text = "Marcador Local:";
            // 
            // txtMarcadorLocal
            // 
            txtMarcadorLocal.Location = new Point(1198, 268);
            txtMarcadorLocal.Name = "txtMarcadorLocal";
            txtMarcadorLocal.Size = new Size(125, 27);
            txtMarcadorLocal.TabIndex = 22;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Sylfaen", 100.200005F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(963, 133);
            label15.Name = "label15";
            label15.Size = new Size(134, 220);
            label15.TabIndex = 24;
            label15.Text = "|";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(1043, 184);
            label16.Name = "label16";
            label16.Size = new Size(164, 28);
            label16.TabIndex = 25;
            label16.Text = "Modificar Partido";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(1043, 232);
            label17.Name = "label17";
            label17.Size = new Size(103, 20);
            label17.TabIndex = 27;
            label17.Text = "ID del Partido:";
            // 
            // txtIdPartidoModificar
            // 
            txtIdPartidoModificar.Location = new Point(1043, 268);
            txtIdPartidoModificar.Name = "txtIdPartidoModificar";
            txtIdPartidoModificar.Size = new Size(125, 27);
            txtIdPartidoModificar.TabIndex = 26;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(1219, 324);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 28;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnLimpiarBorrador
            // 
            btnLimpiarBorrador.Location = new Point(706, 324);
            btnLimpiarBorrador.Name = "btnLimpiarBorrador";
            btnLimpiarBorrador.Size = new Size(94, 70);
            btnLimpiarBorrador.TabIndex = 29;
            btnLimpiarBorrador.Text = "Limpiar Borrador";
            btnLimpiarBorrador.UseVisualStyleBackColor = true;
            btnLimpiarBorrador.Click += btnLimpiarBorrador_Click;
            // 
            // btnAgregarAlBorrador
            // 
            btnAgregarAlBorrador.Location = new Point(475, 324);
            btnAgregarAlBorrador.Name = "btnAgregarAlBorrador";
            btnAgregarAlBorrador.Size = new Size(94, 70);
            btnAgregarAlBorrador.TabIndex = 30;
            btnAgregarAlBorrador.Text = "Agregar Partido Al Borrador";
            btnAgregarAlBorrador.UseVisualStyleBackColor = true;
            btnAgregarAlBorrador.Click += btnAgregarAlBorrador_Click;
            // 
            // btnGuardarBorrador
            // 
            btnGuardarBorrador.Location = new Point(588, 324);
            btnGuardarBorrador.Name = "btnGuardarBorrador";
            btnGuardarBorrador.Size = new Size(94, 70);
            btnGuardarBorrador.TabIndex = 31;
            btnGuardarBorrador.Text = "Guardar Borrador";
            btnGuardarBorrador.UseVisualStyleBackColor = true;
            btnGuardarBorrador.Click += btnGuardarBorrador_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 665);
            Controls.Add(btnGuardarBorrador);
            Controls.Add(btnAgregarAlBorrador);
            Controls.Add(btnLimpiarBorrador);
            Controls.Add(btnModificar);
            Controls.Add(label17);
            Controls.Add(txtIdPartidoModificar);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(txtMarcadorLocal);
            Controls.Add(label13);
            Controls.Add(txtMarcadorVisitante);
            Controls.Add(label11);
            Controls.Add(btnEliminar);
            Controls.Add(txtIdPartidoEliminar);
            Controls.Add(label12);
            Controls.Add(txtEquipoVisitante);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgvPartidos);
            Controls.Add(btnGuardar);
            Controls.Add(dateFechaPartido);
            Controls.Add(txtEquipoLocal);
            Controls.Add(cmbDeporte);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(label15);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbDeporte;
        private TextBox txtEquipoLocal;
        private DateTimePicker dateFechaPartido;
        private Button btnGuardar;
        private DataGridView dgvPartidos;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtEquipoVisitante;
        private Label label10;
        private Label label11;
        private Button btnEliminar;
        private TextBox txtIdPartidoEliminar;
        private Label label12;
        private Label label13;
        private TextBox txtMarcadorVisitante;
        private Label label14;
        private TextBox txtMarcadorLocal;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtIdPartidoModificar;
        private Button btnModificar;
        private Button btnLimpiarBorrador;
        private Button btnAgregarAlBorrador;
        private Button btnGuardarBorrador;
    }
}

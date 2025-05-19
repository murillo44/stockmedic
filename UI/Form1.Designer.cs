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
            groupBox1 = new GroupBox();
            btnGuardarLista = new Button();
            btnCrearIngreso = new Button();
            btnAgregarBorrador = new Button();
            label1 = new Label();
            dtpFechaRegistro = new DateTimePicker();
            txtNombreEncargado = new TextBox();
            txtCantidad = new TextBox();
            txtIDEmpresa = new TextBox();
            txtDescripcion = new TextBox();
            txtNombreInsumo = new TextBox();
            txtCodigoBarra = new TextBox();
            groupBox2 = new GroupBox();
            txtCantModificar = new TextBox();
            button1 = new Button();
            txtIdIngreso = new TextBox();
            groupBox3 = new GroupBox();
            button2 = new Button();
            txtIdAEliminar = new TextBox();
            dgvListaIngresos = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaIngresos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardarLista);
            groupBox1.Controls.Add(btnCrearIngreso);
            groupBox1.Controls.Add(btnAgregarBorrador);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpFechaRegistro);
            groupBox1.Controls.Add(txtNombreEncargado);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(txtIDEmpresa);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtNombreInsumo);
            groupBox1.Controls.Add(txtCodigoBarra);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 358);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CREAR INGRESO";
            // 
            // btnGuardarLista
            // 
            btnGuardarLista.Location = new Point(63, 303);
            btnGuardarLista.Name = "btnGuardarLista";
            btnGuardarLista.Size = new Size(116, 46);
            btnGuardarLista.TabIndex = 10;
            btnGuardarLista.Text = "Guardar Lista de Ingresos";
            btnGuardarLista.UseVisualStyleBackColor = true;
            btnGuardarLista.Click += button3_Click;
            // 
            // btnCrearIngreso
            // 
            btnCrearIngreso.Location = new Point(128, 256);
            btnCrearIngreso.Name = "btnCrearIngreso";
            btnCrearIngreso.Size = new Size(101, 41);
            btnCrearIngreso.TabIndex = 9;
            btnCrearIngreso.Text = "Crear Ingreso";
            btnCrearIngreso.UseVisualStyleBackColor = true;
            btnCrearIngreso.Click += btnCrearIngreso_Click;
            // 
            // btnAgregarBorrador
            // 
            btnAgregarBorrador.Location = new Point(6, 256);
            btnAgregarBorrador.Name = "btnAgregarBorrador";
            btnAgregarBorrador.Size = new Size(116, 41);
            btnAgregarBorrador.TabIndex = 8;
            btnAgregarBorrador.Text = "Agregar al Borrador";
            btnAgregarBorrador.UseVisualStyleBackColor = true;
            btnAgregarBorrador.Click += btnAgregarBorrador_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 209);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 7;
            label1.Text = "Fecha de Registro:";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Location = new Point(6, 227);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(214, 23);
            dtpFechaRegistro.TabIndex = 6;
            // 
            // txtNombreEncargado
            // 
            txtNombreEncargado.Location = new Point(6, 180);
            txtNombreEncargado.Name = "txtNombreEncargado";
            txtNombreEncargado.PlaceholderText = "NOMBRE DEL ENCARGADO";
            txtNombreEncargado.Size = new Size(154, 23);
            txtNombreEncargado.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(6, 151);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "CANTIDAD";
            txtCantidad.Size = new Size(154, 23);
            txtCantidad.TabIndex = 4;
            // 
            // txtIDEmpresa
            // 
            txtIDEmpresa.Location = new Point(6, 122);
            txtIDEmpresa.Name = "txtIDEmpresa";
            txtIDEmpresa.PlaceholderText = "ID EMPRESA";
            txtIDEmpresa.Size = new Size(154, 23);
            txtIDEmpresa.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(6, 93);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "DESCRIPCION";
            txtDescripcion.Size = new Size(154, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // txtNombreInsumo
            // 
            txtNombreInsumo.Location = new Point(6, 64);
            txtNombreInsumo.Name = "txtNombreInsumo";
            txtNombreInsumo.PlaceholderText = "NOMBRE DEL INSUMO";
            txtNombreInsumo.Size = new Size(154, 23);
            txtNombreInsumo.TabIndex = 1;
            // 
            // txtCodigoBarra
            // 
            txtCodigoBarra.Location = new Point(6, 35);
            txtCodigoBarra.Name = "txtCodigoBarra";
            txtCodigoBarra.PlaceholderText = "CODIGO DE BARRA";
            txtCodigoBarra.Size = new Size(154, 23);
            txtCodigoBarra.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCantModificar);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txtIdIngreso);
            groupBox2.Location = new Point(258, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(214, 145);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "MODIFICAR CANTIDAD DE INGRESO";
            // 
            // txtCantModificar
            // 
            txtCantModificar.Location = new Point(19, 64);
            txtCantModificar.Name = "txtCantModificar";
            txtCantModificar.PlaceholderText = "CANTIDAD A MODIFICAR";
            txtCantModificar.Size = new Size(154, 23);
            txtCantModificar.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(19, 93);
            button1.Name = "button1";
            button1.Size = new Size(154, 33);
            button1.TabIndex = 11;
            button1.Text = "Modificar Cambios";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIdIngreso
            // 
            txtIdIngreso.Location = new Point(19, 35);
            txtIdIngreso.Name = "txtIdIngreso";
            txtIdIngreso.PlaceholderText = "ID INGRESO";
            txtIdIngreso.Size = new Size(154, 23);
            txtIdIngreso.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(txtIdAEliminar);
            groupBox3.Location = new Point(258, 163);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(214, 123);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "ELIMINAR INGRESO";
            // 
            // button2
            // 
            button2.Location = new Point(19, 75);
            button2.Name = "button2";
            button2.Size = new Size(154, 33);
            button2.TabIndex = 11;
            button2.Text = "Eliminar Ingreso";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtIdAEliminar
            // 
            txtIdAEliminar.Location = new Point(19, 35);
            txtIdAEliminar.Name = "txtIdAEliminar";
            txtIdAEliminar.PlaceholderText = "ID INGRESO";
            txtIdAEliminar.Size = new Size(154, 23);
            txtIdAEliminar.TabIndex = 11;
            // 
            // dgvListaIngresos
            // 
            dgvListaIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaIngresos.Location = new Point(478, 12);
            dgvListaIngresos.Name = "dgvListaIngresos";
            dgvListaIngresos.Size = new Size(451, 421);
            dgvListaIngresos.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 445);
            Controls.Add(dgvListaIngresos);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaIngresos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNombreEncargado;
        private TextBox txtCantidad;
        private TextBox txtIDEmpresa;
        private TextBox txtDescripcion;
        private TextBox txtNombreInsumo;
        private TextBox txtCodigoBarra;
        private Button btnGuardarLista;
        private Button btnCrearIngreso;
        private Button btnAgregarBorrador;
        private Label label1;
        private DateTimePicker dtpFechaRegistro;
        private GroupBox groupBox2;
        private TextBox txtCantModificar;
        private Button button1;
        private TextBox txtIdIngreso;
        private GroupBox groupBox3;
        private Button button2;
        private TextBox txtIdAEliminar;
        private DataGridView dgvListaIngresos;
    }
}

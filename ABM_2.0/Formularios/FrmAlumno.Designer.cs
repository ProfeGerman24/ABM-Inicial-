namespace Formularios
{
    partial class FrmAlumno
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtLegajo = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtNota = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(38, 189);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(85, 42);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(154, 189);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 42);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 19);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 2;
            label1.Text = "Legajo";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(113, 11);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(100, 29);
            txtLegajo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 29);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 62);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(113, 93);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 29);
            txtApellido.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 101);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(113, 139);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(100, 29);
            txtNota.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 142);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 8;
            label4.Text = "Nota";
            // 
            // FrmAlumno
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 254);
            Controls.Add(txtNota);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtLegajo);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FrmAlumno";
            Text = "FrmAlumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtLegajo;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtNota;
        private Label label4;
    }
}
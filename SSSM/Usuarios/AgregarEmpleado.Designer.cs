namespace SSSM
{
    partial class AgregarEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radUser = new System.Windows.Forms.RadioButton();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.usuario = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(350, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 52);
            this.button4.TabIndex = 7;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(132, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "NOMBRE:";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.nombre.Location = new System.Drawing.Point(174, 78);
            this.nombre.MaxLength = 100;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(230, 33);
            this.nombre.TabIndex = 14;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radUser);
            this.groupBox1.Controls.Add(this.radAdmin);
            this.groupBox1.Location = new System.Drawing.Point(443, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 153);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO DE USUARIO";
            // 
            // radUser
            // 
            this.radUser.AutoSize = true;
            this.radUser.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.radUser.Location = new System.Drawing.Point(8, 34);
            this.radUser.Name = "radUser";
            this.radUser.Size = new System.Drawing.Size(108, 29);
            this.radUser.TabIndex = 18;
            this.radUser.TabStop = true;
            this.radUser.Text = "USUARIO";
            this.radUser.UseVisualStyleBackColor = true;
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.radAdmin.Location = new System.Drawing.Point(6, 88);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(177, 29);
            this.radAdmin.TabIndex = 21;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "ADMINISTRADOR";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.usuario.Location = new System.Drawing.Point(174, 128);
            this.usuario.MaxLength = 100;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(230, 33);
            this.usuario.TabIndex = 25;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.pass.Location = new System.Drawing.Point(174, 194);
            this.pass.MaxLength = 100;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(230, 33);
            this.pass.TabIndex = 26;
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 321);
            this.ControlBox = false;
            this.Controls.Add(this.pass);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AgregarEmpleado";
            this.Text = "Agregar Empleado";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radUser;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox pass;
    }
}
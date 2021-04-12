namespace SSSM
{
    partial class EditarEmpleado
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
            this.button1 = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radUser = new System.Windows.Forms.RadioButton();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.estadoCmb = new MetroFramework.Controls.MetroComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(70, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.pass.Location = new System.Drawing.Point(140, 206);
            this.pass.MaxLength = 100;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(230, 33);
            this.pass.TabIndex = 33;
            // 
            // user
            // 
            this.user.Enabled = false;
            this.user.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.user.Location = new System.Drawing.Point(140, 146);
            this.user.MaxLength = 100;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(230, 33);
            this.user.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radUser);
            this.groupBox1.Controls.Add(this.radAdmin);
            this.groupBox1.Location = new System.Drawing.Point(410, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 103);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO DE USUARIO";
            // 
            // radUser
            // 
            this.radUser.AutoSize = true;
            this.radUser.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.radUser.Location = new System.Drawing.Point(8, 25);
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
            this.radAdmin.Location = new System.Drawing.Point(6, 63);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(177, 29);
            this.radAdmin.TabIndex = 21;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "ADMINISTRADOR";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.nombre.Location = new System.Drawing.Point(140, 86);
            this.nombre.MaxLength = 100;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(230, 33);
            this.nombre.TabIndex = 30;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "USUARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "ESTADO:";
            // 
            // estadoCmb
            // 
            this.estadoCmb.FormattingEnabled = true;
            this.estadoCmb.ItemHeight = 23;
            this.estadoCmb.Location = new System.Drawing.Point(410, 223);
            this.estadoCmb.Margin = new System.Windows.Forms.Padding(2);
            this.estadoCmb.Name = "estadoCmb";
            this.estadoCmb.Size = new System.Drawing.Size(230, 29);
            this.estadoCmb.TabIndex = 35;
            this.estadoCmb.UseSelectable = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(262, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 52);
            this.button2.TabIndex = 36;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 347);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.estadoCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "EditarEmpleado";
            this.Text = "Editar Empleado";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radUser;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.TextBox nombre;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox estadoCmb;
        private System.Windows.Forms.Button button2;
    }
}
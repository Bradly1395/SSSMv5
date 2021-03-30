namespace SSSM
{
    partial class CrearTrabajo
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
            this.fechaL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.atencionCmb = new MetroFramework.Controls.MetroComboBox();
            this.clientecmb = new MetroFramework.Controls.MetroComboBox();
            this.horaL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.finalizarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "FECHA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fechaL
            // 
            this.fechaL.AutoSize = true;
            this.fechaL.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaL.Location = new System.Drawing.Point(223, 78);
            this.fechaL.Name = "fechaL";
            this.fechaL.Size = new System.Drawing.Size(68, 25);
            this.fechaL.TabIndex = 2;
            this.fechaL.Text = "FECHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "DESCRIPCION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "ATENCION:";
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.descripcion.Location = new System.Drawing.Point(228, 211);
            this.descripcion.MaxLength = 100;
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(257, 63);
            this.descripcion.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(273, 430);
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
            this.button1.Location = new System.Drawing.Point(63, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "CLIENTE:";
            // 
            // valor
            // 
            this.valor.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.valor.Location = new System.Drawing.Point(228, 297);
            this.valor.MaxLength = 9;
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(257, 33);
            this.valor.TabIndex = 14;
            this.valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "VALOR:";
            // 
            // atencionCmb
            // 
            this.atencionCmb.FormattingEnabled = true;
            this.atencionCmb.ItemHeight = 23;
            this.atencionCmb.Location = new System.Drawing.Point(228, 162);
            this.atencionCmb.Name = "atencionCmb";
            this.atencionCmb.Size = new System.Drawing.Size(257, 29);
            this.atencionCmb.TabIndex = 17;
            this.atencionCmb.UseSelectable = true;
            this.atencionCmb.SelectedIndexChanged += new System.EventHandler(this.atencionCmb_SelectedIndexChanged);
            // 
            // clientecmb
            // 
            this.clientecmb.FormattingEnabled = true;
            this.clientecmb.ItemHeight = 23;
            this.clientecmb.Location = new System.Drawing.Point(228, 362);
            this.clientecmb.Name = "clientecmb";
            this.clientecmb.Size = new System.Drawing.Size(257, 29);
            this.clientecmb.TabIndex = 18;
            this.clientecmb.UseSelectable = true;
            // 
            // horaL
            // 
            this.horaL.AutoSize = true;
            this.horaL.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaL.Location = new System.Drawing.Point(223, 115);
            this.horaL.Name = "horaL";
            this.horaL.Size = new System.Drawing.Size(62, 25);
            this.horaL.TabIndex = 20;
            this.horaL.Text = "HORA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "HORA:";
            // 
            // finalizarBtn
            // 
            this.finalizarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.finalizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizarBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizarBtn.ForeColor = System.Drawing.Color.White;
            this.finalizarBtn.Location = new System.Drawing.Point(157, 488);
            this.finalizarBtn.Name = "finalizarBtn";
            this.finalizarBtn.Size = new System.Drawing.Size(185, 52);
            this.finalizarBtn.TabIndex = 21;
            this.finalizarBtn.Text = "Finalizar";
            this.finalizarBtn.UseVisualStyleBackColor = false;
            this.finalizarBtn.Visible = false;
            this.finalizarBtn.Click += new System.EventHandler(this.finalizarBtn_Click);
            // 
            // CrearTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 546);
            this.ControlBox = false;
            this.Controls.Add(this.finalizarBtn);
            this.Controls.Add(this.horaL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clientecmb);
            this.Controls.Add(this.atencionCmb);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaL);
            this.Controls.Add(this.label1);
            this.Name = "CrearTrabajo";
            this.Text = "Orden de Trabajo";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label fechaL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label horaL;
        private System.Windows.Forms.Label label7;
        public MetroFramework.Controls.MetroComboBox atencionCmb;
        public MetroFramework.Controls.MetroComboBox clientecmb;
        public System.Windows.Forms.Button finalizarBtn;
    }
}
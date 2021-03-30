namespace SSSM
{
    partial class CrearPedido
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
            this.cancelar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.horaL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.atencionCmb = new MetroFramework.Controls.MetroComboBox();
            this.cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.abono = new System.Windows.Forms.TextBox();
            this.saldo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.costo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.finalizarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.Color.White;
            this.cancelar.Location = new System.Drawing.Point(61, 503);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(185, 52);
            this.cancelar.TabIndex = 41;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.Color.White;
            this.guardar.Location = new System.Drawing.Point(271, 503);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(185, 52);
            this.guardar.TabIndex = 40;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.button4_Click);
            // 
            // horaL
            // 
            this.horaL.AutoSize = true;
            this.horaL.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaL.Location = new System.Drawing.Point(407, 69);
            this.horaL.Name = "horaL";
            this.horaL.Size = new System.Drawing.Size(62, 25);
            this.horaL.TabIndex = 54;
            this.horaL.Text = "HORA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "HORA:";
            // 
            // fechaL
            // 
            this.fechaL.AutoSize = true;
            this.fechaL.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaL.Location = new System.Drawing.Point(142, 69);
            this.fechaL.Name = "fechaL";
            this.fechaL.Size = new System.Drawing.Size(68, 25);
            this.fechaL.TabIndex = 52;
            this.fechaL.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "FECHA:";
            // 
            // atencionCmb
            // 
            this.atencionCmb.FormattingEnabled = true;
            this.atencionCmb.ItemHeight = 23;
            this.atencionCmb.Location = new System.Drawing.Point(234, 374);
            this.atencionCmb.Name = "atencionCmb";
            this.atencionCmb.Size = new System.Drawing.Size(257, 29);
            this.atencionCmb.TabIndex = 61;
            this.atencionCmb.UseSelectable = true;
            this.atencionCmb.SelectedIndexChanged += new System.EventHandler(this.atencionCmb_SelectedIndexChanged);
            // 
            // cliente
            // 
            this.cliente.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cliente.Location = new System.Drawing.Point(234, 127);
            this.cliente.MaxLength = 100;
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(257, 33);
            this.cliente.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "ABONO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "CLIENTE:";
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.descripcion.Location = new System.Drawing.Point(234, 422);
            this.descripcion.MaxLength = 100;
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(257, 63);
            this.descripcion.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "ATENCION:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "DESCRIPCION:";
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.telefono.Location = new System.Drawing.Point(234, 179);
            this.telefono.MaxLength = 100;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(257, 33);
            this.telefono.TabIndex = 63;
            this.telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 62;
            this.label7.Text = "NUMERO DE TEL:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // abono
            // 
            this.abono.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.abono.Location = new System.Drawing.Point(234, 282);
            this.abono.MaxLength = 6;
            this.abono.Name = "abono";
            this.abono.Size = new System.Drawing.Size(150, 33);
            this.abono.TabIndex = 64;
            this.abono.TextChanged += new System.EventHandler(this.abono_TextChanged);
            this.abono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.abono_KeyPress);
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldo.Location = new System.Drawing.Point(234, 330);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(46, 25);
            this.saldo.TabIndex = 66;
            this.saldo.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(143, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 65;
            this.label9.Text = "SALDO:";
            // 
            // costo
            // 
            this.costo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.costo.Location = new System.Drawing.Point(234, 232);
            this.costo.MaxLength = 6;
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(150, 33);
            this.costo.TabIndex = 68;
            this.costo.TextChanged += new System.EventHandler(this.costo_TextChanged);
            this.costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 25);
            this.label8.TabIndex = 67;
            this.label8.Text = "COSTO DEL TRABAJO:";
            // 
            // finalizarBtn
            // 
            this.finalizarBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.finalizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finalizarBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalizarBtn.ForeColor = System.Drawing.Color.White;
            this.finalizarBtn.Location = new System.Drawing.Point(168, 561);
            this.finalizarBtn.Name = "finalizarBtn";
            this.finalizarBtn.Size = new System.Drawing.Size(185, 52);
            this.finalizarBtn.TabIndex = 69;
            this.finalizarBtn.Text = "Finalizar";
            this.finalizarBtn.UseVisualStyleBackColor = false;
            this.finalizarBtn.Visible = false;
            this.finalizarBtn.Click += new System.EventHandler(this.finalizarBtn_Click);
            // 
            // CrearPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 618);
            this.ControlBox = false;
            this.Controls.Add(this.finalizarBtn);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.abono);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.atencionCmb);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.horaL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.guardar);
            this.Name = "CrearPedido";
            this.Text = "TRABAJO ENCARGADO";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.vacaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button guardar;
        public System.Windows.Forms.Label horaL;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label fechaL;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox atencionCmb;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox abono;
        public System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button finalizarBtn;
    }
}
namespace SSSM
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.agregaruserbtn = new System.Windows.Forms.Button();
            this.editarbtn = new System.Windows.Forms.Button();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // agregaruserbtn
            // 
            this.agregaruserbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.agregaruserbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregaruserbtn.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.agregaruserbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.agregaruserbtn.Location = new System.Drawing.Point(616, 92);
            this.agregaruserbtn.Name = "agregaruserbtn";
            this.agregaruserbtn.Size = new System.Drawing.Size(159, 58);
            this.agregaruserbtn.TabIndex = 20;
            this.agregaruserbtn.Text = "AGREGAR CLIENTES";
            this.agregaruserbtn.UseVisualStyleBackColor = false;
            this.agregaruserbtn.Click += new System.EventHandler(this.agregaruserbtn_Click);
            // 
            // editarbtn
            // 
            this.editarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.editarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarbtn.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F);
            this.editarbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.editarbtn.Location = new System.Drawing.Point(440, 92);
            this.editarbtn.Name = "editarbtn";
            this.editarbtn.Size = new System.Drawing.Size(159, 58);
            this.editarbtn.TabIndex = 21;
            this.editarbtn.Text = "EDITAR";
            this.editarbtn.UseVisualStyleBackColor = false;
            this.editarbtn.Click += new System.EventHandler(this.editarbtn_Click);
            // 
            // gridClientes
            // 
            this.gridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClientes.BackgroundColor = System.Drawing.SystemColors.WindowText;
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(14, 157);
            this.gridClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.RowHeadersWidth = 51;
            this.gridClientes.Size = new System.Drawing.Size(761, 323);
            this.gridClientes.TabIndex = 157;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 158;
            this.pictureBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(731, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 41);
            this.button6.TabIndex = 159;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 485);
            this.ControlBox = false;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.editarbtn);
            this.Controls.Add(this.agregaruserbtn);
            this.Name = "Clientes";
            this.Text = "CLIENTES";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button agregaruserbtn;
        private System.Windows.Forms.Button editarbtn;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button6;
    }
}
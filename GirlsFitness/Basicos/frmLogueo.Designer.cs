namespace GirlsFitness.Basicos
{
    partial class frmLogueo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogueo));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.LblError = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCuponera = new System.Windows.Forms.Label();
            this.lblCant1 = new System.Windows.Forms.Label();
            this.lblAccesos1 = new System.Windows.Forms.Label();
            this.lblRestan = new System.Windows.Forms.Label();
            this.lblAccesos2 = new System.Windows.Forms.Label();
            this.lblCant2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BarraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(720, 362);
            this.txtPassword.MaxLength = 6;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 38);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(720, 312);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(172, 38);
            this.txtUsuario.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(720, 416);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(172, 39);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Registrar Acceso";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(651, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "PIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(552, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Documento";
            // 
            // BarraEstado
            // 
            this.BarraEstado.BackColor = System.Drawing.Color.Transparent;
            this.BarraEstado.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblError});
            this.BarraEstado.Location = new System.Drawing.Point(0, 707);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(1350, 22);
            this.BarraEstado.TabIndex = 17;
            this.BarraEstado.Text = "statusStrip1";
            // 
            // LblError
            // 
            this.LblError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LblError.ForeColor = System.Drawing.Color.Red;
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 17);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(520, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 290);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBienvenido.Location = new System.Drawing.Point(610, 499);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(214, 42);
            this.lblBienvenido.TabIndex = 19;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.lblNombre.Location = new System.Drawing.Point(577, 560);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(250, 37);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Andrea Castaña";
            this.lblNombre.Visible = false;
            // 
            // lblCuponera
            // 
            this.lblCuponera.AutoSize = true;
            this.lblCuponera.BackColor = System.Drawing.Color.Transparent;
            this.lblCuponera.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuponera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.lblCuponera.Location = new System.Drawing.Point(480, 605);
            this.lblCuponera.Name = "lblCuponera";
            this.lblCuponera.Size = new System.Drawing.Size(202, 37);
            this.lblCuponera.TabIndex = 21;
            this.lblCuponera.Text = "Cuponera de";
            this.lblCuponera.Visible = false;
            // 
            // lblCant1
            // 
            this.lblCant1.AutoSize = true;
            this.lblCant1.BackColor = System.Drawing.Color.Transparent;
            this.lblCant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.lblCant1.Location = new System.Drawing.Point(700, 605);
            this.lblCant1.Name = "lblCant1";
            this.lblCant1.Size = new System.Drawing.Size(51, 37);
            this.lblCant1.TabIndex = 22;
            this.lblCant1.Text = "12";
            this.lblCant1.Visible = false;
            // 
            // lblAccesos1
            // 
            this.lblAccesos1.AutoSize = true;
            this.lblAccesos1.BackColor = System.Drawing.Color.Transparent;
            this.lblAccesos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccesos1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.lblAccesos1.Location = new System.Drawing.Point(763, 605);
            this.lblAccesos1.Name = "lblAccesos1";
            this.lblAccesos1.Size = new System.Drawing.Size(134, 37);
            this.lblAccesos1.TabIndex = 23;
            this.lblAccesos1.Text = "accesos";
            this.lblAccesos1.Visible = false;
            // 
            // lblRestan
            // 
            this.lblRestan.AutoSize = true;
            this.lblRestan.BackColor = System.Drawing.Color.Transparent;
            this.lblRestan.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.lblRestan.Location = new System.Drawing.Point(565, 647);
            this.lblRestan.Name = "lblRestan";
            this.lblRestan.Size = new System.Drawing.Size(117, 37);
            this.lblRestan.TabIndex = 24;
            this.lblRestan.Text = "Restan";
            this.lblRestan.Visible = false;
            // 
            // lblAccesos2
            // 
            this.lblAccesos2.AutoSize = true;
            this.lblAccesos2.BackColor = System.Drawing.Color.Transparent;
            this.lblAccesos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccesos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.lblAccesos2.Location = new System.Drawing.Point(763, 647);
            this.lblAccesos2.Name = "lblAccesos2";
            this.lblAccesos2.Size = new System.Drawing.Size(134, 37);
            this.lblAccesos2.TabIndex = 26;
            this.lblAccesos2.Text = "accesos";
            this.lblAccesos2.Visible = false;
            // 
            // lblCant2
            // 
            this.lblCant2.AutoSize = true;
            this.lblCant2.BackColor = System.Drawing.Color.Transparent;
            this.lblCant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCant2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.lblCant2.Location = new System.Drawing.Point(707, 647);
            this.lblCant2.Name = "lblCant2";
            this.lblCant2.Size = new System.Drawing.Size(35, 37);
            this.lblCant2.TabIndex = 25;
            this.lblCant2.Text = "7";
            this.lblCant2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 7000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLogueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.lblAccesos2);
            this.Controls.Add(this.lblCant2);
            this.Controls.Add(this.lblRestan);
            this.Controls.Add(this.lblAccesos1);
            this.Controls.Add(this.lblCant1);
            this.Controls.Add(this.lblCuponera);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogueo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel LblError;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAccesos2;
        private System.Windows.Forms.Label lblCant2;
        private System.Windows.Forms.Label lblRestan;
        private System.Windows.Forms.Label lblAccesos1;
        private System.Windows.Forms.Label lblCant1;
        private System.Windows.Forms.Label lblCuponera;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Timer timer1;
    }
}
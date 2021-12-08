namespace ADCN
{
    partial class frmFinDeJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinDeJuego));
            this.btnVolverAJugar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.pbxTrophy = new System.Windows.Forms.PictureBox();
            this.btnVerVideo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.btnPuntuaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTrophy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolverAJugar
            // 
            this.btnVolverAJugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolverAJugar.BackColor = System.Drawing.Color.Gold;
            this.btnVolverAJugar.FlatAppearance.BorderSize = 0;
            this.btnVolverAJugar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolverAJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAJugar.ForeColor = System.Drawing.Color.Black;
            this.btnVolverAJugar.Location = new System.Drawing.Point(232, 374);
            this.btnVolverAJugar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolverAJugar.Name = "btnVolverAJugar";
            this.btnVolverAJugar.Size = new System.Drawing.Size(207, 39);
            this.btnVolverAJugar.TabIndex = 6;
            this.btnVolverAJugar.Text = "VOLVER A JUGAR";
            this.btnVolverAJugar.UseVisualStyleBackColor = false;
            this.btnVolverAJugar.Visible = false;
            this.btnVolverAJugar.Click += new System.EventHandler(this.btnVolverAJugar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(13, 286);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(424, 64);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "label1";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensaje.Visible = false;
            // 
            // delay
            // 
            this.delay.Interval = 4420;
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // pbxTrophy
            // 
            this.pbxTrophy.BackColor = System.Drawing.Color.Transparent;
            this.pbxTrophy.Enabled = false;
            this.pbxTrophy.Image = ((System.Drawing.Image)(resources.GetObject("pbxTrophy.Image")));
            this.pbxTrophy.Location = new System.Drawing.Point(12, 11);
            this.pbxTrophy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxTrophy.Name = "pbxTrophy";
            this.pbxTrophy.Size = new System.Drawing.Size(428, 308);
            this.pbxTrophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTrophy.TabIndex = 4;
            this.pbxTrophy.TabStop = false;
            // 
            // btnVerVideo
            // 
            this.btnVerVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerVideo.BackColor = System.Drawing.Color.Gold;
            this.btnVerVideo.FlatAppearance.BorderSize = 0;
            this.btnVerVideo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVideo.ForeColor = System.Drawing.Color.Black;
            this.btnVerVideo.Location = new System.Drawing.Point(232, 424);
            this.btnVerVideo.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerVideo.Name = "btnVerVideo";
            this.btnVerVideo.Size = new System.Drawing.Size(207, 39);
            this.btnVerVideo.TabIndex = 7;
            this.btnVerVideo.Text = "VER UN VIDEO";
            this.btnVerVideo.UseVisualStyleBackColor = false;
            this.btnVerVideo.Visible = false;
            this.btnVerVideo.Click += new System.EventHandler(this.btnVerVideo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.Gold;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(12, 424);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(207, 39);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "IR AL MENÚ";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.lblEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.Location = new System.Drawing.Point(12, 0);
            this.lblEncabezado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(428, 64);
            this.lblEncabezado.TabIndex = 9;
            this.lblEncabezado.Text = "label1";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEncabezado.Visible = false;
            // 
            // btnPuntuaciones
            // 
            this.btnPuntuaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPuntuaciones.BackColor = System.Drawing.Color.Gold;
            this.btnPuntuaciones.FlatAppearance.BorderSize = 0;
            this.btnPuntuaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPuntuaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuntuaciones.ForeColor = System.Drawing.Color.Black;
            this.btnPuntuaciones.Location = new System.Drawing.Point(12, 374);
            this.btnPuntuaciones.Margin = new System.Windows.Forms.Padding(4);
            this.btnPuntuaciones.Name = "btnPuntuaciones";
            this.btnPuntuaciones.Size = new System.Drawing.Size(207, 39);
            this.btnPuntuaciones.TabIndex = 10;
            this.btnPuntuaciones.Text = "PUNTUACIONES";
            this.btnPuntuaciones.UseVisualStyleBackColor = false;
            this.btnPuntuaciones.Visible = false;
            this.btnPuntuaciones.Click += new System.EventHandler(this.btnPuntuaciones_Click);
            // 
            // frmFinDeJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ADCN.Properties.Resources.fin_de_juego2;
            this.ClientSize = new System.Drawing.Size(452, 476);
            this.Controls.Add(this.btnPuntuaciones);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerVideo);
            this.Controls.Add(this.btnVolverAJugar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pbxTrophy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFinDeJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFinDeJuego";
            this.Load += new System.EventHandler(this.frmFinDeJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTrophy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnVolverAJugar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox pbxTrophy;
        private System.Windows.Forms.Timer delay;
        public System.Windows.Forms.Button btnVerVideo;
        public System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblEncabezado;
        public System.Windows.Forms.Button btnPuntuaciones;
    }
}
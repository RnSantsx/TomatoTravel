namespace TomatoTravel
{
    partial class TomatoTravel
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
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.imagemlugar = new System.Windows.Forms.PictureBox();
            this.btanterior = new System.Windows.Forms.Button();
            this.btproximo = new System.Windows.Forms.Button();
            this.btnAvaliar = new System.Windows.Forms.Button();
            this.cbnota = new System.Windows.Forms.ComboBox();
            this.desclabel = new System.Windows.Forms.Label();
            this.nomelugarlbl = new System.Windows.Forms.Label();
            this.lbnota = new System.Windows.Forms.Label();
            this.entraradd = new System.Windows.Forms.Button();
            this.lblnotamsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagemlugar)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList4
            // 
            this.imageList4.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList4.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imagemlugar
            // 
            this.imagemlugar.BackColor = System.Drawing.Color.Black;
            this.imagemlugar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagemlugar.Location = new System.Drawing.Point(269, 129);
            this.imagemlugar.Name = "imagemlugar";
            this.imagemlugar.Size = new System.Drawing.Size(220, 153);
            this.imagemlugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagemlugar.TabIndex = 0;
            this.imagemlugar.TabStop = false;
            this.imagemlugar.Click += new System.EventHandler(this.imagemlugar_Click);
            // 
            // btanterior
            // 
            this.btanterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btanterior.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btanterior.Location = new System.Drawing.Point(12, 192);
            this.btanterior.Name = "btanterior";
            this.btanterior.Size = new System.Drawing.Size(61, 59);
            this.btanterior.TabIndex = 5;
            this.btanterior.Text = "<<";
            this.btanterior.UseVisualStyleBackColor = false;
            this.btanterior.Click += new System.EventHandler(this.btanterior_Click);
            // 
            // btproximo
            // 
            this.btproximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btproximo.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btproximo.Location = new System.Drawing.Point(727, 192);
            this.btproximo.Name = "btproximo";
            this.btproximo.Size = new System.Drawing.Size(61, 59);
            this.btproximo.TabIndex = 5;
            this.btproximo.Text = ">>";
            this.btproximo.UseVisualStyleBackColor = false;
            this.btproximo.Click += new System.EventHandler(this.btproximo_Click);
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.BackColor = System.Drawing.Color.Firebrick;
            this.btnAvaliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvaliar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaliar.ForeColor = System.Drawing.Color.White;
            this.btnAvaliar.Location = new System.Drawing.Point(594, 391);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(80, 30);
            this.btnAvaliar.TabIndex = 8;
            this.btnAvaliar.Text = "Avaliar";
            this.btnAvaliar.UseVisualStyleBackColor = false;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
            // 
            // cbnota
            // 
            this.cbnota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnota.FormattingEnabled = true;
            this.cbnota.Location = new System.Drawing.Point(539, 391);
            this.cbnota.Name = "cbnota";
            this.cbnota.Size = new System.Drawing.Size(50, 23);
            this.cbnota.TabIndex = 7;
            this.cbnota.SelectedIndexChanged += new System.EventHandler(this.cbnota_SelectedIndexChanged);
            // 
            // desclabel
            // 
            this.desclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.desclabel.Location = new System.Drawing.Point(264, 305);
            this.desclabel.Name = "desclabel";
            this.desclabel.Size = new System.Drawing.Size(238, 94);
            this.desclabel.TabIndex = 9;
            this.desclabel.Click += new System.EventHandler(this.desclabel_Click);
            // 
            // nomelugarlbl
            // 
            this.nomelugarlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomelugarlbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nomelugarlbl.Location = new System.Drawing.Point(206, 67);
            this.nomelugarlbl.Name = "nomelugarlbl";
            this.nomelugarlbl.Size = new System.Drawing.Size(331, 39);
            this.nomelugarlbl.TabIndex = 10;
            this.nomelugarlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnota
            // 
            this.lbnota.AutoSize = true;
            this.lbnota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbnota.Location = new System.Drawing.Point(536, 372);
            this.lbnota.Name = "lbnota";
            this.lbnota.Size = new System.Drawing.Size(0, 16);
            this.lbnota.TabIndex = 11;
            // 
            // entraradd
            // 
            this.entraradd.BackColor = System.Drawing.Color.Firebrick;
            this.entraradd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entraradd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entraradd.ForeColor = System.Drawing.Color.White;
            this.entraradd.Location = new System.Drawing.Point(681, 391);
            this.entraradd.Name = "entraradd";
            this.entraradd.Size = new System.Drawing.Size(107, 30);
            this.entraradd.TabIndex = 12;
            this.entraradd.Text = "Adicionar Lugar";
            this.entraradd.UseVisualStyleBackColor = false;
            this.entraradd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblnotamsg
            // 
            this.lblnotamsg.AutoSize = true;
            this.lblnotamsg.Location = new System.Drawing.Point(541, 428);
            this.lblnotamsg.Name = "lblnotamsg";
            this.lblnotamsg.Size = new System.Drawing.Size(0, 13);
            this.lblnotamsg.TabIndex = 13;
            // 
            // TomatoTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnotamsg);
            this.Controls.Add(this.entraradd);
            this.Controls.Add(this.lbnota);
            this.Controls.Add(this.nomelugarlbl);
            this.Controls.Add(this.desclabel);
            this.Controls.Add(this.cbnota);
            this.Controls.Add(this.btnAvaliar);
            this.Controls.Add(this.btproximo);
            this.Controls.Add(this.btanterior);
            this.Controls.Add(this.imagemlugar);
            this.Name = "TomatoTravel";
            this.Text = "TomatoTravel";
            this.Load += new System.EventHandler(this.TomatoTravel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagemlugar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList4;
        private System.Windows.Forms.PictureBox imagemlugar;
        private System.Windows.Forms.Button btanterior;
        private System.Windows.Forms.Button btproximo;
        private System.Windows.Forms.Button btnAvaliar;
        private System.Windows.Forms.ComboBox cbnota;
        private System.Windows.Forms.Label desclabel;
        private System.Windows.Forms.Label nomelugarlbl;
        private System.Windows.Forms.Label lbnota;
        private System.Windows.Forms.Button entraradd;
        private System.Windows.Forms.Label lblnotamsg;
    }
}
namespace TomatoTravel.formularios
{
    partial class addTT
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
            this.txtnomlugar = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lblinserir = new System.Windows.Forms.Label();
            this.lxlsubt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addlugar = new System.Windows.Forms.Button();
            this.lbladdlugar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnomlugar
            // 
            this.txtnomlugar.Location = new System.Drawing.Point(219, 162);
            this.txtnomlugar.Multiline = true;
            this.txtnomlugar.Name = "txtnomlugar";
            this.txtnomlugar.Size = new System.Drawing.Size(314, 30);
            this.txtnomlugar.TabIndex = 1;
            this.txtnomlugar.TextChanged += new System.EventHandler(this.txtnomlugar_TextChanged);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(219, 201);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(314, 30);
            this.txtdescricao.TabIndex = 2;
            // 
            // lblinserir
            // 
            this.lblinserir.Font = new System.Drawing.Font("Sans Serif Collection", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinserir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblinserir.Location = new System.Drawing.Point(50, 9);
            this.lblinserir.Name = "lblinserir";
            this.lblinserir.Size = new System.Drawing.Size(303, 104);
            this.lblinserir.TabIndex = 3;
            this.lblinserir.Text = "Insira o lugar";
            // 
            // lxlsubt
            // 
            this.lxlsubt.AutoSize = true;
            this.lxlsubt.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lxlsubt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lxlsubt.Location = new System.Drawing.Point(68, 95);
            this.lxlsubt.Name = "lxlsubt";
            this.lxlsubt.Size = new System.Drawing.Size(214, 18);
            this.lxlsubt.TabIndex = 4;
            this.lxlsubt.Text = "Insira os dados do lugar!";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(69, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do Lugar:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(110, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrição:";
            // 
            // addlugar
            // 
            this.addlugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addlugar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlugar.ForeColor = System.Drawing.Color.White;
            this.addlugar.Location = new System.Drawing.Point(219, 274);
            this.addlugar.Name = "addlugar";
            this.addlugar.Size = new System.Drawing.Size(177, 37);
            this.addlugar.TabIndex = 7;
            this.addlugar.Text = "Adicionar lugar";
            this.addlugar.UseVisualStyleBackColor = true;
            this.addlugar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbladdlugar
            // 
            this.lbladdlugar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdlugar.Location = new System.Drawing.Point(219, 246);
            this.lbladdlugar.Name = "lbladdlugar";
            this.lbladdlugar.Size = new System.Drawing.Size(390, 23);
            this.lbladdlugar.TabIndex = 8;
            // 
            // addTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbladdlugar);
            this.Controls.Add(this.addlugar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lxlsubt);
            this.Controls.Add(this.lblinserir);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtnomlugar);
            this.Name = "addTT";
            this.Text = "addTT";
            this.Load += new System.EventHandler(this.addTT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnomlugar;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label lblinserir;
        private System.Windows.Forms.Label lxlsubt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addlugar;
        private System.Windows.Forms.Label lbladdlugar;
    }
}
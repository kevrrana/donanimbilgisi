namespace donanımbilgisi
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTümParçalar = new System.Windows.Forms.ListBox();
            this.lstDisDonanim = new System.Windows.Forms.ListBox();
            this.lstİcDonanim = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tüm Parçalar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(169, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dış Donanım";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(313, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "İç Donanım";
            // 
            // lstTümParçalar
            // 
            this.lstTümParçalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTümParçalar.FormattingEnabled = true;
            this.lstTümParçalar.ItemHeight = 16;
            this.lstTümParçalar.Items.AddRange(new object[] {
            "ram",
            "hoparlör",
            "anakart",
            "ekran kartı",
            "monitör",
            "CPU",
            "mikrofon",
            "hardisk",
            "klavye"});
            this.lstTümParçalar.Location = new System.Drawing.Point(36, 105);
            this.lstTümParçalar.Name = "lstTümParçalar";
            this.lstTümParçalar.Size = new System.Drawing.Size(94, 180);
            this.lstTümParçalar.TabIndex = 3;
            // 
            // lstDisDonanim
            // 
            this.lstDisDonanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstDisDonanim.FormattingEnabled = true;
            this.lstDisDonanim.ItemHeight = 16;
            this.lstDisDonanim.Location = new System.Drawing.Point(172, 105);
            this.lstDisDonanim.Name = "lstDisDonanim";
            this.lstDisDonanim.Size = new System.Drawing.Size(94, 180);
            this.lstDisDonanim.TabIndex = 4;
            // 
            // lstİcDonanim
            // 
            this.lstİcDonanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstİcDonanim.FormattingEnabled = true;
            this.lstİcDonanim.ItemHeight = 16;
            this.lstİcDonanim.Location = new System.Drawing.Point(316, 105);
            this.lstİcDonanim.Name = "lstİcDonanim";
            this.lstİcDonanim.Size = new System.Drawing.Size(94, 180);
            this.lstİcDonanim.TabIndex = 5;
            // 
            // btnAktar
            // 
            this.btnAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktar.Location = new System.Drawing.Point(13, 327);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(117, 42);
            this.btnAktar.TabIndex = 6;
            this.btnAktar.Text = "AKTAR";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lstİcDonanim);
            this.Controls.Add(this.lstDisDonanim);
            this.Controls.Add(this.lstTümParçalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTümParçalar;
        private System.Windows.Forms.ListBox lstDisDonanim;
        private System.Windows.Forms.ListBox lstİcDonanim;
        private System.Windows.Forms.Button btnAktar;
    }
}


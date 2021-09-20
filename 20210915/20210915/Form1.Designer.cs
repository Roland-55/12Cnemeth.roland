namespace _20210915
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
            this.btnosszead = new System.Windows.Forms.Button();
            this.btnkivon = new System.Windows.Forms.Button();
            this.btnszorzas = new System.Windows.Forms.Button();
            this.lbladd1 = new System.Windows.Forms.Label();
            this.lbladd2 = new System.Windows.Forms.Label();
            this.lbleredmeny = new System.Windows.Forms.Label();
            this.lblmuvelet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnosszead
            // 
            this.btnosszead.Location = new System.Drawing.Point(102, 244);
            this.btnosszead.Name = "btnosszead";
            this.btnosszead.Size = new System.Drawing.Size(75, 23);
            this.btnosszead.TabIndex = 0;
            this.btnosszead.Text = "Összeadás";
            this.btnosszead.UseVisualStyleBackColor = true;
            // 
            // btnkivon
            // 
            this.btnkivon.Location = new System.Drawing.Point(102, 304);
            this.btnkivon.Name = "btnkivon";
            this.btnkivon.Size = new System.Drawing.Size(75, 23);
            this.btnkivon.TabIndex = 1;
            this.btnkivon.Text = "Kivonás ";
            this.btnkivon.UseVisualStyleBackColor = true;
            // 
            // btnszorzas
            // 
            this.btnszorzas.Location = new System.Drawing.Point(102, 366);
            this.btnszorzas.Name = "btnszorzas";
            this.btnszorzas.Size = new System.Drawing.Size(75, 23);
            this.btnszorzas.TabIndex = 2;
            this.btnszorzas.Text = "Szórzás ";
            this.btnszorzas.UseVisualStyleBackColor = true;
            // 
            // lbladd1
            // 
            this.lbladd1.AutoSize = true;
            this.lbladd1.Location = new System.Drawing.Point(99, 49);
            this.lbladd1.Name = "lbladd1";
            this.lbladd1.Size = new System.Drawing.Size(32, 13);
            this.lbladd1.TabIndex = 3;
            this.lbladd1.Text = "Add1";
            // 
            // lbladd2
            // 
            this.lbladd2.AutoSize = true;
            this.lbladd2.Location = new System.Drawing.Point(99, 86);
            this.lbladd2.Name = "lbladd2";
            this.lbladd2.Size = new System.Drawing.Size(32, 13);
            this.lbladd2.TabIndex = 4;
            this.lbladd2.Text = "Add2";
            // 
            // lbleredmeny
            // 
            this.lbleredmeny.AutoSize = true;
            this.lbleredmeny.Location = new System.Drawing.Point(348, 314);
            this.lbleredmeny.Name = "lbleredmeny";
            this.lbleredmeny.Size = new System.Drawing.Size(57, 13);
            this.lbleredmeny.TabIndex = 5;
            this.lbleredmeny.Text = "Eredmény ";
            // 
            // lblmuvelet
            // 
            this.lblmuvelet.AutoSize = true;
            this.lblmuvelet.Location = new System.Drawing.Point(478, 253);
            this.lblmuvelet.Name = "lblmuvelet";
            this.lblmuvelet.Size = new System.Drawing.Size(98, 13);
            this.lblmuvelet.TabIndex = 6;
            this.lblmuvelet.Text = "Művelet összeadás";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmuvelet);
            this.Controls.Add(this.lbleredmeny);
            this.Controls.Add(this.lbladd2);
            this.Controls.Add(this.lbladd1);
            this.Controls.Add(this.btnszorzas);
            this.Controls.Add(this.btnkivon);
            this.Controls.Add(this.btnosszead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnosszead;
        private System.Windows.Forms.Button btnkivon;
        private System.Windows.Forms.Button btnszorzas;
        private System.Windows.Forms.Label lbladd1;
        private System.Windows.Forms.Label lbladd2;
        private System.Windows.Forms.Label lbleredmeny;
        private System.Windows.Forms.Label lblmuvelet;
    }
}


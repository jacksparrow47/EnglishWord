namespace EnglishTerms
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
            this.txtDetail = new System.Windows.Forms.RichTextBox();
            this.lblword = new System.Windows.Forms.Label();
            this.btncevap = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnpre = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtanswear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtsentence = new System.Windows.Forms.RichTextBox();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.pnlEkle = new System.Windows.Forms.Panel();
            this.btnlist = new System.Windows.Forms.Button();
            this.pnlEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(4, 12);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(657, 200);
            this.txtDetail.TabIndex = 0;
            this.txtDetail.Text = "";
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblword.Location = new System.Drawing.Point(23, 228);
            this.lblword.Name = "lblword";
            this.lblword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblword.Size = new System.Drawing.Size(0, 17);
            this.lblword.TabIndex = 1;
            // 
            // btncevap
            // 
            this.btncevap.Location = new System.Drawing.Point(297, 218);
            this.btncevap.Name = "btncevap";
            this.btncevap.Size = new System.Drawing.Size(100, 36);
            this.btncevap.TabIndex = 2;
            this.btncevap.Text = "Cevabını Göster";
            this.btncevap.UseVisualStyleBackColor = true;
            this.btncevap.Click += new System.EventHandler(this.btncevap_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(422, 218);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(100, 36);
            this.btnnext.TabIndex = 3;
            this.btnnext.Text = "Sonraki";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnpre
            // 
            this.btnpre.Location = new System.Drawing.Point(556, 218);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(100, 36);
            this.btnpre.TabIndex = 4;
            this.btnpre.Text = "Önceki";
            this.btnpre.UseVisualStyleBackColor = true;
            this.btnpre.Click += new System.EventHandler(this.btnpre_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(4, 232);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(13, 13);
            this.lblid.TabIndex = 5;
            this.lblid.Text = "0";
            this.lblid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kelime";
            // 
            // txtword
            // 
            this.txtword.Location = new System.Drawing.Point(101, 7);
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(534, 20);
            this.txtword.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Anlamı";
            // 
            // txtanswear
            // 
            this.txtanswear.Location = new System.Drawing.Point(101, 41);
            this.txtanswear.Name = "txtanswear";
            this.txtanswear.Size = new System.Drawing.Size(534, 20);
            this.txtanswear.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "cümle";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(101, 141);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 36);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Ekle";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtsentence
            // 
            this.txtsentence.Location = new System.Drawing.Point(101, 67);
            this.txtsentence.Name = "txtsentence";
            this.txtsentence.Size = new System.Drawing.Size(534, 68);
            this.txtsentence.TabIndex = 13;
            this.txtsentence.Text = "";
            // 
            // btnShowHide
            // 
            this.btnShowHide.Location = new System.Drawing.Point(297, 260);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(100, 36);
            this.btnShowHide.TabIndex = 14;
            this.btnShowHide.Text = "Kelime Ekle Göster";
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // pnlEkle
            // 
            this.pnlEkle.Controls.Add(this.label1);
            this.pnlEkle.Controls.Add(this.txtword);
            this.pnlEkle.Controls.Add(this.txtsentence);
            this.pnlEkle.Controls.Add(this.label2);
            this.pnlEkle.Controls.Add(this.btnadd);
            this.pnlEkle.Controls.Add(this.txtanswear);
            this.pnlEkle.Controls.Add(this.label3);
            this.pnlEkle.Location = new System.Drawing.Point(12, 314);
            this.pnlEkle.Name = "pnlEkle";
            this.pnlEkle.Size = new System.Drawing.Size(638, 193);
            this.pnlEkle.TabIndex = 15;
            this.pnlEkle.Visible = false;
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(422, 260);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(100, 36);
            this.btnlist.TabIndex = 16;
            this.btnlist.Text = "Kelime Listesi Göster";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 519);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.pnlEkle);
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnpre);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btncevap);
            this.Controls.Add(this.lblword);
            this.Controls.Add(this.txtDetail);
            this.Name = "Form1";
            this.Text = "Word";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlEkle.ResumeLayout(false);
            this.pnlEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtDetail;
        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.Button btncevap;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtanswear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.RichTextBox txtsentence;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Panel pnlEkle;
        private System.Windows.Forms.Button btnlist;
    }
}


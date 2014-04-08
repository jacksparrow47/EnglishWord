namespace EnglishTerms
{
    partial class WordListForm
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
            this.grdWordList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.WordEng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sentences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.WordId = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdWordList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdWordList
            // 
            this.grdWordList.AllowUserToDeleteRows = false;
            this.grdWordList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdWordList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdWordList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdWordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdWordList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WordEng,
            this.WordTur,
            this.Sentences,
            this.Save,
            this.Delete,
            this.WordId});
            this.grdWordList.Location = new System.Drawing.Point(12, 76);
            this.grdWordList.Name = "grdWordList";
            this.grdWordList.Size = new System.Drawing.Size(727, 426);
            this.grdWordList.TabIndex = 0;
            this.grdWordList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdWordList_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word List";
            // 
            // WordEng
            // 
            this.WordEng.DataPropertyName = "WordEng";
            this.WordEng.HeaderText = "Word English";
            this.WordEng.Name = "WordEng";
            // 
            // WordTur
            // 
            this.WordTur.DataPropertyName = "WordTur";
            this.WordTur.HeaderText = "Word Turkish";
            this.WordTur.Name = "WordTur";
            // 
            // Sentences
            // 
            this.Sentences.DataPropertyName = "Sentences";
            this.Sentences.HeaderText = "Word Sentences";
            this.Sentences.Name = "Sentences";
            // 
            // Save
            // 
            this.Save.DataPropertyName = "Save";
            this.Save.HeaderText = "Save";
            this.Save.Name = "Save";
            this.Save.Text = "";
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "";
            // 
            // WordId
            // 
            this.WordId.DataPropertyName = "WordId";
            this.WordId.HeaderText = "WordId";
            this.WordId.Name = "WordId";
            this.WordId.Visible = false;
            // 
            // WordListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdWordList);
            this.Name = "WordListForm";
            this.Text = "Words List";
            this.Load += new System.EventHandler(this.Words_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdWordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdWordList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordEng;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sentences;
        private System.Windows.Forms.DataGridViewButtonColumn Save;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn WordId;
    }
}
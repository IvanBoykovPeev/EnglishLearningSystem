namespace WindowsFormsEnglishLearningSystem
{
    partial class AdminForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.database1DataSet = new WindowsFormsEnglishLearningSystem.Database1DataSet();
            this.wordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordsTableAdapter = new WindowsFormsEnglishLearningSystem.Database1DataSetTableAdapters.WordsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordInEnglishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordInBulgarianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.synonymDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.wordInEnglishDataGridViewTextBoxColumn,
            this.wordInBulgarianDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.synonymDataGridViewTextBoxColumn,
            this.levelsIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.wordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wordsBindingSource
            // 
            this.wordsBindingSource.DataMember = "Words";
            this.wordsBindingSource.DataSource = this.database1DataSet;
            // 
            // wordsTableAdapter
            // 
            this.wordsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wordInEnglishDataGridViewTextBoxColumn
            // 
            this.wordInEnglishDataGridViewTextBoxColumn.DataPropertyName = "WordInEnglish";
            this.wordInEnglishDataGridViewTextBoxColumn.HeaderText = "WordInEnglish";
            this.wordInEnglishDataGridViewTextBoxColumn.Name = "wordInEnglishDataGridViewTextBoxColumn";
            // 
            // wordInBulgarianDataGridViewTextBoxColumn
            // 
            this.wordInBulgarianDataGridViewTextBoxColumn.DataPropertyName = "WordInBulgarian";
            this.wordInBulgarianDataGridViewTextBoxColumn.HeaderText = "WordInBulgarian";
            this.wordInBulgarianDataGridViewTextBoxColumn.Name = "wordInBulgarianDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // synonymDataGridViewTextBoxColumn
            // 
            this.synonymDataGridViewTextBoxColumn.DataPropertyName = "Synonym";
            this.synonymDataGridViewTextBoxColumn.HeaderText = "Synonym";
            this.synonymDataGridViewTextBoxColumn.Name = "synonymDataGridViewTextBoxColumn";
            // 
            // levelsIdDataGridViewTextBoxColumn
            // 
            this.levelsIdDataGridViewTextBoxColumn.DataPropertyName = "LevelsId";
            this.levelsIdDataGridViewTextBoxColumn.HeaderText = "LevelsId";
            this.levelsIdDataGridViewTextBoxColumn.Name = "levelsIdDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 410);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource wordsBindingSource;
        private Database1DataSetTableAdapters.WordsTableAdapter wordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordInEnglishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordInBulgarianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn synonymDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
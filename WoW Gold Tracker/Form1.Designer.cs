namespace WoW_Gold_Tracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBroswer = new FolderBrowserDialog();
            txt_path = new TextBox();
            button_fetch = new Button();
            dataGridView1 = new DataGridView();
            col_index = new DataGridViewTextBoxColumn();
            col_char = new DataGridViewTextBoxColumn();
            col_realm = new DataGridViewTextBoxColumn();
            col_gold = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txt_path
            // 
            txt_path.Location = new Point(12, 12);
            txt_path.Name = "txt_path";
            txt_path.Size = new Size(293, 23);
            txt_path.TabIndex = 0;
            txt_path.Text = "Click here to select your WoW folder. ";
            txt_path.Click += textBox1_Click;
            // 
            // button_fetch
            // 
            button_fetch.Location = new Point(311, 10);
            button_fetch.Name = "button_fetch";
            button_fetch.Size = new Size(89, 25);
            button_fetch.TabIndex = 1;
            button_fetch.Text = "Fetch";
            button_fetch.UseVisualStyleBackColor = true;
            button_fetch.Click += button_fetch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_index, col_char, col_realm, col_gold });
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(388, 217);
            dataGridView1.TabIndex = 2;
            // 
            // col_index
            // 
            col_index.HeaderText = "Index";
            col_index.Name = "col_index";
            col_index.Width = 45;
            // 
            // col_char
            // 
            col_char.HeaderText = "Character";
            col_char.Name = "col_char";
            // 
            // col_realm
            // 
            col_realm.HeaderText = "Realm";
            col_realm.Name = "col_realm";
            // 
            // col_gold
            // 
            col_gold.HeaderText = "Gold";
            col_gold.Name = "col_gold";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 267);
            Controls.Add(dataGridView1);
            Controls.Add(button_fetch);
            Controls.Add(txt_path);
            Name = "Form1";
            Text = "Gold Tracker Client";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBroswer;
        private TextBox txt_path;
        private Button button_fetch;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn col_index;
        private DataGridViewTextBoxColumn col_char;
        private DataGridViewTextBoxColumn col_realm;
        private DataGridViewTextBoxColumn col_gold;
    }
}
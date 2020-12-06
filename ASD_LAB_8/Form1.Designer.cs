namespace ASD_LAB_8
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.generatedOut = new System.Windows.Forms.RichTextBox();
            this.generate = new System.Windows.Forms.Button();
            this.lin = new System.Windows.Forms.RadioButton();
            this.rand = new System.Windows.Forms.RadioButton();
            this.size = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.valTable = new System.Windows.Forms.Label();
            this.tableSart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.result = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(406, 201);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.generatedOut);
            this.tabPage2.Controls.Add(this.generate);
            this.tabPage2.Controls.Add(this.lin);
            this.tabPage2.Controls.Add(this.rand);
            this.tabPage2.Controls.Add(this.size);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(398, 175);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GENERATE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // generatedOut
            // 
            this.generatedOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.generatedOut.Location = new System.Drawing.Point(61, 103);
            this.generatedOut.Name = "generatedOut";
            this.generatedOut.Size = new System.Drawing.Size(250, 56);
            this.generatedOut.TabIndex = 14;
            this.generatedOut.Text = "";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(236, 20);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 62);
            this.generate.TabIndex = 13;
            this.generate.Text = "GENERATE";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // lin
            // 
            this.lin.AutoSize = true;
            this.lin.Location = new System.Drawing.Point(144, 65);
            this.lin.Name = "lin";
            this.lin.Size = new System.Drawing.Size(64, 17);
            this.lin.TabIndex = 12;
            this.lin.TabStop = true;
            this.lin.Text = "LINEAR";
            this.lin.UseVisualStyleBackColor = true;
            // 
            // rand
            // 
            this.rand.AutoSize = true;
            this.rand.Location = new System.Drawing.Point(61, 65);
            this.rand.Name = "rand";
            this.rand.Size = new System.Drawing.Size(73, 17);
            this.rand.TabIndex = 11;
            this.rand.TabStop = true;
            this.rand.Text = "RANDOM";
            this.rand.UseVisualStyleBackColor = true;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(144, 24);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(64, 20);
            this.size.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ARRAY SIZE : ";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.valTable);
            this.tabPage1.Controls.Add(this.tableSart);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(398, 175);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TABLE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 20);
            this.textBox1.TabIndex = 6;
            // 
            // valTable
            // 
            this.valTable.AutoSize = true;
            this.valTable.Location = new System.Drawing.Point(26, 132);
            this.valTable.Name = "valTable";
            this.valTable.Size = new System.Drawing.Size(107, 13);
            this.valTable.TabIndex = 5;
            this.valTable.Text = "SEEK FOR VALUE : ";
            // 
            // tableSart
            // 
            this.tableSart.Location = new System.Drawing.Point(284, 129);
            this.tableSart.Name = "tableSart";
            this.tableSart.Size = new System.Drawing.Size(88, 22);
            this.tableSart.TabIndex = 4;
            this.tableSart.Text = "START";
            this.tableSart.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "COMPARED : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RESULT : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AMMOUNT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(150, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(222, 69);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "10";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "20";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "200";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "2000";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "20000";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.result);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.log);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(398, 175);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TASK";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(265, 40);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 20);
            this.result.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "RESULT : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "START TASK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "LOG : ";
            // 
            // log
            // 
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.Location = new System.Drawing.Point(54, 102);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(286, 67);
            this.log.TabIndex = 0;
            this.log.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 207);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label valTable;
        private System.Windows.Forms.Button tableSart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.RichTextBox generatedOut;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.RadioButton lin;
        private System.Windows.Forms.RadioButton rand;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox log;
    }
}


namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelSektorowAwarii = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.btnDebug = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolejkaDataSet = new WindowsFormsApplication1.kolejkaDataSet();
            this.eventsTableAdapter = new WindowsFormsApplication1.kolejkaDataSetTableAdapters.EventsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTestAddData = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolejkaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1;
            this.panel2.Location = new System.Drawing.Point(928, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 104);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(1041, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 104);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(1147, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(107, 104);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(801, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Aktualny czas przejazdu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(801, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Najwolniejszy przejazd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(801, 669);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Najszybszy przejazd";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(802, 552);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(804, 712);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(970, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ostatnie awarie ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(957, 576);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 147);
            this.listBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(1163, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Liczba awarii w sektorach ";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(1209, 585);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 147);
            this.listBox2.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1;
            this.panel6.Location = new System.Drawing.Point(1260, 229);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 104);
            this.panel6.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.Location = new System.Drawing.Point(1167, 328);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 104);
            this.panel7.TabIndex = 18;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.Location = new System.Drawing.Point(1048, 328);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 104);
            this.panel8.TabIndex = 18;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.Location = new System.Drawing.Point(928, 328);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(100, 104);
            this.panel9.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(392, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(706, 55);
            this.label6.TabIndex = 20;
            this.label6.Text = "ANDRZEJKOWA KOLEJKA xD \r\n";
            // 
            // panelSektorowAwarii
            // 
            this.panelSektorowAwarii.FormattingEnabled = true;
            this.panelSektorowAwarii.Location = new System.Drawing.Point(19, 229);
            this.panelSektorowAwarii.Name = "panelSektorowAwarii";
            this.panelSektorowAwarii.Size = new System.Drawing.Size(223, 199);
            this.panelSektorowAwarii.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(53, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Potwierdzanie awarii";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(65, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(351, 46);
            this.label8.TabIndex = 29;
            this.label8.Text = "Panel użytkownika";
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(452, 234);
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(112, 20);
            this.txtDebug.TabIndex = 30;
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(599, 721);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 23);
            this.btnDebug.TabIndex = 31;
            this.btnDebug.Text = "button5";
            this.btnDebug.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(951, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 36);
            this.label9.TabIndex = 32;
            this.label9.Text = "Baza danych";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(298, 593);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 51);
            this.button4.TabIndex = 34;
            this.button4.Text = "ON";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(32, 547);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 33);
            this.label10.TabIndex = 35;
            this.label10.Text = "Ustaw prędkość ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(269, 547);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 33);
            this.label11.TabIndex = 36;
            this.label11.Text = "Tryb automatyczny";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 51);
            this.button1.TabIndex = 37;
            this.button1.Text = "OFF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(105, 593);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 51);
            this.button5.TabIndex = 38;
            this.button5.Text = "S0";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(105, 649);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 51);
            this.button6.TabIndex = 39;
            this.button6.Text = "S1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(105, 707);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 51);
            this.button7.TabIndex = 40;
            this.button7.Text = "S2";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.kolejkaDataSet;
            // 
            // kolejkaDataSet
            // 
            this.kolejkaDataSet.DataSetName = "kolejkaDataSet";
            this.kolejkaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1;
            this.panel1.Location = new System.Drawing.Point(822, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnTestAddData
            // 
            this.btnTestAddData.Location = new System.Drawing.Point(472, 205);
            this.btnTestAddData.Name = "btnTestAddData";
            this.btnTestAddData.Size = new System.Drawing.Size(75, 23);
            this.btnTestAddData.TabIndex = 47;
            this.btnTestAddData.Text = "btnTestAddData";
            this.btnTestAddData.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1;
            this.panel5.Location = new System.Drawing.Point(1260, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 104);
            this.panel5.TabIndex = 48;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1;
            this.panel10.Location = new System.Drawing.Point(802, 270);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(100, 100);
            this.panel10.TabIndex = 49;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1433, 793);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnTestAddData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelSektorowAwarii);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolejkaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox panelSektorowAwarii;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private kolejkaDataSet kolejkaDataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private kolejkaDataSetTableAdapters.EventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.Button btnTestAddData;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
    }
}


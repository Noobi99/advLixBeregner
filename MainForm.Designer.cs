namespace advLixBeregner
{
    partial class MainForm
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
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.ofdPDF = new System.Windows.Forms.OpenFileDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtLix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.dtpScheTime = new System.Windows.Forms.DateTimePicker();
            this.lblAddSche = new System.Windows.Forms.LinkLabel();
            this.dtpScheDate = new System.Windows.Forms.DateTimePicker();
            this.lstSche = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTidsplan = new System.Windows.Forms.Label();
            this.pnlSchedule = new System.Windows.Forms.Panel();
            this.lblNextSche = new System.Windows.Forms.LinkLabel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblLix = new System.Windows.Forms.Label();
            this.lblViewTable = new System.Windows.Forms.LinkLabel();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlSchedule.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(20, 12);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(669, 299);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = "Indsæt bogens tekst her vha. CTRL+C og CTRL+V.\n\nEller upload en filtype der enten" +
    " er .PDF eller .txt, ved brug af Upload bog-knappen";
            // 
            // ofdPDF
            // 
            this.ofdPDF.FileName = "ofdPDF";
            this.ofdPDF.Tag = "PDF";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage3.Controls.Add(this.txtLix);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtTitel);
            this.tabPage3.Controls.Add(this.dtpScheTime);
            this.tabPage3.Controls.Add(this.lblAddSche);
            this.tabPage3.Controls.Add(this.dtpScheDate);
            this.tabPage3.Controls.Add(this.lstSche);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(665, 124);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tidsplan";
            // 
            // txtLix
            // 
            this.txtLix.Location = new System.Drawing.Point(151, 20);
            this.txtLix.Name = "txtLix";
            this.txtLix.Size = new System.Drawing.Size(37, 20);
            this.txtLix.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "LIX-tal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bogens titel";
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(8, 20);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(127, 20);
            this.txtTitel.TabIndex = 5;
            // 
            // dtpScheTime
            // 
            this.dtpScheTime.Checked = false;
            this.dtpScheTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpScheTime.Location = new System.Drawing.Point(162, 59);
            this.dtpScheTime.Name = "dtpScheTime";
            this.dtpScheTime.Size = new System.Drawing.Size(71, 20);
            this.dtpScheTime.TabIndex = 4;
            // 
            // lblAddSche
            // 
            this.lblAddSche.AutoSize = true;
            this.lblAddSche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSche.Location = new System.Drawing.Point(124, 96);
            this.lblAddSche.Name = "lblAddSche";
            this.lblAddSche.Size = new System.Drawing.Size(112, 18);
            this.lblAddSche.TabIndex = 3;
            this.lblAddSche.TabStop = true;
            this.lblAddSche.Text = "Tilføj til Tidsplan";
            this.lblAddSche.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAddSche_LinkClicked);
            // 
            // dtpScheDate
            // 
            this.dtpScheDate.Checked = false;
            this.dtpScheDate.Location = new System.Drawing.Point(8, 59);
            this.dtpScheDate.Name = "dtpScheDate";
            this.dtpScheDate.Size = new System.Drawing.Size(148, 20);
            this.dtpScheDate.TabIndex = 2;
            // 
            // lstSche
            // 
            this.lstSche.FormattingEnabled = true;
            this.lstSche.Location = new System.Drawing.Point(242, 6);
            this.lstSche.Name = "lstSche";
            this.lstSche.Size = new System.Drawing.Size(417, 108);
            this.lstSche.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 124);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bag beregningen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::advLixBeregner.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(472, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 79);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 65);
            this.label7.TabIndex = 11;
            this.label7.Text = "Lavet af Christoffer Christian Hollensen\r\n\r\nEksamensprojekt - Programmering C\r\n\r\n" +
    "Afleveringsdato: 28-04-2017";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblL);
            this.panel1.Controls.Add(this.lblP);
            this.panel1.Controls.Add(this.lblO);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 96);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ord > 6 karakterer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Punktummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ord";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(3, 43);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(16, 13);
            this.lblL.TabIndex = 3;
            this.lblL.Text = "L:";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(3, 30);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(17, 13);
            this.lblP.TabIndex = 2;
            this.lblP.Text = "P:";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Location = new System.Drawing.Point(3, 17);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(18, 13);
            this.lblO.TabIndex = 1;
            this.lblO.Text = "O:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analyse panel";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage1.Controls.Add(this.lblTidsplan);
            this.tabPage1.Controls.Add(this.pnlSchedule);
            this.tabPage1.Controls.Add(this.btnUpload);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.lblLix);
            this.tabPage1.Controls.Add(this.lblViewTable);
            this.tabPage1.Controls.Add(this.lblPages);
            this.tabPage1.Controls.Add(this.lblLevel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 124);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generel";
            // 
            // lblTidsplan
            // 
            this.lblTidsplan.AutoSize = true;
            this.lblTidsplan.Location = new System.Drawing.Point(314, 2);
            this.lblTidsplan.Name = "lblTidsplan";
            this.lblTidsplan.Size = new System.Drawing.Size(89, 13);
            this.lblTidsplan.TabIndex = 3;
            this.lblTidsplan.Text = "Tidsplan Overblik";
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSchedule.Controls.Add(this.lblNextSche);
            this.pnlSchedule.Controls.Add(this.lblTimer);
            this.pnlSchedule.Location = new System.Drawing.Point(317, 16);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(342, 102);
            this.pnlSchedule.TabIndex = 8;
            // 
            // lblNextSche
            // 
            this.lblNextSche.AutoSize = true;
            this.lblNextSche.Location = new System.Drawing.Point(8, 8);
            this.lblNextSche.Name = "lblNextSche";
            this.lblNextSche.Size = new System.Drawing.Size(82, 13);
            this.lblNextSche.TabIndex = 2;
            this.lblNextSche.TabStop = true;
            this.lblNextSche.Text = "Næste læsning:";
            this.lblNextSche.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNextSche_LinkClicked);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(19, 25);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 13);
            this.lblTimer.TabIndex = 1;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(79, 88);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(99, 30);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload bog";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(184, 88);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(99, 30);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Udregn";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblLix
            // 
            this.lblLix.AutoSize = true;
            this.lblLix.Location = new System.Drawing.Point(20, 18);
            this.lblLix.Name = "lblLix";
            this.lblLix.Size = new System.Drawing.Size(40, 13);
            this.lblLix.TabIndex = 4;
            this.lblLix.Text = "LIX-tal:";
            // 
            // lblViewTable
            // 
            this.lblViewTable.AutoSize = true;
            this.lblViewTable.Location = new System.Drawing.Point(20, 97);
            this.lblViewTable.Name = "lblViewTable";
            this.lblViewTable.Size = new System.Drawing.Size(51, 13);
            this.lblViewTable.TabIndex = 7;
            this.lblViewTable.TabStop = true;
            this.lblViewTable.Text = "Vis Tabel";
            this.lblViewTable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblViewTable_LinkClicked);
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(20, 47);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(34, 13);
            this.lblPages.TabIndex = 5;
            this.lblPages.Text = "Sider:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(20, 32);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(80, 13);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "Sværhedsgrad:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 317);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 150);
            this.tabControl1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 470);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rtbText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "LIX beregner - Christoffer Hollensen";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlSchedule.ResumeLayout(false);
            this.pnlSchedule.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.OpenFileDialog ofdPDF;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlSchedule;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblLix;
        private System.Windows.Forms.LinkLabel lblViewTable;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.LinkLabel lblNextSche;
        private System.Windows.Forms.ListBox lstSche;
        private System.Windows.Forms.DateTimePicker dtpScheDate;
        private System.Windows.Forms.LinkLabel lblAddSche;
        private System.Windows.Forms.DateTimePicker dtpScheTime;
        private System.Windows.Forms.TextBox txtLix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTidsplan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


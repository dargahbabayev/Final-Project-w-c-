namespace Stadium
{
    partial class AddCustomer
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
            this.dtpEndtime = new System.Windows.Forms.DateTimePicker();
            this.dtpStarttime = new System.Windows.Forms.DateTimePicker();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStadium = new System.Windows.Forms.ComboBox();
            this.Stadion = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError2 = new System.Windows.Forms.Label();
            this.lblErrorCustomer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtCustomerNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblErrorTimespan = new System.Windows.Forms.Label();
            this.lblErrorNumber = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpEndtime
            // 
            this.dtpEndtime.CustomFormat = "HH";
            this.dtpEndtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndtime.Location = new System.Drawing.Point(192, 188);
            this.dtpEndtime.Name = "dtpEndtime";
            this.dtpEndtime.Size = new System.Drawing.Size(52, 20);
            this.dtpEndtime.TabIndex = 32;
            // 
            // dtpStarttime
            // 
            this.dtpStarttime.CustomFormat = "HH";
            this.dtpStarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStarttime.Location = new System.Drawing.Point(192, 142);
            this.dtpStarttime.Name = "dtpStarttime";
            this.dtpStarttime.Size = new System.Drawing.Size(52, 20);
            this.dtpStarttime.TabIndex = 31;
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddMatch.Location = new System.Drawing.Point(30, 215);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(129, 32);
            this.btnAddMatch.TabIndex = 30;
            this.btnAddMatch.Text = "İlave et";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(44, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Bitme Saati";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Bashlangich Saati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(44, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Gun";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd.MM.yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(177, 93);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(102, 20);
            this.dtpDate.TabIndex = 26;
            // 
            // cmbStadium
            // 
            this.cmbStadium.FormattingEnabled = true;
            this.cmbStadium.Location = new System.Drawing.Point(177, 54);
            this.cmbStadium.Name = "cmbStadium";
            this.cmbStadium.Size = new System.Drawing.Size(102, 21);
            this.cmbStadium.TabIndex = 25;
            // 
            // Stadion
            // 
            this.Stadion.AutoSize = true;
            this.Stadion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Stadion.Location = new System.Drawing.Point(44, 55);
            this.Stadion.Name = "Stadion";
            this.Stadion.Size = new System.Drawing.Size(72, 20);
            this.Stadion.TabIndex = 24;
            this.Stadion.Text = "Stadyum";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(177, 24);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(102, 21);
            this.cmbCustomer.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mushteri";
            // 
            // lblError2
            // 
            this.lblError2.AutoSize = true;
            this.lblError2.Location = new System.Drawing.Point(54, 271);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(0, 13);
            this.lblError2.TabIndex = 35;
            // 
            // lblErrorCustomer
            // 
            this.lblErrorCustomer.AutoSize = true;
            this.lblErrorCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblErrorCustomer.Location = new System.Drawing.Point(482, 215);
            this.lblErrorCustomer.Name = "lblErrorCustomer";
            this.lblErrorCustomer.Size = new System.Drawing.Size(0, 17);
            this.lblErrorCustomer.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblErrorNumber);
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Controls.Add(this.txtCustomerNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(375, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 336);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mushteri Ekle";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddCustomer.Location = new System.Drawing.Point(123, 240);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(166, 32);
            this.btnAddCustomer.TabIndex = 28;
            this.btnAddCustomer.Text = "İlave et";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click_2);
            // 
            // txtCustomerNumber
            // 
            this.txtCustomerNumber.Location = new System.Drawing.Point(200, 152);
            this.txtCustomerNumber.Name = "txtCustomerNumber";
            this.txtCustomerNumber.Size = new System.Drawing.Size(118, 23);
            this.txtCustomerNumber.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mushteri Numarasi";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(200, 101);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(118, 23);
            this.txtCustomerName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(66, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mushteri Adi";
            // 
            // lblErrorTimespan
            // 
            this.lblErrorTimespan.AutoSize = true;
            this.lblErrorTimespan.Location = new System.Drawing.Point(57, 319);
            this.lblErrorTimespan.Name = "lblErrorTimespan";
            this.lblErrorTimespan.Size = new System.Drawing.Size(0, 13);
            this.lblErrorTimespan.TabIndex = 38;
            // 
            // lblErrorNumber
            // 
            this.lblErrorNumber.AutoSize = true;
            this.lblErrorNumber.Location = new System.Drawing.Point(70, 42);
            this.lblErrorNumber.Name = "lblErrorNumber";
            this.lblErrorNumber.Size = new System.Drawing.Size(0, 17);
            this.lblErrorNumber.TabIndex = 29;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(177, 215);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 32);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Bosh zamani bul";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 334);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblErrorTimespan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblErrorCustomer);
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndtime);
            this.Controls.Add(this.dtpStarttime);
            this.Controls.Add(this.btnAddMatch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbStadium);
            this.Controls.Add(this.Stadion);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCustomer_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpEndtime;
        private System.Windows.Forms.DateTimePicker dtpStarttime;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbStadium;
        private System.Windows.Forms.Label Stadion;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.Label lblErrorCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtCustomerNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblErrorTimespan;
        private System.Windows.Forms.Label lblErrorNumber;
        private System.Windows.Forms.Button btnSearch;
    }
}
namespace Q1ExamSample
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
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.rbRegistrationYr = new System.Windows.Forms.RadioButton();
            this.rbMileage = new System.Windows.Forms.RadioButton();
            this.rbMLS = new System.Windows.Forms.RadioButton();
            this.rbRFA = new System.Windows.Forms.RadioButton();
            this.btnMechanicalReport = new System.Windows.Forms.Button();
            this.btnTotalRFA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.grpSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(2, 2);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.Size = new System.Drawing.Size(694, 377);
            this.dgvVehicles.TabIndex = 0;
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.rbRFA);
            this.grpSort.Controls.Add(this.rbMLS);
            this.grpSort.Controls.Add(this.rbMileage);
            this.grpSort.Controls.Add(this.rbRegistrationYr);
            this.grpSort.Location = new System.Drawing.Point(13, 412);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(240, 191);
            this.grpSort.TabIndex = 1;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "Sort";
            // 
            // rbRegistrationYr
            // 
            this.rbRegistrationYr.AutoSize = true;
            this.rbRegistrationYr.Location = new System.Drawing.Point(16, 30);
            this.rbRegistrationYr.Name = "rbRegistrationYr";
            this.rbRegistrationYr.Size = new System.Drawing.Size(106, 17);
            this.rbRegistrationYr.TabIndex = 0;
            this.rbRegistrationYr.TabStop = true;
            this.rbRegistrationYr.Text = "Registration Year";
            this.rbRegistrationYr.UseVisualStyleBackColor = true;
            this.rbRegistrationYr.CheckedChanged += new System.EventHandler(this.rbRegistrationYr_CheckedChanged);
            // 
            // rbMileage
            // 
            this.rbMileage.AutoSize = true;
            this.rbMileage.Location = new System.Drawing.Point(16, 71);
            this.rbMileage.Name = "rbMileage";
            this.rbMileage.Size = new System.Drawing.Size(62, 17);
            this.rbMileage.TabIndex = 1;
            this.rbMileage.TabStop = true;
            this.rbMileage.Text = "Mileage";
            this.rbMileage.UseVisualStyleBackColor = true;
            this.rbMileage.CheckedChanged += new System.EventHandler(this.rbMileage_CheckedChanged);
            // 
            // rbMLS
            // 
            this.rbMLS.AutoSize = true;
            this.rbMLS.Location = new System.Drawing.Point(16, 112);
            this.rbMLS.Name = "rbMLS";
            this.rbMLS.Size = new System.Drawing.Size(47, 17);
            this.rbMLS.TabIndex = 2;
            this.rbMLS.TabStop = true;
            this.rbMLS.Text = "MLS";
            this.rbMLS.UseVisualStyleBackColor = true;
            // 
            // rbRFA
            // 
            this.rbRFA.AutoSize = true;
            this.rbRFA.Location = new System.Drawing.Point(16, 153);
            this.rbRFA.Name = "rbRFA";
            this.rbRFA.Size = new System.Drawing.Size(46, 17);
            this.rbRFA.TabIndex = 3;
            this.rbRFA.TabStop = true;
            this.rbRFA.Text = "RFA";
            this.rbRFA.UseVisualStyleBackColor = true;
            // 
            // btnMechanicalReport
            // 
            this.btnMechanicalReport.Location = new System.Drawing.Point(356, 442);
            this.btnMechanicalReport.Name = "btnMechanicalReport";
            this.btnMechanicalReport.Size = new System.Drawing.Size(139, 121);
            this.btnMechanicalReport.TabIndex = 2;
            this.btnMechanicalReport.Text = "Mechanical Report";
            this.btnMechanicalReport.UseVisualStyleBackColor = true;
            this.btnMechanicalReport.Click += new System.EventHandler(this.btnMechanicalReport_Click);
            // 
            // btnTotalRFA
            // 
            this.btnTotalRFA.Location = new System.Drawing.Point(526, 442);
            this.btnTotalRFA.Name = "btnTotalRFA";
            this.btnTotalRFA.Size = new System.Drawing.Size(139, 121);
            this.btnTotalRFA.TabIndex = 3;
            this.btnTotalRFA.Text = "Total RFA (2009+)";
            this.btnTotalRFA.UseVisualStyleBackColor = true;
            this.btnTotalRFA.Click += new System.EventHandler(this.btnTotalRFA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 625);
            this.Controls.Add(this.btnTotalRFA);
            this.Controls.Add(this.btnMechanicalReport);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.dgvVehicles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.RadioButton rbRFA;
        private System.Windows.Forms.RadioButton rbMLS;
        private System.Windows.Forms.RadioButton rbMileage;
        private System.Windows.Forms.RadioButton rbRegistrationYr;
        private System.Windows.Forms.Button btnMechanicalReport;
        private System.Windows.Forms.Button btnTotalRFA;
    }
}


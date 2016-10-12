namespace Q1ExamSample
{
    partial class MechanicalReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDiagnosticService = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRTM = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosticService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRTM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicles Requiring Diagnostic Service";
            // 
            // dgvDiagnosticService
            // 
            this.dgvDiagnosticService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosticService.Location = new System.Drawing.Point(4, 18);
            this.dgvDiagnosticService.Name = "dgvDiagnosticService";
            this.dgvDiagnosticService.Size = new System.Drawing.Size(795, 221);
            this.dgvDiagnosticService.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehicles Requiring A Return To Manufacturer";
            // 
            // dgvRTM
            // 
            this.dgvRTM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRTM.Location = new System.Drawing.Point(3, 260);
            this.dgvRTM.Name = "dgvRTM";
            this.dgvRTM.Size = new System.Drawing.Size(795, 221);
            this.dgvRTM.TabIndex = 3;
            // 
            // MechanicalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 751);
            this.Controls.Add(this.dgvRTM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDiagnosticService);
            this.Controls.Add(this.label1);
            this.Name = "MechanicalReport";
            this.Text = "MechanicalReport";
            this.Load += new System.EventHandler(this.MechanicalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosticService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRTM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDiagnosticService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRTM;
    }
}
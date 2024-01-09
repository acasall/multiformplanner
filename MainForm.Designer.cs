namespace multiformplanner
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
            this.lblInvestment = new System.Windows.Forms.Label();
            this.txtInvestment = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblGoal = new System.Windows.Forms.Label();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInvestment
            // 
            this.lblInvestment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestment.Location = new System.Drawing.Point(110, 42);
            this.lblInvestment.Name = "lblInvestment";
            this.lblInvestment.Size = new System.Drawing.Size(108, 23);
            this.lblInvestment.TabIndex = 0;
            this.lblInvestment.Text = "Yearly Investment";
            // 
            // txtInvestment
            // 
            this.txtInvestment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvestment.Location = new System.Drawing.Point(261, 41);
            this.txtInvestment.Multiline = true;
            this.txtInvestment.Name = "txtInvestment";
            this.txtInvestment.Size = new System.Drawing.Size(100, 20);
            this.txtInvestment.TabIndex = 1;
            // 
            // lblRate
            // 
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(110, 89);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(108, 23);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Growth Rate (%)";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(261, 86);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 3;
            // 
            // lblGoal
            // 
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.Location = new System.Drawing.Point(110, 142);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(108, 23);
            this.lblGoal.TabIndex = 4;
            this.lblGoal.Text = "Goal";
            // 
            // txtGoal
            // 
            this.txtGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoal.Location = new System.Drawing.Point(261, 139);
            this.txtGoal.Multiline = true;
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(100, 20);
            this.txtGoal.TabIndex = 5;
            // 
            // btnEstimate
            // 
            this.btnEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstimate.Location = new System.Drawing.Point(173, 203);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(89, 28);
            this.btnEstimate.TabIndex = 6;
            this.btnEstimate.Text = "How Long?";
            this.btnEstimate.UseVisualStyleBackColor = true;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(283, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 27);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtInvestment);
            this.Controls.Add(this.lblInvestment);
            this.HelpButton = true;
            this.Name = "MainForm";
            this.Text = "Financial Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvestment;
        private System.Windows.Forms.TextBox txtInvestment;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.Button btnExit;
    }
}


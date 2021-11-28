namespace NewspaperSellerSimulation
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
            this.btnReadData = new System.Windows.Forms.Button();
            this.DGVTypeOfNewsday = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cummProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxrange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVNewspaperDemand = new System.Windows.Forms.DataGridView();
            this.demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodprob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fairProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poorProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fairRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poorRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTypeOfNewsday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewspaperDemand)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadData
            // 
            this.btnReadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReadData.Location = new System.Drawing.Point(12, 72);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(170, 90);
            this.btnReadData.TabIndex = 0;
            this.btnReadData.Text = "Read Data From File";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.BtnReadData_Click);
            // 
            // DGVTypeOfNewsday
            // 
            this.DGVTypeOfNewsday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTypeOfNewsday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.prob,
            this.cummProbability,
            this.minRange,
            this.maxrange});
            this.DGVTypeOfNewsday.Location = new System.Drawing.Point(237, 72);
            this.DGVTypeOfNewsday.Name = "DGVTypeOfNewsday";
            this.DGVTypeOfNewsday.RowTemplate.Height = 24;
            this.DGVTypeOfNewsday.Size = new System.Drawing.Size(692, 135);
            this.DGVTypeOfNewsday.TabIndex = 1;
            // 
            // type
            // 
            this.type.HeaderText = "Type of news day";
            this.type.Name = "type";
            // 
            // prob
            // 
            this.prob.HeaderText = "propability";
            this.prob.Name = "prob";
            // 
            // cummProbability
            // 
            this.cummProbability.HeaderText = "Cummulative probability";
            this.cummProbability.Name = "cummProbability";
            // 
            // minRange
            // 
            this.minRange.HeaderText = "Min range";
            this.minRange.Name = "minRange";
            // 
            // maxrange
            // 
            this.maxrange.HeaderText = "Max range";
            this.maxrange.Name = "maxrange";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Random digit assignment for type of newsdays";
            // 
            // DGVNewspaperDemand
            // 
            this.DGVNewspaperDemand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNewspaperDemand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.demand,
            this.goodprob,
            this.fairProb,
            this.poorProb,
            this.goodRange,
            this.fairRange,
            this.poorRange});
            this.DGVNewspaperDemand.Location = new System.Drawing.Point(237, 275);
            this.DGVNewspaperDemand.Name = "DGVNewspaperDemand";
            this.DGVNewspaperDemand.RowTemplate.Height = 24;
            this.DGVNewspaperDemand.Size = new System.Drawing.Size(953, 271);
            this.DGVNewspaperDemand.TabIndex = 3;
            // 
            // demand
            // 
            this.demand.HeaderText = "Demand";
            this.demand.Name = "demand";
            // 
            // goodprob
            // 
            this.goodprob.HeaderText = "Good";
            this.goodprob.Name = "goodprob";
            // 
            // fairProb
            // 
            this.fairProb.HeaderText = "Fair";
            this.fairProb.Name = "fairProb";
            // 
            // poorProb
            // 
            this.poorProb.HeaderText = "Poor";
            this.poorProb.Name = "poorProb";
            // 
            // goodRange
            // 
            this.goodRange.HeaderText = "Good Range";
            this.goodRange.Name = "goodRange";
            // 
            // fairRange
            // 
            this.fairRange.HeaderText = "Fair range";
            this.fairRange.Name = "fairRange";
            // 
            // poorRange
            // 
            this.poorRange.HeaderText = "Poor Range";
            this.poorRange.Name = "poorRange";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(668, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Random digit assignment for type of newspaper demand";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 229);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(169, 104);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start System";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 584);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVNewspaperDemand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVTypeOfNewsday);
            this.Controls.Add(this.btnReadData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTypeOfNewsday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewspaperDemand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.DataGridView DGVTypeOfNewsday;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob;
        private System.Windows.Forms.DataGridViewTextBoxColumn cummProbability;
        private System.Windows.Forms.DataGridViewTextBoxColumn minRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxrange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVNewspaperDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodprob;
        private System.Windows.Forms.DataGridViewTextBoxColumn fairProb;
        private System.Windows.Forms.DataGridViewTextBoxColumn poorProb;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn fairRange;
        private System.Windows.Forms.DataGridViewTextBoxColumn poorRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
    }
}
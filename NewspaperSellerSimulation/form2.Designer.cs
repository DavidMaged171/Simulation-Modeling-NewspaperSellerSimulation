namespace NewspaperSellerSimulation
{
    partial class FormSimulattionSystem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salvage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Rand,
            this.type,
            this.randDemand,
            this.demand,
            this.revenu,
            this.lost,
            this.salvage,
            this.daily});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 445);
            this.dataGridView1.TabIndex = 0;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // Rand
            // 
            this.Rand.HeaderText = "Random Digits Of type of newspaper";
            this.Rand.Name = "Rand";
            this.Rand.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Type of newdays";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // randDemand
            // 
            this.randDemand.HeaderText = "Random digits of demand";
            this.randDemand.Name = "randDemand";
            this.randDemand.ReadOnly = true;
            // 
            // demand
            // 
            this.demand.HeaderText = "Demand";
            this.demand.Name = "demand";
            this.demand.ReadOnly = true;
            // 
            // revenu
            // 
            this.revenu.HeaderText = "Revenue from sales";
            this.revenu.Name = "revenu";
            this.revenu.ReadOnly = true;
            // 
            // lost
            // 
            this.lost.HeaderText = "Lost profit from Excess Demand";
            this.lost.Name = "lost";
            // 
            // salvage
            // 
            this.salvage.HeaderText = "Salvage From Sale Of Scrab";
            this.salvage.Name = "salvage";
            this.salvage.ReadOnly = true;
            // 
            // daily
            // 
            this.daily.HeaderText = "Daily profit";
            this.daily.Name = "daily";
            this.daily.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check Tests";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormSimulattionSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSimulattionSystem";
            this.Text = "SimulattionSystem";
            this.Load += new System.EventHandler(this.SimulattionSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rand;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn randDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn lost;
        private System.Windows.Forms.DataGridViewTextBoxColumn salvage;
        private System.Windows.Forms.DataGridViewTextBoxColumn daily;
        private System.Windows.Forms.Button button1;
    }
}
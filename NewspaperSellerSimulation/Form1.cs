using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        bool available=false;
        public Form1()
        {
            InitializeComponent();
        }
        private void setDGVTypeOfNewsDays( List<DayTypeDistribution> DayTD)
        {
            for (int i = 0; i < DayTD.Count; i++)
            {
                DayTypeDistribution d = DayTD[i];
                DGVTypeOfNewsday.Rows.Add(d.DayType, d.Probability, d.CummProbability, d.MinRange, d.MaxRange);
            }
        }
        private void setDGVRandomDigitAssignment(List<DemandDistribution>demandList,DataGridView DGV)
        {
            
            for(int i=0;i<demandList.Count;i++)
            {
                DemandDistribution d = demandList[i];
                string Good = d.DayTypeDistributions[0].MinRange.ToString() + " _ " + d.DayTypeDistributions[0].MaxRange.ToString();
                string Fair = d.DayTypeDistributions[1].MinRange.ToString() + " _ " + d.DayTypeDistributions[1].MaxRange.ToString();
                string Poor = d.DayTypeDistributions[2].MinRange.ToString() + " _ " + d.DayTypeDistributions[2].MaxRange.ToString();
                DGV.Rows.Add(d.Demand, d.DayTypeDistributions[0].Probability, 
                    d.DayTypeDistributions[1].Probability, d.DayTypeDistributions[2].Probability,Good,Fair,Poor);

            }
            
        }
        private void BtnReadData_Click(object sender, EventArgs e)
        {
            var configuration = new Configuration();
            

             //configuration.setDayTimeDestributions();
            List<DayTypeDistribution> DayTD = Configuration.DayTimeDestibiutions;
            setDGVTypeOfNewsDays(DayTD);

            List < DemandDistribution > Demand= Configuration.DemandData;

            setDGVRandomDigitAssignment(Demand, DGVNewspaperDemand);
            btnStart.Enabled = true;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var form = new FormSimulattionSystem();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
        }
    }
}

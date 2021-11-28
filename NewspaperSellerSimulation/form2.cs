using NewspaperSellerModels;
using NewspaperSellerTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperSellerSimulation
{
    public partial class FormSimulattionSystem : Form
    {
        SimulationSystem SimSys;
        public FormSimulattionSystem()
        {
            InitializeComponent();
        }

        private void SimulattionSystem_Load(object sender, EventArgs e)
        {
             SimSys = new SimulationSystem();
            List<SimulationCase> simCase=SimSys.SimulationCaseTable();
            string type;

            for(int i=0;i<SimSys.NumOfRecords-1;i++)
            {
                if (simCase[i].NewsDayType == Enums.DayType.Good)
                    type = "Good";
                else if (simCase[i].NewsDayType == Enums.DayType.Fair)
                    type = "Fair";
                else 
                    type = "Poor";
                

                dataGridView1.Rows.Add(
                    simCase[i].DayNo,simCase[i].RandomNewsDayType,type, 
                    simCase[i].RandomDemand, simCase[i].Demand, simCase[i].SalesProfit,
                    simCase[i].LostProfit, simCase[i].ScrapProfit, simCase[i].DailyNetProfit
                    );
            }

            
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string testingResult = TestingManager.Test(SimSys, Constants.FileNames.TestCase1);
            MessageBox.Show(testingResult);
        }
    }
}

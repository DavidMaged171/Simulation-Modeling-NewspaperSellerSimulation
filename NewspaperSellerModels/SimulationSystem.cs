using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
            setSymulationSystemData();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        /// <summary>
        /// Get all the data related to Simulation system class from the file
        /// </summary>
        /// <returns></returns>
        private void setSymulationSystemData()
        {
            
            string[] data = Configuration.data;
            
            NumOfNewspapers = int.Parse(data[1]);
            NumOfRecords = int.Parse(data[4]);
            PurchasePrice = decimal.Parse(data[7]);
            ScrapPrice = decimal.Parse(data[10]);
            SellingPrice = decimal.Parse(data[13]);
            UnitProfit = SellingPrice - PurchasePrice;
        }
        /// <summary>
        /// Fill List of simulation case
        /// </summary>
        /// <returns></returns>
        public List<SimulationCase> SimulationCaseTable()
        {
            List<SimulationCase> SCList = new List<SimulationCase>();
            for (int i = 1; i <=NumOfRecords;i++)
            {
                SimulationCase SCTemp = new SimulationCase();
                SCTemp.DayNo = i;
                SCTemp.RandomNewsDayType = Configuration.GenerateRandomNumber();
                SCTemp.NewsDayType = typeOfNewsDays(SCTemp.RandomNewsDayType);
                
                SCTemp.RandomDemand = Configuration.GenerateRandomNumber();
                SCTemp.Demand = getDemand(SCTemp.RandomDemand,SCTemp.NewsDayType);
                SCTemp.DailyCost = NumOfNewspapers*PurchasePrice;
                SCTemp.SalesProfit = SellingPrice * Math.Min(SCTemp.Demand,NumOfNewspapers);
                if (SCTemp.Demand < NumOfNewspapers)
                {
                    SCTemp.LostProfit = 0;
                    SCTemp.ScrapProfit = (NumOfNewspapers - SCTemp.Demand) * ScrapPrice;
                }
                else
                {
                    SCTemp.LostProfit = (SCTemp.Demand - NumOfNewspapers) * UnitProfit;
                    SCTemp.ScrapProfit = 0;
                }

                SCTemp.DailyNetProfit = SCTemp.SalesProfit - SCTemp.DailyCost - SCTemp.LostProfit + SCTemp.ScrapProfit;
                SCList.Add(SCTemp);
            }
            SimulationTable = SCList;
            CalculatePerformanceMeasures();
            return SCList;
        }
        /// <summary>
        /// Check The Day Type
        /// </summary>
        /// <param name="randNum"></param>
        /// <returns></returns>
        private Enums.DayType typeOfNewsDays(int randNum)
        {
            List<DayTypeDistribution> dayDistributions = Configuration.DayTimeDestibiutions;
            if (randNum <= dayDistributions[0].MaxRange)
                return Enums.DayType.Good;
            else if (randNum >= dayDistributions[1].MinRange && randNum <= dayDistributions[1].MaxRange)
                return Enums.DayType.Fair;
            else return Enums.DayType.Poor;
        }
        /// <summary>
        /// get Demand number dependent on random variable
        /// </summary>
        /// <param name="randNum"></param>
        /// <param name="DayType"></param>
        /// <returns></returns>
        private int getDemand(int randNum, Enums.DayType DayType)
        {
            List<DemandDistribution> demandData = Configuration.DemandData;
            for(int i=0;i<demandData.Count;i++)
            {
                List<DayTypeDistribution> dayDistrution = demandData[i].DayTypeDistributions;
                if(DayType==Enums.DayType.Good)
                {
                    if(randNum>=dayDistrution[0].MinRange&&randNum<=dayDistrution[0].MaxRange)
                    {
                        return demandData[i].Demand;
                    }
                }
                else if(DayType == Enums.DayType.Fair)
                {
                        if (randNum >= dayDistrution[1].MinRange && randNum <= dayDistrution[1].MaxRange)
                        {
                            return demandData[i].Demand;
                        }
                }
                else
                {
                    if (randNum >= dayDistrution[2].MinRange && randNum <= dayDistrution[2].MaxRange)
                    {
                        return demandData[i].Demand;
                    }
                }
            }


            return 0;
        }
        /// <summary>
        /// CalculatePerformanceMeasures
        /// </summary>
        /// <param name="SCList"></param>
        /// <returns></returns>
        public void CalculatePerformanceMeasures()
        {
            //PerformanceMeasures PM = new PerformanceMeasures();
            //SET PM
            PerformanceMeasures.TotalSalesProfit =0;
            PerformanceMeasures.TotalLostProfit = 0;
            PerformanceMeasures.TotalCost = 0;
            PerformanceMeasures.TotalScrapProfit = 0;
            PerformanceMeasures.TotalNetProfit = 0;
            PerformanceMeasures.DaysWithMoreDemand = 0;
            PerformanceMeasures.DaysWithUnsoldPapers = 0;

            //ADD Values
            for (int i=0;i< SimulationTable.Count;i++)
            {
                PerformanceMeasures.TotalSalesProfit += SimulationTable[i].SalesProfit;
                PerformanceMeasures.TotalLostProfit += SimulationTable[i].LostProfit;
                PerformanceMeasures.TotalCost +=  SimulationTable[i].DailyCost;
                PerformanceMeasures.TotalScrapProfit += SimulationTable[i].ScrapProfit;
                PerformanceMeasures.TotalNetProfit += SimulationTable[i].DailyNetProfit;
                PerformanceMeasures.DaysWithMoreDemand = numOfDaysWithMoreDemand(SimulationTable);
                PerformanceMeasures.DaysWithUnsoldPapers = numOfUnsoldPapers(SimulationTable);
            }
           
        }
        /// <summary>
        /// Calculate Total Sales Profit
        /// </summary>
        /// <param name="SCList"></param>
        /// <returns></returns>
       private int numOfDaysWithMoreDemand(List<SimulationCase>SCList)
        {
            int sum = 0;
            for(int i=0;i<SCList.Count;i++)
            {
                if (SCList[i].Demand > NumOfNewspapers)
                    sum++;
            }
            return sum;
        }
        private int numOfUnsoldPapers(List<SimulationCase>SCList)
        {
            int sum = 0;
            for(int i=0;i<SCList.Count;i++)
            {
                if (NumOfNewspapers > SCList[i].Demand)
                    sum++;
            }
            return sum;
        }
    }
}

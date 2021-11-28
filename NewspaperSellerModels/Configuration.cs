using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace NewspaperSellerModels
{
    public class  Configuration
    {
        public static  string[] data;

        public static List<DemandDistribution> DemandData;

        public static List<DayTypeDistribution> DayTimeDestibiutions;
        public void ReadFile()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.ShowDialog();
            string path = OFD.FileName;
            data = File.ReadAllLines(path);
        }

        public Configuration()
        {
            ReadFile();
            setDayTimeDestributions();
            CalculateDayTypeDistribution(DayTimeDestibiutions);
            setDemandDistribution();
            CalculateDemandDistribution(DemandData);
        }

        /// <summary>
        /// Get all the data related to Daytime distributions class from the file
        /// </summary>
        /// <returns></returns>
        private void setDayTimeDestributions()
        {
            List<DayTypeDistribution> dayTypeDistributions = new List<DayTypeDistribution>();
            string[] prob = data[16].Split(',', (char)StringSplitOptions.RemoveEmptyEntries);
            //Good Day
            DayTypeDistribution temp = new DayTypeDistribution();
            temp.Probability = decimal.Parse(prob[0]);
            temp.DayType = Enums.DayType.Good;
            temp.CummProbability = temp.Probability;
            temp.MinRange = 1;temp.MaxRange = (int)(temp.CummProbability * 100);

            dayTypeDistributions.Add(temp);
            //Fair Day
            temp = new DayTypeDistribution();
            temp.Probability = decimal.Parse(prob[1]);
            temp.DayType = Enums.DayType.Fair;
            temp.CummProbability = temp.Probability+dayTypeDistributions[0].CummProbability;
            temp.MinRange = (int)dayTypeDistributions[0].MaxRange+1;
            temp.MaxRange = (int)(temp.CummProbability * 100);

            dayTypeDistributions.Add(temp);

            //Poor Day
            temp = new DayTypeDistribution();
            temp.Probability = decimal.Parse(prob[2]);
            temp.DayType = Enums.DayType.Poor;
            temp.CummProbability = temp.Probability + dayTypeDistributions[1].CummProbability;
            temp.MinRange = (int)dayTypeDistributions[1].MaxRange + 1;
            temp.MaxRange = (int)(temp.CummProbability * 100);


            dayTypeDistributions.Add(temp);
            DayTimeDestibiutions = new List<DayTypeDistribution>();
            DayTimeDestibiutions = dayTypeDistributions;
        }
        /// <summary>
        /// Get Demand Distribution Data from file
        /// </summary>
        /// <returns></returns>
        private void setDemandDistribution()
        {
            List<DemandDistribution> demandDistributionList =
                new List<DemandDistribution>();

            int i = 19;
            while(i<data.Count())
            {
                //Demand Line
                DemandDistribution d = new DemandDistribution();
                string[] s = data[i].Split(',', (char)StringSplitOptions.RemoveEmptyEntries);
                //Demand Value
                d.Demand = int.Parse(s[0]);
                //Demand Day Type Distribution
                List<DayTypeDistribution> DaytempList = new List<DayTypeDistribution>();
                DayTypeDistribution dayTemp ;
                for(int g=1;g<s.Count();g++)
                {
                    dayTemp = new DayTypeDistribution();
                    dayTemp.Probability = decimal.Parse(s[g]);
                    DaytempList.Add(dayTemp);
                }
                d.DayTypeDistributions = DaytempList;
                
                demandDistributionList.Add(d);
                i++;
            }
            DemandData = new List<DemandDistribution>();
            DemandData = demandDistributionList;
            //CalculateDemandDistribution(DemandData);
            
        }
        /// <summary>
        /// calculate all Probabilities of day type;
        /// </summary>
        /// <param name="dayTypeDistributions"></param>
        /// <returns></returns>
        private void CalculateDayTypeDistribution(List<DayTypeDistribution>dayTypeDistributions)
        {
            dayTypeDistributions[0].CummProbability = dayTypeDistributions[0].Probability;
            dayTypeDistributions[0].MinRange = 1;
            dayTypeDistributions[0].MaxRange = (int)(dayTypeDistributions[0].CummProbability * 100);
            dayTypeDistributions[0].DayType = Enums.DayType.Good;

            for(int i=1;i<3;i++)
            {
                dayTypeDistributions[i].CummProbability = dayTypeDistributions[i].Probability+dayTypeDistributions[i-1].CummProbability;
                dayTypeDistributions[i].MinRange = dayTypeDistributions[i-1].MaxRange+1;
                dayTypeDistributions[i].MaxRange = (int)(dayTypeDistributions[i].CummProbability * 100);
                if(i==1)
                    dayTypeDistributions[i].DayType = Enums.DayType.Fair;
                else
                    dayTypeDistributions[i].DayType = Enums.DayType.Poor;

            }
            
        }

        /// <summary>
        /// Calculate all the propabilities of the demand destribution table;
        /// </summary>
        /// <param name="demandList"></param>
        /// <returns></returns>
        private void CalculateDemandDistribution(List<DemandDistribution>demandList)
        {
            DemandDistribution demandTemp = demandList[0];
            List<DayTypeDistribution> dayList = demandTemp.DayTypeDistributions;
            //Good Day
            dayList[0].CummProbability = dayList[0].Probability;
            dayList[0].MinRange = 1;dayList[0].MaxRange = (int)(dayList[0].CummProbability * 100);
            dayList[0].DayType = Enums.DayType.Good;
            //Fair Day
            dayList[1].CummProbability = dayList[1].Probability;
            dayList[1].MinRange = 1; dayList[1].MaxRange = (int)(dayList[1].CummProbability * 100);
            dayList[1].DayType = Enums.DayType.Fair;
            //Poor Day
            dayList[2].CummProbability = dayList[2].Probability;
            dayList[2].MinRange = 1; dayList[2].MaxRange = (int)(dayList[2].CummProbability * 100);
            dayList[2].DayType = Enums.DayType.Poor;
            //Equalization
            demandTemp.DayTypeDistributions = dayList;
            demandList[0] = demandTemp;
            for(int i=1;i<demandList.Count;i++)
            {
                demandTemp = demandList[i];
                DemandDistribution previousDemand = demandList[i - 1];
                dayList = demandTemp.DayTypeDistributions;

                //Good Day
                
                dayList[0].CummProbability = dayList[0].Probability +previousDemand.DayTypeDistributions[0].CummProbability;
                dayList[0].MinRange = previousDemand.DayTypeDistributions[0].MaxRange + 1;
                dayList[0].MaxRange = (int)(dayList[0].CummProbability * 100);
                dayList[0].DayType = Enums.DayType.Good;
                //Fair Day

                dayList[1].CummProbability = dayList[1].Probability + previousDemand.DayTypeDistributions[1].CummProbability;
                dayList[1].MinRange = previousDemand.DayTypeDistributions[1].MaxRange + 1;
                dayList[1].MaxRange = (int)(dayList[1].CummProbability * 100);
                dayList[1].DayType = Enums.DayType.Fair;
                //Poor Day
                dayList[2].CummProbability = dayList[2].Probability + previousDemand.DayTypeDistributions[2].CummProbability;
                dayList[2].MinRange = previousDemand.DayTypeDistributions[2].MaxRange + 1;
                dayList[2].MaxRange = (int)(dayList[2].CummProbability * 100);
                dayList[2].DayType = Enums.DayType.Poor;

                //equalization

                
                demandTemp.DayTypeDistributions = dayList;
                demandList[i] = demandTemp;
            }
            //DemandData = new List<DemandDistribution>();
                DemandData= demandList;
            //return demandList;
        }

        public static int GenerateRandomNumber(int Min=1,int Max=101)
        {
            Random rand = new Random();
            int num = rand.Next(Min, Max);
            Thread.Sleep(150);//to give a chance to hardware to generate another random number
            return num;
        }
        
            

    }
}

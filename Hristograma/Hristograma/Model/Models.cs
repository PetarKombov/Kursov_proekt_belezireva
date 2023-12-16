using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Hristograma.Module
{       
    public class Models
    { 
        double CalculatePercentage( int count)
        {
            return (100 / Broi) * count;
        }
        private int broi;
        public int Broi 
        {
            get { return broi; }
            set {  broi = value; }
        }
        public List<int> Chisla { get; set; }
        public Models(List<int> chisla)
        {
            this.Broi = chisla.Count ;
            this.Chisla = chisla;
        }

        public double CalculateP1()
        {
            int count = 0;
            for (int i = 0; i < Broi; i++)
            {
                if (Chisla[i] >= 1 && Chisla[i] < 200)
                {
                    count++;
                }
            }
            return CalculatePercentage( count);
        }


        public double CalculateP2()
        {
            int count = 0;
            for (int i = 0; i < Broi; i++)
            {
                if (Chisla[i] < 400 && Chisla[i] >= 200)
                {
                    count++;
                }
            }
            return CalculatePercentage(count);

        }
        public double CalculateP3()
        {
            int count = 0;
            for (int i = 0; i < Broi; i++)
            {
                if (Chisla[i] < 600 && Chisla[i] >= 400)
                {
                    count++;
                }
            }
            return CalculatePercentage(count);
        }
        public double CalculateP4()
        {
            int count = 0;
            for (int i = 0; i < Broi; i++)
            {
                if (Chisla[i] < 800 && Chisla[i] >= 600)
                {
                    count++;
                }
            }
            return CalculatePercentage(count);
        }
        public double CalculateP5()
         {
           int count = 0;
            for (int i = 0; i < Broi; i++)
            {
                if (Chisla[i] <= 1000 && Chisla[i] >= 800)
                {
                    count++;
                }
            }
              return CalculatePercentage(count);
         }

    }
}


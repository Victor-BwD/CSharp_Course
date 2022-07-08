using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationStatusCaracter
{
    internal class Points
    {
        private int points;
        private int limitPoints = 28;

        public void SpendPoint(int pointsDistributes)
        {
            this.points += pointsDistributes;
            if(this.points > limitPoints)
            {
                throw new ArgumentException("No points left");
            }
        }

        public double getPoints()
        {
            return this.points;
        }
    }
}

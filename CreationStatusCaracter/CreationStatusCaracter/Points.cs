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

        public bool SpendPoint(int pointsDistributes)
        {
            if(pointsDistributes < 0) return false;
            if(this.points > limitPoints) return false;
            
            this.points += pointsDistributes;
            return true;
        }

        public double getPoints()
        {
            return this.points;
        }
    }
}

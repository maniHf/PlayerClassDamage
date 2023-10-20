using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlayerClass
{
    public class Player
    {
        private int Health = 100;
        public int s_Health
        {
            get { return Health; }
            set
            { if (value >= 0 && value < 100) Health = value; }
        }
        public void m_Hit (int Damage){this.Health -= Damage;}
     
    }
}

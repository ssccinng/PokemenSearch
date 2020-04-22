using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemenSearch
{
    class Racial
    {
        public int HP;
        public int Atk;
        public int Def;
        public int Spa;
        public int Spf;
        public int Spe;

        public int SumRacial
        {
            get
            {
                return HP + Atk + Def + Spa + Spf + Spe;
            }
        }

        public void clear()
        {
            HP = Atk = Def = Spa = Spf = Spe = 0;
        }

        public void fill()
        {
            HP = Atk = Def = Spa = Spf = Spe = 31;
        }
        public void setf(int HP, int Atk, int Def, int Spa, int Spf, int Spe)
        {
            this.HP = HP;
            this.Atk = Atk;
            this.Def = Def;
            this.Spa = Spa;
            this.Spf = Spf;
            this.Spe = Spe;
            //this.SumRacial = HP + Atk + Def + Spa + Spf + Spe;
        }
    }
}

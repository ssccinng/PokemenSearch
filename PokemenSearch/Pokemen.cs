using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemenSearch
{
    // mega对mega 形态归形态
    class Pokemen // hash中存
    {
        public int num;

        public string Decp;

        public Racial RacialValue = new Racial();

        public int type1, type2;

        public bool CanMega;

        public int feature1, feature2, featuresDream;

        public bool isfina;

        public bool diffstat;

        public Pokemen()
        {
            diffstat = false;
            specialZ = new string[7];
        }

        public bool isType(string Type1, string Type2)
        {
            string[] typelist = load_data.loadpokemenTYPE();
            string a = typelist[type1], b = typelist[type2 == 0 ? type1 : type2];
            return ((Type1 == "(无)" || Type1 == a || Type1 == b) && (Type2 == "(无)" || Type2 == a || Type2 == b));
        }

        public bool isTX(string TX)
        {
            string[] Txlist = load_data.loadpokemenTX();
            return (TX == "" || TX == Txlist[feature1] || TX == Txlist[feature2] || TX == Txlist[featuresDream]);
        }

        public bool havespZ(string ZS, int SD)
        {
            if (specialZ[SD] == null) return false;
            string[] gg = specialZ[SD].Split(',');
            foreach (string temp in gg)
            {
                if (temp == ZS) return true;
            }
            return false;
        }

        public string[] specialZ;
    }

    class canusepokemen: Pokemen
    {
        public Racial hardlyValue = new Racial(); // 努力值
        public Racial ownValue = new Racial();    // 个体值
        public int sexge;
        public int level;
        public canusepokemen()
        {
            level = 50;
            sexge = 1;
            hardlyValue.clear();
            ownValue.fill();
        }
    }
}


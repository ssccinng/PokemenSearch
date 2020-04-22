using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PokemenSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable Texin = PokemenSearch.load_data.loadtexin();
        Hashtable[] zhaoshi = PokemenSearch.load_data.loadzhaoshi();
        Hashtable pokemens;
        string[] pokemensdec;
        string[] allpoke = load_data.loadpokemenname();
        Hashtable poketonum = new Hashtable();
        
        private string getans()
        {
            string SDT = comboBox1.Text;
            int SD = 0;
            switch (SDT)
            {
                case "第一世代": SD = 0; break;
                case "第二世代": SD = 1; break;
                case "第三世代": SD = 2; break;
                case "第四世代": SD = 3; break;
                case "第五世代": SD = 4; break;
                case "第六世代": SD = 5; break;
                case "第七世代": SD = 6; break;
                default: break;
            }
            string type1 = Type1.Text, type2 = Type2.Text;
            string TX = textBox1.Text, ZS = textBox2.Text;
            StringBuilder ans = new StringBuilder();
            string[] Typelist = load_data.loadpokemenTYPE();
            //ans.Append("具有这些特性的宝可梦是:\n");
            string[] texinlist = (TX != "" ? (string[])Texin[TX] : load_data.loadpokemenname());
            if (texinlist == null) return "无此特性!";
            int tag1 = 1;
            foreach (string PoinTx in texinlist)
            {

                if (tag1 == 1)
                {
                    tag1 = 2;
                    continue;
                }
                string[] pokelist;
                bool flag = false;
                pokelist = pokemensdec[(int)(poketonum[PoinTx])].Split(',');

  
                foreach (string zs in ((string[])zhaoshi[SD][PoinTx]))
                {
                    if (ZS == "" || zs == ZS)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag) continue;
                int tag = 0;
                //if (((Pokemen)pokemens[PoinTx]).diffstat)
                //{
                //    if (PoinTx == "洛托姆")
                //    {
                //     if (SD > 4)
                //        {

                //        }   
                //    }
                    
                //}
                foreach (string poke in pokelist)
                {
                    if (((Pokemen)pokemens[poke]).isTX(TX) && ((Pokemen)pokemens[poke]).isType(type1, type2))
                    {
                        if (ans.ToString() == "") ans.Append(poke);
                        else ans.Append(',' + poke);
                    }
                }
            }

            if (ans.ToString() == null) return "未找到符合该类型的破壳萌!";
            return ans.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Texin = PokemenSearch.load_data.loadtexin();
            zhaoshi = PokemenSearch.load_data.loadzhaoshi();
            load_data.AutoTexin(textBox1);
            load_data.AutoZS(textBox2);
            comboBox1.Text = "第七世代";
            Type1.Text = "(无)";
            Type2.Text = "(无)";
            pokemensdec = new string[803];
            //pokemens = PokemenSearch.load_data.GetPokemen(ref pokemensdec);
            for (int i = 1; i < 803; ++i)
            {
                poketonum[allpoke[i]] = i;
            }
            int a = 1 + 1;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该搜索不考虑图图犬的特殊性\n招式不考虑z招式\n附带招式表及特性表\n可能有一些数据错误及bug，如遇到希望能反馈XD");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Type1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

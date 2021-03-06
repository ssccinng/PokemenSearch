﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Resources;
using System.Windows.Forms;

namespace PokemenSearch
{
    public partial class showpokemen : Form
    {
        Hashtable Texin;
        Hashtable[] zhaoshi;
        Hashtable pokemens;
        string[] pokemensdec;
        string[] allpoke;
        Hashtable poketonum;
        string[] Typelist;
        string[] Txlist = load_data.loadpokemenTX();
        Label[] power;
        Label[] title;
        string wanttoshow;
        canusepokemen[] player = new canusepokemen[1000];
        string[] sexge = load_data.getsexname();
        string[] rssguo = load_data.getrss();
        Sexge[] xingge = new Sexge[26];
        Hashtable sexgenum = new Hashtable();
        ZSmin[] zsmin = new ZSmin[6];
        int ZSnum = 0;
        struct ZSmin
        {
            public Label min;
            public Button del;
        };
        public showpokemen()
        {
            InitializeComponent();
        }
        

        
        private void showpokemen_Load(object sender, EventArgs e)
        {
            power = new Label[6];
            title = new Label[6];
            poketonum = new Hashtable();
            
            pokemensdec = new string[1000];
            pokemens = new Hashtable();
            pokemens = PokemenSearch.load_data.GetPokemen(ref pokemensdec, ref poketonum);

            for (int i = 0; i < 6; ++i)
            {
                power[i] = new Label();
                title[i] = new Label();
                zsmin[i].min = new Label();
                zsmin[i].min.Text = i.ToString();
                zsmin[i].del = new Button();
                zsmin[i].del.Tag = i + 1;
                zsmin[i].del.Size = new Size(21, 21);
                zsmin[i].del.Text = "x";
                zsmin[i].del.Click += new EventHandler(ZSUP);
                power[i].Location = new System.Drawing.Point(406, 95 + 26 * i);
                title[i].Location = new System.Drawing.Point(202, 95 + 26 * i);
                zsmin[i].min.Location = new System.Drawing.Point(20, 44 + 26 * i);
                zsmin[i].del.Location = new System.Drawing.Point(120, 40 + 26 * i);
                zsmin[i].del.Visible = false;
                zsmin[i].min.Visible = false;
            }
            power[0].Name = "PoHP";
            power[1].Name = "PoAtk";
            power[2].Name = "PoDef";
            power[3].Name = "PoSpa";
            power[4].Name = "PoSpf";
            power[5].Name = "PoSpe";
            title[0].Text = "HP";
            title[1].Text = "物攻";
            title[2].Text = "物防";
            title[3].Text = "特攻";
            title[4].Text = "特防";
            title[5].Text = "速度";
            for (int i = 0; i < 6; ++i)
            {
                Controls.Add(power[i]);
                Controls.Add(title[i]);
                ZSlist1.Controls.Add(zsmin[i].del);
                ZSlist1.Controls.Add(zsmin[i].min);
            }
            for (int i = 0; i < player.Length; ++i)
            {
                player[i] = new canusepokemen();
            }
            for (int i = 1; i < 26; ++i)
            {
                string[] ss = sexge[i - 1].Split(',');
                xingge[i] = new Sexge(ss[0], int.Parse(ss[1]), int.Parse(ss[2]), int.Parse(ss[3]));
                Sex.Items.Add(xingge[i].name);
                sexgenum[xingge[i].name] = i;
            }
            Sex.Text = xingge[1].name;


            Texin = PokemenSearch.load_data.loadtexin();
            zhaoshi = PokemenSearch.load_data.loadzhaoshi();
            allpoke = load_data.loadpokemenname();
            Typelist = load_data.loadpokemenTYPE();
            load_data.AutoTexin(TX);
            load_data.AutoZS(ZS);
            load_data.Autoname(AfterSearch);
            sorttag.SelectedIndex = 0;
            //for (int i = 1; i < allpoke.Length; ++i)
            //{
            //    poketonum[allpoke[i]] = i;
            //}
            Type1.Text = Type2.Text = "(无)";
            SD.Text = "迦勒尔图鉴";
        }

        private void ZSUP(object sender, EventArgs e)
        {
            if (ZSnum == 0) return;
            for (int i = (int)((Button)sender).Tag; i < ZSnum; ++i)
            {
                zsmin[i - 1].min.Text = zsmin[i].min.Text;
            }
            ZSnum--;
            zsmin[ZSnum].del.Visible = false;
            zsmin[ZSnum].min.Visible = false;
            updata();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           updata();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //updata();
        }

        private void updata()
        {
            string afsearch = updataPKlist();
            AfterSearch.Items.Clear();
            AfterSearch.Text = "";
            string [] poke;
            if (afsearch != null && afsearch != "")
            {
                poke = afsearch.Split(',');
                foreach (string item in poke)
                {
                    AfterSearch.Items.Add(item);
                }
                if (AfterSearch.Text != poke[0])
                    AfterSearch.Text = poke[0];
            }
            else
            {
                wanttoshow = "伊布";
                updataimage();
                updata6V();
            }
            upxinge();
        }
        int shidai = 0;
        private string updataPKlist()
        {
            string type1 = Type1.Text, type2 = Type2.Text;
            //string sd = SD.Text;
            string sex = Sex.Text;
            string tx = TX.Text, zs = ZS.Text;
            StringBuilder ret = new StringBuilder();
            Hashtable rret = new Hashtable();
            //switch (sd)
            //{
            //    //case "第一世代": shidai = 0; break;
            //    //case "第二世代": shidai = 1; break;
            //    //case "第三世代": shidai = 2; break;
            //    //case "第四世代": shidai = 3; break;
            //    //case "第五世代": shidai = 4; break;
            //    //case "第六世代": shidai = 5; break;
            //    //case "第七世代": shidai = 6; break;
            //    default: break;
            //}
            string[] texinlist = (tx != "" ? (string[])Texin[tx] : load_data.loadpokemenname());
            if (texinlist == null) return null;
            
            if (ZSnum == 0)
            {
                int flag1 = 0;
                foreach (string poke in texinlist)
                {
                    if (flag1 == 0)
                    {
                        flag1 = 1;
                        continue;
                    }
                    if (((Pokemen)pokemens[poke]).isType(type1, type2))
                    {
                        if (rret.Contains(poke))
                        {
                            rret[poke] = ((int)(rret[poke])) + 1;
                        }
                        else
                        {
                            rret[poke] = 1;
                        }
                    }
                }

            }
            else
            {
                foreach (string PoinTx in texinlist)
                {
                    if (PoinTx != tx)
                    {
                        //string[] pokelist = pokemensdec[(int)(poketonum[PoinTx])].Split(',');



                        for (int i = 0; i < Math.Max(ZSnum, 1); ++i)
                        {
                            if (ZSnum == 0) zs = "";
                            else zs = zsmin[i].min.Text;
                            bool flag = false;
                            foreach (string zs1 in ((string[])zhaoshi[0][PoinTx]))
                            {
                                if (zs == "" || zs == zs1 || zs == zs1.Split('-')[0])
                                {
                                    flag = true;
                                    break;
                                }
                            }
                            if (!flag) continue;

                            //foreach (string poke in pokelist)
                            //{
                                if (((Pokemen)pokemens[PoinTx]).isTX(tx) && ((Pokemen)pokemens[PoinTx]).isType(type1, type2))
                                {
                                    if (rret.Contains(PoinTx))
                                    {
                                        rret[PoinTx] = ((int)(rret[PoinTx])) + 1;
                                    }
                                    else
                                    {
                                        rret[PoinTx] = 1;
                                    }
                                //}
                            }
                        }

                    }

                }
            }
            string[] tli = new string[rret.Count];
            int index = 0;
            foreach (DictionaryEntry i in rret)
            {
                if ((int)i.Value >= ZSnum)
                {
                    tli[index++] = (string)i.Key;
                }
                //if (ret.ToString() == "") ret.Append((string)i.Key);
                //else ret.Append(',' + (string)i.Key);


            }
            //string[] tli = ret.ToString().Split(',');
            int[] comp = new int[index];
            //for (int i = 0; i < index; ++i)
            //{
            //    comp[i] = (int)poketonum[tli[i]];
            //}
            //for (int i = 0; i < index; ++i)
            //{
            //    comp[i] =  -((Pokemen)pokemens[tli[i]]).RacialValue.SumRacial;
            //}
            switch (sorttag.SelectedIndex)

        
            {

                case 0:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = (int)poketonum[tli[i]];
                    }
                    break;
                case 1:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = -((Pokemen)pokemens[tli[i]]).RacialValue.SumRacial;
                    }
                    break;
                case 2:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = ((Pokemen)pokemens[tli[i]]).RacialValue.SumRacial;
                    }
                    break;
                case 3:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = -((Pokemen)pokemens[tli[i]]).RacialValue.HP;
                    }
                    break;
                case 4:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = ((Pokemen)pokemens[tli[i]]).RacialValue.HP;
                    }
                    break;
                case 5:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = -((Pokemen)pokemens[tli[i]]).RacialValue.Atk;
                    }
                    break;
                case 6:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = ((Pokemen)pokemens[tli[i]]).RacialValue.Atk;
                    }
                    break;
                case 7:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = -((Pokemen)pokemens[tli[i]]).RacialValue.Def;
                    }
                    break;
                case 8:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = ((Pokemen)pokemens[tli[i]]).RacialValue.Def;
                    }
                    break;
                case 9:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = -((Pokemen)pokemens[tli[i]]).RacialValue.Spa;
                    }
                    break;
                case 10:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = ((Pokemen)pokemens[tli[i]]).RacialValue.Spa;
                    }
                    break;
                case 11:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = -((Pokemen)pokemens[tli[i]]).RacialValue.Spf;
                    }
                    break;
                case 12:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = ((Pokemen)pokemens[tli[i]]).RacialValue.Spf;
                    }
                    break;
                case 13:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = -((Pokemen)pokemens[tli[i]]).RacialValue.Spe;
                    }
                    break;
                case 14:
                    for (int i = 0; i < index; ++i)
                    {
                        comp[i] = ((Pokemen)pokemens[tli[i]]).RacialValue.Spe;
                    }
                    break;
                default:
                    break;
            }
            //if (sortra.Checked)
            //{
            //    for (int i = 0; i < index; ++i)
            //    {
            //        comp[i] = -((Pokemen)pokemens[tli[i]]).RacialValue.SumRacial;
            //    }
            //    Array.Sort(comp, tli);

            //}
            //else
            //{
            //    for (int i = 0; i < index; ++i)
            //    {
            //        comp[i] = (int)poketonum[tli[i]];
            //    }
                

            //}
            Array.Sort(comp, tli);
            ret = new StringBuilder();
            for (int i = 0; i < index; ++i)
            {
                if (ret.ToString() == "") ret.Append(tli[i]);
                else ret.Append(',' + tli[i]);
            }
            //foreach (string i in tli)
            //{

                


            //}
            return ret.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Type1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updata();
        }

        private void AfterSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            wanttoshow = AfterSearch.Text;
            updataimage();
            updata6V();
        }

        private void updata6V()
        {
            if (stat.Text == wanttoshow || wanttoshow == null) return;
            //pokehead.Image = (Image)pokemenhead.ResourceManager.GetObject("六尾");
            pokename.Text = wanttoshow;// allpoke[((Pokemen)pokemens[wanttoshow]).num];
            string[] aflist = pokemensdec[((Pokemen)pokemens[wanttoshow]).num].Split(',');
            stat.Items.Clear();
            foreach (string item in aflist)
            {
                stat.Items.Add(item);
            }
            if (stat.Text != wanttoshow)
                stat.Text = wanttoshow;

        }

        private void up6V()
        {
            if (wanttoshow == null) return;
            RHP.Text = ((Pokemen)(pokemens[wanttoshow])).RacialValue.HP.ToString();
            RAtk.Text = ((Pokemen)(pokemens[wanttoshow])).RacialValue.Atk.ToString();
            RDef.Text = ((Pokemen)(pokemens[wanttoshow])).RacialValue.Def.ToString();
            RSpa.Text = ((Pokemen)(pokemens[wanttoshow])).RacialValue.Spa.ToString();
            RSpf.Text = ((Pokemen)(pokemens[wanttoshow])).RacialValue.Spf.ToString();
            RSpe.Text = ((Pokemen)(pokemens[wanttoshow])).RacialValue.Spe.ToString();
            Rsum.Text = ((Pokemen)(pokemens[wanttoshow])).RacialValue.SumRacial.ToString();

            uphard();

            upown();

            level.Text = player[((Pokemen)(pokemens[wanttoshow])).num].level.ToString();

            //PoAtk.Text = ((int)((int.Parse(RAtk.Text) * 2 + int.Parse(PAtk.Text) + (Math.Sqrt(int.Parse(HAtk.Text)) / 4)) * int.Parse(level.Text) / 100 + 5)).ToString();
            //PoDef.Text = ((int)((int.Parse(RDef.Text) * 2 + int.Parse(PDef.Text) + (Math.Sqrt(int.Parse(HDef.Text)) / 4)) * int.Parse(level.Text) / 100 + 5)).ToString();
            //PoSpa.Text = ((int)((int.Parse(RSpa.Text) * 2 + int.Parse(PSpa.Text) + (Math.Sqrt(int.Parse(HSpa.Text)) / 4)) * int.Parse(level.Text) / 100 + 5)).ToString();
            //PoSpf.Text = ((int)((int.Parse(RSpf.Text) * 2 + int.Parse(PSpf.Text) + (Math.Sqrt(int.Parse(HSpf.Text)) / 4)) * int.Parse(level.Text) / 100 + 5)).ToString();
            //PoSpe.Text = ((int)((int.Parse(RSpe.Text) * 2 + int.Parse(PSpe.Text) + (Math.Sqrt(int.Parse(HSpe.Text)) / 4)) * int.Parse(level.Text) / 100 + 5)).ToString();
            //upxg();
            uppow();
            //object obj = ResourceManager.GetObject(AfterSearch.Text);
            //object obj = ResourceManager.GetObject("资源名称", resourceCulture);
        }

        private void upown()
        {
            PHP.Text  = player[((Pokemen)(pokemens[wanttoshow])).num].ownValue.HP.ToString();
            //if (PHP.Text == "0") PHP.SelectionStart = 2;
            PAtk.Text = player[((Pokemen)(pokemens[wanttoshow])).num].ownValue.Atk.ToString();
            //if (PAtk.Text == "0") PAtk.SelectionStart = 2;
            PDef.Text = player[((Pokemen)(pokemens[wanttoshow])).num].ownValue.Def.ToString();
            //if (PDef.Text == "0") PDef.SelectionStart = 2;
            PSpa.Text = player[((Pokemen)(pokemens[wanttoshow])).num].ownValue.Spa.ToString();
            //if (PSpa.Text == "0") PSpa.SelectionStart = 2;
            PSpf.Text = player[((Pokemen)(pokemens[wanttoshow])).num].ownValue.Spf.ToString();
            //if (PSpf.Text == "0") PSpf.SelectionStart = 2;
            PSpe.Text = player[((Pokemen)(pokemens[wanttoshow])).num].ownValue.Spe.ToString();
            //if (PSpe.Text == "0") PSpe.SelectionStart = 2;
        }

        private void uphard()
        {
            HHP.Text  = player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.HP.ToString();
            //if (HHP.Text == "0") HHP.SelectionStart = HHP.Text.Length;
            HAtk.Text = player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.Atk.ToString();
            //if (HAtk.Text == "0") HAtk.SelectionStart = 2;
            HDef.Text = player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.Def.ToString();
            //if (HDef.Text == "0") HDef.SelectionStart = 2;
            HSpa.Text = player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.Spa.ToString();
            //if (HSpa.Text == "0") HSpa.SelectionStart = 2;
            HSpf.Text = player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.Spf.ToString();
            //if (HSpf.Text == "0") HSpf.SelectionStart = 2;
            HSpe.Text = player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.Spe.ToString();
            //if (HSpe.Text == "0") HSpe.SelectionStart = 2;
            Hsum.Text = player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.SumRacial.ToString();
        }

        private void upxg()
        {
            if (wanttoshow == null) return;
            Sex.Text = xingge[player[((Pokemen)(pokemens[wanttoshow])).num].sexge].name;
        }

        private void gg(TextBox a)
        {
            a.SelectionStart = a.Text.Length;
        }

        private void uppow()

        {
            if (wanttoshow == null) return;
            if (wanttoshow == "脱壳忍者")
            {
                power[0].Text = "1";
            }
            else
            {
                power[0].Text = ((int)((int.Parse(RHP.Text) * 2 + int.Parse(PHP.Text) + (int.Parse(HHP.Text) / 4)) * int.Parse(level.Text) / 100 + 10 + int.Parse(level.Text))).ToString();
            }
            power[1].Text = ((int)((int.Parse(RAtk.Text) * 2 + int.Parse(PAtk.Text) + (int.Parse(HAtk.Text) / 4)) * int.Parse(level.Text) / 100 + 5)).ToString();
            power[2].Text = ((int)((int.Parse(RDef.Text) * 2 + int.Parse(PDef.Text) + (int.Parse(HDef.Text) / 4)) * int.Parse(level.Text) / 100 + 5)).ToString();
            power[3].Text = ((int)((int.Parse(RSpa.Text) * 2 + int.Parse(PSpa.Text) + (int.Parse(HSpa.Text) / 4)) * int.Parse(level.Text) / 100 + 5)).ToString();
            power[4].Text = ((int)((int.Parse(RSpf.Text) * 2 + int.Parse(PSpf.Text) + (int.Parse(HSpf.Text) / 4)) * int.Parse(level.Text) / 100 + 5)).ToString();
            power[5].Text = ((int)((int.Parse(RSpe.Text) * 2 + int.Parse(PSpe.Text) + (int.Parse(HSpe.Text) / 4)) * int.Parse(level.Text) / 100 + 5)).ToString();
            upxinge();
            //upxg();
        }

        private void updataimage()
        {
            if (wanttoshow == null) return;

            pokehead.Image = (Image)pokemenhead.ResourceManager.GetObject(wanttoshow.Replace('-', 'T').Replace("（", "T").Replace("）", "").Replace("：", "T"));


            evfield.Text = "HP: " + ((Pokemen)(pokemens[wanttoshow])).EVfield.HP.ToString();
            evfield.Text += ";物攻: " + ((Pokemen)(pokemens[wanttoshow])).EVfield.Atk.ToString();
            evfield.Text += ";物防: " + ((Pokemen)(pokemens[wanttoshow])).EVfield.Def.ToString();
            evfield.Text += "\n特攻: " + ((Pokemen)(pokemens[wanttoshow])).EVfield.Spa.ToString();
            evfield.Text += ";特防: " + ((Pokemen)(pokemens[wanttoshow])).EVfield.Spf.ToString();
            evfield.Text += ";速度: " + ((Pokemen)(pokemens[wanttoshow])).EVfield.Spe.ToString();

            typel.Text = "属性: " + Typelist[ ((Pokemen)(pokemens[wanttoshow])).type1];
            if (((Pokemen)(pokemens[wanttoshow])).type2 != 0)
            {
                typel.Text += "\n      " + Typelist[((Pokemen)(pokemens[wanttoshow])).type2];
            }

            egggroup.Text = "蛋组:  " + ((Pokemen)(pokemens[wanttoshow])).egggroup;

            TXp.Text = "普特:  " + Txlist[ ((Pokemen)(pokemens[wanttoshow])).feature1];
            if (((Pokemen)(pokemens[wanttoshow])).feature2 != 0)
                TXp.Text += " / " + Txlist[((Pokemen)(pokemens[wanttoshow])).feature2];
            TXM.Text = "梦特:  " + Txlist[((Pokemen)(pokemens[wanttoshow])).featuresDream];
        }

        private void stat_SelectedIndexChanged(object sender, EventArgs e)
        {
            wanttoshow = stat.Text;
            pokename.Text = wanttoshow;

            updataimage();
            

            up6V();
        }

        private void PHP_TextChanged(object sender, EventArgs e)
        {
            int temp = ree1(PHP.Text);
            if (temp >= 0)
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].ownValue.HP = temp;
                if (PHP.Text != temp.ToString())
                {
                    PHP.Text = temp.ToString();
                    gg(PHP);
                }
                upown();

                uppow();
            }
        }

        private void PAtk_TextChanged(object sender, EventArgs e)
        {
            int temp = ree1(PAtk.Text);
            if (temp >= 0)
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].ownValue.Atk = temp;
                if (PAtk.Text != temp.ToString())
                {
                    PAtk.Text = temp.ToString();
                    gg(PAtk);
                }
                upown();

                uppow();
            }
        }

        private void PSpf_TextChanged(object sender, EventArgs e)
        {
            int temp = ree1(PSpf.Text);
            if (temp >= 0)
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].ownValue.Spf = temp;
                if (PSpf.Text != temp.ToString())
                {
                    PSpf.Text = temp.ToString();
                    gg(PSpf);
                }
                upown();

                uppow();
            }
        }

        private void PSpa_TextChanged(object sender, EventArgs e)
        {
            int temp = ree1(PSpa.Text);
            if (temp >= 0)
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].ownValue.Spa = temp;
                if (PSpa.Text != temp.ToString())
                {
                    PSpa.Text = temp.ToString();
                    gg(PSpa);
                }
                upown();

                uppow();
            }
        }

        private void PDef_TextChanged(object sender, EventArgs e)
        {
            int temp = ree1(PDef.Text);
            if (temp >= 0)
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].ownValue.Def = temp;
                if (PDef.Text != temp.ToString())
                {
                    PDef.Text = temp.ToString();
                    gg(PDef);
                }
                upown();

                uppow();
            }
        }

        private void PSpe_TextChanged(object sender, EventArgs e)
        {
            int temp = ree1(PSpe.Text);
            if (temp >= 0)
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].ownValue.Spe = temp;
                if (PSpe.Text != temp.ToString())
                {
                    PSpe.Text = temp.ToString();
                    gg(PSpe);
                }
                upown();
                uppow();

            }

        }

        private void HSpf_TextChanged(object sender, EventArgs e)
        {
            int temp = ree(HSpf.Text);
            if (temp >= 0)
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.Spf = temp;
                if (HSpf.Text != temp.ToString())
                {
                    HSpf.Text = temp.ToString();
                    gg(HSpf);
                }
                uphard();
                uppow();
            }
        }

        private void HDef_TextChanged(object sender, EventArgs e)
        {
            int temp = ree(HDef.Text);
            if (temp >= 0)
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.Def = temp;
                if (HDef.Text != temp.ToString())
                {
                    HDef.Text = temp.ToString();
                    gg(HDef);

                }
                uphard();
                uppow();
            }
        }

        private void HAtk_TextChanged(object sender, EventArgs e)
        {
            int temp = ree(HAtk.Text);
            if (temp >= 0)
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.Atk = temp;
                if (HAtk.Text != temp.ToString())
                {
                    HAtk.Text = temp.ToString();
                    gg(HAtk);
                }
                uphard();
                uppow();
            }

        }

        private void HHP_TextChanged(object sender, EventArgs e)
        {
            int temp = ree(HHP.Text);
            if (temp >= 0)
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.HP = temp;
                if (HHP.Text != temp.ToString())
                {
                    HHP.Text = temp.ToString();
                    gg(HHP);
                }
                uphard();
                uppow();
            }
        }
        private int ree1(string gg)
        {
            if (gg == "")
            {
                return -1;
            }
            int aa = int.Parse(gg);
            if (aa > 31)
            {
                return 31;
            }
            if (aa < 0)
            {
                return 0;
            }
            return int.Parse(gg);
        }

        private int ree(string gg)
        {
            if (gg == "")
            {
                return -1;
            }
            int aa = int.Parse(gg);
            if (aa > 252)
            {
                return 252;
            }
            if (aa < 0)
            {
                return 0;
            }
            return int.Parse(gg);
        }

        private void HSpa_TextChanged(object sender, EventArgs e)
        {
            int temp = ree(HSpa.Text);
            if (temp >= 0)
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.Spa = temp;
                if (HSpa.Text != temp.ToString())
                {
                    HSpa.Text = temp.ToString();
                    gg(HSpa);
                }
                uphard();
            uppow();

            }
        }

        private void HSpe_TextChanged(object sender, EventArgs e)
        {
            int temp = ree(HSpe.Text);
            if (temp >= 0)
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.Spe = temp;
                if (HSpe.Text != temp.ToString())
                {
                    HSpe.Text = temp.ToString();
                    gg(HSpe);
                }
                uphard();
            uppow();

            }
        }

        private void upxinge()
        {
            if (wanttoshow == null) return;
            player[((Pokemen)(pokemens[wanttoshow])).num].sexge = (int)sexgenum[Sex.Text];
            for (int i = 0; i < 6; ++i) title[i].ForeColor = Color.Black;
            if (xingge[(int)sexgenum[Sex.Text]].up == 0)
            {
                rss.Text = "这只宝可梦现在喜欢吃所有的rss果! 稳了";
                return;
            }

            title[xingge[(int)sexgenum[Sex.Text]].up].ForeColor = Color.Red;
            title[xingge[(int)sexgenum[Sex.Text]].down].ForeColor = Color.Blue;

            power[xingge[(int)sexgenum[Sex.Text]].up].Text = ((int)(int.Parse(power[xingge[(int)sexgenum[Sex.Text]].up].Text) * 1.1)).ToString();
            power[xingge[(int)sexgenum[Sex.Text]].down].Text = ((int)(int.Parse(power[xingge[(int)sexgenum[Sex.Text]].down].Text) * 0.9)).ToString();
            rss.Text = "不可食用的rss果:" + rssguo[xingge[(int)sexgenum[Sex.Text]].rss];
        }

        private void Sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            uppow();
            //upxinge();
           
            
        }

        private void level_TextChanged(object sender, EventArgs e)
        {
            if (level.Text == "")
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].level = 0;
                level.Text = "0";
                return;
            }
            try
            {
                int aa = int.Parse(level.Text);
                if (aa > 100)
                {
                    level.Text = "100";
                    player[((Pokemen)(pokemens[wanttoshow])).num].level = 100;
                    return;
                }

                if (aa < 0)
                {
                    player[((Pokemen)(pokemens[wanttoshow])).num].level = 0;
                    level.Text = "0";
                    return;
                }
            }
            catch
            {
                player[((Pokemen)(pokemens[wanttoshow])).num].level = 0;
                level.Text = "0";
                return;
            }
            player[((Pokemen)(pokemens[wanttoshow])).num].level = int.Parse(level.Text);
            uppow();
        }

        private void SD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ZS.Text != "")
                updata();
        }

        private void pokename_TextChanged(object sender, EventArgs e)
        {
            string[] gg = ((string[])zhaoshi[shidai][pokename.Text]);
            StringBuilder ggg = new StringBuilder();
            foreach (string zz in gg)
            {
                if (zz == pokename.Text) continue;
                ggg.AppendFormat("{0}\r\n", zz);
            }
            textBox21.Text = ggg.ToString();
        }

        private void Hsum_TextAlignChanged(object sender, EventArgs e)
        {
            
        }

        private void Hsum_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(Hsum.Text) > 510)
            {
                Hsum.ForeColor = Color.DarkGoldenrod;
            }
            else
            {
                Hsum.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player[((Pokemen)(pokemens[wanttoshow])).num].ownValue.fill();
            uppow();
            upown();
            upxinge();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            player[((Pokemen)(pokemens[wanttoshow])).num].hardlyValue.clear();

            upown();
            uppow();
        }

        private void PSpe_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
            uppow();
        }

        private void PSpe_KeyUp(object sender, KeyEventArgs e)
        {
            //((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
        }

        private void PSpe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void ZSt_Click(object sender, EventArgs e)
        {
            if (ZSnum >= 6) return;
            if (ZS.Text == "") return;
            for (int i = 0; i < ZSnum; ++i)
            {
                if (ZS.Text == zsmin[i].min.Text) return;
            }
            zsmin[ZSnum].min.Text = ZS.Text;
            zsmin[ZSnum].del.Visible = true;
            zsmin[ZSnum].min.Visible = true;
            ZSnum++;

            updata();
        }
        private void CLEAR1()
        {
            for (int i = 0; i < ZSnum; ++i)
            {
                zsmin[i].del.Visible = false;
                zsmin[i].min.Visible = false;
            }
            ZSnum = 0;
            //updata();
        }
        private void CLEAR_Click(object sender, EventArgs e)
        {
            CLEAR1();
            updata();
        }

        private void sortra_CheckedChanged(object sender, EventArgs e)
        {
            updata();
        }

        private void AfterSearch_TextChanged(object sender, EventArgs e)
        {
            if(((ComboBox)sender).Items.Contains(((ComboBox)sender).Text))
            {
                wanttoshow = ((ComboBox)sender).Text;
                updataimage();
                updata6V();
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            // 展示页面

        }

        private void sorttag_SelectedIndexChanged(object sender, EventArgs e)
        {
            updata();
        }

        private void evfield_Click(object sender, EventArgs e)
        {

        }
    }
}

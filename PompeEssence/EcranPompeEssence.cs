using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PompeEssence
{
    public partial class EcranPompeEssence : Form
    {
        public static string valueControle = "";
        Interaction form2 = new Interaction();
        public EcranPompeEssence()
        {
            InitializeComponent();
            if (valueControle == "") {
                PanelCarte.Visible = true;
                Patienter.Visible = false;
                PanelCode.Visible = false;
                PanChoixEs.Visible = false;
                PanelEssence.Visible = false;
                PanPrix.Visible = false;
                PanelBJ.Visible = false;
                panTicket.Visible = false;
            }
            form2.Show();
            form2.clickBtn += Form2_clickBtn;
        }
        
        private void Form2_clickBtn(string touche)
        {
            valueControle = touche;
            if (valueControle == "Inserer carte")
            {
                timer2.Enabled = true;
            }
            if (valueControle == "Sortir la pompe")
            {
                PanelEssence.Visible = false;
                timer1.Enabled = true;
                PanPrix.Visible = true;

            }
            if (valueControle == "Ranger la pompe")
            {
                PanPrix.Visible = false;
                panTicket.Visible = true;
            }
        }

        private void SP95E_Click(object sender, EventArgs e)
        {
            PanelCode.Visible = false;
            PanChoixEs.Visible = true;
            LabEssence.Text = "servez vous en SP-95-E10";
        }

        private void SP95_Click(object sender, EventArgs e)
        {
            PanChoixEs.Visible = false;
            PanelEssence.Visible = true;
            LabEssence.Text = "servez vous en SP-98";
        }

        private void VINDIESEL_Click(object sender, EventArgs e)
        {
            PanChoixEs.Visible = false;
            PanelEssence.Visible = true;
            LabEssence.Text = "servez vous en DIESEL";
        }
        public static float prix = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            prix++;
            labLitre.Text = prix.ToString();
            PrixEs.Text = (prix + (prix/(prix/1.3*prix))).ToString(); 
        }

        public static int temps = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            temps++;
            if (temps == 200)
            {
                Patienter.Visible = false;
                PanelCode.Visible = true;
            }
            else if(temps < 200)
            {
                Patienter.Visible = true;
                PanelCarte.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBCalc.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBCalc.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TBCalc.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TBCalc.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TBCalc.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TBCalc.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TBCalc.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TBCalc.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TBCalc.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TBCalc.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TBCalc.Text += "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panTicket.Visible = false;
            PanelBJ.Visible = true;
            timer3.Enabled = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            panTicket.Visible = false;
            PanelBJ.Visible = true;
            timer3.Enabled = true;
        }
        public static int timerdeux = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            timerdeux++;
            if(timerdeux > 200)
            {
                PanelBJ.Visible = false;
                PanelCarte.Visible = true;
            }
        }
    }
}

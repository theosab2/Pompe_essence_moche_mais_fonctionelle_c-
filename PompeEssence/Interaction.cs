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
    public partial class Interaction : Form
    {
        public delegate void DelegateClickBtn(string touche);
        public event DelegateClickBtn clickBtn;

        public Interaction()
        {
            InitializeComponent();

        }
        public static string valueClick = "";

        private void inserer_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }
        }

        private void LabPompe_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }
        }

        private void LabRanger_Click(object sender, EventArgs e)
        {
            if (clickBtn != null)
            {
                clickBtn(((Button)sender).Text);
            }
        }
    }
}

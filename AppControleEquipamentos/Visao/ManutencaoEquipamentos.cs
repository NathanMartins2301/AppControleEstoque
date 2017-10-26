using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visao
{
    public partial class ManutencaoEquipamentos : Form
    {
        public ManutencaoEquipamentos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Splash vMenu2 = new Splash();
            vMenu2.ShowDialog();
        }
    }
}

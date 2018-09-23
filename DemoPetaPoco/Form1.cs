using DemoPetaPoco.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPetaPoco
{
    public partial class Form1 : Form
    {
        private PetaPoco.Database dbContext = new PetaPoco.Database("DatabaseContext"); // connectionStrings name
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list = dbContext.Query<M01_Item>(string.Empty);

            var list2 = dbContext.Query<M01_Item>($@"select top 3 * from M01_Item");




        }
    }
}

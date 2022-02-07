using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalSalesWin
{   /* 
     1/31/2022
     CSC 153
     Kalie Kirch
     A listbox Windows form to calculate total sales 
    */
    public partial class Form1 : Form
    {
        decimal[] sales = { 1245.67m, 1189.55m, 1098.72m, 1456.88m, 2109.34m, 1987.55m, 1872.36m };
        decimal total = 0;
        public Form1()
        {
            InitializeComponent();
            totalSalesArray.Items.Clear();
            foreach (decimal sale in sales)
            {
                totalSalesArray.Items.Add(sale.ToString("C"));
                total += sale;

            }
            totalSumOfSales.Text = total.ToString("C");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

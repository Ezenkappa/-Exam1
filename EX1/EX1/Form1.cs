using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form : System.Windows.Forms.Form
    {
        int sum;
        Menu steak, omelette, lemoneggjuice, bubbletea;
        String Order, desk, personName;

        public Form()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Menu1_Click(object sender, EventArgs e)
        {
                sum += steak.Price;
                Order += steak.MenuName + "\r\n";
        }
        private void Menu1_CheckedChanged(object sender, EventArgs e)
        {
            if (Menu1.Checked)
            {
                sum += steak.Price;
                Order += steak.MenuName + "\r\n";
            }
            else
            {
                sum -= steak.Price;
                Order = Order.Replace(steak.MenuName + "\r\n", "");
            }
        }
        private void Menu2_CheckedChanged(object sender, EventArgs e)
        {
            if (Menu2.Checked)
            {
                sum += omelette.Price;
                Order += omelette.MenuName + "\r\n";
            }
            else
            {
                sum -= omelette.Price;
                Order = Order.Replace(omelette.MenuName + "\r\n", "");
            }
        }

        

        private void Menu3_CheckedChanged(object sender, EventArgs e)
        {
            if (Menu3.Checked)
            {
                sum += lemoneggjuice.Price;
                Order += lemoneggjuice.MenuName +"\r\n";
            }
            else
            {
                sum -= lemoneggjuice.Price;
                Order = Order.Replace(lemoneggjuice.MenuName + "\r\n", "");
            }
        }
        private void Menu4_CheckedChanged(object sender, EventArgs e)
        {
            if (Menu4.Checked)
            {
                sum += bubbletea.Price;
                Order += bubbletea.MenuName + "\r\n";
            }
            else
            {
                sum -= bubbletea.Price;
                Order = Order.Replace(bubbletea.MenuName + "\r\n", "");
            }
        } 
        private void checkbutton_Click(object sender, EventArgs e)
        {   
            desk = Desk.Text;
            personName = PersonName.Text;
            steak = new Menu(Menu1.Text, Convert.ToInt32(Price1.Text));
            omelette = new Menu(Menu2.Text, Convert.ToInt32(Price2.Text));
            lemoneggjuice = new Menu(Menu3.Text, Convert.ToInt32(Price3.Text));
            bubbletea = new Menu(Menu4.Text, Convert.ToInt32(Price4.Text));

            Desk.Enabled = false;
            PersonName.Enabled = false;

            MessageBox.Show("歡迎光臨");

            Menu1.Enabled = true;
            Menu2.Enabled = true;
            Menu3.Enabled = true;
            Menu4.Enabled = true;
            submitButton.Enabled = true;
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("第" + desk +  "桌的客人:" + personName +   "\r\n點了" + Order +  "總共:" + Convert.ToString(sum)+ "元");
        }
    }
}

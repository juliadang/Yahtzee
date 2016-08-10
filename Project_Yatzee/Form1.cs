using Project_Yatzee.GameLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Project_Yatzee
{
    public partial class Form1 : Form
    {
        public int counter;
        //public List<DiceButton> myButtons = new List<DiceButton>();
        public List<System.Windows.Forms.Button> buttonList = new List<System.Windows.Forms.Button>();

        public Form1()
        {
            InitializeComponent();
            CreateButtonList();
        }

        public void CreateButtonList()
        {
            //DiceButton button1 = new DiceButton();
            //button1.Value = Convert.ToInt32(buttonDice1.Text);
            buttonList.Add(buttonDice1);
            buttonList.Add(buttonDice2);
            buttonList.Add(buttonDice3);
            buttonList.Add(buttonDice4);
            buttonList.Add(buttonDice5);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter < 4)
                RollDice();
            else
                MessageBox.Show("No more throws");
        }

        private void RollDice()
        {
            Random rnd = new Random();
            int result;
            foreach (var button in buttonList)
            {
                //if (!checkBox1.Checked)
                //{
                //}
                result = rnd.Next(1, 7);
                Dice dice = new Dice();
                button.Text = result.ToString();
            }
        }

        private void buttonDice1_Click(object sender, EventArgs e)
        {
            CheckIfButtonClicked();
        }

        private static void CheckIfButtonClicked()
        {
        }

        private void buttonDice1_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}

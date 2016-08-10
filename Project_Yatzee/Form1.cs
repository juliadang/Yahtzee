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
        public List<DiceButton> buttonList = new List<DiceButton>();
        List<System.Windows.Forms.CheckBox> checkboxList = new List<System.Windows.Forms.CheckBox>();

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
        public void CreateCheckboxList()
        {
            checkboxList.Add(checkBox1);
            checkboxList.Add(checkBox2);
            checkboxList.Add(checkBox3);
            checkboxList.Add(checkBox4);
            checkboxList.Add(checkBox5);
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
                if (!button.HoldState)
                {
                    result = rnd.Next(1, 7);
                    Dice dice = new Dice();
                    button.Text = result.ToString();
                }


            }

        }



        private void buttonDice_Click(object sender, EventArgs e)
        {
            DiceButton diceButton = sender as DiceButton;
            diceButton.HoldState = !diceButton.HoldState;
        }


        private void buttonDice1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if(checkBox1.Checked)
            //{
            //    DiceButton dice = new DiceButton();
            //    dice.HoldState = true;
            //    //RollDice();
            //}

            //this.Controls

        }

        private void buttonDice2_Click(object sender, EventArgs e)
        {

        }
    }
}

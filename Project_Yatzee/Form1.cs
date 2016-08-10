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
        CalculateScore score = new CalculateScore();

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

            foreach (var button in buttonList)
            {
                if (!button.HoldState)
                {
                    button.Value = rnd.Next(1, 7);
                    Dice dice = new Dice();
                    button.Text = button.Value.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if ((counter > 0) && (tableLayoutPanel1.Controls[0].Text == ""))
            {
                int displayScore = score.AddUpDice(1, buttonList);
                tableLayoutPanel1.Controls[0].Text = displayScore.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TextBox Text1 = new TextBox();
            //tableLayoutPanel1.Controls.Add(Text1, 0, 0);

            //TextBox TB = sender as TextBox;
            //int index = this.tableLayoutPanel1.Controls.GetChildIndex(TB);

            int rowIndex = 0;
            int columnIndex = 0;
            for (int i = 0; i < 18; i++)
            {
                TextBox Text = new TextBox();
                Text.Name = "text+" + i + 1;
                //Text.TextChanged += new System.EventHandler(this.TB_TextChanged);
                if (i % 2 == 0 && i > 0)
                    rowIndex++;
                if (i % 2 != 0 && i > 0)
                    columnIndex++;
                else
                    columnIndex = 0;
                this.tableLayoutPanel1.Controls.Add(Text, columnIndex, rowIndex);
            }
        }
    }
}

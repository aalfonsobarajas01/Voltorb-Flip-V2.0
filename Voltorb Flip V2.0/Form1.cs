namespace Voltorb_Flip_V2._0
{
    public partial class Form1 : Form
    {

        GameSetup setup = new GameSetup();
        GamePlay gamePlay = new GamePlay();

        public Form1()
        {

            InitializeComponent();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            ClearBoard();

        }

        private void ClearBoard()
        {

            //currentTotal = 0;
            //lblScore.Text = currentTotal.ToString();
            this.pnlButtons.Controls.Clear();
            this.pnlBottom.Controls.Clear();
            this.pnlRight.Controls.Clear();

            gamePlay.ResetTotal();
            lblScore.Text = "0";

            RunSetup();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

               ClearBoard();

        }

        public void pnlButtonClick(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;

            if (gamePlay.RevealResult(clickedButton))
            {

                MessageBox.Show("BZZT! You hit a Voltorb! Game Over! You got " + gamePlay.GetTotal() + " points!");
                ClearBoard();

            }
            else
            {
              
                lblScore.Text = gamePlay.GetTotal().ToString();
                if(gamePlay.CheckVictory(setup.GetVoltorbTotal()))
                {

                    MessageBox.Show("You won with a total of " + gamePlay.GetTotal());
                    ClearBoard();

                }


            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void AddClickEvent (ref Button[,] bA)
        {

            foreach (Button b in bA)
            {

                b.Click += new EventHandler(pnlButtonClick);

            }

        }

        private void RunSetup()
        {

            setup.BoardSetup(pnlButtons, pnlBottom, pnlRight);

            AddClickEvent(ref setup._gameButtons);

        }

        private void btnThanks_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Special thanks to Butterfree/Dragonfree/antialiasis for use of their guide.");

        }
    }
}
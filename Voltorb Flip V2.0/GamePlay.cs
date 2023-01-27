using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voltorb_Flip_V2._0
{
    internal class GamePlay
    {

        private int _currentTotal = 0;
        private int _timesClicked = 0;

        public GamePlay() 
        {
        
        
        }

        public bool RevealResult(Button b)
        {

            bool gameOver = false;

            if (b.Tag == "0")
            {

                b.Text = "0";
                gameOver = true;

            }
            else
            {

                AddPoint(b);

                _timesClicked++;


            }

            return gameOver;

        }

        private void AddPoint(Button b)
        {

            if (b.Text == "?")
            {

                b.Text = b.Tag.ToString();

                _currentTotal += Convert.ToInt32(b.Tag);

            }

        }

        public int GetTotal()
        {

            return _currentTotal;

        }

        public bool CheckVictory(int voltorbs)
        {

            bool gameWon = false;

            int totalButtons = 25;
            int nonVoltorbs = totalButtons - voltorbs;
            

            if (_timesClicked == nonVoltorbs)
            {

                gameWon = true;

            }

            return gameWon;

        }

        public void ResetTotal()
        {

            _currentTotal = 0;

        }

    }
}

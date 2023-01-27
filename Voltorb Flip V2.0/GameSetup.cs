using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Voltorb_Flip_V2._0
{
    internal class GameSetup
    {

        public Button[,] _gameButtons = new Button[5, 5];

        private Label[] _colPoints = new Label[5];
        private Label[] _colVoltorbs = new Label[5];
        private PictureBox[] _colVoltorbPic = new PictureBox[5];

        private Label[] _rowPoints = new Label[5];
        private Label[] _rowVoltorbs = new Label[5];
        private PictureBox[] _rowVoltorbPic = new PictureBox[5];

        private int[,] _rngResults = new int[5, 5];
        private int[] _rowPointTotal = new int[5];
        private int[] _rowVoltorbTotal = new int[5];
        private int[] _colPointTotal = new int[5];
        private int[] _colVoltorbTotal = new int[5];

        private int _totalVoltorbs = 0;

        public GameSetup()
        {


        }

        public void BoardSetup(Panel pnlButton, Panel pnlBottom, Panel pnlRight)
        {

            _totalVoltorbs = 0;
            OnReset();
            RNG();
            CalculateTotals();
            CreateButtons(pnlButton);
            BottomPanel(pnlBottom);
            RightPanel(pnlRight);    

        }

        private void CreateButtons(Panel pnlButton)
        {

            int xPos = 0;
            int yPos = 0;

            int buttonSize = 80;

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5; j++)
                {

                    //creates instances of buttons and adds to panel
                    _gameButtons[i, j] = new Button();
                    pnlButton.Controls.Add(_gameButtons[i, j]);

                    //Button size and position
                    _gameButtons[i, j].Height = buttonSize;
                    _gameButtons[i, j].Width = buttonSize;
                    _gameButtons[i,j].Left = xPos;
                    _gameButtons[i,j].Top = yPos;


                    //Make some changes 1 


                    _gameButtons[i, j].Text = "?";
                    _gameButtons[i, j].Font = new Font("Segoe UI", 15);

                    //Left position moves to next button's position, based on button size
                    xPos += buttonSize;

                    //gives button a tag based on the identical position in RNG array
                    _gameButtons[i, j].Tag = _rngResults[i,j].ToString();

                }

                //resetting xPos to 0 for next line 
                xPos = 0;

                yPos += buttonSize;

            }

        }

        private void BottomPanel(Panel pnlBottom)
        {
            int colPointXPos = 35;

            int colVoltorbXPos = 35;
            int colVoltorbYPos = 20;

            int colVoltorbPicXPos = 55;
            int colVoltorbPicYPos = 20;

            for (int i = 0; i < 5; i++)
            {

                //create the labels which will show the points in columns
                _colPoints[i] = new Label();
                pnlBottom.Controls.Add(_colPoints[i]);
                _colPoints[i].Width = 20;
                _colPoints[i].Text = _colPointTotal[i].ToString();
                _colPoints[i].Left = colPointXPos;
                colPointXPos += 80;

                //create the labels which will show the voltorb amounts in columns
                _colVoltorbs[i] = new Label();
                pnlBottom.Controls.Add(_colVoltorbs[i]);
                _colVoltorbs[i].Width = 20;
                _colVoltorbs[i].Text = _colVoltorbTotal[i].ToString();
                _colVoltorbs[i].Top = colVoltorbYPos;
                _colVoltorbs[i].Left = colVoltorbXPos;
                colVoltorbXPos += 80;

                //creates the voltorb photos for columns
                _colVoltorbPic[i] = new PictureBox();
                _colVoltorbPic[i].SizeMode = PictureBoxSizeMode.Zoom;
                pnlBottom.Controls.Add(_colVoltorbPic[i]);
                _colVoltorbPic[i].Height = 20;
                _colVoltorbPic[i].Width = 20;
                _colVoltorbPic[i].Image = Image.FromFile("Voltorb.gif");
                _colVoltorbPic[i].Top = colVoltorbPicYPos;
                _colVoltorbPic[i].Left = colVoltorbPicXPos;
                colVoltorbPicXPos += 80;


            }

        }

        private void RightPanel(Panel pnlRight)
        {

            int rowPointYPos = 35;

            int rowVoltorbXPos = 0;
            int rowVoltorbYPos = 55;

            int rowVoltorbPicXPos = 20;
            int rowVoltorbPicYPos = 55;

            for (int i = 0; i < 5; i++)
            {

                //create the labels which will show the points in rows
                _rowPoints[i] = new Label();
                pnlRight.Controls.Add(_rowPoints[i]);
                _rowPoints[i].Height = 20;
                _rowPoints[i].Text = _rowPointTotal[i].ToString();
                _rowPoints[i].Top = rowPointYPos;
                rowPointYPos += 80;

                //create the labels which will show the voltorb amounts in rows
                _rowVoltorbs[i] = new Label();
                pnlRight.Controls.Add(_rowVoltorbs[i]);
                _rowVoltorbs[i].Height = 20;
                _rowVoltorbs[i].Width = 20;
                _rowVoltorbs[i].Text = _rowVoltorbTotal[i].ToString();
                _rowVoltorbs[i].Top = rowVoltorbYPos;
                _rowVoltorbs[i].Left = rowVoltorbXPos;
                rowVoltorbYPos += 80;

                //creates the voltorb photos for rows
                _rowVoltorbPic[i] = new PictureBox();
                _rowVoltorbPic[i].SizeMode = PictureBoxSizeMode.Zoom;
                pnlRight.Controls.Add(_rowVoltorbPic[i]);
                _rowVoltorbPic[i].Height = 20;
                _rowVoltorbPic[i].Width = 20;
                _rowVoltorbPic[i].Image = Image.FromFile("Voltorb.gif");
                _rowVoltorbPic[i].Top = rowVoltorbPicYPos;
                _rowVoltorbPic[i].Left = rowVoltorbPicXPos;
                rowVoltorbPicYPos += 80;


            }


        }

        private void RNG ()
        {

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5; j++)
                {

                    _rngResults[i, j] = rnd.Next(4);

                }

            }

        }

        private void CalculateTotals ()
        {

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5 ; j++)
                {

                    _rowPointTotal[i] += _rngResults[i, j];

                    _colPointTotal[i] += _rngResults[j, i];

                    if (_rngResults[i,j] == 0)
                    {

                        _rowVoltorbTotal[i]++;
                        _totalVoltorbs++;

                    }

                    if (_rngResults[j,i] == 0)
                    {

                        _colVoltorbTotal[i]++;

                    }

                }

            }


        }

        private void OnReset()
        {

            for (int i = 0; i < 5; i++)
            {

                _rowPointTotal[i] = 0;
                _colPointTotal[i] = 0;
                _rowVoltorbTotal[i] = 0;
                _colVoltorbTotal[i] = 0;

            }


        }

        public int GetVoltorbTotal ()
        {

            return _totalVoltorbs;

        }

    }
}

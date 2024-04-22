using System;
using System.Drawing;
using System.Windows.Forms;

namespace RaceKart
{
    public partial class Form1 : Form
    {
        private int GameSpeed = 20;
        private const int CarSpeed = 10;
        private int _trackW, _trackH;
        private readonly PictureBox[] _lines;
        private readonly Random _random = new Random();
        private int _myCoins;
        private int _numCoinsCollected = 0;


        public int MyCoins
        {
            get { return _myCoins; }
            set
            {
                _myCoins = value;
                lblCoins.Text = "Coins: " + _myCoins;
            }
        }
        public Point PbCoin1Location
        {
            get { return pbCoin1.Location; }
            set { pbCoin1.Location = value; }
        }
        public Point PbCoin2Location
        {
            get { return pbCoin2.Location; }
            set { pbCoin2.Location = value; }
        }

        public Form1()
        {
            InitializeComponent();
            _lines = new[] { line1, line2, line3, line4 };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveTrack();
            MoveCoins();
            CoinsCollect();
        }

        private void MoveCoins()
        {
            MoveCoin(pbCoin1);
            MoveCoin(pbCoin2);
        }

        private void CoinsCollect()
        {
            if (pbCar.Bounds.IntersectsWith(pbCoin1.Bounds))
            {
                PbCoin1Location = new Point(_random.Next(0, _trackW - pbCoin1.Width), 0);
                MyCoins++;
                _numCoinsCollected++;
            }
            if (pbCar.Bounds.IntersectsWith(pbCoin2.Bounds))
            {
                PbCoin2Location = new Point(_random.Next(0, _trackW - pbCoin2.Width), 0);
                MyCoins++;
                _numCoinsCollected++;
            }
            if (_numCoinsCollected == 10)
            {
                timer1.Stop();
                MessageBox.Show("Congratulations! You have achieved your goal.");
            }
        }

        private void MoveCoin(PictureBox coin)
        {
            coin.Top += GameSpeed;
            if (coin.Top > _trackH)
            {
                coin.Location = new Point(_random.Next(0, _trackW - coin.Width), 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _trackH = Bounds.Height;
            _trackW = Bounds.Width;
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (_numCoinsCollected < 10)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        if (pbCar.Left > lineL.Right) // check if the car is to the right of LineL
                        {
                            pbCar.Left -= CarSpeed;
                        }
                        break;
                    case Keys.Right:
                        if (pbCar.Right < lineR.Left) // check if the car is to the left of LineR
                        {
                            pbCar.Left += CarSpeed;
                        }
                        break;
                    case Keys.Up:
                        if (pbCar.Top > 0) // check if the car is not at the top edge of the track
                        {
                            pbCar.Top -= CarSpeed;
                        }
                        break;
                    case Keys.Down:
                        if (pbCar.Bottom < _trackH) // check if the car is not at the bottom edge of the track
                        {
                            pbCar.Top += CarSpeed;
                        }
                        break;
                    case Keys.PageUp:
                        GameSpeed += 5; // increase the speed by 5
                        if (GameSpeed > 50) GameSpeed = 50; // limit the speed to 50
                        break;
                    case Keys.PageDown:
                        GameSpeed -= 5; // decrease the speed by 5
                        if (GameSpeed < 0) GameSpeed = 0; // stop the game if the speed becomes negative
                        break;
                }
            }
        }
        private void MoveTrack()
        {
            foreach (var line in _lines)
            {
                line.Top += GameSpeed;
                if (line.Top > _trackH)
                {
                    line.Top = 0;
                }
            }
            if (pbCar.Top < 0) // check if the car is above the top edge of the track
            {
                pbCar.Top = 0;
            }
            else if (pbCar.Bottom > _trackH) // check if the car is below the bottom edge of the track
            {
                pbCar.Top = _trackH - pbCar.Height;
            }
        }
    }
}


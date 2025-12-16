namespace newTask
{
    public partial class Form1 : Form
    {
        Button firstButton = null;
        Button secondButton = null;
        bool player1Turn = true;
        int score1 = 0;
        int score2 = 0;

        List<Color> colorList = new List<Color>()
        {
            Color.Red, Color.Red,
            Color.Green, Color.Green,
            Color.Blue, Color.Blue,
            Color.Yellow, Color.Yellow,
        };
        public Form1()
        {
            InitializeComponent();
            OyunuBaslat();
        }
        void OyunuBaslat()
        {
            Random r = new Random();
            colorList = colorList.OrderBy(x => r.Next()).ToList();

            Button[] buttons =
            {
                btn0, btn1, btn2, btn3,
                btn4, btn5, btn6, btn7
            };

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor = Color.White;
                buttons[i].Tag = colorList[i];
                buttons[i].Enabled = true;
            }
            firstButton = null;
            secondButton = null;

            lblTurn.Text = "Növbə: Oyunçu 1";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            score1 = 0;
            score2 = 0;
            lblScore1.Text = "Oyunçu 1 : 0";
            lblScore2.Text = "Oyunçu 2 : 0";
            player1Turn = true;
            OyunuBaslat();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            if (clicked == null)
            {
                return;
            }
            if (clicked.BackColor != Color.White)
            {
                return;
            }

            if(firstButton == clicked)
            { 
                return;
            }
            clicked.BackColor = (Color)clicked.Tag;
            if(firstButton == null)
            {
                firstButton = clicked;
                return;
            }
            secondButton = clicked;
            if (firstButton.Tag.Equals(secondButton.Tag))
            {
                timer1.Stop();
                firstButton.Enabled = false;
                secondButton.Enabled = false;

                if (player1Turn)
                {
                    score1++;
                    lblScore1.Text = "Oyunçu 1 : " + score1;
                }
                else
                {
                    score2++;
                    lblScore2.Text = "Oyunçu 2 : " + score2;
                }

                firstButton = null;
                secondButton = null;
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                        c.Enabled = true;
                }
                OyunuYoxla();
                lblTurn.Text = player1Turn ? "Növbə: Oyunçu 1" : "Növbə: Oyunçu 2";
            }
            else
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Button && c != btnReset && c!= btnClose)
                        c.Enabled = false;
                }
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstButton.BackColor = Color.White;
            secondButton.BackColor = Color.White;

            foreach (Control c in this.Controls)
            {
                if(c is Button)
                    c.Enabled = true;
            }
            firstButton = null;
            secondButton = null;
            player1Turn = !player1Turn;
            lblTurn.Text = player1Turn ? "Növbə: Oyunçu 1" : "Növbə: Oyunçu 2";
        }

        void OyunuYoxla()
        {
            if (score1 + score2 == 4) 
            {
                if (score1 > score2)
                {
                    MessageBox.Show("Qalib: Oyunçu 1 🏆");
                }
                else if (score2 > score1)
                {
                    MessageBox.Show("Qalib: Oyunçu 2 🏆");
                }
                else
                {
                    MessageBox.Show("Bərabərlik 🤝");
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

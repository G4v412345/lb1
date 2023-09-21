using System.Windows.Markup;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        CEmblem[] cemblem;
        int emblemcount = 0;
        int currentemblemindex;
        public Form1()
        {
            InitializeComponent();
            cemblem = new CEmblem[100];
        }
        class CEmblem
        {
            const int defrad = 50;
            private Graphics graphics;
            private int _radius;
            public int X { get; set; }
            public int Y { get; set; }
            public int Radius
            {
                get
                {
                    return _radius;
                }
                set
                {
                    _radius = value >= 200 ? 200 : value;
                    _radius = value <= 5 ? 5 : value;
                }
            }
            public CEmblem(Graphics graphics, int X, int Y)
            {
                this.graphics = graphics;
                this.X = X;
                this.Y = Y;
                this.Radius = defrad;
            }
            public CEmblem(Graphics graphics, int X, int Y, int Radius)
            {
                this.graphics = graphics;
                this.X = X;
                this.Y = Y;
                this.Radius = Radius;
            }
            private void DrawShape(Pen pen)
            {

                Point p1 = new Point(X, Y-Radius);
                Point p2 = new Point(X - Radius, Y + Radius*-3);
                Point p3 = new Point(X + Radius, Y + Radius*-3);

                Point[] trianglePoints = { p1, p2, p3 };
                 
                graphics.DrawPolygon(pen, trianglePoints);


                Rectangle circle = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
                graphics.DrawEllipse(pen, circle);


                Rectangle square = new Rectangle(X - Radius, Y + Radius, 2 * Radius, 2 * Radius);
                graphics.DrawRectangle(pen, square);
            }

            public void Show()
            {
                DrawShape(Pens.Red);
            }

            public void Hide()
            {
                DrawShape(Pens.White);
            }

            public void Expand()
            {
                Hide();
                Radius++;
                Show();
            }

            public void Expand(int dR)
            {
                Hide();
                Radius = Radius + dR;
                Show();
            }

            public void Collapse()
            {
                Hide();
                Radius--;
                Show();
            }

            public void Collapse(int dR)
            {
                Hide();
                Radius = Radius - dR;
                Show();
            }

            public void Move(int dX, int dY)
            {
                Hide();
                X = X + dX;
                Y = Y + dY;
                Show();
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentemblemindex = cbEmblem.SelectedIndex;
            if ((currentemblemindex > emblemcount) || (currentemblemindex < 0))
            {
                return;
            }
            cemblem[currentemblemindex].Move(10, 0);
        }

        private void pnTools_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (emblemcount >= 99)
            {
                MessageBox.Show("Лiмит емблем");
                return; 
            }
            Graphics graphics = pnName.CreateGraphics();
            currentemblemindex = emblemcount;
            cemblem[currentemblemindex] = new CEmblem(graphics, pnName.Width / 2, pnName.Height / 2, 50);
            cemblem[currentemblemindex].Show();
            emblemcount++;
            cbEmblem.Items.Add("Емблема №" + (emblemcount - 1).ToString());
            cbEmblem.SelectedIndex = emblemcount - 1;
        }

        private void cbEmblem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            currentemblemindex = cbEmblem.SelectedIndex;
            if ((currentemblemindex > emblemcount) || (currentemblemindex < 0))
            {
                return;
            }
            cemblem[currentemblemindex].Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            currentemblemindex = cbEmblem.SelectedIndex;
            if ((currentemblemindex > emblemcount) || (currentemblemindex < 0))
            {
                return;
            }
            cemblem[currentemblemindex].Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentemblemindex = cbEmblem.SelectedIndex;
            if ((currentemblemindex > emblemcount) || (currentemblemindex < 0))
            {
                return;
            }
            cemblem[currentemblemindex].Expand(5);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            currentemblemindex = cbEmblem.SelectedIndex;
            if ((currentemblemindex > emblemcount) || (currentemblemindex < 0))
            {
                return;
            }
            cemblem[currentemblemindex].Collapse(5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentemblemindex = cbEmblem.SelectedIndex;
            if ((currentemblemindex > emblemcount) || (currentemblemindex < 0))
            {
                return;
            }
            cemblem[currentemblemindex].Move(0, -10);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentemblemindex = cbEmblem.SelectedIndex;
            if ((currentemblemindex > emblemcount) || (currentemblemindex < 0))
            {
                return;
            }
            cemblem[currentemblemindex].Move(0, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentemblemindex = cbEmblem.SelectedIndex;
            if ((currentemblemindex > emblemcount) || (currentemblemindex < 0))
            {
                return;
            }
            cemblem[currentemblemindex].Move(-10, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentemblemindex = cbEmblem.SelectedIndex;
            if ((currentemblemindex > emblemcount) || (currentemblemindex < 0))
            {
                return;
            }
            for (int i = 0; i < 100; i++)
            {
                cemblem[currentemblemindex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentemblemindex = cbEmblem.SelectedIndex;
            if ((currentemblemindex > emblemcount) || (currentemblemindex < 0))
            {
                return;
            }
            for (int i = 0; i < 100; i++)
            {
                cemblem[currentemblemindex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentemblemindex = cbEmblem.SelectedIndex;
            if ((currentemblemindex > emblemcount) || (currentemblemindex < 0))
            {
                return;
            }
            for (int i = 0; i < 100; i++)
            {
                cemblem[currentemblemindex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentemblemindex = cbEmblem.SelectedIndex;
            if ((currentemblemindex > emblemcount) || (currentemblemindex < 0))
            {
                return;
            }
            for (int i = 0; i < 100; i++)
            {
                cemblem[currentemblemindex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }
    }
}
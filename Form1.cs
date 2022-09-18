namespace VGE
{
    public partial class MainForm : Form
    {
        Dictionary<string, Creators.Creator> creators;
        List<Figures.Figure> figures;
        Graphics g;
        Bitmap bmp;
        string creator;
        Point startPoint = new Point(-1, -1);
        public MainForm()
        {
            InitializeComponent();
            figures = new List<Figures.Figure>();
            creators = new Dictionary<string, Creators.Creator>();
            creators.Add("Rect", new Creators.RectCreator());
            creators.Add("Ellipse", new Creators.EllipseCreator());
            creator = "Rect";

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            Figures.Figure fig = new Figures.Rect(10, 10, 10, 10);
            fig.Draw(g);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (startPoint.X == -1)
            {
                startPoint = new Point(me.Location.X, me.Location.Y);
                return;
            }
            pictureBox.Image = bmp;

            Point beginPoint = new Point(startPoint.X, startPoint.Y);
            Point endPoint = new Point(me.Location.X, me.Location.Y);
            if (me.Location.X - startPoint.X < 0)
            {
                endPoint.X = startPoint.X;
                beginPoint.X = me.Location.X;
            }
            if (me.Location.Y - startPoint.Y < 0)
            {
                endPoint.Y = startPoint.Y;
                beginPoint.Y = me.Location.Y;
            }
            Figures.Figure new_figure = creators[creator].Create(beginPoint.X, beginPoint.Y,
                endPoint.X - beginPoint.X, endPoint.Y - beginPoint.Y);
            figures.Add(new_figure);

            label2.Text = $"x = {figures[figures.Count() - 1].X}, y = {figures[figures.Count() - 1].Y}";
            label3.Text = $"x = {me.Location.X}, y = {me.Location.Y}";
            startPoint.X = -1;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figures.Figure f in figures)
            {
                f.Draw(g);
            }
        }

        private void buttonChooseRect_Click(object sender, EventArgs e)
        {
            creator = "Rect";
            buttonChooseRect.BackColor = Color.Gray;
            buttonChooseEllipse.BackColor = Color.White;
        }

        private void buttonChooseEllipse_Click(object sender, EventArgs e)
        {
            creator = "Ellipse";
            buttonChooseRect.BackColor = Color.White;
            buttonChooseEllipse.BackColor = Color.Gray;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPoint.X != -1)
            {
                Bitmap tmpBmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(tmpBmp);
                foreach (Figures.Figure f in figures)
                {
                    f.Draw(g);
                }
                Point beginPoint = new Point(startPoint.X, startPoint.Y);
                Point endPoint = new Point(e.Location.X, e.Location.Y);
                if (e.Location.X - startPoint.X < 0)
                {
                    endPoint.X = startPoint.X;
                    beginPoint.X = e.Location.X;
                }
                if (e.Location.Y - startPoint.Y < 0)
                {
                    endPoint.Y = startPoint.Y;
                    beginPoint.Y = e.Location.Y;
                }
                Figures.Figure tmp = creators[creator].Create(beginPoint.X, beginPoint.Y,
                endPoint.X - beginPoint.X, endPoint.Y - beginPoint.Y);
                tmp.Draw(g);
                pictureBox1.Image = tmpBmp;
                pictureBox1.Refresh();
                tmpBmp.Dispose();
                GC.Collect();
            }
            //else
            //{
            //    pictureBox1.Image = bmp;
            //}
        }
    }
}
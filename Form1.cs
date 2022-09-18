namespace VGE
{
    public partial class MainForm : Form
    {
        Dictionary<string, Creators.Creator> creators;
        List<Button> buttons;
        List<Figures.Figure> figures;
        Graphics g;
        Bitmap bmp;
        string creator;

        public MainForm()
        {
            InitializeComponent();

            initLogic();

            initGraphics();
        }

        private void initLogic()
        {
            buttons = new List<Button>();
            creators = new Dictionary<string, Creators.Creator>();
            creators.Add("Rect", new Creators.RectCreator());
            creators.Add("Ellipse", new Creators.EllipseCreator());
            creator = "Rect";

            byte i = 0;
            foreach (KeyValuePair<string, Creators.Creator> item in creators)
            {
                initButton(item.Key, ++i, clickEventFiller);
            }
            initButton("Select", ++i, selectEvent);
        }

        private void initButton(string name, byte i, MouseEventHandler f)
        {
            buttons.Add(new Button());
            buttons[buttons.Count() - 1].Text = name;
            buttons[buttons.Count() - 1].Location = new Point(i * 100 + 20, 50);
            buttons[buttons.Count() - 1].MouseClick += f;
            flowLayoutPanel1.Controls.Add(buttons[buttons.Count() - 1]);
        }

        private void selectEvent(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            creator = "Select";
            // Переход в режим выбора фигуры
            // Или выбор последней созданной фигуры
            accentButton(button);
        }

        private void clickEventFiller(object? sender, EventArgs e)
        {
            Button? button = (Button?)sender;
            creator = button.Text;
            accentButton(button);
        }

        private void accentButton(Button button)
        {
            foreach (Button btn in buttons)
            {
                btn.BackColor = Color.White;
            }
            button.BackColor = Color.Gray;
        }

        private void initGraphics()
        {
            figures = new List<Figures.Figure>();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            Figures.Figure new_figure = creators[creator].Create(me.Location.X, me.Location.Y, 20f, 20f);
            figures.Add(new_figure);
            pictureBox1.Refresh();
            pictureBox1.Refresh();

            label2.Text = $"x = {figures[figures.Count() - 1].X}, y = {figures[figures.Count() - 1].Y}";
            label3.Text = $"x = {me.Location.X}, y = {me.Location.Y}";
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figures.Figure f in figures)
            {
                f.Draw(g);
            }
        }
    }
}
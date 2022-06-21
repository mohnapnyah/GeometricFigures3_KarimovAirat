using System;

namespace GF3
{
    public partial class FigureForm : Form
    {
        Graphics graphics;
        Figures image = new Figures();
        string selectedFigure = "";
        Color brushColor = Color.White;
        Color penColor = Color.Black;
        public int x1, y1, x2, y2, x3, y3, Mouse_click = 0;

        public FigureForm()
        {
            InitializeComponent();
        }

        private void ChoiceColor(Button textBox)
        {
            if (colorDialogFigure.ShowDialog() == DialogResult.Cancel)
                return;
            textBox.BackColor = colorDialogFigure.Color;
        }

        public void Figure_Load(object sender, EventArgs e)
        {
            graphics = Ñanvas.CreateGraphics();
        }

        private void Ñanvas_MouseClick(object sender, MouseEventArgs e)
        {
            switch (selectedFigure)
            {
                case "Circle":

                    if (Mouse_click % 2 == 0)
                    {
                        x1 = e.X;
                        y1 = e.Y;
                    }
                    else if (Mouse_click % 2 == 1)
                    {
                        x2 = e.X;
                        y2 = e.Y;
                        int sx = Math.Min(x1, x2);
                        int sy = Math.Min(y1, y2);
                        int bx = Math.Max(x1, x2);
                        int by = Math.Max(y1, y2);
                        double katet1 = Math.Pow(bx - sx, 2);
                        double katet2 = Math.Pow(by - sy, 2);
                        int radius = (int)Math.Sqrt(katet1 + katet2);
                        image.Add(new Circle(new Point(x1-radius, y1-radius), radius, new Pen(penColor, ScrollB.Value)));
                        image.Draw(graphics);
                    }
                    break;

                case "Line":

                    if (Mouse_click % 2 == 0)
                    {
                        x1 = e.X;
                        y1 = e.Y;
                    }
                    else if (Mouse_click % 2 == 1)
                    {
                        x2 = e.X;
                        y2 = e.Y;

                        image.Add(new Line(new Point(x1, y1), new Point(x2, y2), new Pen(penColor, ScrollB.Value)));
                        image.Draw(graphics);
                    }
                    break;

                case "Rectangle":

                    if (Mouse_click % 2 == 0)
                    {
                        x1 = e.X;
                        y1 = e.Y;
                    }
                    else if (Mouse_click % 2 == 1)
                    {
                        x2 = e.X;
                        y2 = e.Y;
                        int sx = Math.Min(x1, x2);
                        int sy = Math.Min(y1, y2);
                        int bx = Math.Max(x1, x2);
                        int by = Math.Max(y1, y2);
                        int width = bx - sx;
                        int basasdd = by - sy;

                        image.Add(new GF3.Rectangle(new Point(sx, sy), basasdd, width,  new Pen(penColor, ScrollB.Value)));
                        image.Draw(graphics);
                    }
                    break;


                case "Triangle":
                    if (Mouse_click % 3 == 0)
                    {
                        x1 = e.X;
                        y1 = e.Y;
                    }
                    else if (Mouse_click % 3 == 1)
                    {
                        x2 = e.X;
                        y2 = e.Y;
                    }
                    else if (Mouse_click % 3 == 2)
                    {
                        x3 = e.X;
                        y3 = e.Y;

                        image.Add(new GF3.Triangle(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3),  new Pen(penColor, ScrollB.Value)));
                        image.Draw(graphics);
                    }
                    break;
            }
            Mouse_click++;
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            selectedFigure = "Triangle";
            Mouse_click = 0;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            selectedFigure = "Rectangle";
            Mouse_click = 0;
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            selectedFigure = "Circle";
            Mouse_click = 0;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            selectedFigure = "Line";
            Mouse_click = 0;
        }

        private void CustomP_Click(object sender, EventArgs e)
        {
            ChoiceColor(CustomP);
            penColor = CustomP.BackColor;
        }

        private void RedP_Click(object sender, EventArgs e)
        {
            penColor = RedP.BackColor;
        }

        private void GreenP_Click(object sender, EventArgs e)
        {
            penColor = GreenP.BackColor;
        }

        private void Texter_Click(object sender, EventArgs e)
        {

        }

        private void Ñanvas_ClientSizeChanged(object sender, EventArgs e)
        {
            Ñanvas.Size = new System.Drawing.Size(10000, 10000);
            graphics.Dispose();
            graphics = Ñanvas.CreateGraphics();
        }

        private void BlueP_Click(object sender, EventArgs e)
        {
            penColor = BlueP.BackColor;
        }

        private void ClearB_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            image.Clear();
        }

        private void panelLine_Paint(object sender, PaintEventArgs e)
        {
            image.Draw(graphics);
        }

        private void ItemSave_Click(object sender, EventArgs e)
        {
            if(dlgSave.ShowDialog() == DialogResult.OK)
            {
                string fname = dlgSave.FileName;
                image.Save(fname);
            }
        }

        private void itemLoad_Click(object sender, EventArgs e)
        {
            if (dlgLoad.ShowDialog() == DialogResult.OK)
            {
                string fname = dlgLoad.FileName;
                image.Load(fname);
            }
            image.Draw(graphics);
        }
    }
}
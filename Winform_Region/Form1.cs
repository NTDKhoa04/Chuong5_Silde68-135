using System.Drawing.Drawing2D;
namespace Winform_Region;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
       
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        Rectangle rect1 = new Rectangle(10, 10, 120, 140);
        Rectangle rect2 = new Rectangle(80, 50, 160, 200);
        Region rgn1 = new Region(rect1);
        Region rgn2 = new Region(rect2);
        g.DrawRectangle(Pens.Green, rect1);
        g.DrawRectangle(Pens.Black, rect2);
        rgn1.Complement(rgn2);
        g.FillRegion(Brushes.Blue, rgn1);

        rect1 = new Rectangle(250, 10, 120, 140);
        rect2 = new Rectangle(320, 50, 160, 200);
        rgn1 = new Region(rect1);
        rgn2 = new Region(rect2);
        g.DrawRectangle(Pens.Green, rect1);
        g.DrawRectangle(Pens.Black, rect2);
        rgn1.Exclude(rgn2);
        g.FillRegion(Brushes.Red, rgn1);

        rect1 = new Rectangle(500, 10, 120, 140);
        rect2 = new Rectangle(570, 50, 160, 200);
        rgn1 = new Region(rect1);
        rgn2 = new Region(rect2);
        g.DrawRectangle(Pens.Green, rect1);
        g.DrawRectangle(Pens.Black, rect2);
        rgn1.Union(rgn2);
        g.FillRegion(Brushes.Green, rgn1);

        g = e.Graphics;
        rect1 = new Rectangle(10, 300, 120, 140);
        rect2 = new Rectangle(80, 350, 160, 200);
        rgn1 = new Region(rect1);
        rgn2 = new Region(rect2);
        g.DrawRectangle(Pens.Green, rect1);
        g.DrawRectangle(Pens.Black, rect2);
        rgn1.Xor(rgn2);
        g.FillRegion(Brushes.Yellow, rgn1);

        g = e.Graphics;
        rect1 = new Rectangle(250, 300, 120, 140);
        rect2 = new Rectangle(320, 350, 160, 200);
        rgn1 = new Region(rect1);
        rgn2 = new Region(rect2);
        g.DrawRectangle(Pens.Green, rect1);
        g.DrawRectangle(Pens.Black, rect2);
        rgn1.Intersect(rgn2);
        g.FillRegion(Brushes.Pink, rgn1);

        g.Dispose();
    }
}
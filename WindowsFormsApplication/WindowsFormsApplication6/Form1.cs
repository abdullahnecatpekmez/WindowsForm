using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public class Nokta
        {
            private Point p;
            private Rectangle r;
            private Color c;
      
            public Nokta(int x, int y)
            {
                p = new Point(x, y);
                r = new Rectangle(x - 10 / 2, y - 10 / 2, 10, 10);
                c = Color.Black;
            }

            public Point getPoint()
            {
                return p;
            }

            public Rectangle getRectangle()
            {
                return r;
            }

            public Color getColor()
            {
                return c;
            }

            public void setColor(Color col)
            {
                c = col;
            }

            public void setPoint(Point p)
            {
                this.p = p;
                this.r = new Rectangle(p.X - 10 / 2, p.Y - 10 / 2, 10, 10);
            }

        }

        List<Nokta> pointList = new List<Nokta>();
        Boolean draw, translate, delete, translateStart, cluster;
        Point[] clusterCentroids;
        Point currentPoint;
        int translatedPointIndex, clusterNumber;
        Color translatedColor;
        Color[] colors = { Color.Blue, Color.Chocolate, Color.Gold, Color.Green, Color.Orange, Color.Red };

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            draw = true;
            translate = false;
            delete = false;
            translateStart = false;
            cluster = false;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(200, 100, 400,300);
            g.DrawRectangle(Pens.Black, r);

            if (!translateStart)
                for (int i = 0; i < pointList.Count; i++)
                    g.FillEllipse(new SolidBrush(pointList[i].getColor()), pointList[i].getRectangle());
            else
            {
                for (int i = 0; i < pointList.Count; i++)
                    g.FillEllipse(new SolidBrush(pointList[i].getColor()), pointList[i].getRectangle());

                Rectangle rect = new Rectangle(currentPoint.X - 10 / 2, currentPoint.Y - 10 / 2, 10, 10);
                g.FillEllipse(new SolidBrush(translatedColor), rect);
            }

            if (cluster)
            {
                for (int i = 0; i < clusterNumber; i++)
                { 
                    Point[] myPoints = {new Point(clusterCentroids[i].X,clusterCentroids[i].Y-5),
                                        new Point(clusterCentroids[i].X+5,clusterCentroids[i].Y),
                                        new Point(clusterCentroids[i].X,clusterCentroids[i].Y+5),
                                        new Point(clusterCentroids[i].X-5,clusterCentroids[i].Y)};

                    g.FillPolygon(Brushes.Gray, myPoints);
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Boolean found = false;

            if (draw)
            {
                if ((e.X >= 200 && e.X <= 600) && (e.Y >= 100 && e.Y <= 400))//çizim alanında mı
                {
                    for (int i = 0; i < pointList.Count; i++)
                    {
                        if (pointList[i].getRectangle().Contains(e.X, e.Y))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Nokta n = new Nokta(e.X, e.Y);
                        pointList.Add(n);
                        Invalidate();
                    }
                }
            }

            else if (delete)
            {
                if ((e.X >= 200 && e.X <= 600) && (e.Y >= 100 && e.Y <= 400))//çizim alanında mı
                {
                    for (int i = 0; i < pointList.Count; i++)
                    { 
                        if(pointList[i].getRectangle().Contains(e.X,e.Y))
                        {
                            pointList.RemoveAt(i);
                            Invalidate();                          
                        }
                    }            
                }
            }   
        }

        private void addRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            draw = true;
            translate = false;
            delete = false;
        }

        private void translateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            draw = false;
            translate = true;
            delete = false;
        }

        private void deleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            draw = false;
            translate = false;
            delete = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (translate)
            {
                for (int i = 0; i < pointList.Count; i++)
                {
                    if (pointList[i].getRectangle().Contains(e.X, e.Y))
                    {
                        currentPoint = new Point(e.X, e.Y);
                        translatedPointIndex = i;
                        translatedColor = pointList[i].getColor();
                        pointList.RemoveAt(i);
                        translateStart = true;
                    }
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (translateStart)
            {
                currentPoint.X = e.X;
                currentPoint.Y = e.Y;
                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (translateStart)
            {
                Nokta n = new Nokta(e.X, e.Y);
                n.setColor(translatedColor);
                pointList.Add(n);
                translateStart = false;
                Invalidate(); 
            }
        }

        public double euclideanDistance(Point p1, Point p2)
        {
            return Math.Sqrt((Math.Pow(p1.X - p2.X, 2.0) + Math.Pow(p1.Y - p2.Y, 2.0)));
        }

        private void clusterButton_Click(object sender, EventArgs e)
        {
            int check = 0;
            Random r = new Random();

            clusterNumber = Convert.ToInt32(clusterNumberTextBox.Text);
            clusterCentroids = new Point[clusterNumber];

            for (int i = 0; i < clusterNumber; i++)
            {
                clusterCentroids[i].X = r.Next(200, 600);
                clusterCentroids[i].Y = r.Next(100, 400);
            }

            cluster = true;
            Invalidate();
            double[,] distances = new double[clusterNumber, pointList.Count];
       
          
            for (int k = 0; k < 20; k++)
            {
                for (int i = 0; i < clusterNumber; i++)
                {
                    for (int j = 0; j < pointList.Count; j++)
                    {
                        distances[i, j] = euclideanDistance(clusterCentroids[i], pointList[j].getPoint());
                    }
                }

                for (int i = 0; i < pointList.Count; i++)
                {
                    double min = distances[0, i];
                    int minCluster = 0;

                    for (int j = 1; j < clusterNumber; j++)
                    {
                        if (distances[j, i] < min)
                        {
                            min = distances[j, i];
                            minCluster = j;
                            check = 1;
                        }
                    }
                    pointList[i].setColor(colors[minCluster]);
                }
                Invalidate();

                if (check == 0)
                    break;    

                for (int i = 0; i < clusterNumber; i++)
                {
                    int newX = 0;
                    int newY = 0;
                    int counter = 0;
                    for (int j = 0; j < pointList.Count; j++)
                    {
                        if (pointList[j].getColor() == colors[i])
                        {
                            newX += pointList[j].getPoint().X;
                            newY += pointList[j].getPoint().Y;
                            counter++;
                        }
                    }
                    clusterCentroids[i].X = newX / counter;
                    clusterCentroids[i].Y = newY / counter;
                }
                  
            }
            Invalidate();


        }

    }
}

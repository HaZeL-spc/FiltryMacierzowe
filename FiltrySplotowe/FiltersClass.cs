using FiltrySplotowe.Enums;
using ScottPlot.Drawing.Colormaps;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrySplotowe
{
    public class FiltersClass
    {
        public static TypeAreaEnum typeArea;
        public static TypeFillingEnum typeFilling;
        public static int brushCircleSize = 100;
        public static Polygon polygon = new Polygon();
        public static double[,] OwnMatrix = new double[3, 3];
        public static double translation = 0;
        public static double dzielnik = 1;
        public static Point point = new Point(-1, -1);
        public static bool polygonFinished = false;

        public FiltersClass() {
            typeArea = Enums.TypeAreaEnum.WholePage;
            typeFilling = Enums.TypeFillingEnum.Identity;

            OwnMatrix = new double[3, 3];
            OwnMatrix[1, 1] = 1;
            changeDzielnikDefault();
        }

        public static void rePaintCanvas(Bitmap drawArea)
        {
            switch (typeArea)
            {
                case TypeAreaEnum.WholePage:
                    drawWholePage(drawArea);
                    break;
                case TypeAreaEnum.BrushCircle:
                    drawCirlePage(drawArea);
                    break;
                case TypeAreaEnum.Polygon:
                    drawPolygonPage(drawArea);
                    break;
            }
        }

        public static void drawWholePage(Bitmap drawArea)
        {
            for (int i = 1; i < drawArea.Width - 1; i++)
            {
                for (int j = 1; j < drawArea.Height - 1; j++)
                {
                    drawArea.SetPixel(i, j, countNewColor(drawArea, i, j));
                }
            }
        }

        public static void drawCirlePage(Bitmap drawArea)
        {
            int x = point.X;
            int y = point.Y;

            if (x == -1 && y == -1)
                return;
            int r = brushCircleSize;

            int minX = Math.Max(1, x - r);
            int maxX = Math.Min(drawArea.Width - 2, x + r);
            int minY = Math.Max(1, y - r);
            int maxY = Math.Min(drawArea.Height - 2, y + r);

            // Loop through every pixel in the square.
            for (int k = minY; k <= maxY; k++)
            {
                for (int h = minX; h <= maxX; h++)
                {
                    // Check if the pixel is inside the circle.
                    int dx = x - h;
                    int dy = y - k;
                    if (dx * dx + dy * dy <= r * r)
                    {
                        // The pixel is inside the circle. Process it.
                        drawArea.SetPixel(h, k, countNewColor(drawArea, h, k));
                    }
                }
            }
        }

        public static void drawPolygonPage(Bitmap drawArea)
        {
            Point? previousPoint = null;
            if (polygon.points.Count == 0) return;

            foreach (var point in polygon.points)
            {
                using (Graphics g = Graphics.FromImage(drawArea))
                {
                    Pen pen = new Pen(Color.Black, 2);
                    g.FillEllipse(Brushes.Black, point.X - 10, point.Y - 10, 10 * 2, 10 * 2);

                    if (previousPoint != null)
                    {
                        g.DrawLine(pen, previousPoint.Value, point);
                    }
                }
                previousPoint = point;
            }

            if (!polygonFinished) return;

            for (int i = 1; i < drawArea.Width - 1; i++)
            {
                for (int j = 1; j < drawArea.Height - 1; j++)
                {
                    if (Polygon.CheckIfInsidePolygon(i, j, polygon.points))
    
                        drawArea.SetPixel(i, j, countNewColor(drawArea, i, j));
                }
            }
        }

        public static void changeDzielnikDefault()
        {
            double dz = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dz = dz + OwnMatrix[i, j];
                }
            }

            if (dz == 0)
                dzielnik = 1;
            else
                dzielnik = dz;
        }

        public static Color countNewColor(Bitmap drawArea, int x, int y)
        {
            double newColorRed = 0; double newColorGreen = 0; double newColorBlue = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Color pixel = Form1.originalPictureColors[y + j - 1, x + i - 1];
                    newColorRed += OwnMatrix[i, j] * pixel.R;
                    newColorGreen += OwnMatrix[i, j] * pixel.G;
                    newColorBlue += OwnMatrix[i, j] * pixel.B;
                }
            }

            newColorRed = newColorRed / dzielnik + translation;
            newColorGreen = newColorGreen / dzielnik + translation;
            newColorBlue = newColorBlue / dzielnik + translation;

            if (newColorRed > 255)
                newColorRed = 255;
            if (newColorGreen > 255)
                newColorGreen = 255;
            if (newColorBlue > 255)
                newColorBlue = 255;

            if (newColorRed < 0)
                newColorRed = 0;
            if (newColorGreen < 0)
                newColorGreen = 0;
            if (newColorBlue < 0)
                newColorBlue = 0;

            return Color.FromArgb((int)newColorRed, (int)newColorGreen, (int)newColorBlue);
        }
    }
}

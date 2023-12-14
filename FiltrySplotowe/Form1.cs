using ScottPlot;
using System.Collections.Generic;
using System.Drawing;
using System.Transactions;

namespace FiltrySplotowe
{
    public partial class Form1 : Form
    {
        public FiltersClass filtersClass;
        public DirectBitmap drawArea;
        public DirectBitmap drawAreaCopy;
        public static Color[,] pictureColors;
        public static Color[,] originalPictureColors;
        public static Color[,] ogOriginalPictureColors;
        public string filePathImage;

        public Form1()
        {
            InitializeComponent();
            filtersClass = new FiltersClass();

            drawArea = new DirectBitmap(Canvas.Size.Width, Canvas.Size.Height);
            Canvas.Image = drawArea.Bitmap;
            using (Graphics g = Graphics.FromImage(drawArea.Bitmap))
            {
                g.Clear(Color.LightBlue);
            }
            pictureColors = new Color[Canvas.Height, Canvas.Width];
            originalPictureColors = new Color[Canvas.Height, Canvas.Width];
            ogOriginalPictureColors = new Color[Canvas.Height, Canvas.Width];
            drawAreaCopy = drawArea;
            //FiltersClass.rePaintCanvas(drawArea);
        }

        private void splitMainContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBarBrushCircle_Scroll(object sender, EventArgs e)
        {
            labelBrushCircle.Text = "" + trackBarBrushCircle.Value;
            FiltersClass.brushCircleSize = trackBarBrushCircle.Value;
        }

        private void areaTypeRado_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (!radioButton.Checked)
            {
                if (radioButton.Name == "polygonRadio")
                    buttonClean.Enabled = polygonRadio.Checked;

                return;
            }

            if (radioButton.Name == "wholePaintingRadio")
            {
                FiltersClass.typeArea = Enums.TypeAreaEnum.WholePage;
            }
            else if (radioButton.Name == "brushCircleRadio")
            {
                FiltersClass.typeFilling = Enums.TypeFillingEnum.Identity;
                identityRadio.Checked = true;
                FiltersClass.typeArea = Enums.TypeAreaEnum.BrushCircle;
                doImageWork();
            }
            else if (radioButton.Name == "polygonRadio")
            {
                buttonClean.Enabled = polygonRadio.Checked;
                FiltersClass.typeArea = Enums.TypeAreaEnum.Polygon;
            }

            doImageWork();
        }

        private void TranslationUpDown_ValueChanged(object sender, EventArgs e)
        {
            FiltersClass.translation = decimal.ToDouble(TranslationUpDown.Value);
            doImageWork();
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (FiltersClass.typeArea.Equals(Enums.TypeAreaEnum.BrushCircle))
            {
                if (e.Button == MouseButtons.Left)
                {
                    FiltersClass.point = new Point(e.X, e.Y);
                    refreshImageToStart();
                    doImageWork();
                }
            }
            else if (FiltersClass.typeArea.Equals(Enums.TypeAreaEnum.Polygon))
            {
                if (e.Button == MouseButtons.Left)
                {
                    var ret = FiltersClass.polygon.AddPointOrFinish(new Point(e.X, e.Y));
                    FiltersClass.polygonFinished = ret;
                    doImageWork();
                } else if (e.Button == MouseButtons.Right)
                {
                    FiltersClass.polygon.movePolygon(e.X, e.Y);
                    doImageWork();
                }
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            FiltersClass.polygon.ClearPolygon();
            doImageWork();
        }

        private void filterTypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (!radioButton.Checked) return;
            double[,] matrix = new double[3, 3];

            if (radioButton.Name == "identityRadio")
            {
                FiltersClass.typeFilling = Enums.TypeFillingEnum.Identity;
                matrix[1, 1] = 1;
            }
            else if (radioButton.Name == "blurRadio")
            {
                FiltersClass.typeFilling = Enums.TypeFillingEnum.Blur;
                matrix[0, 1] = 1;
                matrix[1, 0] = 1;
                matrix[1, 1] = 4;
                matrix[1, 2] = 1;
                matrix[2, 1] = 1;
            }
            else if (radioButton.Name == "sharpRadio")
            {
                FiltersClass.typeFilling = Enums.TypeFillingEnum.Sharp;
                matrix[0, 1] = -1;
                matrix[1, 0] = -1;
                matrix[1, 1] = 5;
                matrix[1, 2] = -1;
                matrix[2, 1] = -1;
            }
            else if (radioButton.Name == "plaskorzezbaRadio")
            {
                FiltersClass.typeFilling = Enums.TypeFillingEnum.Plaskorzezba;
                matrix[0, 0] = -1;
                matrix[0, 1] = -1;
                matrix[1, 0] = -1;
                matrix[1, 1] = 1;
                matrix[1, 2] = 1;
                matrix[2, 1] = 1;
                matrix[2, 2] = 1;
            }
            else if (radioButton.Name == "detectingEdgesRadio")
            {
                FiltersClass.typeFilling = Enums.TypeFillingEnum.DetectingEdges;
                matrix[0, 1] = -1;
                matrix[1, 0] = -1;
                matrix[1, 1] = 4;
                matrix[1, 2] = -1;
                matrix[2, 1] = -1;
            }
            else if (radioButton.Name == "OwnRadio")
            {
                FiltersClass.typeFilling = Enums.TypeFillingEnum.Own;
                matrix = FiltersClass.OwnMatrix;
            }

            FiltersClass.OwnMatrix = matrix;

            doImageWork();
        }

        private void doImageWork()
        {
            if (checkBoxWyznaczanieDzielnik.Checked)
                FiltersClass.changeDzielnikDefault();

            if (!FiltersClass.typeArea.Equals(Enums.TypeAreaEnum.WholePage))
            {
                refreshImageToStart();
            }

            changeAvailabilityOwnMatrix(FiltersClass.typeFilling);
            setUpPictureColors(drawArea.Bitmap, false);
            FiltersClass.rePaintCanvas(drawArea.Bitmap);
            Canvas.Image = drawArea.Bitmap;
            doPlotsWork();
        }

        private void changeAvailabilityOwnMatrix(Enums.TypeFillingEnum type)
        {
            bool enable = false;

            if (type.Equals(Enums.TypeFillingEnum.Own))
                enable = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string controlName = $"OwnUpDown{i}{j}";
                    Control control = this.Controls.Find(controlName, true).FirstOrDefault();
                    control.Enabled = enable;
                }
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int i = int.Parse(numericUpDown.Name[9].ToString());
            int j = int.Parse(numericUpDown.Name[10].ToString());

            FiltersClass.OwnMatrix[i, j] = decimal.ToDouble(numericUpDown.Value);
            doImageWork();
        }

        private void checkBoxWyznaczanieDzielnik_CheckedChanged(object sender, EventArgs e)
        {
            DzielnikUpDown.Enabled = !checkBoxWyznaczanieDzielnik.Checked;

            if (checkBoxWyznaczanieDzielnik.Checked)
            {
                FiltersClass.changeDzielnikDefault();
            }
            else
            {
                FiltersClass.dzielnik = decimal.ToDouble(DzielnikUpDown.Value);
            }

            doImageWork();
        }

        private void DzielnikUpDown_ValueChanged(object sender, EventArgs e)
        {
            FiltersClass.dzielnik = decimal.ToDouble(DzielnikUpDown.Value);
            doImageWork();
        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Image image = Image.FromFile(filePath);
                //Canvas.Image = image;

                Bitmap imageBitmap = new Bitmap(image);
                setUpPictureColors(imageBitmap);
                filePathImage = filePath;
            }

            FiltersClass.rePaintCanvas(drawArea.Bitmap);

            drawAreaCopy = drawArea;
            Canvas.Image = drawArea.Bitmap;

            doPlotsWork();
        }

        public void setUpPictureColors(Bitmap bitmap, bool loadedImage = true)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    if (loadedImage)
                    {
                        Color pixelColor = bitmap.GetPixel(x, y);
                        pictureColors[y, x] = pixelColor;
                        originalPictureColors[y, x] = pixelColor;
                    }
                }
            }
        }

        public void doPlotsWork()
        {
            var colorsPixels = countColors(drawArea.Bitmap);
            drawScottPlot(formsPlotRed, colorsPixels.CountRed, Color.Red);
            drawScottPlot(formsPlotGreen, colorsPixels.CountGreen, Color.Green);
            drawScottPlot(formsPlotBlue, colorsPixels.CountBlue, Color.Blue);
        }

        public void drawScottPlot(FormsPlot formsPlot, List<double> countedPixels, Color colorBar)
        {
            formsPlot.Plot.Clear();

            // Create a new histogram with the same bin size
            var hist = new ScottPlot.Statistics.Histogram(min: 0, max: 255, 255);

            double[] heights = countedPixels.ToArray();
            hist.AddRange(heights);

            // Show the histogram counts as a bar plot
            var barPlot = formsPlot.Plot.AddBar(values: hist.Counts, positions: hist.Bins);
            barPlot.FillColor = colorBar; // Change the color of the bars to red
            barPlot.BorderLineWidth = 0; // Remove the border line

            // Customize the plot style
            formsPlot.Plot.XAxis.Ticks(false);
            formsPlot.Plot.YAxis.Ticks(false);
            formsPlot.Plot.SetAxisLimits(yMin: 0);
            formsPlot.Refresh();
        }

        public CountColorsScott countColors(Bitmap bitmap)
        {
            var returnValue = new CountColorsScott();
            List<double> histR = new();
            List<double> histG = new();
            List<double> histB = new();

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixel = bitmap.GetPixel(x,y);
                    histR.Add(pixel.R);
                    histG.Add(pixel.G);
                    histB.Add(pixel.B);
                }
            }

            returnValue.assignLists(histR, histG, histB);

            return returnValue;
        }

        private void refreshImageToStart()
        {
            for (int y = 0; y < Canvas.Height; y++)
            {
                for (int x = 0; x < Canvas.Width; x++)
                {
                    drawArea.SetPixel(x, y, originalPictureColors[y, x]);
                }
            }
        }
    }

    public class CountColorsScott
    {
        public List<double> CountRed = new();
        public List<double> CountGreen = new();
        public List<double> CountBlue = new();

        public void assignLists(List<double> r, List<double> g, List<double> b)
        {
            CountRed = r;
            CountGreen = g;
            CountBlue = b;
        }
    }
}

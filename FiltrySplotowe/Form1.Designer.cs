namespace FiltrySplotowe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GroupBox groupBoxAreaFill;
            polygonRadio = new RadioButton();
            buttonClean = new Button();
            labelBrushCircle = new Label();
            trackBarBrushCircle = new TrackBar();
            brushCircleRadio = new RadioButton();
            wholePaintingRadio = new RadioButton();
            splitMainContainer = new SplitContainer();
            Canvas = new PictureBox();
            formsPlotBlue = new ScottPlot.FormsPlot();
            formsPlotGreen = new ScottPlot.FormsPlot();
            formsPlotRed = new ScottPlot.FormsPlot();
            buttonPicture = new Button();
            groupBoxTypeFilter = new GroupBox();
            checkBoxWyznaczanieDzielnik = new CheckBox();
            DzielnikUpDown = new NumericUpDown();
            TranslationUpDown = new NumericUpDown();
            labelDzielnik = new Label();
            labelTranslation = new Label();
            OwnUpDown22 = new NumericUpDown();
            OwnUpDown21 = new NumericUpDown();
            OwnUpDown20 = new NumericUpDown();
            OwnUpDown12 = new NumericUpDown();
            OwnUpDown11 = new NumericUpDown();
            OwnUpDown10 = new NumericUpDown();
            OwnUpDown02 = new NumericUpDown();
            OwnUpDown01 = new NumericUpDown();
            OwnUpDown00 = new NumericUpDown();
            OwnRadio = new RadioButton();
            detectingEdgesRadio = new RadioButton();
            plaskorzezbaRadio = new RadioButton();
            sharpRadio = new RadioButton();
            blurRadio = new RadioButton();
            identityRadio = new RadioButton();
            groupBoxAreaFill = new GroupBox();
            groupBoxAreaFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBrushCircle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitMainContainer).BeginInit();
            splitMainContainer.Panel1.SuspendLayout();
            splitMainContainer.Panel2.SuspendLayout();
            splitMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            groupBoxTypeFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DzielnikUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TranslationUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown00).BeginInit();
            SuspendLayout();
            // 
            // groupBoxAreaFill
            // 
            groupBoxAreaFill.Controls.Add(polygonRadio);
            groupBoxAreaFill.Controls.Add(buttonClean);
            groupBoxAreaFill.Controls.Add(labelBrushCircle);
            groupBoxAreaFill.Controls.Add(trackBarBrushCircle);
            groupBoxAreaFill.Controls.Add(brushCircleRadio);
            groupBoxAreaFill.Controls.Add(wholePaintingRadio);
            groupBoxAreaFill.Location = new Point(263, 12);
            groupBoxAreaFill.Name = "groupBoxAreaFill";
            groupBoxAreaFill.Size = new Size(203, 203);
            groupBoxAreaFill.TabIndex = 0;
            groupBoxAreaFill.TabStop = false;
            groupBoxAreaFill.Text = "Obszar zastosowania filtra";
            // 
            // polygonRadio
            // 
            polygonRadio.AutoSize = true;
            polygonRadio.Location = new Point(6, 148);
            polygonRadio.Name = "polygonRadio";
            polygonRadio.Size = new Size(89, 24);
            polygonRadio.TabIndex = 5;
            polygonRadio.TabStop = true;
            polygonRadio.Text = "Wielokąt";
            polygonRadio.UseVisualStyleBackColor = true;
            polygonRadio.CheckedChanged += areaTypeRado_CheckedChanged;
            // 
            // buttonClean
            // 
            buttonClean.Enabled = false;
            buttonClean.Location = new Point(117, 148);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(80, 28);
            buttonClean.TabIndex = 4;
            buttonClean.Text = "Wyczyść";
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += buttonClean_Click;
            // 
            // labelBrushCircle
            // 
            labelBrushCircle.AutoSize = true;
            labelBrushCircle.Location = new Point(166, 97);
            labelBrushCircle.Name = "labelBrushCircle";
            labelBrushCircle.Size = new Size(25, 20);
            labelBrushCircle.TabIndex = 3;
            labelBrushCircle.Text = "50";
            // 
            // trackBarBrushCircle
            // 
            trackBarBrushCircle.LargeChange = 50;
            trackBarBrushCircle.Location = new Point(6, 86);
            trackBarBrushCircle.Maximum = 600;
            trackBarBrushCircle.Name = "trackBarBrushCircle";
            trackBarBrushCircle.Size = new Size(163, 56);
            trackBarBrushCircle.TabIndex = 2;
            trackBarBrushCircle.Value = 50;
            trackBarBrushCircle.Scroll += trackBarBrushCircle_Scroll;
            // 
            // brushCircleRadio
            // 
            brushCircleRadio.AutoSize = true;
            brushCircleRadio.Location = new Point(6, 56);
            brushCircleRadio.Name = "brushCircleRadio";
            brushCircleRadio.Size = new Size(124, 24);
            brushCircleRadio.TabIndex = 1;
            brushCircleRadio.Text = "Pędzel kołowy";
            brushCircleRadio.UseVisualStyleBackColor = true;
            brushCircleRadio.CheckedChanged += areaTypeRado_CheckedChanged;
            // 
            // wholePaintingRadio
            // 
            wholePaintingRadio.AutoSize = true;
            wholePaintingRadio.Checked = true;
            wholePaintingRadio.Location = new Point(6, 26);
            wholePaintingRadio.Name = "wholePaintingRadio";
            wholePaintingRadio.Size = new Size(100, 24);
            wholePaintingRadio.TabIndex = 0;
            wholePaintingRadio.TabStop = true;
            wholePaintingRadio.Text = "Cały obraz";
            wholePaintingRadio.UseVisualStyleBackColor = true;
            wholePaintingRadio.CheckedChanged += areaTypeRado_CheckedChanged;
            // 
            // splitMainContainer
            // 
            splitMainContainer.Dock = DockStyle.Fill;
            splitMainContainer.IsSplitterFixed = true;
            splitMainContainer.Location = new Point(0, 0);
            splitMainContainer.Name = "splitMainContainer";
            // 
            // splitMainContainer.Panel1
            // 
            splitMainContainer.Panel1.BackColor = SystemColors.ButtonFace;
            splitMainContainer.Panel1.Controls.Add(Canvas);
            // 
            // splitMainContainer.Panel2
            // 
            splitMainContainer.Panel2.BackColor = SystemColors.ControlLight;
            splitMainContainer.Panel2.Controls.Add(formsPlotBlue);
            splitMainContainer.Panel2.Controls.Add(formsPlotGreen);
            splitMainContainer.Panel2.Controls.Add(formsPlotRed);
            splitMainContainer.Panel2.Controls.Add(buttonPicture);
            splitMainContainer.Panel2.Controls.Add(groupBoxTypeFilter);
            splitMainContainer.Panel2.Controls.Add(groupBoxAreaFill);
            splitMainContainer.Panel2.Paint += splitMainContainer_Panel2_Paint;
            splitMainContainer.Size = new Size(1082, 703);
            splitMainContainer.SplitterDistance = 600;
            splitMainContainer.TabIndex = 0;
            // 
            // Canvas
            // 
            Canvas.Dock = DockStyle.Fill;
            Canvas.Location = new Point(0, 0);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(600, 703);
            Canvas.TabIndex = 0;
            Canvas.TabStop = false;
            Canvas.MouseDown += Canvas_MouseDown;
            // 
            // formsPlotBlue
            // 
            formsPlotBlue.Location = new Point(4, 342);
            formsPlotBlue.Margin = new Padding(5, 4, 5, 4);
            formsPlotBlue.Name = "formsPlotBlue";
            formsPlotBlue.Size = new Size(242, 185);
            formsPlotBlue.TabIndex = 5;
            // 
            // formsPlotGreen
            // 
            formsPlotGreen.Location = new Point(4, 169);
            formsPlotGreen.Margin = new Padding(5, 4, 5, 4);
            formsPlotGreen.Name = "formsPlotGreen";
            formsPlotGreen.Size = new Size(242, 192);
            formsPlotGreen.TabIndex = 4;
            // 
            // formsPlotRed
            // 
            formsPlotRed.Location = new Point(4, 12);
            formsPlotRed.Margin = new Padding(5, 4, 5, 4);
            formsPlotRed.Name = "formsPlotRed";
            formsPlotRed.Size = new Size(242, 180);
            formsPlotRed.TabIndex = 3;
            // 
            // buttonPicture
            // 
            buttonPicture.Location = new Point(280, 671);
            buttonPicture.Name = "buttonPicture";
            buttonPicture.Size = new Size(129, 29);
            buttonPicture.TabIndex = 2;
            buttonPicture.Text = "Wybierz Zdjęcie";
            buttonPicture.UseVisualStyleBackColor = true;
            buttonPicture.Click += buttonPicture_Click;
            // 
            // groupBoxTypeFilter
            // 
            groupBoxTypeFilter.Controls.Add(checkBoxWyznaczanieDzielnik);
            groupBoxTypeFilter.Controls.Add(DzielnikUpDown);
            groupBoxTypeFilter.Controls.Add(TranslationUpDown);
            groupBoxTypeFilter.Controls.Add(labelDzielnik);
            groupBoxTypeFilter.Controls.Add(labelTranslation);
            groupBoxTypeFilter.Controls.Add(OwnUpDown22);
            groupBoxTypeFilter.Controls.Add(OwnUpDown21);
            groupBoxTypeFilter.Controls.Add(OwnUpDown20);
            groupBoxTypeFilter.Controls.Add(OwnUpDown12);
            groupBoxTypeFilter.Controls.Add(OwnUpDown11);
            groupBoxTypeFilter.Controls.Add(OwnUpDown10);
            groupBoxTypeFilter.Controls.Add(OwnUpDown02);
            groupBoxTypeFilter.Controls.Add(OwnUpDown01);
            groupBoxTypeFilter.Controls.Add(OwnUpDown00);
            groupBoxTypeFilter.Controls.Add(OwnRadio);
            groupBoxTypeFilter.Controls.Add(detectingEdgesRadio);
            groupBoxTypeFilter.Controls.Add(plaskorzezbaRadio);
            groupBoxTypeFilter.Controls.Add(sharpRadio);
            groupBoxTypeFilter.Controls.Add(blurRadio);
            groupBoxTypeFilter.Controls.Add(identityRadio);
            groupBoxTypeFilter.Location = new Point(263, 221);
            groupBoxTypeFilter.Name = "groupBoxTypeFilter";
            groupBoxTypeFilter.Size = new Size(212, 445);
            groupBoxTypeFilter.TabIndex = 1;
            groupBoxTypeFilter.TabStop = false;
            groupBoxTypeFilter.Text = "Wybór filtra macierzowego";
            // 
            // checkBoxWyznaczanieDzielnik
            // 
            checkBoxWyznaczanieDzielnik.Checked = true;
            checkBoxWyznaczanieDzielnik.CheckState = CheckState.Checked;
            checkBoxWyznaczanieDzielnik.Location = new Point(0, 386);
            checkBoxWyznaczanieDzielnik.Name = "checkBoxWyznaczanieDzielnik";
            checkBoxWyznaczanieDzielnik.Size = new Size(178, 46);
            checkBoxWyznaczanieDzielnik.TabIndex = 19;
            checkBoxWyznaczanieDzielnik.Text = "Automatyczne wyznaczanie dzielnika";
            checkBoxWyznaczanieDzielnik.UseVisualStyleBackColor = true;
            checkBoxWyznaczanieDzielnik.CheckedChanged += checkBoxWyznaczanieDzielnik_CheckedChanged;
            // 
            // DzielnikUpDown
            // 
            DzielnikUpDown.DecimalPlaces = 5;
            DzielnikUpDown.Enabled = false;
            DzielnikUpDown.Location = new Point(111, 353);
            DzielnikUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DzielnikUpDown.Name = "DzielnikUpDown";
            DzielnikUpDown.Size = new Size(92, 27);
            DzielnikUpDown.TabIndex = 18;
            DzielnikUpDown.ThousandsSeparator = true;
            DzielnikUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            DzielnikUpDown.ValueChanged += DzielnikUpDown_ValueChanged;
            // 
            // TranslationUpDown
            // 
            TranslationUpDown.Location = new Point(111, 323);
            TranslationUpDown.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            TranslationUpDown.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            TranslationUpDown.Name = "TranslationUpDown";
            TranslationUpDown.Size = new Size(92, 27);
            TranslationUpDown.TabIndex = 17;
            TranslationUpDown.ValueChanged += TranslationUpDown_ValueChanged;
            // 
            // labelDzielnik
            // 
            labelDzielnik.AutoSize = true;
            labelDzielnik.Location = new Point(6, 355);
            labelDzielnik.Name = "labelDzielnik";
            labelDzielnik.Size = new Size(62, 20);
            labelDzielnik.TabIndex = 16;
            labelDzielnik.Text = "Dzielnik";
            // 
            // labelTranslation
            // 
            labelTranslation.AutoSize = true;
            labelTranslation.Location = new Point(5, 325);
            labelTranslation.Name = "labelTranslation";
            labelTranslation.Size = new Size(90, 20);
            labelTranslation.TabIndex = 15;
            labelTranslation.Text = "Przesunięcie";
            // 
            // OwnUpDown22
            // 
            OwnUpDown22.DecimalPlaces = 2;
            OwnUpDown22.Enabled = false;
            OwnUpDown22.Location = new Point(131, 279);
            OwnUpDown22.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            OwnUpDown22.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            OwnUpDown22.Name = "OwnUpDown22";
            OwnUpDown22.Size = new Size(52, 27);
            OwnUpDown22.TabIndex = 14;
            OwnUpDown22.Value = new decimal(new int[] { 1, 0, 0, 0 });
            OwnUpDown22.ValueChanged += numericUpDown_ValueChanged;
            // 
            // OwnUpDown21
            // 
            OwnUpDown21.DecimalPlaces = 2;
            OwnUpDown21.Enabled = false;
            OwnUpDown21.Location = new Point(69, 279);
            OwnUpDown21.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            OwnUpDown21.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            OwnUpDown21.Name = "OwnUpDown21";
            OwnUpDown21.Size = new Size(53, 27);
            OwnUpDown21.TabIndex = 13;
            OwnUpDown21.Value = new decimal(new int[] { 1, 0, 0, 0 });
            OwnUpDown21.ValueChanged += numericUpDown_ValueChanged;
            // 
            // OwnUpDown20
            // 
            OwnUpDown20.DecimalPlaces = 2;
            OwnUpDown20.Enabled = false;
            OwnUpDown20.Location = new Point(6, 279);
            OwnUpDown20.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            OwnUpDown20.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            OwnUpDown20.Name = "OwnUpDown20";
            OwnUpDown20.Size = new Size(53, 27);
            OwnUpDown20.TabIndex = 12;
            OwnUpDown20.Value = new decimal(new int[] { 1, 0, 0, 0 });
            OwnUpDown20.ValueChanged += numericUpDown_ValueChanged;
            // 
            // OwnUpDown12
            // 
            OwnUpDown12.DecimalPlaces = 2;
            OwnUpDown12.Enabled = false;
            OwnUpDown12.Location = new Point(131, 241);
            OwnUpDown12.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            OwnUpDown12.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            OwnUpDown12.Name = "OwnUpDown12";
            OwnUpDown12.Size = new Size(52, 27);
            OwnUpDown12.TabIndex = 11;
            OwnUpDown12.Value = new decimal(new int[] { 1, 0, 0, 0 });
            OwnUpDown12.ValueChanged += numericUpDown_ValueChanged;
            // 
            // OwnUpDown11
            // 
            OwnUpDown11.DecimalPlaces = 2;
            OwnUpDown11.Enabled = false;
            OwnUpDown11.Location = new Point(69, 241);
            OwnUpDown11.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            OwnUpDown11.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            OwnUpDown11.Name = "OwnUpDown11";
            OwnUpDown11.Size = new Size(52, 27);
            OwnUpDown11.TabIndex = 10;
            OwnUpDown11.Value = new decimal(new int[] { 1, 0, 0, 0 });
            OwnUpDown11.ValueChanged += numericUpDown_ValueChanged;
            // 
            // OwnUpDown10
            // 
            OwnUpDown10.DecimalPlaces = 2;
            OwnUpDown10.Enabled = false;
            OwnUpDown10.Location = new Point(6, 241);
            OwnUpDown10.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            OwnUpDown10.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            OwnUpDown10.Name = "OwnUpDown10";
            OwnUpDown10.Size = new Size(53, 27);
            OwnUpDown10.TabIndex = 9;
            OwnUpDown10.Value = new decimal(new int[] { 1, 0, 0, 0 });
            OwnUpDown10.ValueChanged += numericUpDown_ValueChanged;
            // 
            // OwnUpDown02
            // 
            OwnUpDown02.DecimalPlaces = 2;
            OwnUpDown02.Enabled = false;
            OwnUpDown02.Location = new Point(131, 206);
            OwnUpDown02.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            OwnUpDown02.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            OwnUpDown02.Name = "OwnUpDown02";
            OwnUpDown02.Size = new Size(52, 27);
            OwnUpDown02.TabIndex = 8;
            OwnUpDown02.Value = new decimal(new int[] { 1, 0, 0, 0 });
            OwnUpDown02.ValueChanged += numericUpDown_ValueChanged;
            // 
            // OwnUpDown01
            // 
            OwnUpDown01.DecimalPlaces = 2;
            OwnUpDown01.Enabled = false;
            OwnUpDown01.Location = new Point(69, 206);
            OwnUpDown01.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            OwnUpDown01.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            OwnUpDown01.Name = "OwnUpDown01";
            OwnUpDown01.Size = new Size(53, 27);
            OwnUpDown01.TabIndex = 7;
            OwnUpDown01.Value = new decimal(new int[] { 1, 0, 0, 0 });
            OwnUpDown01.ValueChanged += numericUpDown_ValueChanged;
            // 
            // OwnUpDown00
            // 
            OwnUpDown00.DecimalPlaces = 2;
            OwnUpDown00.Enabled = false;
            OwnUpDown00.Location = new Point(6, 206);
            OwnUpDown00.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            OwnUpDown00.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            OwnUpDown00.Name = "OwnUpDown00";
            OwnUpDown00.Size = new Size(53, 27);
            OwnUpDown00.TabIndex = 6;
            OwnUpDown00.ThousandsSeparator = true;
            OwnUpDown00.Value = new decimal(new int[] { 1, 0, 0, 0 });
            OwnUpDown00.ValueChanged += numericUpDown_ValueChanged;
            // 
            // OwnRadio
            // 
            OwnRadio.AutoSize = true;
            OwnRadio.Location = new Point(6, 176);
            OwnRadio.Name = "OwnRadio";
            OwnRadio.Size = new Size(77, 24);
            OwnRadio.TabIndex = 5;
            OwnRadio.Text = "Własny";
            OwnRadio.UseVisualStyleBackColor = true;
            OwnRadio.CheckedChanged += filterTypeRadio_CheckedChanged;
            // 
            // detectingEdgesRadio
            // 
            detectingEdgesRadio.AutoSize = true;
            detectingEdgesRadio.Location = new Point(6, 146);
            detectingEdgesRadio.Name = "detectingEdgesRadio";
            detectingEdgesRadio.Size = new Size(172, 24);
            detectingEdgesRadio.TabIndex = 4;
            detectingEdgesRadio.Text = "Wykrywanie krawędzi";
            detectingEdgesRadio.UseVisualStyleBackColor = true;
            detectingEdgesRadio.CheckedChanged += filterTypeRadio_CheckedChanged;
            // 
            // plaskorzezbaRadio
            // 
            plaskorzezbaRadio.AutoSize = true;
            plaskorzezbaRadio.Location = new Point(6, 116);
            plaskorzezbaRadio.Name = "plaskorzezbaRadio";
            plaskorzezbaRadio.Size = new Size(116, 24);
            plaskorzezbaRadio.TabIndex = 3;
            plaskorzezbaRadio.Text = "Płaskorzeźba";
            plaskorzezbaRadio.UseVisualStyleBackColor = true;
            plaskorzezbaRadio.CheckedChanged += filterTypeRadio_CheckedChanged;
            // 
            // sharpRadio
            // 
            sharpRadio.AutoSize = true;
            sharpRadio.Location = new Point(6, 86);
            sharpRadio.Name = "sharpRadio";
            sharpRadio.Size = new Size(111, 24);
            sharpRadio.TabIndex = 2;
            sharpRadio.Text = "Wyostrzanie";
            sharpRadio.UseVisualStyleBackColor = true;
            sharpRadio.CheckedChanged += filterTypeRadio_CheckedChanged;
            // 
            // blurRadio
            // 
            blurRadio.AutoSize = true;
            blurRadio.Location = new Point(6, 56);
            blurRadio.Name = "blurRadio";
            blurRadio.Size = new Size(94, 24);
            blurRadio.TabIndex = 1;
            blurRadio.Text = "Rozmycie";
            blurRadio.UseVisualStyleBackColor = true;
            blurRadio.CheckedChanged += filterTypeRadio_CheckedChanged;
            // 
            // identityRadio
            // 
            identityRadio.AutoSize = true;
            identityRadio.Checked = true;
            identityRadio.Location = new Point(6, 26);
            identityRadio.Name = "identityRadio";
            identityRadio.Size = new Size(115, 24);
            identityRadio.TabIndex = 0;
            identityRadio.TabStop = true;
            identityRadio.Text = "Identyczność";
            identityRadio.UseVisualStyleBackColor = true;
            identityRadio.CheckedChanged += filterTypeRadio_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 703);
            Controls.Add(splitMainContainer);
            Name = "Form1";
            Text = "Form1";
            groupBoxAreaFill.ResumeLayout(false);
            groupBoxAreaFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBrushCircle).EndInit();
            splitMainContainer.Panel1.ResumeLayout(false);
            splitMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMainContainer).EndInit();
            splitMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            groupBoxTypeFilter.ResumeLayout(false);
            groupBoxTypeFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DzielnikUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)TranslationUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown22).EndInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown21).EndInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown20).EndInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown12).EndInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown11).EndInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown10).EndInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown02).EndInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown01).EndInit();
            ((System.ComponentModel.ISupportInitialize)OwnUpDown00).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMainContainer;
        private RadioButton brushCircleRadio;
        private RadioButton wholePaintingRadio;
        private TrackBar trackBarBrushCircle;
        private Label labelBrushCircle;
        private RadioButton polygonRadio;
        private Button buttonClean;
        private GroupBox groupBoxTypeFilter;
        private RadioButton OwnRadio;
        private RadioButton detectingEdgesRadio;
        private RadioButton plaskorzezbaRadio;
        private RadioButton sharpRadio;
        private RadioButton blurRadio;
        private RadioButton identityRadio;
        private NumericUpDown OwnUpDown22;
        private NumericUpDown OwnUpDown21;
        private NumericUpDown OwnUpDown12;
        private NumericUpDown OwnUpDown11;
        private NumericUpDown OwnUpDown10;
        private NumericUpDown OwnUpDown02;
        private NumericUpDown OwnUpDown01;
        private NumericUpDown OwnUpDown00;
        private Label labelDzielnik;
        private Label labelTranslation;
        private NumericUpDown TranslationUpDown;
        private NumericUpDown DzielnikUpDown;
        private CheckBox checkBoxWyznaczanieDzielnik;
        private NumericUpDown OwnUpDown20;
        private PictureBox Canvas;
        private Button buttonPicture;
        private ScottPlot.FormsPlot formsPlotRed;
        private ScottPlot.FormsPlot formsPlotBlue;
        private ScottPlot.FormsPlot formsPlotGreen;
    }
}

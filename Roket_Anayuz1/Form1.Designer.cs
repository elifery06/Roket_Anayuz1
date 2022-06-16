
namespace Roket_Anayuz1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.takim_ismi = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnroll = new System.Windows.Forms.Button();
            this.lblbasinc = new System.Windows.Forms.Label();
            this.lblenlem = new System.Windows.Forms.Label();
            this.lblirtifa = new System.Windows.Forms.Label();
            this.lblyaw = new System.Windows.Forms.Label();
            this.lblpitch = new System.Windows.Forms.Label();
            this.lblroll = new System.Windows.Forms.Label();
            this.btnbasınc = new System.Windows.Forms.Button();
            this.btnirtifa = new System.Windows.Forms.Button();
            this.btnenlem = new System.Windows.Forms.Button();
            this.btnpitch = new System.Windows.Forms.Button();
            this.btnyaw = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblanakart = new System.Windows.Forms.Label();
            this.lblfaydaliyuk = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnboylam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblboylam = new System.Windows.Forms.Label();
            this.lblboylamf = new System.Windows.Forms.Label();
            this.btnboylamf = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnenlemf = new System.Windows.Forms.Button();
            this.lblenlemf = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gMapControl2 = new GMap.NET.WindowsForms.GMapControl();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComPortCloseButton = new System.Windows.Forms.Button();
            this.ComPortBox = new System.Windows.Forms.ComboBox();
            this.ComPortStatus = new System.Windows.Forms.ProgressBar();
            this.ComPortOpenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seriP1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "modtop-removebg-preview (2).png");
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Roket_Anayuz1.Properties.Resources.indir;
            this.pictureBox2.Location = new System.Drawing.Point(1416, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Roket_Anayuz1.Properties.Resources.modtop_removebg_preview__2_;
            this.pictureBox1.Location = new System.Drawing.Point(9, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // takim_ismi
            // 
            this.takim_ismi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.takim_ismi.Location = new System.Drawing.Point(394, 64);
            this.takim_ismi.Multiline = true;
            this.takim_ismi.Name = "takim_ismi";
            this.takim_ismi.Size = new System.Drawing.Size(948, 90);
            this.takim_ismi.TabIndex = 2;
            this.takim_ismi.Text = "      KONURALP ROKET TAKIMI\r\n             GÖKTÜRK 10.000\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(437, 213);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // btnroll
            // 
            this.btnroll.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnroll.Location = new System.Drawing.Point(540, 471);
            this.btnroll.Name = "btnroll";
            this.btnroll.Size = new System.Drawing.Size(152, 29);
            this.btnroll.TabIndex = 34;
            this.btnroll.UseVisualStyleBackColor = false;
            // 
            // lblbasinc
            // 
            this.lblbasinc.AutoSize = true;
            this.lblbasinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbasinc.Location = new System.Drawing.Point(429, 243);
            this.lblbasinc.Name = "lblbasinc";
            this.lblbasinc.Size = new System.Drawing.Size(111, 31);
            this.lblbasinc.TabIndex = 35;
            this.lblbasinc.Text = "Basınç :";
            // 
            // lblenlem
            // 
            this.lblenlem.AutoSize = true;
            this.lblenlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblenlem.Location = new System.Drawing.Point(437, 532);
            this.lblenlem.Name = "lblenlem";
            this.lblenlem.Size = new System.Drawing.Size(105, 31);
            this.lblenlem.TabIndex = 36;
            this.lblenlem.Text = "Enlem :";
            // 
            // lblirtifa
            // 
            this.lblirtifa.AutoSize = true;
            this.lblirtifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblirtifa.Location = new System.Drawing.Point(428, 296);
            this.lblirtifa.Name = "lblirtifa";
            this.lblirtifa.Size = new System.Drawing.Size(83, 31);
            this.lblirtifa.TabIndex = 37;
            this.lblirtifa.Text = "İrtifa :";
            // 
            // lblyaw
            // 
            this.lblyaw.AutoSize = true;
            this.lblyaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyaw.Location = new System.Drawing.Point(431, 412);
            this.lblyaw.Name = "lblyaw";
            this.lblyaw.Size = new System.Drawing.Size(82, 31);
            this.lblyaw.TabIndex = 38;
            this.lblyaw.Text = "Yaw :";
            // 
            // lblpitch
            // 
            this.lblpitch.AutoSize = true;
            this.lblpitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpitch.Location = new System.Drawing.Point(429, 357);
            this.lblpitch.Name = "lblpitch";
            this.lblpitch.Size = new System.Drawing.Size(90, 31);
            this.lblpitch.TabIndex = 39;
            this.lblpitch.Text = "Pitch :";
            // 
            // lblroll
            // 
            this.lblroll.AutoSize = true;
            this.lblroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblroll.Location = new System.Drawing.Point(437, 471);
            this.lblroll.Name = "lblroll";
            this.lblroll.Size = new System.Drawing.Size(76, 31);
            this.lblroll.TabIndex = 40;
            this.lblroll.Text = "Roll :";
            // 
            // btnbasınc
            // 
            this.btnbasınc.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnbasınc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbasınc.Location = new System.Drawing.Point(540, 243);
            this.btnbasınc.Name = "btnbasınc";
            this.btnbasınc.Size = new System.Drawing.Size(152, 29);
            this.btnbasınc.TabIndex = 41;
            this.btnbasınc.UseVisualStyleBackColor = false;
            // 
            // btnirtifa
            // 
            this.btnirtifa.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnirtifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnirtifa.Location = new System.Drawing.Point(540, 296);
            this.btnirtifa.Name = "btnirtifa";
            this.btnirtifa.Size = new System.Drawing.Size(152, 29);
            this.btnirtifa.TabIndex = 42;
            this.btnirtifa.UseVisualStyleBackColor = false;
            // 
            // btnenlem
            // 
            this.btnenlem.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnenlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnenlem.Location = new System.Drawing.Point(540, 534);
            this.btnenlem.Name = "btnenlem";
            this.btnenlem.Size = new System.Drawing.Size(152, 29);
            this.btnenlem.TabIndex = 43;
            this.btnenlem.UseVisualStyleBackColor = false;
            // 
            // btnpitch
            // 
            this.btnpitch.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnpitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpitch.Location = new System.Drawing.Point(540, 357);
            this.btnpitch.Name = "btnpitch";
            this.btnpitch.Size = new System.Drawing.Size(152, 29);
            this.btnpitch.TabIndex = 44;
            this.btnpitch.UseVisualStyleBackColor = false;
            // 
            // btnyaw
            // 
            this.btnyaw.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnyaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyaw.Location = new System.Drawing.Point(540, 414);
            this.btnyaw.Name = "btnyaw";
            this.btnyaw.Size = new System.Drawing.Size(152, 29);
            this.btnyaw.TabIndex = 45;
            this.btnyaw.UseVisualStyleBackColor = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 798);
            this.splitter1.TabIndex = 46;
            this.splitter1.TabStop = false;
            // 
            // lblanakart
            // 
            this.lblanakart.AutoSize = true;
            this.lblanakart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblanakart.Location = new System.Drawing.Point(518, 157);
            this.lblanakart.Name = "lblanakart";
            this.lblanakart.Size = new System.Drawing.Size(119, 31);
            this.lblanakart.TabIndex = 48;
            this.lblanakart.Text = "Ana Kart";
            // 
            // lblfaydaliyuk
            // 
            this.lblfaydaliyuk.AutoSize = true;
            this.lblfaydaliyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfaydaliyuk.Location = new System.Drawing.Point(864, 157);
            this.lblfaydaliyuk.Name = "lblfaydaliyuk";
            this.lblfaydaliyuk.Size = new System.Drawing.Size(156, 31);
            this.lblfaydaliyuk.TabIndex = 50;
            this.lblfaydaliyuk.Text = "Faydalı Yük";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(820, 213);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(284, 21);
            this.comboBox2.TabIndex = 49;
            // 
            // btnboylam
            // 
            this.btnboylam.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnboylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnboylam.Location = new System.Drawing.Point(540, 597);
            this.btnboylam.Name = "btnboylam";
            this.btnboylam.Size = new System.Drawing.Size(152, 29);
            this.btnboylam.TabIndex = 52;
            this.btnboylam.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(413, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 51;
            // 
            // lblboylam
            // 
            this.lblboylam.AutoSize = true;
            this.lblboylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblboylam.Location = new System.Drawing.Point(437, 597);
            this.lblboylam.Name = "lblboylam";
            this.lblboylam.Size = new System.Drawing.Size(119, 31);
            this.lblboylam.TabIndex = 53;
            this.lblboylam.Text = "Boylam :";
            // 
            // lblboylamf
            // 
            this.lblboylamf.AutoSize = true;
            this.lblboylamf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblboylamf.Location = new System.Drawing.Point(814, 290);
            this.lblboylamf.Name = "lblboylamf";
            this.lblboylamf.Size = new System.Drawing.Size(119, 31);
            this.lblboylamf.TabIndex = 58;
            this.lblboylamf.Text = "Boylam :";
            // 
            // btnboylamf
            // 
            this.btnboylamf.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnboylamf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnboylamf.Location = new System.Drawing.Point(952, 292);
            this.btnboylamf.Name = "btnboylamf";
            this.btnboylamf.Size = new System.Drawing.Size(152, 29);
            this.btnboylamf.TabIndex = 57;
            this.btnboylamf.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(723, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 31);
            this.label6.TabIndex = 56;
            // 
            // btnenlemf
            // 
            this.btnenlemf.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnenlemf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnenlemf.Location = new System.Drawing.Point(952, 240);
            this.btnenlemf.Name = "btnenlemf";
            this.btnenlemf.Size = new System.Drawing.Size(152, 29);
            this.btnenlemf.TabIndex = 55;
            this.btnenlemf.UseVisualStyleBackColor = false;
            // 
            // lblenlemf
            // 
            this.lblenlemf.AutoSize = true;
            this.lblenlemf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblenlemf.Location = new System.Drawing.Point(814, 241);
            this.lblenlemf.Name = "lblenlemf";
            this.lblenlemf.Size = new System.Drawing.Size(105, 31);
            this.lblenlemf.TabIndex = 54;
            this.lblenlemf.Text = "Enlem :";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1259, 185);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "İrtifa";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(368, 203);
            this.chart1.TabIndex = 59;
            this.chart1.Text = "chart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1394, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 31);
            this.label8.TabIndex = 62;
            this.label8.Text = "İrtifa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(132, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 31);
            this.label9.TabIndex = 63;
            this.label9.Text = "Konum";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(85, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 31);
            this.label10.TabIndex = 64;
            this.label10.Text = "Tahmini Konum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(1362, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 31);
            this.label11.TabIndex = 65;
            this.label11.Text = "Pozisyon";
            // 
            // gMapControl2
            // 
            this.gMapControl2.Bearing = 0F;
            this.gMapControl2.CanDragMap = true;
            this.gMapControl2.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl2.GrayScaleMode = false;
            this.gMapControl2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl2.LevelsKeepInMemmory = 5;
            this.gMapControl2.Location = new System.Drawing.Point(29, 469);
            this.gMapControl2.MarkersEnabled = true;
            this.gMapControl2.MaxZoom = 2;
            this.gMapControl2.MinZoom = 2;
            this.gMapControl2.MouseWheelZoomEnabled = true;
            this.gMapControl2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl2.Name = "gMapControl2";
            this.gMapControl2.NegativeMode = false;
            this.gMapControl2.PolygonsEnabled = true;
            this.gMapControl2.RetryLoadTile = 0;
            this.gMapControl2.RoutesEnabled = true;
            this.gMapControl2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl2.ShowTileGridLines = false;
            this.gMapControl2.Size = new System.Drawing.Size(336, 273);
            this.gMapControl2.TabIndex = 67;
            this.gMapControl2.Zoom = 0D;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(29, 191);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(336, 230);
            this.gMapControl1.TabIndex = 68;
            this.gMapControl1.Zoom = 0D;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.ComPortCloseButton);
            this.groupBox1.Controls.Add(this.ComPortBox);
            this.groupBox1.Controls.Add(this.ComPortStatus);
            this.groupBox1.Controls.Add(this.ComPortOpenButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(870, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(136, 180);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Ayarları";
            // 
            // ComPortCloseButton
            // 
            this.ComPortCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortCloseButton.Location = new System.Drawing.Point(8, 100);
            this.ComPortCloseButton.Name = "ComPortCloseButton";
            this.ComPortCloseButton.Size = new System.Drawing.Size(120, 38);
            this.ComPortCloseButton.TabIndex = 7;
            this.ComPortCloseButton.Text = "Bağlantıyı Kes";
            this.ComPortCloseButton.UseVisualStyleBackColor = true;
            this.ComPortCloseButton.Click += new System.EventHandler(this.ComPortCloseButton_Click);
            // 
            // ComPortBox
            // 
            this.ComPortBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortBox.FormattingEnabled = true;
            this.ComPortBox.Location = new System.Drawing.Point(8, 31);
            this.ComPortBox.Name = "ComPortBox";
            this.ComPortBox.Size = new System.Drawing.Size(120, 21);
            this.ComPortBox.TabIndex = 6;
            // 
            // ComPortStatus
            // 
            this.ComPortStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortStatus.Location = new System.Drawing.Point(8, 144);
            this.ComPortStatus.Name = "ComPortStatus";
            this.ComPortStatus.Size = new System.Drawing.Size(120, 28);
            this.ComPortStatus.TabIndex = 5;
            this.ComPortStatus.Tag = "";
            // 
            // ComPortOpenButton
            // 
            this.ComPortOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortOpenButton.Location = new System.Drawing.Point(8, 58);
            this.ComPortOpenButton.Name = "ComPortOpenButton";
            this.ComPortOpenButton.Size = new System.Drawing.Size(120, 36);
            this.ComPortOpenButton.TabIndex = 4;
            this.ComPortOpenButton.Text = "Bağlan ";
            this.ComPortOpenButton.UseVisualStyleBackColor = true;
            this.ComPortOpenButton.Click += new System.EventHandler(this.ComPortOpenButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 798);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.gMapControl2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblboylamf);
            this.Controls.Add(this.btnboylamf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnenlemf);
            this.Controls.Add(this.lblenlemf);
            this.Controls.Add(this.lblboylam);
            this.Controls.Add(this.btnboylam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblfaydaliyuk);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblanakart);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnyaw);
            this.Controls.Add(this.btnpitch);
            this.Controls.Add(this.btnenlem);
            this.Controls.Add(this.btnirtifa);
            this.Controls.Add(this.btnbasınc);
            this.Controls.Add(this.lblroll);
            this.Controls.Add(this.lblpitch);
            this.Controls.Add(this.lblyaw);
            this.Controls.Add(this.lblirtifa);
            this.Controls.Add(this.lblenlem);
            this.Controls.Add(this.lblbasinc);
            this.Controls.Add(this.btnroll);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.takim_ismi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "KONURALP ROKET TAKIMI-ORTA İRTİFA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox takim_ismi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnroll;
        private System.Windows.Forms.Label lblbasinc;
        private System.Windows.Forms.Label lblenlem;
        private System.Windows.Forms.Label lblirtifa;
        private System.Windows.Forms.Label lblyaw;
        private System.Windows.Forms.Label lblpitch;
        private System.Windows.Forms.Label lblroll;
        private System.Windows.Forms.Button btnbasınc;
        private System.Windows.Forms.Button btnirtifa;
        private System.Windows.Forms.Button btnenlem;
        private System.Windows.Forms.Button btnpitch;
        private System.Windows.Forms.Button btnyaw;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblanakart;
        private System.Windows.Forms.Label lblfaydaliyuk;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnboylam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblboylam;
        private System.Windows.Forms.Label lblboylamf;
        private System.Windows.Forms.Button btnboylamf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnenlemf;
        private System.Windows.Forms.Label lblenlemf;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private GMap.NET.WindowsForms.GMapControl gMapControl2;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ComPortCloseButton;
        private System.Windows.Forms.ComboBox ComPortBox;
        private System.Windows.Forms.ProgressBar ComPortStatus;
        private System.Windows.Forms.Button ComPortOpenButton;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort seriP1;
    }
}


namespace TaxiStationCarTrekking
{
    partial class AddDataForm
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createTransport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numberOfSeats = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.classOfTransport = new System.Windows.Forms.ComboBox();
            this.nameTransport = new System.Windows.Forms.TextBox();
            this.typeOfTransport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeletePointOfRoute = new System.Windows.Forms.Button();
            this.SaveNewRoute = new System.Windows.Forms.Button();
            this.nameRoute = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listOfPoints = new System.Windows.Forms.ListBox();
            this.createRoute = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UpdateDetail = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.arrivalPoint = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.departurePoint = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listOfTransport = new System.Windows.Forms.ListBox();
            this.listOfRoute = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DeleteRouteByTransport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSeats)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
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
            this.gMapControl1.Size = new System.Drawing.Size(949, 448);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMapClick += new GMap.NET.WindowsForms.MapClick(this.gMapControl1_OnMapClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createTransport);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numberOfSeats);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.classOfTransport);
            this.groupBox1.Controls.Add(this.nameTransport);
            this.groupBox1.Controls.Add(this.typeOfTransport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(712, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Створити транспорт";
            // 
            // createTransport
            // 
            this.createTransport.Location = new System.Drawing.Point(6, 177);
            this.createTransport.Name = "createTransport";
            this.createTransport.Size = new System.Drawing.Size(148, 23);
            this.createTransport.TabIndex = 9;
            this.createTransport.Text = "Створення транспорту";
            this.createTransport.UseVisualStyleBackColor = true;
            this.createTransport.Click += new System.EventHandler(this.createTransport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Кількість місць";
            // 
            // numberOfSeats
            // 
            this.numberOfSeats.Location = new System.Drawing.Point(6, 151);
            this.numberOfSeats.Name = "numberOfSeats";
            this.numberOfSeats.Size = new System.Drawing.Size(217, 20);
            this.numberOfSeats.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Клас транспортного засобу";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Тип транспортного засобу";
            // 
            // classOfTransport
            // 
            this.classOfTransport.FormattingEnabled = true;
            this.classOfTransport.Location = new System.Drawing.Point(6, 111);
            this.classOfTransport.Name = "classOfTransport";
            this.classOfTransport.Size = new System.Drawing.Size(217, 21);
            this.classOfTransport.TabIndex = 13;
            // 
            // nameTransport
            // 
            this.nameTransport.Location = new System.Drawing.Point(6, 32);
            this.nameTransport.Name = "nameTransport";
            this.nameTransport.Size = new System.Drawing.Size(217, 20);
            this.nameTransport.TabIndex = 0;
            // 
            // typeOfTransport
            // 
            this.typeOfTransport.FormattingEnabled = true;
            this.typeOfTransport.Location = new System.Drawing.Point(6, 71);
            this.typeOfTransport.Name = "typeOfTransport";
            this.typeOfTransport.Size = new System.Drawing.Size(217, 21);
            this.typeOfTransport.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Назва транспортного засобу";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeletePointOfRoute);
            this.groupBox2.Controls.Add(this.SaveNewRoute);
            this.groupBox2.Controls.Add(this.nameRoute);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.listOfPoints);
            this.groupBox2.Controls.Add(this.createRoute);
            this.groupBox2.Location = new System.Drawing.Point(477, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 201);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Створити маршрут";
            // 
            // DeletePointOfRoute
            // 
            this.DeletePointOfRoute.Location = new System.Drawing.Point(6, 171);
            this.DeletePointOfRoute.Name = "DeletePointOfRoute";
            this.DeletePointOfRoute.Size = new System.Drawing.Size(98, 23);
            this.DeletePointOfRoute.TabIndex = 19;
            this.DeletePointOfRoute.Text = "Видалити точку";
            this.DeletePointOfRoute.UseVisualStyleBackColor = true;
            this.DeletePointOfRoute.Click += new System.EventHandler(this.DeletePointOfRoute_Click);
            // 
            // SaveNewRoute
            // 
            this.SaveNewRoute.Location = new System.Drawing.Point(139, 170);
            this.SaveNewRoute.Name = "SaveNewRoute";
            this.SaveNewRoute.Size = new System.Drawing.Size(75, 23);
            this.SaveNewRoute.TabIndex = 18;
            this.SaveNewRoute.Text = "Зберегти";
            this.SaveNewRoute.UseVisualStyleBackColor = true;
            this.SaveNewRoute.Click += new System.EventHandler(this.SaveNewRoute_Click);
            // 
            // nameRoute
            // 
            this.nameRoute.Location = new System.Drawing.Point(6, 32);
            this.nameRoute.Name = "nameRoute";
            this.nameRoute.Size = new System.Drawing.Size(217, 20);
            this.nameRoute.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Назва маршруту";
            // 
            // listOfPoints
            // 
            this.listOfPoints.FormattingEnabled = true;
            this.listOfPoints.Location = new System.Drawing.Point(6, 57);
            this.listOfPoints.Name = "listOfPoints";
            this.listOfPoints.Size = new System.Drawing.Size(217, 108);
            this.listOfPoints.TabIndex = 10;
            this.listOfPoints.SelectedIndexChanged += new System.EventHandler(this.listOfPoints_SelectedIndexChanged);
            // 
            // createRoute
            // 
            this.createRoute.Location = new System.Drawing.Point(6, 171);
            this.createRoute.Name = "createRoute";
            this.createRoute.Size = new System.Drawing.Size(127, 23);
            this.createRoute.TabIndex = 10;
            this.createRoute.Text = "Створення маршруту";
            this.createRoute.UseVisualStyleBackColor = true;
            this.createRoute.Click += new System.EventHandler(this.createRoute_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeleteRouteByTransport);
            this.groupBox3.Controls.Add(this.UpdateDetail);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.arrivalPoint);
            this.groupBox3.Controls.Add(this.price);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.departurePoint);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.listOfTransport);
            this.groupBox3.Controls.Add(this.listOfRoute);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(7, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 201);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оновлення інформації транспорта";
            // 
            // UpdateDetail
            // 
            this.UpdateDetail.Location = new System.Drawing.Point(229, 170);
            this.UpdateDetail.Name = "UpdateDetail";
            this.UpdateDetail.Size = new System.Drawing.Size(62, 23);
            this.UpdateDetail.TabIndex = 17;
            this.UpdateDetail.Text = "Оновити";
            this.UpdateDetail.UseVisualStyleBackColor = true;
            this.UpdateDetail.Click += new System.EventHandler(this.UpdateDetail_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(229, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Вартість проїзду";
            // 
            // arrivalPoint
            // 
            this.arrivalPoint.Location = new System.Drawing.Point(229, 108);
            this.arrivalPoint.Name = "arrivalPoint";
            this.arrivalPoint.Size = new System.Drawing.Size(229, 20);
            this.arrivalPoint.TabIndex = 8;
            // 
            // price
            // 
            this.price.DecimalPlaces = 2;
            this.price.Location = new System.Drawing.Point(229, 146);
            this.price.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(229, 20);
            this.price.TabIndex = 16;
            this.price.ThousandsSeparator = true;
            this.price.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(226, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Кінцева точка";
            // 
            // departurePoint
            // 
            this.departurePoint.Location = new System.Drawing.Point(229, 70);
            this.departurePoint.Name = "departurePoint";
            this.departurePoint.Size = new System.Drawing.Size(229, 20);
            this.departurePoint.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Початкова точка";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Маршрут";
            // 
            // listOfTransport
            // 
            this.listOfTransport.FormattingEnabled = true;
            this.listOfTransport.Location = new System.Drawing.Point(9, 32);
            this.listOfTransport.Name = "listOfTransport";
            this.listOfTransport.Size = new System.Drawing.Size(214, 160);
            this.listOfTransport.TabIndex = 9;
            this.listOfTransport.SelectedIndexChanged += new System.EventHandler(this.listOfTransport_SelectedIndexChanged);
            // 
            // listOfRoute
            // 
            this.listOfRoute.FormattingEnabled = true;
            this.listOfRoute.Location = new System.Drawing.Point(229, 31);
            this.listOfRoute.Name = "listOfRoute";
            this.listOfRoute.Size = new System.Drawing.Size(229, 21);
            this.listOfRoute.TabIndex = 15;
            this.listOfRoute.SelectedIndexChanged += new System.EventHandler(this.listOfRoute_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Перелік транспортних засобів";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 454);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(949, 226);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // DeleteRouteByTransport
            // 
            this.DeleteRouteByTransport.Location = new System.Drawing.Point(295, 170);
            this.DeleteRouteByTransport.Name = "DeleteRouteByTransport";
            this.DeleteRouteByTransport.Size = new System.Drawing.Size(163, 23);
            this.DeleteRouteByTransport.TabIndex = 18;
            this.DeleteRouteByTransport.Text = "Відмінити|закінчити маршрут";
            this.DeleteRouteByTransport.UseVisualStyleBackColor = true;
            this.DeleteRouteByTransport.Click += new System.EventHandler(this.DeleteRouteByTransport_Click);
            // 
            // AddDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 680);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gMapControl1);
            this.Name = "AddDataForm";
            this.Text = "Додання даних";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddDataForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSeats)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox nameTransport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox classOfTransport;
        private System.Windows.Forms.ComboBox typeOfTransport;
        private System.Windows.Forms.Button createTransport;
        private System.Windows.Forms.NumericUpDown numberOfSeats;
        private System.Windows.Forms.ListBox listOfPoints;
        private System.Windows.Forms.Button createRoute;
        private System.Windows.Forms.ListBox listOfTransport;
        private System.Windows.Forms.TextBox nameRoute;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox arrivalPoint;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox departurePoint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox listOfRoute;
        private System.Windows.Forms.Button UpdateDetail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SaveNewRoute;
        private System.Windows.Forms.Button DeletePointOfRoute;
        private System.Windows.Forms.Button DeleteRouteByTransport;
    }
}
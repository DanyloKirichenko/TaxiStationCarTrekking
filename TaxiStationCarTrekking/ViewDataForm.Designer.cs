namespace TaxiStationCarTrekking
{
    partial class ViewDataForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.ListOfTransport = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фільтриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобіліToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CarSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.BusSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.автобусиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EconomySelected = new System.Windows.Forms.ToolStripMenuItem();
            this.StandartSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.PremiumSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.пропозиціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BusySelected = new System.Windows.Forms.ToolStripMenuItem();
            this.FreeSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.allTransportSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenAddForm = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailsAboutTransport = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 27);
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
            this.gMapControl1.Size = new System.Drawing.Size(570, 461);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            // 
            // ListOfTransport
            // 
            this.ListOfTransport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListOfTransport.FormattingEnabled = true;
            this.ListOfTransport.Location = new System.Drawing.Point(576, 49);
            this.ListOfTransport.Name = "ListOfTransport";
            this.ListOfTransport.Size = new System.Drawing.Size(224, 264);
            this.ListOfTransport.TabIndex = 1;
            this.ListOfTransport.SelectedIndexChanged += new System.EventHandler(this.ListOfTransport_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фільтриToolStripMenuItem,
            this.OpenAddForm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фільтриToolStripMenuItem
            // 
            this.фільтриToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автомобіліToolStripMenuItem,
            this.автобусиToolStripMenuItem,
            this.пропозиціїToolStripMenuItem,
            this.allTransportSelected});
            this.фільтриToolStripMenuItem.Name = "фільтриToolStripMenuItem";
            this.фільтриToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.фільтриToolStripMenuItem.Text = "Фільтри";
            // 
            // автомобіліToolStripMenuItem
            // 
            this.автомобіліToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarSelected,
            this.BusSelected});
            this.автомобіліToolStripMenuItem.Name = "автомобіліToolStripMenuItem";
            this.автомобіліToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.автомобіліToolStripMenuItem.Text = "Місткість";
            // 
            // CarSelected
            // 
            this.CarSelected.Name = "CarSelected";
            this.CarSelected.Size = new System.Drawing.Size(192, 22);
            this.CarSelected.Text = "Легковий автомобіль";
            this.CarSelected.Click += new System.EventHandler(this.CarSelected_Click);
            // 
            // BusSelected
            // 
            this.BusSelected.Name = "BusSelected";
            this.BusSelected.Size = new System.Drawing.Size(192, 22);
            this.BusSelected.Text = "Автобус";
            this.BusSelected.Click += new System.EventHandler(this.BusSelected_Click);
            // 
            // автобусиToolStripMenuItem
            // 
            this.автобусиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EconomySelected,
            this.StandartSelected,
            this.PremiumSelected});
            this.автобусиToolStripMenuItem.Name = "автобусиToolStripMenuItem";
            this.автобусиToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.автобусиToolStripMenuItem.Text = "Клас";
            // 
            // EconomySelected
            // 
            this.EconomySelected.Name = "EconomySelected";
            this.EconomySelected.Size = new System.Drawing.Size(124, 22);
            this.EconomySelected.Text = "Економ";
            this.EconomySelected.Click += new System.EventHandler(this.EconomySelected_Click);
            // 
            // StandartSelected
            // 
            this.StandartSelected.Name = "StandartSelected";
            this.StandartSelected.Size = new System.Drawing.Size(124, 22);
            this.StandartSelected.Text = "Стандарт";
            this.StandartSelected.Click += new System.EventHandler(this.StandartSelected_Click);
            // 
            // PremiumSelected
            // 
            this.PremiumSelected.Name = "PremiumSelected";
            this.PremiumSelected.Size = new System.Drawing.Size(124, 22);
            this.PremiumSelected.Text = "Преміум";
            this.PremiumSelected.Click += new System.EventHandler(this.PremiumSelected_Click);
            // 
            // пропозиціїToolStripMenuItem
            // 
            this.пропозиціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BusySelected,
            this.FreeSelected});
            this.пропозиціїToolStripMenuItem.Name = "пропозиціїToolStripMenuItem";
            this.пропозиціїToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.пропозиціїToolStripMenuItem.Text = "Пропозиції";
            // 
            // BusySelected
            // 
            this.BusySelected.Name = "BusySelected";
            this.BusySelected.Size = new System.Drawing.Size(115, 22);
            this.BusySelected.Text = "Зайняті";
            this.BusySelected.Click += new System.EventHandler(this.BusySelected_Click);
            // 
            // FreeSelected
            // 
            this.FreeSelected.Name = "FreeSelected";
            this.FreeSelected.Size = new System.Drawing.Size(115, 22);
            this.FreeSelected.Text = "Вільні";
            this.FreeSelected.Click += new System.EventHandler(this.FreeSelected_Click);
            // 
            // allTransportSelected
            // 
            this.allTransportSelected.Name = "allTransportSelected";
            this.allTransportSelected.Size = new System.Drawing.Size(136, 22);
            this.allTransportSelected.Text = "Усі";
            this.allTransportSelected.Click += new System.EventHandler(this.allTransportSelected_Click);
            // 
            // OpenAddForm
            // 
            this.OpenAddForm.Name = "OpenAddForm";
            this.OpenAddForm.Size = new System.Drawing.Size(58, 20);
            this.OpenAddForm.Text = "Додати";
            this.OpenAddForm.Click += new System.EventHandler(this.OpenAddForm_Click);
            // 
            // DetailsAboutTransport
            // 
            this.DetailsAboutTransport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsAboutTransport.Location = new System.Drawing.Point(576, 332);
            this.DetailsAboutTransport.Name = "DetailsAboutTransport";
            this.DetailsAboutTransport.ReadOnly = true;
            this.DetailsAboutTransport.Size = new System.Drawing.Size(224, 156);
            this.DetailsAboutTransport.TabIndex = 3;
            this.DetailsAboutTransport.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Подробиці по обраному засобу";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Всі транспортні засоби таксопарку";
            // 
            // ViewDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetailsAboutTransport);
            this.Controls.Add(this.ListOfTransport);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 527);
            this.Name = "ViewDataForm";
            this.Text = "Трекінг транспорту";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewDataForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.ListBox ListOfTransport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фільтриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автобусиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EconomySelected;
        private System.Windows.Forms.ToolStripMenuItem StandartSelected;
        private System.Windows.Forms.ToolStripMenuItem PremiumSelected;
        private System.Windows.Forms.ToolStripMenuItem пропозиціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BusySelected;
        private System.Windows.Forms.ToolStripMenuItem FreeSelected;
        private System.Windows.Forms.ToolStripMenuItem allTransportSelected;
        private System.Windows.Forms.RichTextBox DetailsAboutTransport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem OpenAddForm;
        private System.Windows.Forms.ToolStripMenuItem автомобіліToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CarSelected;
        private System.Windows.Forms.ToolStripMenuItem BusSelected;
    }
}


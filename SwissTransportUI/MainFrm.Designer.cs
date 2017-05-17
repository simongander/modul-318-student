namespace SwissTransportUI
{
    partial class MainFrm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Abfahrt", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Ankunft", System.Windows.Forms.HorizontalAlignment.Left);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageConnections = new System.Windows.Forms.TabPage();
            this.listViewConnections = new System.Windows.Forms.ListView();
            this.columnHeaderDeparture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTravelTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTransportType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePickerSearchTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSearchDate = new System.Windows.Forms.DateTimePicker();
            this.radioButtonArrivalTime = new System.Windows.Forms.RadioButton();
            this.radioButtonDepartureTime = new System.Windows.Forms.RadioButton();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.lblArrivalLocation = new System.Windows.Forms.Label();
            this.lblDepartureLocation = new System.Windows.Forms.Label();
            this.comboBoxArrivalLocation = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartureLocation = new System.Windows.Forms.ComboBox();
            this.tabPageDepartureTable = new System.Windows.Forms.TabPage();
            this.tabPageStations = new System.Windows.Forms.TabPage();
            this.groupBoxSearchBar = new System.Windows.Forms.GroupBox();
            this.btnSearchStations = new System.Windows.Forms.Button();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.listViewStations = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDepartureTable = new System.Windows.Forms.ListView();
            this.groupBoxDepartureTableSearchBar = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.columnHeaderDepTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArrTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArrLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDepLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControlMain.SuspendLayout();
            this.tabPageConnections.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.tabPageDepartureTable.SuspendLayout();
            this.tabPageStations.SuspendLayout();
            this.groupBoxSearchBar.SuspendLayout();
            this.groupBoxDepartureTableSearchBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageConnections);
            this.tabControlMain.Controls.Add(this.tabPageDepartureTable);
            this.tabControlMain.Controls.Add(this.tabPageStations);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(700, 644);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageConnections
            // 
            this.tabPageConnections.Controls.Add(this.listViewConnections);
            this.tabPageConnections.Controls.Add(this.groupBoxSearch);
            this.tabPageConnections.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnections.Name = "tabPageConnections";
            this.tabPageConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnections.Size = new System.Drawing.Size(692, 618);
            this.tabPageConnections.TabIndex = 0;
            this.tabPageConnections.Text = "Verbindungen";
            this.tabPageConnections.UseVisualStyleBackColor = true;
            // 
            // listViewConnections
            // 
            this.listViewConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDeparture,
            this.columnHeaderArrival,
            this.columnHeaderTravelTime,
            this.columnHeaderTransportType});
            this.listViewConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Abfahrt";
            listViewGroup1.Name = "listViewGroupDeparture";
            listViewGroup2.Header = "Ankunft";
            listViewGroup2.Name = "listViewGroupArrival";
            this.listViewConnections.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listViewConnections.Location = new System.Drawing.Point(3, 175);
            this.listViewConnections.Name = "listViewConnections";
            this.listViewConnections.Size = new System.Drawing.Size(686, 440);
            this.listViewConnections.TabIndex = 1;
            this.listViewConnections.UseCompatibleStateImageBehavior = false;
            this.listViewConnections.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDeparture
            // 
            this.columnHeaderDeparture.Text = "Abfahrt";
            this.columnHeaderDeparture.Width = 129;
            // 
            // columnHeaderArrival
            // 
            this.columnHeaderArrival.Text = "Ankunft";
            this.columnHeaderArrival.Width = 136;
            // 
            // columnHeaderTravelTime
            // 
            this.columnHeaderTravelTime.Text = "Reisedauer";
            this.columnHeaderTravelTime.Width = 124;
            // 
            // columnHeaderTransportType
            // 
            this.columnHeaderTransportType.Text = "Verkehrsmittel";
            this.columnHeaderTransportType.Width = 313;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.dateTimePickerSearchTime);
            this.groupBoxSearch.Controls.Add(this.dateTimePickerSearchDate);
            this.groupBoxSearch.Controls.Add(this.radioButtonArrivalTime);
            this.groupBoxSearch.Controls.Add(this.radioButtonDepartureTime);
            this.groupBoxSearch.Controls.Add(this.lblTimeDate);
            this.groupBoxSearch.Controls.Add(this.lblArrivalLocation);
            this.groupBoxSearch.Controls.Add(this.lblDepartureLocation);
            this.groupBoxSearch.Controls.Add(this.comboBoxArrivalLocation);
            this.groupBoxSearch.Controls.Add(this.comboBoxDepartureLocation);
            this.groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearch.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(686, 172);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Suche";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(515, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 122);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Suche";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePickerSearchTime
            // 
            this.dateTimePickerSearchTime.CustomFormat = "HH:mm";
            this.dateTimePickerSearchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSearchTime.Location = new System.Drawing.Point(202, 133);
            this.dateTimePickerSearchTime.Name = "dateTimePickerSearchTime";
            this.dateTimePickerSearchTime.ShowUpDown = true;
            this.dateTimePickerSearchTime.Size = new System.Drawing.Size(81, 20);
            this.dateTimePickerSearchTime.TabIndex = 9;
            // 
            // dateTimePickerSearchDate
            // 
            this.dateTimePickerSearchDate.Location = new System.Drawing.Point(299, 134);
            this.dateTimePickerSearchDate.Name = "dateTimePickerSearchDate";
            this.dateTimePickerSearchDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSearchDate.TabIndex = 8;
            // 
            // radioButtonArrivalTime
            // 
            this.radioButtonArrivalTime.AutoSize = true;
            this.radioButtonArrivalTime.Location = new System.Drawing.Point(103, 134);
            this.radioButtonArrivalTime.Name = "radioButtonArrivalTime";
            this.radioButtonArrivalTime.Size = new System.Drawing.Size(83, 17);
            this.radioButtonArrivalTime.TabIndex = 7;
            this.radioButtonArrivalTime.TabStop = true;
            this.radioButtonArrivalTime.Text = "Ankunftszeit";
            this.radioButtonArrivalTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonDepartureTime
            // 
            this.radioButtonDepartureTime.AutoSize = true;
            this.radioButtonDepartureTime.Location = new System.Drawing.Point(12, 134);
            this.radioButtonDepartureTime.Name = "radioButtonDepartureTime";
            this.radioButtonDepartureTime.Size = new System.Drawing.Size(80, 17);
            this.radioButtonDepartureTime.TabIndex = 6;
            this.radioButtonDepartureTime.TabStop = true;
            this.radioButtonDepartureTime.Text = "Abfahrtszeit";
            this.radioButtonDepartureTime.UseVisualStyleBackColor = true;
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Location = new System.Drawing.Point(9, 118);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(61, 13);
            this.lblTimeDate.TabIndex = 5;
            this.lblTimeDate.Text = "Zeit/Datum";
            // 
            // lblArrivalLocation
            // 
            this.lblArrivalLocation.AutoSize = true;
            this.lblArrivalLocation.Location = new System.Drawing.Point(9, 60);
            this.lblArrivalLocation.Name = "lblArrivalLocation";
            this.lblArrivalLocation.Size = new System.Drawing.Size(61, 13);
            this.lblArrivalLocation.TabIndex = 4;
            this.lblArrivalLocation.Text = "Ankunftsort";
            // 
            // lblDepartureLocation
            // 
            this.lblDepartureLocation.AutoSize = true;
            this.lblDepartureLocation.Location = new System.Drawing.Point(6, 16);
            this.lblDepartureLocation.Name = "lblDepartureLocation";
            this.lblDepartureLocation.Size = new System.Drawing.Size(58, 13);
            this.lblDepartureLocation.TabIndex = 3;
            this.lblDepartureLocation.Text = "Abfahrtsort";
            // 
            // comboBoxArrivalLocation
            // 
            this.comboBoxArrivalLocation.FormattingEnabled = true;
            this.comboBoxArrivalLocation.Location = new System.Drawing.Point(9, 76);
            this.comboBoxArrivalLocation.Name = "comboBoxArrivalLocation";
            this.comboBoxArrivalLocation.Size = new System.Drawing.Size(490, 21);
            this.comboBoxArrivalLocation.TabIndex = 2;
            this.comboBoxArrivalLocation.DropDown += new System.EventHandler(this.comboBoxArrivalLocation_DropDown);
            // 
            // comboBoxDepartureLocation
            // 
            this.comboBoxDepartureLocation.FormattingEnabled = true;
            this.comboBoxDepartureLocation.Location = new System.Drawing.Point(9, 32);
            this.comboBoxDepartureLocation.Name = "comboBoxDepartureLocation";
            this.comboBoxDepartureLocation.Size = new System.Drawing.Size(490, 21);
            this.comboBoxDepartureLocation.TabIndex = 1;
            this.comboBoxDepartureLocation.DropDown += new System.EventHandler(this.comboBoxDepartureLocation_DropDown);
            // 
            // tabPageDepartureTable
            // 
            this.tabPageDepartureTable.Controls.Add(this.groupBoxDepartureTableSearchBar);
            this.tabPageDepartureTable.Controls.Add(this.listViewDepartureTable);
            this.tabPageDepartureTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageDepartureTable.Name = "tabPageDepartureTable";
            this.tabPageDepartureTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartureTable.Size = new System.Drawing.Size(692, 618);
            this.tabPageDepartureTable.TabIndex = 1;
            this.tabPageDepartureTable.Text = "Abfahrtstafel";
            this.tabPageDepartureTable.UseVisualStyleBackColor = true;
            // 
            // tabPageStations
            // 
            this.tabPageStations.Controls.Add(this.groupBoxSearchBar);
            this.tabPageStations.Controls.Add(this.listViewStations);
            this.tabPageStations.Location = new System.Drawing.Point(4, 22);
            this.tabPageStations.Name = "tabPageStations";
            this.tabPageStations.Size = new System.Drawing.Size(692, 618);
            this.tabPageStations.TabIndex = 2;
            this.tabPageStations.Text = "Stationen";
            this.tabPageStations.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchBar
            // 
            this.groupBoxSearchBar.Controls.Add(this.btnSearchStations);
            this.groupBoxSearchBar.Controls.Add(this.txtSearchInput);
            this.groupBoxSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearchBar.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearchBar.Name = "groupBoxSearchBar";
            this.groupBoxSearchBar.Size = new System.Drawing.Size(692, 53);
            this.groupBoxSearchBar.TabIndex = 1;
            this.groupBoxSearchBar.TabStop = false;
            this.groupBoxSearchBar.Text = "Suche";
            // 
            // btnSearchStations
            // 
            this.btnSearchStations.Location = new System.Drawing.Point(545, 16);
            this.btnSearchStations.Name = "btnSearchStations";
            this.btnSearchStations.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStations.TabIndex = 1;
            this.btnSearchStations.Text = "Suche";
            this.btnSearchStations.UseVisualStyleBackColor = true;
            this.btnSearchStations.Click += new System.EventHandler(this.btnSearchStations_Click);
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Location = new System.Drawing.Point(6, 19);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(519, 20);
            this.txtSearchInput.TabIndex = 0;
            // 
            // listViewStations
            // 
            this.listViewStations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName});
            this.listViewStations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewStations.Location = new System.Drawing.Point(0, 59);
            this.listViewStations.Name = "listViewStations";
            this.listViewStations.Size = new System.Drawing.Size(692, 559);
            this.listViewStations.TabIndex = 0;
            this.listViewStations.UseCompatibleStateImageBehavior = false;
            this.listViewStations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 763;
            // 
            // listViewDepartureTable
            // 
            this.listViewDepartureTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDepLocation,
            this.columnHeaderDepTime,
            this.columnHeaderArrLocation,
            this.columnHeaderArrTime,
            this.columnHeaderDuration,
            this.columnHeaderVehicle});
            this.listViewDepartureTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewDepartureTable.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewDepartureTable.Location = new System.Drawing.Point(3, 103);
            this.listViewDepartureTable.Name = "listViewDepartureTable";
            this.listViewDepartureTable.Size = new System.Drawing.Size(686, 512);
            this.listViewDepartureTable.TabIndex = 0;
            this.listViewDepartureTable.UseCompatibleStateImageBehavior = false;
            this.listViewDepartureTable.View = System.Windows.Forms.View.Details;
            // 
            // groupBoxDepartureTableSearchBar
            // 
            this.groupBoxDepartureTableSearchBar.Controls.Add(this.comboBox1);
            this.groupBoxDepartureTableSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDepartureTableSearchBar.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDepartureTableSearchBar.Name = "groupBoxDepartureTableSearchBar";
            this.groupBoxDepartureTableSearchBar.Size = new System.Drawing.Size(686, 100);
            this.groupBoxDepartureTableSearchBar.TabIndex = 1;
            this.groupBoxDepartureTableSearchBar.TabStop = false;
            this.groupBoxDepartureTableSearchBar.Text = "groupBox1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(342, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // columnHeaderDepTime
            // 
            this.columnHeaderDepTime.Text = "Abfahrtszeit";
            this.columnHeaderDepTime.Width = 86;
            // 
            // columnHeaderArrTime
            // 
            this.columnHeaderArrTime.Text = "Ankunftszeit";
            this.columnHeaderArrTime.Width = 81;
            // 
            // columnHeaderArrLocation
            // 
            this.columnHeaderArrLocation.Text = "Ankunftsort";
            this.columnHeaderArrLocation.Width = 81;
            // 
            // columnHeaderDepLocation
            // 
            this.columnHeaderDepLocation.Text = "Abfahrtsort";
            this.columnHeaderDepLocation.Width = 73;
            // 
            // columnHeaderDuration
            // 
            this.columnHeaderDuration.Text = "Fahrzeit";
            this.columnHeaderDuration.Width = 136;
            // 
            // columnHeaderVehicle
            // 
            this.columnHeaderVehicle.Text = "Verkehrsmittel";
            this.columnHeaderVehicle.Width = 229;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 644);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainFrm";
            this.Text = "Fahrplan";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageConnections.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.tabPageDepartureTable.ResumeLayout(false);
            this.tabPageStations.ResumeLayout(false);
            this.groupBoxSearchBar.ResumeLayout(false);
            this.groupBoxSearchBar.PerformLayout();
            this.groupBoxDepartureTableSearchBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageConnections;
        private System.Windows.Forms.TabPage tabPageDepartureTable;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxArrivalLocation;
        private System.Windows.Forms.ComboBox comboBoxDepartureLocation;
        private System.Windows.Forms.TabPage tabPageStations;
        private System.Windows.Forms.RadioButton radioButtonArrivalTime;
        private System.Windows.Forms.RadioButton radioButtonDepartureTime;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Label lblArrivalLocation;
        private System.Windows.Forms.Label lblDepartureLocation;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchDate;
        private System.Windows.Forms.ListView listViewConnections;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader columnHeaderDeparture;
        private System.Windows.Forms.ColumnHeader columnHeaderArrival;
        private System.Windows.Forms.ColumnHeader columnHeaderTravelTime;
        private System.Windows.Forms.ColumnHeader columnHeaderTransportType;
        private System.Windows.Forms.ListView listViewStations;
        private System.Windows.Forms.GroupBox groupBoxSearchBar;
        private System.Windows.Forms.Button btnSearchStations;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.GroupBox groupBoxDepartureTableSearchBar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listViewDepartureTable;
        private System.Windows.Forms.ColumnHeader columnHeaderDepLocation;
        private System.Windows.Forms.ColumnHeader columnHeaderDepTime;
        private System.Windows.Forms.ColumnHeader columnHeaderArrLocation;
        private System.Windows.Forms.ColumnHeader columnHeaderArrTime;
        private System.Windows.Forms.ColumnHeader columnHeaderDuration;
        private System.Windows.Forms.ColumnHeader columnHeaderVehicle;
    }
}


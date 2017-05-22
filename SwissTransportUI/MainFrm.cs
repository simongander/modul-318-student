using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportUI
{
    public partial class MainFrm : Form
    {
        SwissTransport.Transport transport = new SwissTransport.Transport();

        //Initialisiert das Hauftfenster
        public MainFrm()
        {
            InitializeComponent();
        }

        //Tab Verbindungen
        //Lädt die gefundenen Stationen ins Dropdown-Menü wenn das Dropdown ausgeklappt wird
        private void comboBoxDepartureLocation_DropDown(object sender, EventArgs e)
        {
            SearchStationFromComboBox(comboBoxDepartureLocation);
        }

        //Lädt die gefundenen Stationen ins Dropdown-Menü wenn das Dropdown ausgeklappt wird
        private void comboBoxArrivalLocation_DropDown(object sender, EventArgs e)
        {
            SearchStationFromComboBox(comboBoxArrivalLocation);
        }

        //Blendet die Erweiterten Suchparameter ein oder aus, je nach dem, ob die Checkbox Checked ist oder nicht
        private void checkBoxExtendedSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExtendedSearch.Checked == true)
            {
                groupBoxDateTime.Visible = true;
            }
            else
            {
                groupBoxDateTime.Visible = false;
            }
        }

        //Tab Abfahrtstafel
        //Lädt die gefundenen Stationen ins Dropdown-Menü wenn das Dropdown ausgeklappt wird
        private void comboBoxDepartureTable_DropDown(object sender, EventArgs e)
        {
            SearchStationFromComboBox(comboBoxDepartureTable);
        }

        //Sucht die Verbindungen, die von der gewählten Station aus abfahren
        private void comboBoxDepartureTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] splittedStringInfos = new string[2];

            splittedStringInfos = comboBoxDepartureTable.Text.Split(';');
            //String Trimmen um den Leerschlag vor der ID zu entfernen
            CreateDepartureTable(splittedStringInfos[0], splittedStringInfos[1].Trim(' '));
        }

        //Tab Stationen
        //Sucht die Stationen und schreibt die Ergebnisse in die ListView
        private void btnSearchStations_Click(object sender, EventArgs e)
        {
            listViewStations.Items.Clear();
            SwissTransport.Stations resultStations = null;
            resultStations = transport.GetStations("*" + txtSearchInput.Text + "*");
            foreach (SwissTransport.Station Station in resultStations.StationList)
            {
                listViewStations.Items.Add(Station.Name);
            }
        }

        //Sucht die Verbindungen zwischen den in den Comboboxen angegebenen Stationen
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SwissTransport.Connections resultConnections = null;
            resultConnections = transport.GetConnections(comboBoxDepartureLocation.Text,comboBoxArrivalLocation.Text);
            foreach (SwissTransport.Connection connection in resultConnections.ConnectionList)
            {
                ListViewItem lvi = new ListViewItem(GetFormattedTimeString(connection.From.Departure));
                lvi.SubItems.Add(GetFormattedTimeString(connection.To.Arrival));
                lvi.SubItems.Add(GetFormattedDurationString(connection.Duration));

                listViewConnections.Items.Add(lvi);
            }
        }

        //Funktionen
        //Funktion um die Stationen in eine Combobox zu laden
        private void SearchStationFromComboBox(ComboBox ComboBox)
        {
            ComboBox.Items.Clear();
            SwissTransport.Stations resultStations = null;
            resultStations = transport.GetStations("*" + ComboBox.Text + "*");
            foreach (SwissTransport.Station Station in resultStations.StationList)
            {
                ComboBox.Items.Add(Station);
            }
        }

        //Funktion um die Abbfahrtszeit und Ankunftszeit zu formatieren
        private string GetFormattedTimeString(string date)
        {
            DateTime formattedDate = Convert.ToDateTime(date);
            return formattedDate.ToString("HH:mm");
        }

        //Funktion um die Fahrzeit zu formatieren
        private string GetFormattedDurationString(string time)
        {
            return time.Replace("00d", string.Empty);
        }

        //Funktion um die Abfahrtstafel zu erstellen
        private void CreateDepartureTable(string stationName, string stationId)
        {
            listViewDepartureTable.Items.Clear();

            SwissTransport.StationBoardRoot resultStations = null;
            resultStations = transport.GetStationBoard(stationName,stationId);

            foreach (SwissTransport.StationBoard connectionFromStation in resultStations.Entries)
            {
                ListViewItem lvi = new ListViewItem(connectionFromStation.Stop.Departure.ToString("HH:mm"));
                lvi.SubItems.Add(connectionFromStation.To);
                lvi.SubItems.Add(connectionFromStation.Category);

                listViewDepartureTable.Items.Add(lvi);
            }
        }
    }
}
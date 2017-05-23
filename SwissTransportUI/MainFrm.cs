namespace SwissTransportUI
{
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    public partial class MainFrm : Form
    {
        SwissTransport.Transport transport = new SwissTransport.Transport();

        // Initialisiert das Hauftfenster
        public MainFrm()
        {
            InitializeComponent();
        }

        // Tab Verbindungen Event

        // Lädt die gefundenen Stationen ins Dropdown-Menü wenn das Dropdown ausgeklappt wird
        private void ComboBoxDepartureLocation_DropDown(object sender, EventArgs e)
        {
            SearchStationFromComboBox(comboBoxDepartureLocation);
        }

        // Lädt die gefundenen Stationen ins Dropdown-Menü wenn das Dropdown ausgeklappt wird
        private void ComboBoxArrivalLocation_DropDown(object sender, EventArgs e)
        {
            SearchStationFromComboBox(comboBoxArrivalLocation);
        }

        // Blendet die Erweiterten Suchparameter ein oder aus, je nach dem, ob die Checkbox Checked ist oder nicht
        private void CheckBoxExtendedSearch_CheckedChanged(object sender, EventArgs e)
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

        // Sucht die Verbindungen zwischen den in den Comboboxen angegebenen Stationen
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            byte isArrivalTime = 1;

            if (radioButtonArrivalTime.Checked == true)
            {
                isArrivalTime = 1;
            }
            else if (radioButtonDepartureTime.Checked == true)
            {
                isArrivalTime = 0;
            }

            listViewConnections.Items.Clear();

            SwissTransport.Connections resultConnections = null;
            resultConnections = transport.GetConnections(comboBoxDepartureLocation.Text, comboBoxArrivalLocation.Text, dateTimePickerSearchDate.Value.ToShortDateString(), dateTimePickerSearchTime.Text, isArrivalTime );
            foreach (SwissTransport.Connection connection in resultConnections.ConnectionList)
            {
                ListViewItem lvi = new ListViewItem(GetFormattedTimeString(connection.From.Departure));
                lvi.SubItems.Add(GetFormattedTimeString(connection.To.Arrival));
                lvi.SubItems.Add(GetFormattedDurationString(connection.Duration));

                listViewConnections.Items.Add(lvi);
            }
        }

        //Aktiviert den Suchbutton wenn beide Comboboxen valid sind
        private void comboBoxDepartureLocation_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = IsComboBoxValid();
        }

        //Aktiviert den Suchbutton wenn beide Comboboxen valid sind
        private void comboBoxArrivalLocation_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = IsComboBoxValid();
        }

        // Tab Abfahrtstafel Events

        // Lädt die gefundenen Stationen ins Dropdown-Menü wenn das Dropdown ausgeklappt wird
        private void ComboBoxDepartureTable_DropDown(object sender, EventArgs e)
        {
            SearchStationFromComboBox(comboBoxDepartureTable);
        }

        // Sucht die Verbindungen, die von der gewählten Station aus abfahren
        private void ComboBoxDepartureTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] splittedStringInfos = new string[2];

            splittedStringInfos = comboBoxDepartureTable.Text.Split(';');
            // String Trimmen um den Leerschlag vor der ID zu entfernen
            CreateDepartureTable(splittedStringInfos[0], splittedStringInfos[1].Trim(' '));
        }

        // Tab Stationen Events

        // Sucht die Stationen und schreibt die Ergebnisse in die ListView
        private void BtnSearchStations_Click(object sender, EventArgs e)
        {
            listViewStations.Items.Clear();
            SwissTransport.Stations resultStations = null;
            resultStations = transport.GetStations("*" + txtSearchInput.Text + "*");
            foreach (SwissTransport.Station station in resultStations.StationList)
            {
                ListViewItem lvi = new ListViewItem(station.Name);
                lvi.SubItems.Add(station.Coordinate.XCoordinate.ToString());
                lvi.SubItems.Add(station.Coordinate.YCoordinate.ToString());

                listViewStations.Items.Add(lvi);
            }
        }

        //Aktiviert den Suchbutton wenn die Textbox valid ist
        private void TxtSearchInput_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchInput.Text != string.Empty)
            {
                btnSearchStations.Enabled = true;
            }
            else
            {
                btnSearchStations.Enabled = false;
            }
        }

        // Funktionen

        // Funktion um die Stationen in eine Combobox zu laden
        private void SearchStationFromComboBox(ComboBox ComboBox)
        {
            ComboBox.Items.Clear();
            SwissTransport.Stations resultStations = null;
            resultStations = transport.GetStations("*" + ComboBox.Text + "*");
            foreach (SwissTransport.Station station in resultStations.StationList)
            {
                ComboBox.Items.Add(station);
            }
        }

        // Funktion um die Abbfahrtszeit und Ankunftszeit zu formatieren
        private string GetFormattedTimeString(string date)
        {
            DateTime formattedDate = Convert.ToDateTime(date);
            return formattedDate.ToString("HH:mm");
        }

        // Funktion um die Fahrzeit zu formatieren
        private string GetFormattedDurationString(string time)
        {
            return time.Replace("00d", string.Empty);
        }

        // Funktion um das Datum für die Verbindungssuche zu Formatieren
        private string GetFormattedDateString(string date)
        {
            DateTime formattedDate = Convert.ToDateTime(date);
            return formattedDate.ToString("YYYY-MM-DD");
        }

        // Funktion um die Abfahrtstafel zu erstellen
        private void CreateDepartureTable(string stationName, string stationId)
        {
            listViewDepartureTable.Items.Clear();

            SwissTransport.StationBoardRoot resultStations = null;
            resultStations = transport.GetStationBoard(stationName, stationId);

            try
            {
                foreach (SwissTransport.StationBoard connectionFromStation in resultStations.Entries)
                {
                    ListViewItem lvi = new ListViewItem(connectionFromStation.Stop.Departure.ToString("HH:mm"));
                    lvi.SubItems.Add(connectionFromStation.To);
                    lvi.SubItems.Add(connectionFromStation.Category);

                    listViewDepartureTable.Items.Add(lvi);
                }
            }
            catch
            {
                MessageBox.Show("Es wurden keine Ergebnisse gefunden");
            }
        }
        //Überprüft ob eine Eingabe in die Comboboxen gemacht wurde
        private bool IsComboBoxValid()
        {
            if (comboBoxArrivalLocation.Text != string.Empty && comboBoxDepartureLocation.Text != string.Empty)
            {
                return true;
            }
            return false;
        }


    }
}
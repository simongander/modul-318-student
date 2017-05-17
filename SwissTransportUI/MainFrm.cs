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

        public MainFrm()
        {
            InitializeComponent();
        }

        private void comboBoxDepartureLocation_DropDown(object sender, EventArgs e)
        {
            SearchStationFromComboBox(comboBoxDepartureLocation);
        }

        private void comboBoxArrivalLocation_DropDown(object sender, EventArgs e)
        {
            SearchStationFromComboBox(comboBoxArrivalLocation);
        }

        private void btnSearchStations_Click(object sender, EventArgs e)
        {
            listViewStations.Items.Clear();
            SwissTransport.Stations resultstations = null;
            resultstations = transport.GetStations("*" + txtSearchInput.Text + "*");
            foreach (SwissTransport.Station Station in resultstations.StationList)
            {
                listViewStations.Items.Add(Station.Name);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SwissTransport.Connections resultconnections = null;
            resultconnections = transport.GetConnections(comboBoxDepartureLocation.Text,comboBoxArrivalLocation.Text);
            foreach (SwissTransport.Connection connection in resultconnections.ConnectionList)
            {
                ListViewItem lvi = new ListViewItem(GetFormattedTimeString(connection.From.Departure));
                lvi.SubItems.Add(GetFormattedTimeString(connection.To.Arrival));
                lvi.SubItems.Add(GetFormattedDurationString(connection.Duration));

                listViewConnections.Items.Add(lvi);
            }
        }

        public void SearchStationFromComboBox(ComboBox ComboBox)
        {
            ComboBox.Items.Clear();
            SwissTransport.Stations resultstations = null;
            resultstations = transport.GetStations("*" + ComboBox.Text + "*");
            foreach (SwissTransport.Station Station in resultstations.StationList)
            {
                ComboBox.Items.Add(Station.Name);
            }
        }

        private string GetFormattedTimeString(string date)
        {
            DateTime formattedDate = Convert.ToDateTime(date);
            return formattedDate.ToString("HH:mm");
        }
        private string GetFormattedDurationString(string time)
        {
            return time.Replace("00d", string.Empty);
        }
    }

}


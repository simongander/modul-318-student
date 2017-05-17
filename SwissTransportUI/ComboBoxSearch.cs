using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportUI
{
    public static class ComboBoxSearch
    {
        public static void SearchStationFromComboBox(SwissTransport.Transport transport, String SearchString)
        {
            SwissTransport.Stations resultstations = null;
            resultstations = transport.GetStations("*" + SearchString + "*");
        }
    }
}

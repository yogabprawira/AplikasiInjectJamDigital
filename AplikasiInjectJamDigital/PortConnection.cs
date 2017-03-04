using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace AplikasiInjectJamDigital
{
    public class PortConnection
    {
        public void detect(ComboBox combo)
        {
            String[] ports = SerialPort.GetPortNames();
            combo.Items.Clear();
            foreach (String port in ports)
            {
                combo.Items.Add(port);
            }
        }
    }
}

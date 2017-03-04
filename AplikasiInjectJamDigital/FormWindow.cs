using System;
using System.Windows.Forms;
using System.Reflection;

namespace AplikasiInjectJamDigital
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            /*
            Assembly parsingTextDLL = Assembly.LoadFrom("ParsingText.dll");
            Type parsingType = parsingTextDLL.GetType("ParsingTextNamespace.ParsingText");
            object parsingObj = Activator.CreateInstance(parsingType);
            MethodInfo[] methods = parsingType.GetMethods();
            object parsingTextObj = methods[0].Invoke(parsingObj, new object[] { clockRTextBox, hexaRTextBox });
            */
            ParsingText parsingText = new ParsingText();
            parsingText.clockToHexa(clockRTextBox, hexaRTextBox);
        }

        private void clockRTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            RightClickMenu rightClickClock = new RightClickMenu();
            rightClickClock.create(clockRTextBox, e);            
        }

        private void hexaRTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            RightClickMenu rightClickHexa = new RightClickMenu();
            rightClickHexa.create(hexaRTextBox, e);  
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            clockRTextBox.Clear();
            hexaRTextBox.Clear();
        }

        private void refreshPortButton_Click(object sender, EventArgs e)
        {
            PortConnection portConn = new PortConnection();
            portConn.detect(serialPortComboBox);
        }
    }
}

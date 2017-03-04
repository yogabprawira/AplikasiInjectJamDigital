using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AplikasiInjectJamDigital
{
    public class ParsingText
    {
        public void clockToHexa(RichTextBox rTextBoxClock, RichTextBox rTextBoxHexa)
        {
            String[] textBoxPerLine = rTextBoxClock.Lines;
            String[] textBoxAfterTrimTab = new String[rTextBoxClock.Lines.Length];
            String[] textBoxAfterTrimColon = new String[rTextBoxClock.Lines.Length];
            rTextBoxHexa.Clear();
            rTextBoxHexa.AppendText("{");
            for (int counter = 0; counter < rTextBoxClock.Lines.Length; counter++)
            {
                textBoxAfterTrimTab[counter] = textBoxPerLine[counter].Replace("\t", "");
                textBoxAfterTrimColon[counter] = textBoxAfterTrimTab[counter].Replace(":", "");
                String[] hexaCode = new String[textBoxAfterTrimColon[counter].Length / 2];
                int[] byteCode = new int[textBoxAfterTrimColon[counter].Length / 2];
                int[] hour = new int[(textBoxAfterTrimColon[counter].Length - 2) / 4];
                int[] minute = new int[(textBoxAfterTrimColon[counter].Length - 2) / 4];
                int[] byteClock = new int[(textBoxAfterTrimColon[counter].Length - 2) / 4];
                for (int countByte = 0; countByte < textBoxAfterTrimColon[counter].Length / 2; countByte++)
                {
                    byteCode[countByte] = Int32.Parse(textBoxAfterTrimColon[counter].Substring(2 * countByte, 2));
                }
                for (int count = 0; count < (textBoxAfterTrimColon[counter].Length - 2) / 4; count++)
                {
                    hour[count] = byteCode[(2 * count) + 1];
                    minute[count] = byteCode[(2 * count) + 2];
                }
                if (hour[0] == 5) byteClock[0] = minute[0] + 128;
                else if (hour[0] == 4) byteClock[0] = minute[0];
                if (hour[1] == 6) byteClock[1] = minute[1] + 128;
                else if (hour[1] == 5) byteClock[1] = minute[1];
                if (hour[2] == 12) byteClock[2] = minute[2] + 128;
                else if (hour[2] == 11) byteClock[2] = minute[2];
                if (hour[3] == 15) byteClock[3] = minute[3] + 128;
                else if (hour[3] == 14) byteClock[3] = minute[3];
                if (hour[4] == 18) byteClock[4] = minute[4] + 128;
                else if (hour[4] == 17) byteClock[4] = minute[4];
                if (hour[5] == 19) byteClock[5] = minute[5] + 128;
                else if (hour[5] == 18) byteClock[5] = minute[5];

                for (int countHex = 0; countHex < byteClock.Length; countHex++)
                {
                    hexaCode[countHex] = String.Format("{0:x}", byteClock[countHex]);
                    rTextBoxHexa.AppendText("0x" + hexaCode[countHex]);
                    if (!((counter == 30) && (countHex == byteClock.Length - 1)))
                        rTextBoxHexa.AppendText(", ");
                }
                if (counter != 30) rTextBoxHexa.AppendText("\n");
            }
            for (int countZero = 0; countZero < 31 - rTextBoxClock.Lines.Length; countZero++)
            {
                rTextBoxHexa.AppendText("0x00, 0x00, 0x00, 0x00, 0x00, 0x00");
                if (!(countZero == 30 - rTextBoxClock.Lines.Length)) rTextBoxHexa.AppendText(",\n");
            }
            rTextBoxHexa.AppendText("};");
        }
    }
}

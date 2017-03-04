using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AplikasiInjectJamDigital
{
    public class RightClickMenu
    {
        private RichTextBox rTextBox;

        public void create(RichTextBox rTextBox1, MouseEventArgs e)
        {
            rTextBox = rTextBox1;
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu contextMenu = new ContextMenu();
                MenuItem menuItem = new MenuItem("Cut");
                menuItem.Click += new EventHandler(CutAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Copy");
                menuItem.Click += new EventHandler(CopyAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Paste");
                menuItem.Click += new EventHandler(PasteAction);
                contextMenu.MenuItems.Add(menuItem);
                menuItem = new MenuItem("Select All");
                menuItem.Click += new EventHandler(SelectAllAction);
                contextMenu.MenuItems.Add(menuItem);

                rTextBox.ContextMenu = contextMenu;
            }
        }

        private void CutAction(object sender, EventArgs e)
        {
            rTextBox.Cut();
        }

        private void CopyAction(object sender, EventArgs e)
        {
            Clipboard.SetText(rTextBox.SelectedText);
        }

        private void PasteAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                rTextBox.Text += Clipboard.GetText(TextDataFormat.Text).ToString();
            }
        }

        private void SelectAllAction(object sender, EventArgs e)
        {
            rTextBox.SelectAll();
        }
    }
}

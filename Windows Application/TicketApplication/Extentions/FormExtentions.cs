using System;
using System.Windows.Forms;

namespace TicketApplication.Extentions
{
    public static class FormExtentions
    {
        public static void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
        public static void LabelBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is Label)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    LabelBoxes(ctrl.Controls);
                }
            }
        }
        public static void TextAreaBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is RichTextBox)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    LabelBoxes(ctrl.Controls);
                }
            }
        }
    }
}

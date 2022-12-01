using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tab_style_button_highlight
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RadioButtonEx.Click += onAnyClick;
        }

        private void onAnyClick(object sender, EventArgs e)
        {
            label1.Text = ((RadioButtonEx)sender).Text;
        }
    }
    public class RadioButtonEx : RadioButton
    {
        public static new event EventHandler Click;
        public RadioButtonEx() 
        {
            FlatAppearance.BorderColor = Color.Red;
            FlatAppearance.BorderSize = 1;
            Appearance = Appearance.Button;
        }
        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);
            if(Checked)
            {
                FlatStyle = FlatStyle.Flat;
                Click?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                FlatStyle = FlatStyle.Standard;
            }
        }
    }
}

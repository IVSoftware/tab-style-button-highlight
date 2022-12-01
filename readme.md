This might lend itself to a `RadioButton` style functionality. To implement the "generalized approach" that you mention in your comment, you could make a simple custom `RadioButtonEx` class where the `Appearance` property is set to `Button` then change your border style when the `Checked` property changes.

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

![screenshot]()
using System;
using System.Windows.Forms;


namespace MarkTwain
{
    public partial class SettingsForm : Form
    {
        MarkTwainOptions options = new MarkTwainOptions();

        public SettingsForm(string optionString)
        {
            InitializeComponent();
            try
            {
                var opts = MarkTwainOptions.Deserialize(optionString);
                nudMinPasswordLength.Value = opts.MinimumPasswordLength;
                nudMaxPasswordLength.Value = opts.MaximumPasswordLength;
                nudNumWords.Value = opts.NumberOfWords;
                nudMinLength.Value = opts.MinimumWordLength;
                nudMaxLength.Value = opts.MaximumWordLength;
            }
            catch
            {
                nudMinPasswordLength.Value = 11;
                nudMaxPasswordLength.Value = 1000;
                nudNumWords.Value = 2;
                nudMinLength.Value = 3;
                nudMaxLength.Value = 10;
            }
            ;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            options.MinimumPasswordLength = (int)nudMinPasswordLength.Value;
            options.MaximumPasswordLength = (int)nudMaxPasswordLength.Value;
            options.NumberOfWords = (int)nudNumWords.Value;
            options.MinimumWordLength = (int)nudMinLength.Value;
            options.MaximumWordLength = (int)nudMaxLength.Value;
            this.DialogResult = DialogResult.OK;
        }

        public string GetSettings()
        {
            return options.Serialize();
        }

        private void nudMaxPasswordLength_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinPasswordLength.Value > nudMaxPasswordLength.Value)
            {
                nudMaxPasswordLength.Value = nudMinPasswordLength.Value;
            }
        }

        private void nudMinPasswordLength_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinPasswordLength.Value > nudMaxPasswordLength.Value)
            {
                nudMinPasswordLength.Value = nudMaxPasswordLength.Value;
            }
        }

        private void nudMinLength_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinLength.Value > nudMaxLength.Value)
            {
                nudMinLength.Value = nudMaxLength.Value;
            }
        }

        private void nudMaxLength_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinLength.Value > nudMaxLength.Value)
            {
                nudMaxLength.Value = nudMinLength.Value;
            }
        }
    }
}

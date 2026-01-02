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
                nudNumWords.Value = opts.NumberOfWords;
                nudMinLength.Value = opts.MinimumWordLength;
                nudMaxLength.Value = opts.MaximumWordLength;
            }
            catch
            {
                nudMinPasswordLength.Value = 8;
                nudNumWords.Value = 2;
                nudMinLength.Value = 3;
                nudMaxLength.Value = 10;
            }
            ;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            options.MinimumPasswordLength = (int)nudMinPasswordLength.Value;
            options.NumberOfWords = (int)nudNumWords.Value;
            options.MinimumWordLength = (int)nudMinLength.Value;
            options.MaximumWordLength = (int)nudMaxLength.Value;
            this.DialogResult = DialogResult.OK;
        }

        public string GetSettings()
        {
            return options.Serialize();
        }

    }
}

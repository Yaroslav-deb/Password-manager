using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PasswordManager.personalizedTools
{
    public partial class LoginTextBox : UserControl
    {
        public LoginTextBox()
        {
            InitializeComponent();
            textBox1.TextChanged += (s, e) => TextChanged?.Invoke(this, e);
        }

        [Browsable(true)]
        public new event EventHandler TextChanged;

        private string _label;
        private bool _isPassword;

        public string label
        {
            get { return _label; }
            set
            {
                _label = value;
                if (label1 != null)
                    label1.Text = _label;
            }
        }

        public bool isPassword
        {
            get { return _isPassword; }
            set
            {
                _isPassword = value;
                if (textBox1 != null)
                {
                    textBox1.UseSystemPasswordChar = _isPassword;
                }
            }
        }

        [Browsable(true)]
        public override string Text
        {
            get
            {
                return textBox1 != null ? textBox1.Text : "";
            }
            set
            {
                if (textBox1 != null)
                    textBox1.Text = value;
            }
        }
    }
}
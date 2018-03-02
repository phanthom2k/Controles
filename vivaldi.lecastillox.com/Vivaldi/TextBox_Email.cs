using System;
using System.Text;

namespace Vivaldi.UserControls
{
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class TextBox_Email : TextBox
    {
        System.Windows.Forms.ToolTip tt;

        public TextBox_Email()
        {
            this.Enter += new System.EventHandler(this.TextBox_Email_Enter);
            this.Leave += new EventHandler(TextBox_Email_Leave);
            this.TextChanged += new EventHandler(TextBox_Email_TextChanged);
            this.BackColor = System.Drawing.Color.Empty;
            this.MaxLength = 300;
            this.Size = new System.Drawing.Size(200, 22);
            tt = new System.Windows.Forms.ToolTip();
            Valido = false;
        }

        private void TextBox_Email_TextChanged(object sender, EventArgs e)
        {
            string pattern = null;
            pattern =
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if (Regex.IsMatch(this.Text, pattern))
            {
                MostratToolTip(true);
                Valido = true;
            }
            else if (string.IsNullOrWhiteSpace(this.Text))
            {
                this.BackColor = System.Drawing.Color.Empty;
                Valido = false;
            }
            else
            {
                MostratToolTip(false);
                Valido = false;
            }
        }
        public bool Valido { get; set; }
        private void TextBox_Email_Enter(object sender, EventArgs e)
        {
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9, System.Drawing.FontStyle.Bold);
        }
        private void TextBox_Email_Leave(object sender, EventArgs e)
        {
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Regular);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
        private void MostratToolTip(bool es)
        {
            if (es)
            {
                tt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
                tt.ToolTipTitle = "Email Valido";
                tt.Show("El email ingresado si es valido.", this, this.Width + 20, -20, 5000);
                this.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                tt.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
                tt.ToolTipTitle = "Email Invalido";
                tt.Show("El email ingresado no es valido.", this, this.Width + 20, -20, 5000);
                this.BackColor = System.Drawing.Color.Red;
            }
        }

    }
}

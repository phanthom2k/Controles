///EXPERIMENTAL
using System;
using System.Collections.Generic;
using System.Text;

namespace Vivaldi
{
    using System.Windows.Forms;
    using System.Drawing;
    using System.Globalization;

    public class DecimalTextBox : TextBox
    {

        bool allowDecimal = false;
        bool allowSeparator = false;
        bool skipEvent = false;

        int decimalCount = 0;
        int separatorCount = 0;

        NumberFormatInfo numberFormatInfo;
        string decimalSeparator;
        string groupSeparator;
        string negativeSign;
        int[] groupSize;

        public DecimalTextBox()
        {
            numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
            decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            groupSeparator = numberFormatInfo.NumberGroupSeparator;
            groupSize = numberFormatInfo.NumberGroupSizes;
            negativeSign = numberFormatInfo.NegativeSign;
        }

        protected override void OnLeave(EventArgs e)
        {
            this.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }
        protected override void OnEnter(EventArgs e)
        {
            this.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            this.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && this.Text.IndexOf(groupSeparator) != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            //if (!System.Text.RegularExpressions.Regex.IsMatch(this.Text, @"^(([0-9]+)(\.[0-9]{1,2}|\.)?)$"))
            //{
            //    e.Handled = true;
            //}

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            //   base.OnKeyDown(e);
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {

            //base.OnKeyUp(e);

            //if (skipEvent)
            //{
            //    skipEvent = false;
            //    return;
            //}
            if (string.IsNullOrEmpty(this.Text))
            {
                this.BackColor = Color.White;
                return;
            }

            //if (System.Text.RegularExpressions.Regex.IsMatch(this.Text, @"^[0-9]+([\.][0-9]{1,2})?$"))   ////@"^(([0-9]+)(\.[0-9]{1,2}|\.)?)$"           
            if (System.Text.RegularExpressions.Regex.IsMatch(this.Text, @"^(([0-9]+)(\.[0-9]{1,2}|\.)?)$"))   ////
                this.BackColor = Color.LightGreen;
            else
            {
                this.BackColor = Color.Red;
            }
        }

        public decimal DecimalValue
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(this.Text))
                        return 0;
                    return Decimal.Parse(this.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign);
                }
                catch (FormatException e)
                {
                    MessageBox.Show("invalid format: ?" + e.Message.ToString());
                    return 0;
                }
            }
        }


    }

}

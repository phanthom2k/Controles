using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivaldi.UserControls
{
    using System.Windows.Forms;
    using System.Drawing;

    public enum Tipo_EP
    {
        Aceptar = 0,
        Rechazar = 1
    }

    [ToolboxBitmap(typeof(ErrorProvider))]
    [System.ComponentModel.ProvideProperty("IconAlignment", typeof(Control))]
    public class Error_Provider : ErrorProvider
    {
        public Error_Provider()
        {
            this.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        }
        /// <summary>
        /// Define la alerta a mostrar
        /// </summary>
        /// <param name="c"></param>
        /// <param name="m"></param>
        /// <param name="t"></param>
        public void Alerta(Control control, string message, Tipo_EP type)
        {
            try
            {
                if (type == Tipo_EP.Aceptar)
                    //Icon = System.Drawing.Icon.FromHandle(new Bitmap(Environment.CurrentDirectory + @"\icons\16x16\accept.png").GetHicon());
                    Icon = System.Drawing.Icon.FromHandle(new Bitmap(Local.accept).GetHicon());
                else
                    //Icon = System.Drawing.Icon.FromHandle(new Bitmap(Environment.CurrentDirectory + @"\icons\16x16\cancel.png").GetHicon());
                    Icon = System.Drawing.Icon.FromHandle(new Bitmap(Local.cancel).GetHicon());
                
                SetIconPadding(control, -5);
            }
            catch (System.IO.IOException ex)
            {
            }
            SetError(control, message);
        }
    }
}

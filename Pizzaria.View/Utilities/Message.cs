using Mike.Utilities.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.View.Utilities
{
    public class CustomMessage
    {
        public static DialogResult MessageFullComButtonOkIconeDeInformacao(string message, string title = "Aviso")
        {
            return DialogMessage.MessageFullComButtonOkIconeDeInformacao(message, title);
        }
        public static DialogResult MessageFullQuestion(string message, string title = "Aviso")
        {
            return DialogMessage.MessageFullQuestion(message, title);
        }
    }
}

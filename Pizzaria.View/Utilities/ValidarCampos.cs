using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.Model.Entity;
using System;

namespace Pizzaria.View.Utilities
{
    public static class ValidaCampos
    {

        public static TextBox ValidarTxt(object entity, TextBox[] txtList)
        {
            IList<ValidationResult> erros = new List<ValidationResult>();
            TextBox txt = null;
            if (!Validator.TryValidateObject(entity, new ValidationContext(entity), erros, true))
            {

                var errosMessage = "";
                erros.ToList().ForEach(c => errosMessage += $"{c.ErrorMessage}\n");
                txt = txtList.ValidarTextBox(textoAviso: errosMessage);
            }
            return txt;
        }
        private static TextBox ValidarTextBox(this TextBox[] txtArray, string textoAviso = "Existem erros na digitação.", bool exibirMensagem = true)
        {
            var txt = txtArray.Where(c => c.Text.Trim() == "" && c.BackColor == Color.Yellow)?.FirstOrDefault();

            if (exibirMensagem)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(textoAviso, "Aviso");
            }
            return txt != null ? txt : txtArray.FirstOrDefault();
        }
        private static MaskedTextBox ValidarMaskedTextBox(this MaskedTextBox[] mtbArray, string textoAviso = "Existem erros na digitação.", bool exibirMensagem = true)
        {
            var txt = mtbArray.Where(c => c.Text.Trim() == "" && c.BackColor == Color.Yellow)?.FirstOrDefault();

            if (exibirMensagem)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(textoAviso, "Aviso");
            }
            return txt != null ? txt : mtbArray.FirstOrDefault();
        }
        public static MaskedTextBox ValidarMtb(object entity, MaskedTextBox[] mtbList, string textoAviso = "Existem erros na digitação.", bool exibirMensagem = true)
        {
            IList<ValidationResult> erros = new List<ValidationResult>();
            MaskedTextBox txt = null;
            if (!Validator.TryValidateObject(entity, new ValidationContext(entity), erros, true))
            {

                var errosMessage = "";
                erros.ToList().ForEach(c => errosMessage += $"{c.ErrorMessage}\n");
                txt = mtbList.ValidarMaskedTextBox(textoAviso: errosMessage);
            }
            return txt;
        }
    }
}

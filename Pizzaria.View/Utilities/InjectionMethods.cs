using Pizzaria.View.Enumerador;
using System;
using System.Windows.Forms;

namespace Pizzaria.View.Utilities
{
    public static class InjectionMethods
    {
        public static void Padronizar(this Button btn)
        {

            switch ((EnumTipoOperacao)Enum.Parse(typeof(EnumTipoOperacao), btn?.Text))
            {
                case EnumTipoOperacao.Novo:
                    btn.BackColor = GetColor.Cor(EnumTipoOperacao.Novo);
                    break;
                case EnumTipoOperacao.Editar:
                    btn.BackColor = GetColor.Cor(EnumTipoOperacao.Editar);
                    break;
                case EnumTipoOperacao.Sair:
                    btn.BackColor = GetColor.Cor(EnumTipoOperacao.Sair);
                    break;
                default:
                case EnumTipoOperacao.Deletar:
                    btn.BackColor = GetColor.Cor(EnumTipoOperacao.Deletar);
                    break;

            }
        }
        public static void LimparSelecao(this DataGridView dgv)
        {

            try
            {
                if (dgv.Rows.Count > 0)
                {
                    dgv.ClearSelection();
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }


        }
        public static string GetLineSelectValue(this DataGridView dgv, string coluna)
        {
            string result = "";
            if (dgv.SelectedRows.Count > 0)
            {
                result = dgv.SelectedRows[0].Cells[coluna].Value.ToString();
            }
            return result;
        }
        public static string SetIcon(this EnumTipoIconCrud icone, EnumExtensao extensao)
        {
            return icone + "." + extensao;
        }
        public static string LimparDigitos(this string valor, int digitos)
        {
            return valor = valor.Substring(digitos, valor.Length - digitos).Trim();
        }
        public static string GetMtbText(this MaskedTextBox mtb)
        {
            mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            return mtb.Text;
        }
    }
}

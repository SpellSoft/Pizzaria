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

    }
}

using System.Drawing;

namespace Pizzaria.View.Enumerador
{
    public class GetColor
    {
        public Color Cores { get; set; }
        public static Color Cor(EnumTipoOperacao cor)
        {
            Color cores = Color.White;
            switch (cor)
            {
                case EnumTipoOperacao.Editar:
                    cores = Color.LightGreen;
                    break;
                case EnumTipoOperacao.Deletar:
                    cores = Color.LightCoral;
                    break;
                case EnumTipoOperacao.Sair:
                    cores = Color.Silver;
                    break;
            }
            return cores;
        }
    }
}

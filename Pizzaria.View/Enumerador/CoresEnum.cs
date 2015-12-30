using System.Drawing;

namespace Pizzaria.View.Enumerador
{
    public enum CoresEnum
    {
        Alterar,
        Deletar,
        Sair,
        Novo
    }

    public class GetColor
    {
        public Color Cores { get; set; }
        public static Color Cor(CoresEnum cor)
        {
            Color cores = Color.White;
            switch (cor)
            {
                case CoresEnum.Alterar:
                    cores = Color.LightGreen;
                    break;
                case CoresEnum.Deletar:
                    cores = Color.LightCoral;
                    break;
                case CoresEnum.Sair:
                    cores = Color.Silver;
                    break;
            }
            return cores;
        }
    }
}

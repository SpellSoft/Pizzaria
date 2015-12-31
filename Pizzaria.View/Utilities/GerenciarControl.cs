using Mike.Utilities.Desktop;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.View.Utilities
{
    public class GerenciarControl
    {
        public static void MudarPosicaoDoButton(Button btn, Point location)
        {
            GerenciarButton.MudarPosicao(btn, location);
        }

        public static void MudarTamanhoDoForm(Form frm,Size size)
        {
            GerenciarForm.MudarTamanho(frm, size);
        }
        public static void DesabilitarOuHabilitarMuitosGroupBox(List<GroupBox> listGpb, bool mostrar = false)
        {
            GerenciarGroupBox.DesabilitarOuHabilitarMuitos(listGpb, mostrar);
        }
        public static void EsconderOuMostrarGroupBox(GroupBox gpb, bool mostrar = false)
        {
            GerenciarGroupBox.EsconderOuMostrar(gpb, mostrar);
        }

        public static void EsconderOuMostrarMuitosGroupBox(List<GroupBox> list, bool mostrar = false)
        {
            GerenciarGroupBox.EsconderOuMostrarMuitos(list, mostrar);
        }
        public static void DesabilitarOuHablitarGroupBox(GroupBox gpb, bool desabilitar = false)
        {
            GerenciarGroupBox.DesabilitarOuHabilitar(gpb, desabilitar);
        }
        public static void DesabilitarButton(Button btn, bool habilitado = false)
        {
            GerenciarButton.DesabilitarOuHabilitar(btn, habilitado);
        }


        public static void DesabilitarOuHablitarCheckBox(CheckBox ckb, bool habilitado = false)
        {
            ckb.Enabled = habilitado;
        }

        public static void EsconderOuMostrarCheckBox(CheckBox ckb, bool mostrar = false)
        {
            ckb.Visible = mostrar;
        }


    }
}

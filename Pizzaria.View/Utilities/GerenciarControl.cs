using Mike.Utilities.Desktop;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Pizzaria.View.Enumerador;
using System;

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
        public static void DesabilitarOuHabilitarButton(Button btn, bool habilitado = false)
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

        public static void MudarTextoDoForm(Form form, string text)
        {
            form.Text = text;
        }

        public static void MudarIConeDoButton(Button btn, EnumTipoOperacao operecao,string iconeName)
        {
            btn.Image = Image.FromFile(iconeName.GetFullPath());
        }

        public static void MudarTextoDoButton(Button btn, string text)
        {
            btn.Text = text;
        }

        public static void MudarTextoDoGroupBox(GroupBox gpb, string text)
        {
            gpb.Text = text;
        }

      
    }
}

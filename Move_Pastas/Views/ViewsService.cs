using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Move_Pastas;

namespace Move_Pastas.Views
{
    class ViewsService
    {
        private IconButton btnAtual;
        private Form formAtual;
        
        public void InsereMenu()
        {

        }
        public void AbrirSubForm(Form subForm, Panel painel)
        {
            //Abrir apenas um Form
            if (formAtual != null)
            {
                formAtual.Close();
            }
            formAtual = subForm;

            //Configurações da view

            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            painel.Controls.Add(subForm);
            painel.Tag = subForm;
            subForm.BringToFront();
            subForm.Show();                        
        }
        
        public void AtivarBtn(object senderBtn, Panel menuButton)
        {
            if (senderBtn != null)
            {
                DesativarBtn();
                btnAtual = (IconButton)senderBtn;
                btnAtual.BackColor = Color.FromArgb(40, 106, 114);
                //btnAtual.ForeColor = color;
                btnAtual.TextAlign = ContentAlignment.MiddleCenter;
                btnAtual.IconColor = Color.White;
                btnAtual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnAtual.ImageAlign = ContentAlignment.MiddleRight;
                
                menuButton.BackColor = Color.White;
                menuButton.Location = new Point(0, btnAtual.Location.Y);
                menuButton.Visible = true;
                menuButton.BringToFront();
            }
        }
        public void DesativarBtn()
        {
            if (btnAtual != null)
            {
                btnAtual.BackColor = Color.FromArgb(66, 146, 157);
                btnAtual.ForeColor = Color.White;
                btnAtual.TextAlign = ContentAlignment.MiddleCenter;
                btnAtual.IconColor = Color.White;
                btnAtual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnAtual.ImageAlign = ContentAlignment.MiddleLeft;

                //iconHome.IconChar = IconChar.Home;
                //iconHome.IconColor = Color.White;
            }
        }
    }
}

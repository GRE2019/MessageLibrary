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

namespace MessageView
{
    public enum Type
    {
        SUCCESS,
        INFORMATION,
        ERROR,
        WARNING,
        INPUT,
        CONFIRMATION
    }
    public partial class MessageView : Form
    {
        public MessageView(Type Type, string description)
        {
            InitializeComponent();
            ActiveControl = lbl_Title;
            mtxt_Input.Enabled = false;
            mtxt_Input.Visible = false;
            PaintMessageScreen(Type);
            lbl_Description.Text = description;
        }

        public void PaintMessageScreen(Type Type)
        {
            switch (Type)
            {
                case Type.SUCCESS:
                    lbl_Title.Text = "ÉXITO!";
                    lbl_Title.ForeColor = Color.MediumSeaGreen;
                    img_Icon.BackColor = Color.MediumSeaGreen;
                    img_2.BackColor = Color.MediumSeaGreen;
                    img_Icon.Image = Properties.Resources.Success_125px;

                    btn_Cancel.Enabled = false;
                    btn_Cancel.Visible = false;
                    break;

                case Type.INFORMATION:
                    lbl_Title.Text = "INFORMACIÓN!";
                    lbl_Title.ForeColor = Color.SteelBlue;
                    img_Icon.BackColor = Color.SteelBlue;
                    img_2.BackColor = Color.SteelBlue;
                    img_Icon.Image = Properties.Resources.Info_125px;

                    btn_Cancel.Enabled = false;
                    btn_Cancel.Visible = false;
                    break;

                case Type.ERROR:
                    lbl_Title.Text = "OH NO!";
                    lbl_Title.ForeColor = Color.IndianRed;
                    img_Icon.BackColor = Color.IndianRed;
                    img_2.BackColor = Color.IndianRed;
                    img_Icon.Image = Properties.Resources.Error_125px;

                    btn_Cancel.Enabled = false;
                    btn_Cancel.Visible = false;
                    break;

                case Type.WARNING:
                    lbl_Title.Text = "CUIDADO...!";
                    lbl_Title.ForeColor = Color.FromArgb(255,168,56);
                    img_Icon.BackColor = Color.FromArgb(255, 168, 56);
                    img_2.BackColor = Color.FromArgb(255, 168, 56);
                    img_Icon.Image = Properties.Resources.Warning_125px;

                    btn_Cancel.Enabled = false;
                    btn_Cancel.Visible = false;
                    break;

                case Type.INPUT:
                    lbl_Title.Text = "ESCRIBA SU RESPUESTA!";
                    lbl_Title.ForeColor = Color.Gray;
                    img_Icon.BackColor = Color.Gray;
                    img_2.BackColor = Color.Gray;
                    img_Icon.Image = Properties.Resources.Warning_125px;
                    mtxt_Input.Enabled = true;
                    mtxt_Input.Visible = true;
                    break;

                case Type.CONFIRMATION:
                    lbl_Title.Text = "CONFIRMAR!";
                    lbl_Title.ForeColor = Color.MediumPurple;
                    img_Icon.BackColor = Color.MediumPurple;
                    img_2.BackColor = Color.MediumPurple;
                    img_Icon.Image = Properties.Resources.Confirmation_125px;
                    break;
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}

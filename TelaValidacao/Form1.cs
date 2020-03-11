using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidacoesBiblioteca;
using System.Windows.Forms;

namespace TelaValidacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string mensagem = "";
        private void BtnCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnCPF.Checked == true)
            {
                msk.Clear();
                msk.Mask = "999,999,999-99";
                msk.Focus();
                this.msk.Size = new System.Drawing.Size(100, 10);
            }
        }

        private void BtnCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (BtnCNPJ.Checked == true)
            {
                msk.Clear();
                msk.Mask = "99,999,999/9999-99";
                msk.Focus();
                this.msk.Size = new System.Drawing.Size(130, 10);
            }
        }   

        private void msk_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
   
        }

        private void BtnValida_Click(object sender, EventArgs e)
        {
            if (BtnCPF.Checked == true)
            {
                if (msk.Text == "" && msk.MaskFull == false)
                { 
                    mensagem = "Digite o seu CPF com 11 dígitos";
                }

                if (msk.MaskFull == true)
                {
                    if (Validacoes.ValidaCPF(msk.Text))
                    {
                        mensagem = "CPF Válido";
                        msk.Focus();
                        msk.SelectAll();
                    }
                    else
                    {
                        mensagem = "CPF Inválido";
                        msk.Clear();
                        msk.Focus();
                    }
                }
                else
                {
                    mensagem = "Preenchimento incorreto! Preencha o CPF com 11 dígitos.";
                }
            }

            if (BtnCNPJ.Checked == true)
            {
                if (msk.Text == "" && msk.MaskFull == false)
                {
                    mensagem = "Digite o seu CNPJ com 14 dígitos";
                }

                if (msk.MaskFull == true)
                {
                    if (Validacoes.ValidaCPF(msk.Text))
                    {
                        mensagem = "CNPJ Válido";
                        msk.Focus();
                        msk.SelectAll();
                    }
                    else
                    {
                        mensagem = "CNPJ Inválido";
                        msk.Clear();
                        msk.Focus();
                    }
                }
                else
                {
                    mensagem = "Preenchimento incorreto! Preencha o CNPJ com 14 dígitos.";
                }

            }
            MessageBox.Show(mensagem);
            mensagem = "";
        }

        private void msk_Keypress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) BtnValida_Click(sender, e);
        }


    }
}

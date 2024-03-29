﻿using App.Service.Services.Clientes.IService;
using App.Service.Services.Contatos.IService;
using App.WFApplication.Forms.About;
using App.WFApplication.Forms.UserControls.Clientes;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace App.WFApplication
{
    public partial class Main : Form
    {
        private About _about;
        public IClienteService _clienteService;
        public IContatoTipoService _contatoTipoService;

        public Main(About about, IClienteService clienteService, IContatoTipoService contatoTipoService)
        {
            _clienteService = clienteService;
            _contatoTipoService = contatoTipoService;

            InitializeComponent();

            SetInfoVersao();

            HideUserControls();

            _about = about;
        }

        #region Eventos
        private void btnClientes_Click(object sender, EventArgs e)
        {
            try
            {
                HideUserControls();
                ucCliente.Visible = true;
                SetMenuAtivo((Button)sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnForncedores_Click(object sender, EventArgs e)
        {
            try
            {
                HideUserControls();
                ucFornecedores.Visible = true;
                SetMenuAtivo((Button)sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnItens_Click(object sender, EventArgs e)
        {
            try
            {
                HideUserControls();
                ucItens.Visible = true;
                SetMenuAtivo((Button)sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOperacoes_Click(object sender, EventArgs e)
        {
            try
            {
                HideUserControls();
                ucOperacoes.Visible = true;
                SetMenuAtivo((Button)sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            try
            {
                _about.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWhatsapp_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnParametrizacoes_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Métodos
        private void SetInfoVersao()
        {
            lblVersao.Text = "Versão " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void HideUserControls()
        {
            ucCliente.Visible =
            ucFornecedores.Visible =
            ucItens.Visible =
            ucOperacoes.Visible =
            pnlMenuAtivo.Visible = false;
        }

        private void SetMenuAtivo(Button button)
        {
            pnlMenuAtivo.Height = button.Height;
            pnlMenuAtivo.Top = button.Top;
            pnlMenuAtivo.Visible = true;
        }
        #endregion
    }
}
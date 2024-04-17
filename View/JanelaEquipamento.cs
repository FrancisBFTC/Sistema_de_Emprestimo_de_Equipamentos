using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AgendamentoModel;

namespace AgendamentoView
{
    public partial class JanelaEquipamento : Form
    {
        public JanelaEquipamento()
        {
            InitializeComponent();
        }

        private void JanelaEquipamento_Load(object sender, EventArgs e)
        {
            this.botaoEquipamento.Cursor = Cursors.Hand;
            CustomControlExtensions.RoundBorder(botaoEquipamento, 30);
        }

        private void BotaoEquipamento_Event(object sender, EventArgs e)
        {

            String conteudoEquipamento = textEquipamento.Text;
            String conteudoTipo = textTipo.Text;
            String conteudoQuantidade = textQuantidade.Text;

            bool emptyInput, errorFormat;

            if (emptyInput = conteudoEquipamento == "")
                MessageBox.Show("Preencha o campo equipamento!", "Entrada vazia", MessageBoxButtons.OK);
            else if (emptyInput = conteudoTipo == "")
                MessageBox.Show("Preencha o campo tipo de equipamento!", "Entrada vazia", MessageBoxButtons.OK);
            else if (emptyInput = conteudoQuantidade == "")
                MessageBox.Show("Preencha o campo quantidade!", "Entrada vazia", MessageBoxButtons.OK);


            if (emptyInput)
                return;

            string padraoQuantidade = "^([1-9]){1,999}$";
            Regex regexQuantidade = new Regex(padraoQuantidade);

            if (errorFormat = !regexQuantidade.IsMatch(conteudoQuantidade))
                MessageBox.Show("Só são permitidos números de 1 para cima!", "Formato Inválido", MessageBoxButtons.OK);

            if (errorFormat)
                return;

            int.TryParse(conteudoQuantidade, out int quant);

            Equipamento equipamento = new Equipamento(conteudoEquipamento, conteudoTipo, quant);
            equipamento.Registrar();

            string message = "Equipamento cadastrado com sucesso!";
            string caption = "Mensagem de Cadastro do Equipamento";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);


        }
    }
}

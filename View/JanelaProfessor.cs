using AgendamentoModel;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AgendamentoView
{
    public partial class JanelaProfessor : Form
    {
        public JanelaProfessor()
        {
            InitializeComponent();
        }

        private void JanelaProfessor_Load(object sender, EventArgs e)
        {
            this.botaoProfessor.Cursor = Cursors.Hand;
            CustomControlExtensions.RoundBorder(botaoProfessor, 30);
        }

        private void BotaoProfessor_Event(object sender, EventArgs e)
        {
            String conteudoProfessor = textProfessor.Text;
            String conteudoDisciplina = textDisciplina.Text;
            String conteudoTurmas = textTurmas.Text;
   
            bool emptyInput, errorFormat;

            if (emptyInput = conteudoProfessor == "")
                MessageBox.Show("Preencha o campo professor!", "Entrada vazia", MessageBoxButtons.OK);
            else if (emptyInput = conteudoDisciplina == "")
                MessageBox.Show("Preencha o campo disciplina!", "Entrada vazia", MessageBoxButtons.OK);
            else if (emptyInput = conteudoTurmas == "")
                MessageBox.Show("Preencha o campo turmas!", "Entrada vazia", MessageBoxButtons.OK);


            if (emptyInput)
                return;

            string padraoNome = "^(([A-Za-z])+( ){1}([A-Za-z])+)+( )*$";
            Regex regexNome = new Regex(padraoNome);

            if (errorFormat = !regexNome.IsMatch(conteudoProfessor))
                MessageBox.Show("Formato de nome inválido! \n Não é permitido números ou nomes imcompletos!", "Formato Inválido", MessageBoxButtons.OK);

            if (errorFormat)
                return;

            Professor professor = new Professor(conteudoProfessor, conteudoDisciplina, conteudoTurmas);
            professor.Registrar();

            string message = "Professor cadastrado com sucesso!";
            string caption = "Mensagem de Cadastro do Professor";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);

        }
    }
}

using AgendamentoModel;
using SistemaEmprestimo.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AgendamentoView
{

    public partial class JanelaAgendamento : Form
    {
        /// <summary>
        /// Variáveis globais auxiliares
        /// </summary>
        public bool[] temCaractere = new bool[8];
        public ContextMenuStrip menuStrip;
        TextBox textBox;

        /// <summary>
        /// Construtor da janela de agendamento
        /// </summary>
        public JanelaAgendamento()
        {
            InitializeComponent();
        }


        /// <summary>
        /// É executado quando a janela é carregada pela primeira vez.
        /// </summary>
        /// <param name="sender">Contexto atual da janela</param>
        /// <param name="e">Argumentos de eventos</param>
        private void JanelaAgendamento_Load(object sender, EventArgs e)
        {
            this.botaoAgendar.Cursor = Cursors.Hand;
            CustomControlExtensions.RoundBorder(botaoAgendar, 30);
            textProfessor.KeyDown += TextAgendamento_KeyDown;
            textEquipamento.KeyDown += TextAgendamento_KeyDown;
        }

        /// <summary>
        /// Método de eventos de teclas em campos de texto de agendamento
        /// </summary>
        /// <param name="sender">Contexto do campo de texto</param>
        /// <param name="e">Evento de teclas</param>
        private void TextAgendamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verificando se a tecla pressionada é Enter
                InitializeMenu(sender); // Chamando o método para exibir o menu
        }

        /// <summary>
        /// Inicializa o menu abaixo de um campo de texto, apresenta as informações
        /// de professores ou equipamentos
        /// </summary>
        /// <param name="sender">Contexto do campo de texto</param>
        public void InitializeMenu(Object sender)
        {
            menuStrip?.Dispose();   // Seleção nula = if(menuStrip != NULL) Dispose()
            menuStrip = new ContextMenuStrip();

            menuStrip.Items.Clear();
            menuStrip.Items.Add("-");

            textBox = (TextBox)sender;

            var consulta = (textBox.Equals(textProfessor)) ? new Professor().Coletar() :
                                                             new Equipamento().Coletar();

            if (consulta != null)
            {
                if (consulta.Any())
                {
                    List<XElement> list = consulta.ToList();
                    list.ForEach(item => menuStrip.Items.Add(item.Element("Nome").Value));

                    menuStrip.ItemClicked += Menu_ItemClicked;
                    menuStrip.Show(textBox, 0, textBox.Height);
                }
            }
        }

        /// <summary>
        /// Evento de clique/press em um dos itens de menus
        /// </summary>
        /// <param name="sender">Objeto do elemento</param>
        /// <param name="e">Evento do menu</param>
        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string itemText = e.ClickedItem.Text;
            textBox.Text = itemText;
        }

        /// <summary>
        /// Método de evento para clique do botão agendar.
        /// O código realiza verificações de campos vazios e validações de Regex,
        /// para depois agendar um empréstimo. Dias disponíveis também são verificados pelo Controller.
        /// </summary>
        /// <param name="sender">Objeto do botão</param>
        /// <param name="e">Eventos de Clique</param>
        private void BotaoAgendar_Event(object sender, EventArgs e)
        {

            String conteudoProfessor = textProfessor.Text;
            String conteudoEquipamento = textEquipamento.Text;
            String conteudoDataInicial = textDataInicial.Text;
            String conteudoDataFinal = textDataFinal.Text;
            String conteudoHoraInicial = textHoraInicial.Text;
            String conteudoHoraFinal = textHoraFinal.Text;
            bool emptyInput, errorFormat, isAvailable;

            if (emptyInput = conteudoProfessor == "")
                MessageBox.Show("Selecione o campo professor!", "Entrada vazia", MessageBoxButtons.OK);
            else if (emptyInput = conteudoEquipamento == "")
                MessageBox.Show("Selecione o campo equipamento!", "Entrada vazia", MessageBoxButtons.OK);
            else if (emptyInput = conteudoDataInicial == "")
                MessageBox.Show("Preencha o campo data inicial!", "Entrada vazia", MessageBoxButtons.OK);
            else if (emptyInput = conteudoDataFinal == "")
                MessageBox.Show("Preencha o campo data final!", "Entrada vazia", MessageBoxButtons.OK);
            else if (emptyInput = conteudoHoraInicial == "")
                MessageBox.Show("Preencha o campo hora inicial!", "Entrada vazia", MessageBoxButtons.OK);
            else if (emptyInput = conteudoHoraFinal == "")
                MessageBox.Show("Preencha o campo hora final!", "Entrada vazia", MessageBoxButtons.OK);


            if (emptyInput)
                return;

            string padraoNome = "^(([A-Za-z])+( ){1}([A-Za-z])+)+( )*$";
            Regex regexNome = new Regex(padraoNome);

            string padraoData = "^((([1-2][0-9]){1})|(([0][1-9]){1})|(([3][0-1]){1}))(/){1}"
                              + "((([0][1-9]){1})|(([1][0-2]){1}))(/){1}[2]{1}[0-9]{3}$";
            Regex regexData = new Regex(padraoData);

            string padraoHora = "^((([0-1][0-9]){1})|(([2][0-3]){1}))(:){1}"
                              + "(([0-5][0-9]){1})(:){1}(([0-5][0-9]){1})$";
            Regex regexHora = new Regex(padraoHora);

            if (errorFormat = conteudoDataInicial.Length < 10 || conteudoDataFinal.Length < 10)
                MessageBox.Show("Tamanho de data inválido!", "Formato Inválido", MessageBoxButtons.OK);
            else if (errorFormat = conteudoHoraInicial.Length < 8 || conteudoHoraFinal.Length < 8)
                MessageBox.Show("Tamanho de hora inválido!", "Formato Inválido", MessageBoxButtons.OK);
            else if (errorFormat = !regexData.IsMatch(conteudoDataInicial) || !regexData.IsMatch(conteudoDataFinal))
                MessageBox.Show("Formato de data inválido!", "Formato Inválido", MessageBoxButtons.OK);
            else if (errorFormat = !regexHora.IsMatch(conteudoHoraInicial) || !regexHora.IsMatch(conteudoHoraFinal))
                MessageBox.Show("Formato de hora inválido!", "Formato Inválido", MessageBoxButtons.OK);
            else if (errorFormat = !regexNome.IsMatch(conteudoProfessor))
                MessageBox.Show("Formato de nome inválido! \n Não é permitido números ou nomes imcompletos!", "Formato Inválido", MessageBoxButtons.OK);

            if (errorFormat)
                return;

            bool toApply = Agendamento.VerificarDisponibilidade(conteudoEquipamento, $"{conteudoDataInicial} {conteudoHoraInicial}",
                                                               $"{conteudoDataFinal} {conteudoHoraFinal}");

            isAvailable = (toApply) ? Agendamento.VerificarDisponibilidade($"{conteudoDataInicial} {conteudoHoraInicial}",
                                                               $"{conteudoDataFinal} {conteudoHoraFinal}")
                                    : !toApply;
 
            if (!isAvailable)
            {
                MessageBox.Show("A data escolhida não está disponível! \n" +
                                "Por favor, verificar na lista de dias disponíveis!");
                return;
            }

            Emprestimo emprestimo = new Emprestimo(conteudoProfessor, conteudoEquipamento, $"{conteudoDataInicial} {conteudoHoraInicial}",
                                                    $"{conteudoDataFinal} {conteudoHoraFinal}");
            emprestimo.Registrar();

            string message = "Agendamento de Empréstimo registrado com sucesso!";
            string caption = "Salvar Agendamento";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);

        }

        /// <summary>
        /// Método auxiliar para atribuir barras no campo de data inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextDataInicial_TextChanged(object sender, EventArgs e)
        {
            AtribuiCaracteres(this.textDataInicial, 0, "/");
        }

        /// <summary>
        /// Método auxiliar para atribuir barras no campo de data final
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextDataFinal_TextChanged(object sender, EventArgs e)
        {
            AtribuiCaracteres(this.textDataFinal, 2, "/");
        }

        /// <summary>
        /// Método auxiliar para atribuir dois-pontos no campo de hora inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextHoraInicial_TextChanged(object sender, EventArgs e)
        {
            AtribuiCaracteres(this.textHoraInicial, 4, ":");
        }

        /// <summary>
        /// Método auxiliar para atribuir dois-pontos no campo de hora final
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextHoraFinal_TextChanged(object sender, EventArgs e)
        {
            AtribuiCaracteres(this.textHoraFinal, 6, ":");
        }

        /// <summary>
        /// Algoritmo que atribui barras ou dois-pontos em posições específicas
        /// de acordo com a quantidade de caracteres digitados.
        /// </summary>
        /// <param name="textBoxObject">Objeto do campo de texto</param>
        /// <param name="index">Índice de identificação de Estados</param>
        /// <param name="simbol">Símbolo a ser inserido (Barra/Dois-pontos)</param>
        private void AtribuiCaracteres(TextBox textBoxObject, int index, String simbol)
        {
            int length = textBoxObject.TextLength;
            for (int i = -1; i < 5; i += 3, index++)
            {
                if (length == (i + 3) && !temCaractere[index])
                {
                    textBoxObject.AppendText(simbol);
                    temCaractere[index] = true;
                    return;
                }
                temCaractere[index] = (!temCaractere[index] || length > (i + 3)) && temCaractere[index];
            }
        }
    }

}

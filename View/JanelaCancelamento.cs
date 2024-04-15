using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using AgendamentoModel;

namespace AgendamentoView
{
    public partial class JanelaCancelamento : Form
    {
        public ContextMenuStrip menuStrip;
        public DataGridView dataGridView;
        TextBox textBox;

        public JanelaCancelamento()
        {
            InitializeComponent();
        }

        private void JanelaCancelamento_Load(object sender, EventArgs e)
        {
            this.botaoCancelar.Cursor = Cursors.Hand;
            CustomControlExtensions.RoundBorder(botaoCancelar, 30);
            textProfessor.KeyDown += TextCancelamento_KeyDown;
            textEquipamento.KeyDown += TextCancelamento_KeyDown;
        }

        private void TextCancelamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verificando se a tecla pressionada é Enter
                InitializeMenu(sender); // Chamando o método para exibir o menu
        }

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

        // Manipulador de evento para o item 1
        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string itemText = e.ClickedItem.Text;
            textBox.Text = itemText;
            listaCancelamento.BeginUpdate();
            listaCancelamento.Items.Clear();

            if (dataGridView != null)
                dataGridView?.Dispose();

            dataGridView = new DataGridView();
            dataGridView.Rows.Clear();

            var consulta = new Emprestimo(itemText).Verificar();

            int i = 0;
            if (consulta.Any())
            {
                dataGridView.Columns.Add("Nome", "Nome");
                dataGridView.Columns.Add("Item", "Item");
                dataGridView.Columns.Add("Inicio", "Inicio");
                dataGridView.Columns.Add("Fim", "Fim");

                foreach (var item in consulta)
                {
                    string id = item.Element("ID").Value;
                    string nome = item.Element("Nome").Value;
                    string equip = item.Element("Equipamento").Value;
                    string inicio = item.Element("DataInicial").Value;
                    string fim = item.Element("DataFinal").Value;

                    dataGridView.Rows.Add(nome, equip, inicio, fim);
                    dataGridView.Rows[i++].Tag = id;
                }
            }

            foreach (DataGridViewColumn coluna in dataGridView.Columns)
            {
                coluna.Width = 150;
            }

            dataGridView.ReadOnly = true;
            dataGridView.Dock = DockStyle.Fill;

            listaCancelamento.Controls.Add(dataGridView);
            listaCancelamento.EndUpdate();
        }

        private void BotaoCancelar_ClickEvent(object sender, EventArgs e)
        {
            if (dataGridView != null)
            {
                if (dataGridView.SelectedRows.Count > 0)
                {

                    Object result = dataGridView.SelectedRows[0].Tag;
                    int.TryParse((string)result, out int id);

                    new Emprestimo(id).Cancelar();
                    MessageBox.Show("O agendamento ID=" + id + " foi cancelado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhuma linha selecionada.");
                }
            }
            else
            {
                MessageBox.Show("Não existe dados exibidos!");
            }
        }

    }
}

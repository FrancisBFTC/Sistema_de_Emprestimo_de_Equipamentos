using AgendamentoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AgendamentoView
{
    public partial class JanelaListagem : Form
    {
        public ContextMenuStrip menuStrip;
        public DataGridView dataGridView;
        TextBox textBox;

        public JanelaListagem()
        {
            InitializeComponent();
        }

        private void JanelaListagem_Load(object sender, EventArgs e)
        {
            textProfessor.KeyDown += TextListagem_KeyDown;
            textEquipamento.KeyDown += TextListagem_KeyDown;
            UpdateTable("", true);
        }

        private void TextListagem_KeyDown(object sender, KeyEventArgs e)
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
            UpdateTable(itemText, false);
        }

        private void UpdateTable(String nomeText, bool isAllData)
        {
            listaListagem.BeginUpdate();
            listaListagem.Items.Clear();

            if (dataGridView != null)
                dataGridView?.Dispose();

            dataGridView = new DataGridView();
            dataGridView.Rows.Clear();

            IEnumerable<XElement> consulta;
            if (isAllData)
                consulta = new Emprestimo().Coletar();
            else
                consulta = new Emprestimo(nomeText).Verificar();

            if (consulta.Any())
            {
                dataGridView.Columns.Add("Nome", "Nome");
                dataGridView.Columns.Add("Item", "Item");
                dataGridView.Columns.Add("Inicio", "Inicio");
                dataGridView.Columns.Add("Fim", "Fim");

                foreach (var item in consulta)
                {
                    string nome = item.Element("Nome").Value;
                    string equip = item.Element("Equipamento").Value;
                    string inicio = item.Element("DataInicial").Value;
                    string fim = item.Element("DataFinal").Value;

                    dataGridView.Rows.Add(nome, equip, inicio, fim);
                }
            }

            foreach (DataGridViewColumn coluna in dataGridView.Columns)
            {
                coluna.Width = 150;
            }

            dataGridView.ReadOnly = true;
            dataGridView.Dock = DockStyle.Fill;

            listaListagem.Controls.Add(dataGridView);
            listaListagem.EndUpdate();
        }

    }
}

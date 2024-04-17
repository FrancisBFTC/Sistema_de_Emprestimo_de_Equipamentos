using AgendamentoModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AgendamentoView
{
    public partial class JanelaDisponibilidade : Form
    {
        public DataGridView dataGridView;
        TextBox textBox;

        public JanelaDisponibilidade()
        {
            InitializeComponent();
        }

        private void JanelaDisponibilidade_Load(object sender, EventArgs e)
        {
            textData.KeyDown += TextDisponibilidade_KeyDown;
            textHora.KeyDown += TextDisponibilidade_KeyDown;
            UpdateTable(sender, true);
        }

        private void TextDisponibilidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verificando se a tecla pressionada é Enter
                InitializeFilter(sender); // Chamando o método para exibir o menu
        }

        public void InitializeFilter(Object sender)
        {
            UpdateTable(sender, false);
        }

        private void UpdateTable(Object sender, bool isAllData)
        {
            listaDisponibilidade.BeginUpdate();
            listaDisponibilidade.Items.Clear();

            if (dataGridView != null)
                dataGridView?.Dispose();

            dataGridView = new DataGridView();
            dataGridView.Rows.Clear();

            Emprestimo emprestimo = new Emprestimo();
            IEnumerable<XElement> consulta = emprestimo.ColetarLivres();

            if (!isAllData)
            {

                textBox = (TextBox)sender;
                int i = textBox.Equals(textData) ? 0 : 1;
                    
                    var dadoXML = from registro in emprestimo.XmlDoc.Descendants(emprestimo.TipoRegistro)
                              where ((String)registro.Element("DataInicial")).Split(' ')[i].Contains(textBox.Text) ||
                                    ((String)registro.Element("DataFinal")).Split(' ')[i].Contains(textBox.Text)
                                  select registro;
                    consulta = dadoXML;
           
            }
               
            if (consulta.Any())
            {

                dataGridView.Columns.Add("DataInicial", "Data de Início");
                dataGridView.Columns.Add("DataFinal", "Data de Término");

                foreach (var item in consulta)
                {
                    string inicio = item.Element("DataInicial").Value;
                    string fim = item.Element("DataFinal").Value;

                    dataGridView.Rows.Add(inicio, fim);
                }
            }

            foreach (DataGridViewColumn coluna in dataGridView.Columns)
            {
                coluna.Width = 150;
            }

            dataGridView.ReadOnly = true;
            dataGridView.Dock = DockStyle.Fill;

            listaDisponibilidade.Controls.Add(dataGridView);

            listaDisponibilidade.EndUpdate();
        }

    }
}

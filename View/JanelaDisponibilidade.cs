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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

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
            UpdateTable(sender, "", true);
        }

        private void TextDisponibilidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verificando se a tecla pressionada é Enter
                InitializeFilter(sender); // Chamando o método para exibir o menu
        }

        public void InitializeFilter(Object sender)
        {
            textBox = (TextBox)sender;
            String itemText = textBox.Text;
            UpdateTable(sender, itemText, false);

        }

        private void UpdateTable(Object sender, String nomeText, bool isAllData)
        {
            listaDisponibilidade.BeginUpdate();
            listaDisponibilidade.Items.Clear();

            if (dataGridView != null)
                dataGridView?.Dispose();

            dataGridView = new DataGridView();
            dataGridView.Rows.Clear();

            Emprestimo emprestimo = new Emprestimo();
            IEnumerable<XElement> consulta = emprestimo.ColetarLivres();

            if (!isAllData) {

                textBox = (TextBox)sender;
                if (textBox.Equals(textData))
                {
                    var dadoXML = from registro in emprestimo.XmlDoc.Descendants(emprestimo.TipoRegistro)
                                  where ((String)registro.Element("DataInicial")).Split(' ')[0].Contains(textBox.Text) ||
                                        ((String)registro.Element("DataFinal")).Split(' ')[0].Contains(textBox.Text)
                                  select registro;
                    consulta = dadoXML;
                }
                else {
                    var dadoXML = from registro in emprestimo.XmlDoc.Descendants(emprestimo.TipoRegistro)
                                  where ((String)registro.Element("DataInicial")).Split(' ')[1].Contains(textBox.Text) ||
                                        ((String)registro.Element("DataFinal")).Split(' ')[1].Contains(textBox.Text)
                                  select registro;
                    consulta = dadoXML;
                }
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

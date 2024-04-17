using SistemaEmprestimo.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace AgendamentoModel
{
    public class Emprestimo : Cadastro, IXmlControl
    {
        /// <summary>
        /// Atributos de dados que vão sobreescrever da Classe herdada Cadastro
        /// </summary>
        public override string Nome { get; set; }
        public override string XmlPath { get; set; }
        public override String TipoRegistro { get; set; }
        public override int ID { get; set; }

        /// <summary>
        /// Atributos de dados específicos da Classe Emprestimo
        /// </summary>
        public String Equipamento { get; set; }
        public String DataInicial { get; set; }
        public String DataFinal { get; set; }

        /// <summary>
        /// Atributo de instância sobreescrita da Classe Cadastro do Documento XML
        /// </summary>
        public override XDocument XmlDoc
        {
            get => base.XmlDoc;
            set => base.XmlDoc = value;
        }

        /// <summary>
        /// Atributo de instância sobreescrita da Classe Cadastro de Elementos XML
        /// </summary>
        public override IEnumerable<XElement> XmlElement
        {
            get => base.XmlElement;
            set => base.XmlElement = value;
        }

        /// <summary>
        /// Construtor principal da Classe Emprestimo para instanciação
        /// e atribuição de novos registros | Formação do arquivo completo
        /// </summary>
        /// <param name="nome">Nome do professor</param>
        /// <param name="equipamento">Nome do equipamento</param>
        /// <param name="dataInicial">Data inicial de agenda | DD/MM/YYYY HH:MM:SS</param>
        /// <param name="dataFinal">Data final de agenda | DD/MM/YYYY HH:MM:S</param>
        public Emprestimo(String nome, String equipamento, String dataInicial, String dataFinal) : base()
        {
            this.Nome = nome;
            this.Equipamento = equipamento;
            this.DataInicial = dataInicial;
            this.DataFinal = dataFinal;
            XmlPath += "Emprestimo.xml";
            TipoRegistro = "Emprestimo";
        }

        /// <summary>
        /// Construtor sobrecarregado de Emprestimo, que instancia a classe Herdada
        /// Neste construtor não é necessário definir todos os atributos de dados
        /// Apenas o nome
        /// </summary>
        public Emprestimo(String nome) : base()
        {
            this.Nome = nome;
            XmlPath += "Emprestimo.xml";
            TipoRegistro = "Emprestimo";
        }

        /// <summary>
        /// Construtor sobrecarregado de Emprestimo, que instancia a classe Herdada
        /// Neste construtor não é necessário definir os atributos de dados
        /// </summary>
        public Emprestimo() : base()
        {
            XmlPath += "Emprestimo.xml";
            TipoRegistro = "Emprestimo";
        }

        /// <summary>
        /// Construtor sobrecarregado de Equipamento, que instancia a classe Herdada
        /// É definido apenas o ID em casos de Cancelamento/Fechamento
        /// </summary>
        /// <param name="id">ID do emprestimo a ser cancelado/fechado</param>
        public Emprestimo(int id) : base()
        {
            this.ID = id;
            XmlPath += "Emprestimo.xml";
            TipoRegistro = "Emprestimo";
        }

        /// <summary>
        /// Consiste em apenas chamar o método Registrar, que será sobreescrito de Cadastro
        /// Os dados são passados na instância de Emprestimo
        /// </summary>
        public void Agendar()
        {
            this.Registrar();
        }

        /// <summary>
        /// Método específico para Fechamento de Empréstimos baseado no ID.
        /// Primeiro é salvo os dados em Entregues, atribuído dia disponível e depois é excluído
        /// usando o método herdado de Cadastro
        /// </summary>
        public void Fechar()
        {
            Console.WriteLine($"Dando baixa em agendamento de equipamento {this.Equipamento}" +
                              $" em nome de {this.Nome}, agendado de {this.DataInicial} até {this.DataFinal}");

            XmlDoc = XDocument.Load("Registros/Emprestimo.xml");
            XmlElement = from registro in XmlDoc.Descendants(TipoRegistro)
                         where ((int)registro.Element("ID")) == this.ID
                         select registro;
            this.Nome = XmlElement.ElementAt(0).Element("Nome").Value;
            this.Equipamento = XmlElement.ElementAt(0).Element("Equipamento").Value;
            this.DataInicial = XmlElement.ElementAt(0).Element("DataInicial").Value;
            this.DataFinal = XmlElement.ElementAt(0).Element("DataFinal").Value;
            Agendamento.AtribuirDisponibilidade(this.DataInicial, this.DataFinal);
            XmlPath = "Registros/Entregues.xml";
            TipoRegistro = "Entregues";
            this.Registrar();
            TipoRegistro = "Emprestimo";
            XmlPath = "Registros/" + TipoRegistro + ".xml";
            this.Excluir();
        }

        /// <summary>
        /// Método para cancelamento de empréstimos baseado no ID.
        /// Primeiro é atribuido um novo dia disponível e depois excluído.
        /// </summary>
        public void Cancelar()
        {
            Console.WriteLine($"Cancelando agendamento de equipamento {this.Equipamento}" +
                              $" em nome de {this.Nome}, agendado de {this.DataInicial} até {this.DataFinal}");

            XmlDoc = XDocument.Load(XmlPath);
            XmlElement = from registro in XmlDoc.Descendants(TipoRegistro)
                         where ((int)registro.Element("ID")) == this.ID
                         select registro;
            this.DataInicial = XmlElement.ElementAt(0).Element("DataInicial").Value;
            this.DataFinal = XmlElement.ElementAt(0).Element("DataFinal").Value;
            Agendamento.AtribuirDisponibilidade(this.DataInicial, this.DataFinal);
            this.Excluir();
        }

        /// <summary>
        /// Método que Registra novo empréstimo, sobreescrevendo o método de Cadastro
        /// e também o chamando.
        /// Carrega o arquivo XML e salva os novos dados passados na instância
        /// </summary>
        public override void Registrar()
        {
            try
            {
                XmlDoc = XDocument.Load(XmlPath);
                XmlAppend();
            }
            catch (Exception e)
            {
                if (e is FileNotFoundException)
                {
                    Console.WriteLine("Arquivo de dados não existente! Criando agora...");
                    XmlCreate();
                }
                else
                {
                    Console.WriteLine("Erro em agendar o empréstimo: " + e.Message);
                    return;
                }

            }
            base.Registrar();
        }

        /// <summary>
        /// Método de exclusão de empréstimos, sobreescrevendo o método de Cadastro.
        /// O elemento é selecionado de acordo com o ID.
        /// </summary>
        public override void Excluir()
        {
            try
            {
                XmlDoc = XDocument.Load(XmlPath);
                XmlElement = from registro in XmlDoc.Descendants(TipoRegistro)
                             where ((int)registro.Element("ID")) == this.ID
                             select registro;
            }
            catch (Exception e)
            {
                e.GetHashCode();
                return;
            }
            base.Excluir();
        }

        /// <summary>
        /// Método que verifica um nome dado na instância de um Empréstimo.
        /// Utilizado para filtragens em cancelamento, fechamento, listagem, etc.
        /// </summary>
        /// <returns>Elementos XML correspondentes ao nome</returns>
        public override IEnumerable<XElement> Verificar()
        {
            try
            {
                XmlDoc = XDocument.Load(XmlPath);
            }
            catch (Exception e)
            {
                e.GetHashCode();
                return null;
            }
            return base.Verificar();
        }

        /// <summary>
        /// Método que verifica em um arquivo específico um nome dado na instância.
        /// Identifica elementos de um arquivo.
        /// </summary>
        /// <param name="tipoRegistro">Parâmetro com o nome do arquivo/tag</param>
        /// <returns></returns>
        public IEnumerable<XElement> Verificar(String tipoRegistro)
        {
            try
            {
                TipoRegistro = tipoRegistro;
                XmlPath = "Registros/" + tipoRegistro + ".xml";
                XmlDoc = XDocument.Load(XmlPath);
            }
            catch (Exception e)
            {
                e.GetHashCode();
                return null;
            }
            return base.Verificar();
        }

        /// <summary>
        /// Método que retorna todos os elementos XML dé empréstimos.
        /// </summary>
        /// <returns>Elementos XML de empréstimos</returns>
        public IEnumerable<XElement> Coletar()
        {
            Console.WriteLine("Listando equipamentos agendados...");
            try
            {
                XmlDoc = XDocument.Load(XmlPath);
            }
            catch (Exception e)
            {
                e.GetHashCode();
                return null;
            }
            var consulta = from agenda in XmlDoc.Descendants(TipoRegistro)
                           select agenda;
            return consulta;
        }

        /// <summary>
        /// Método que coleta todos os elementos de um arquivo específico.
        /// Sendo ele o arquivo Entregues.xml de empréstimos fechados.
        /// </summary>
        /// <returns>Todos os elementos XML de fechados</returns>
        public IEnumerable<XElement> ColetarEntregues()
        {
            TipoRegistro = "Entregues";
            XmlPath = "Registros/" + TipoRegistro + ".xml";
            return this.Coletar();
        }

        /// <summary>
        /// Método que retorna todos os elementos de um arquivo específico.
        /// Sendo ele o arquivo Livres.xml de dias disponíveis.
        /// </summary>
        /// <returns>Elementos XML de Todos os dias disponíveis</returns>
        public IEnumerable<XElement> ColetarLivres()
        {
            TipoRegistro = "Livres";
            XmlPath = "Registros/" + TipoRegistro + ".xml";
            return this.Coletar();
        }

        /// <summary>
        /// Método para criar um arquivo XML pela primeira vez
        /// </summary>
        public void XmlCreate()
        {
            XDocument getConfig = XDocument.Load("Registros/Config.xml");
            IEnumerable<XElement> LastID = from registro in getConfig.Descendants(TipoRegistro)
                                           select registro;
            int.TryParse(LastID.ElementAt(0).Element("LastID").Value, out int theID);
            XmlDoc = new XDocument(
                        new XElement("Registros",
                            new XElement(TipoRegistro,
                                new XElement("ID", ++theID),
                                new XElement("Nome", this.Nome),
                                new XElement("Equipamento", this.Equipamento),
                                new XElement("DataInicial", this.DataInicial),
                                new XElement("DataFinal", this.DataFinal)
                            )
                         )
                      );
            LastID.ElementAt(0).Element("LastID").Value = "" + theID;
            getConfig.Save("Registros/Config.xml");
        }

        /// <summary>
        /// Método para adicionar um novo elemento XML em um documento existente
        /// </summary>
        public void XmlAppend()
        {
            XDocument getConfig = XDocument.Load("Registros/Config.xml");
            IEnumerable<XElement> LastID = from registro in getConfig.Descendants(TipoRegistro)
                                           select registro;
            int.TryParse(LastID.ElementAt(0).Element("LastID").Value, out int theID);
            XElement novoRegistro = new XElement(TipoRegistro,
                                        new XElement("ID", ++theID),
                                        new XElement("Nome", this.Nome),
                                        new XElement("Equipamento", this.Equipamento),
                                        new XElement("DataInicial", this.DataInicial),
                                        new XElement("DataFinal", this.DataFinal)
                                    );
            XmlDoc.Root.Add(novoRegistro);
            LastID.ElementAt(0).Element("LastID").Value = "" + theID;
            getConfig.Save("Registros/Config.xml");
        }

    }

    /// <summary>
    /// Interface que determina quais métodos devem ser implementados
    /// em cada Classe.
    /// </summary>
    public interface IXmlControl
    {
        void XmlCreate();
        void XmlAppend();
    }
}

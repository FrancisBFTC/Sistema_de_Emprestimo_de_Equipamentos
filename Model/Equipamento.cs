using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace AgendamentoModel
{
    public class Equipamento : Cadastro, IXmlControl
    {
        /// <summary>
        /// Atributos de dados que vão sobreescrever da Classe herdada Cadastro
        /// </summary>
        public override string Nome { get; set; }
        public override string XmlPath { get; set; }
        public override string TipoRegistro { get; set; }
        public override int ID { get; set; }

        /// <summary>
        /// Atributos de dados específicos da Classe Equipamento
        /// </summary>
        public String Tipo { get; set; }
        public int Quantidade;

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
        /// Construtor principal da Classe Equipamento para instanciação
        /// e atribuição de novos registros | Formação do arquivo completo
        /// </summary>
        /// <param name="nome">Nome do equipamento</param>
        /// <param name="tipo">Tipo de equipamento (Visual/Sonoro)</param>
        /// <param name="quantidade">Quantidade disponível do equipamento</param>
        public Equipamento(String nome, String tipo, int quantidade) : base()
        {
            this.Nome = nome;
            this.Tipo = tipo;
            this.Quantidade = quantidade;
            XmlPath += "Equipamento.xml";
            TipoRegistro = "Equipamento";
        }

        /// <summary>
        /// Construtor sobrecarregado de Equipamento, que instancia a classe Herdada
        /// Neste construtor não é necessário definir os atributos de dados
        /// </summary>
        public Equipamento() : base()
        {
            XmlPath += "Equipamento.xml";
            TipoRegistro = "Equipamento";
        }

        /// <summary>
        /// Construtor sobrecarregado de Equipamento, que instancia a classe Herdada
        /// É definido apenas o ID em casos de Exclusão
        /// </summary>
        /// <param name="id">ID do Equipamento a ser excluído</param>
        public Equipamento(int id) : base()
        {
            this.ID = id;
            XmlPath += "Equipamento.xml";
            TipoRegistro = "Equipamento";
        }

        /// <summary>
        /// Método que Registra novo equipamento, sobreescrevendo o método de Cadastro
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
                    Console.WriteLine("Erro de Escrita de cadastro do equipamento: " + e.Message);
                    return;
                }
            }
            base.Registrar();
            Console.WriteLine("Equipamento registrado!");
        }

        /// <summary>
        /// Método que exclui um equipamento: foi reservado para atualizações futuras
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
        /// Método sobreescrito de Cadastro que verifica se um equipamento existe.
        /// Pode ser utilizado para filtragem de nomes
        /// </summary>
        /// <returns>Elementos XML do equipamento</returns>
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
        /// Método que captura todos os equipamentos de um documento XML.
        /// Utilizado para exibição em menus ou listas
        /// </summary>
        /// <returns></returns>
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
            var consulta = from professor in XmlDoc.Descendants(TipoRegistro)
                           select professor;
            return consulta;
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
                            new XElement("Equipamento",
                                new XElement("ID", ++theID),
                                new XElement("Nome", this.Nome),
                                new XElement("Tipo", this.Tipo),
                                new XElement("Quantidade", this.Quantidade)
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
            XElement novoRegistro = new XElement("Equipamento",
                                        new XElement("ID", ++theID),
                                        new XElement("Nome", this.Nome),
                                        new XElement("Tipo", this.Tipo),
                                        new XElement("Quantidade", this.Quantidade)
                                    );
            XmlDoc.Root.Add(novoRegistro);
            LastID.ElementAt(0).Element("LastID").Value = "" + theID;
            getConfig.Save("Registros/Config.xml");
        }

    }

}

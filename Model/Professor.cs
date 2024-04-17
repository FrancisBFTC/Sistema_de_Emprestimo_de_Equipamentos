using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace AgendamentoModel
{
    public class Professor : Cadastro, IXmlControl
    {
        /// <summary>
        /// Atributos de dados que vão sobreescrever da Classe herdada Cadastro
        /// </summary>
        public override string Nome {  get; set; }
        public override string XmlPath { get; set; }
        public override String TipoRegistro { get; set; }
        public override int ID { get; set; }

        /// <summary>
        /// Atributos de dados específicos da Classe Professor
        /// </summary>
        public String Disciplina { get; set; }
        public String Turmas { get; set; }

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
        /// Construtor principal da Classe Professor para instanciação
        /// e atribuição de novos registros | Formação do arquivo completo
        /// </summary>
        /// <param name="nome">Nome do Professor</param>
        /// <param name="disciplina">Disciplina do Professor</param>
        /// <param name="turmas">Turmas do professor</param>
        public Professor(String nome, String disciplina, String turmas) : base()
        {
            this.Nome = nome;
            this.Disciplina = disciplina;
            this.Turmas = turmas;
            XmlPath += "Professor.xml";
            TipoRegistro = "Professor";
        }

        /// <summary>
        /// Construtor sobrecarregado de Professor, que instancia a classe Herdada
        /// Neste construtor não é necessário definir os atributos de dados
        /// </summary>
        public Professor() : base()
        {
            XmlPath += "Professor.xml";
            TipoRegistro = "Professor";
        }

        /// <summary>
        /// Construtor sobrecarregado de Equipamento, que instancia a classe Herdada
        /// É definido apenas o ID em casos de Exclusão
        /// </summary>
        /// <param name="id">ID do Professor a ser excluído</param>
        public Professor(int id) : base()
        {
            this.ID = id;
            XmlPath += "Professor.xml";
            TipoRegistro = "Professor";
        }

        /// <summary>
        /// Método que Registra novo professor, sobreescrevendo o método de Cadastro
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
                    Console.WriteLine("Erro de Escrita de cadastro do professor: " + e.Message);
                    return;
                }
            }
            base.Registrar();
            Console.WriteLine("Professor registrado!");
        }

        /// <summary>
        /// Método sobreescrito de Cadastro que exclui um professor: 
        /// Foi reservado para atualizações futuras
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
            Console.WriteLine("Professor excluído!");
        }

        /// <summary>
        /// Método sobreescrito de Cadastro que verifica se um professor existe.
        /// Pode ser utilizado para filtragem de nomes
        /// </summary>
        /// <returns>Elementos XML do professor</returns>
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
        /// Método que captura todos os professores de um documento XML.
        /// Utilizados para exibição em menus ou listas
        /// </summary>
        /// <returns>Elementos XML de todos os professores</returns>
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
                            new XElement("Professor",
                                new XElement("ID", ++theID),
                                new XElement("Nome", this.Nome),
                                new XElement("Disciplina", this.Disciplina),
                                new XElement("Turmas", this.Turmas)
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
            XElement novoRegistro = new XElement("Professor",
                                        new XElement("ID", ++theID),
                                        new XElement("Nome", this.Nome),
                                        new XElement("Disciplina", this.Disciplina),
                                        new XElement("Turmas", this.Turmas)
                                    );
            XmlDoc.Root.Add(novoRegistro);
            LastID.ElementAt(0).Element("LastID").Value = "" + theID;
            getConfig.Save("Registros/Config.xml");
        }
    }
}

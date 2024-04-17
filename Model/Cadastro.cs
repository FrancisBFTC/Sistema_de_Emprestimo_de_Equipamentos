using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace AgendamentoModel
{
    
    public class Cadastro
    {
        /// <summary>
        /// Atributos de dados que serão sobreescritos pelas Classes
        /// Equipamento, Professor e Empréstimo
        /// </summary>
        public virtual String Nome { get; set; }
        public virtual String XmlPath { get; set; }
        public virtual String TipoRegistro { get; set; }
        public virtual int ID { get; set; }

        /// <summary>
        /// Atributos de instância para controle do XML
        /// </summary>
        public virtual XDocument XmlDoc { get; set; }
        public virtual IEnumerable<XElement> XmlElement { get; set; }

        /// <summary>
        /// Construtor de Cadastro que define o diretório principal
        /// de dados
        /// </summary>
        public Cadastro()
        {
            this.XmlPath = "Registros/";
        }

        /// <summary>
        /// Escreve no arquivo XML dado um caminho completo do arquivo
        /// </summary>
        public virtual void Registrar()
        {
            XmlDoc.Save(XmlPath);
        }

        /// <summary>
        /// Exclui um elemento do XML dado um caminho completo do arquivo
        /// </summary>
        public virtual void Excluir()
        {
            XmlElement.Remove();
            XmlDoc.Save(XmlPath);
        }

        /// <summary>
        /// Verifica do arquivo XML um dado que seja igual o nome ou o equipamento
        /// </summary>
        /// <returns>Elementos XMLs com os parâmetros verificados</returns>
        public virtual IEnumerable<XElement> Verificar()
        {
            var dadoXML = from registro in XmlDoc.Descendants(TipoRegistro)
                          where ((String)registro.Element("Nome")) == this.Nome ||
                                ((String)registro.Element("Equipamento")) == this.Nome
                          select registro;
            return dadoXML;
        }
    }
}

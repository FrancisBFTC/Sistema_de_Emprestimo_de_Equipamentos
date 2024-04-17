using AgendamentoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SistemaEmprestimo.Controller
{
    internal static class Agendamento
    {

        /// <summary>
        /// Método estático que salva um dia disponível após um fechamento/cancelamento.
        /// O método manipula o arquivo Livres.xml
        /// </summary>
        /// <param name="dataInicial">Data Inicial vindo do fechamento/cancelamento</param>
        /// <param name="dataFinal">Data Final vindo do fechamento/cancelamento</param>
        public static void AtribuirDisponibilidade(String dataInicial, String dataFinal)
        {
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.ColetarLivres();
            XElement novaData = new XElement(emprestimo.TipoRegistro,
                                                        new XElement("DataInicial", dataInicial.ToString()),
                                                        new XElement("DataFinal", dataFinal.ToString())
                                                    );
            emprestimo.XmlDoc.Root.Add(novaData);
            emprestimo.XmlDoc.Save("Registros/" + emprestimo.TipoRegistro + ".xml");
        }

        /// <summary>
        /// Método estático que atribui a data de hoje na primeira vez
        /// que o software é aberto quando não há empréstimos.
        /// Todos os dias disponíveis vão se basear a partir desta data.
        /// </summary>
        public static void AtribuirDisponibilidade()
        {
            Emprestimo emprestimo = new Emprestimo();
            IEnumerable<XElement> consulta = emprestimo.Coletar();
            if (consulta.Any())
                return;

            DateTime dataHoje = DateTime.Now;
            emprestimo = new Emprestimo();
            emprestimo.ColetarLivres();
            emprestimo.XmlDoc = new XDocument(
                                    new XElement("Registros",
                                        new XElement(emprestimo.TipoRegistro,
                                            new XElement("DataInicial", dataHoje.ToString()),
                                            new XElement("DataFinal", "Data Indefinida")
                                         )
                                    )
                                );

            emprestimo.XmlDoc.Save("Registros/" + emprestimo.TipoRegistro + ".xml");
        }

        /// <summary>
        /// Método estático que verifica se um dia é disponível ou não para empréstimos.
        /// Esse método é chamado durante um agendamento e retorna verdadeiro se houver
        /// um dia disponível. O método também controla o arquivo Livre.xml, guardando
        /// novos dias disponíveis ou alterando os existentes.
        /// </summary>
        /// <param name="dataInicial">Data inicial para agenda</param>
        /// <param name="dataFinal">Data final para agenda</param>
        /// <returns>Verdadeiro/Falso para Disponível/Ocupado</returns>
        public static bool VerificarDisponibilidade(String dataInicial, String dataFinal)
        {
            DateTime tempoInicial = Convert.ToDateTime(dataInicial);
            DateTime tempoFinal = Convert.ToDateTime(dataFinal);
            Emprestimo emprestimo = new Emprestimo();
            IEnumerable<XElement> consulta = emprestimo.ColetarLivres();

            bool horarioLivre = false;

            foreach (var item in consulta)
            {
                DateTime livreAtual = Convert.ToDateTime(item.Element("DataInicial").Value);
                DateTime livreFinal;
                if (item.Element("DataFinal").Value == "Data Indefinida")
                {
                    int comparacaoInicial1 = DateTime.Compare(tempoInicial, livreAtual);
                    bool dentroDaFaixa1 = (comparacaoInicial1 >= 0);
                    if (dentroDaFaixa1)
                    {
                        if (comparacaoInicial1 != 0)
                        {
                            item.Element("DataFinal").Value = tempoInicial.ToString();
                            XElement novaData = new XElement(emprestimo.TipoRegistro,
                                                        new XElement("DataInicial", tempoFinal.ToString()),
                                                        new XElement("DataFinal", "Data Indefinida")
                                                    );
                            emprestimo.XmlDoc.Root.Add(novaData);
                            emprestimo.XmlDoc.Save("Registros/" + emprestimo.TipoRegistro + ".xml");
                        }
                        else
                        {
                            item.Element("DataInicial").Value = tempoFinal.ToString();
                            emprestimo.XmlDoc.Save("Registros/" + emprestimo.TipoRegistro + ".xml");
                        }

                    }
                    else
                    {
                        horarioLivre = false;
                        continue;
                    }
                    return true;
                } // Fim IF : DataFinal == None
                else
                {
                    livreFinal = Convert.ToDateTime(item.Element("DataFinal").Value);
                    // Comparando as datas
                    int comparacaoInicial1 = DateTime.Compare(tempoInicial, livreAtual);
                    int comparacaoFinal1 = DateTime.Compare(tempoInicial, livreFinal);
                    int comparacaoInicial2 = DateTime.Compare(tempoFinal, livreAtual);
                    int comparacaoFinal2 = DateTime.Compare(tempoFinal, livreFinal);

                    bool dentroDaFaixa1 = (comparacaoInicial1 >= 0 && comparacaoFinal1 <= 0);
                    bool dentroDaFaixa2 = (comparacaoInicial2 >= 0 && comparacaoFinal2 <= 0);

                    if (dentroDaFaixa1 && dentroDaFaixa2)
                    {
                        String dataFinalTemp = item.Element("DataFinal").Value;
                        bool isComparacaoInicial = false;

                        if (comparacaoInicial1 != 0)
                        {
                            isComparacaoInicial = true;
                            item.Element("DataInicial").Value = livreAtual.ToString();
                            item.Element("DataFinal").Value = tempoInicial.ToString();
                            emprestimo.XmlDoc.Save("Registros/" + emprestimo.TipoRegistro + ".xml");
                        }

                        if (comparacaoFinal2 != 0)
                        {

                            if (!isComparacaoInicial)
                            {
                                item.Element("DataInicial").Value = tempoFinal.ToString();
                                item.Element("DataFinal").Value = livreFinal.ToString();
                                emprestimo.XmlDoc.Save("Registros/" + emprestimo.TipoRegistro + ".xml");
                            }
                            else
                            {
                                XElement novaData = new XElement(emprestimo.TipoRegistro,
                                                            new XElement("DataInicial", tempoFinal.ToString()),
                                                            new XElement("DataFinal", dataFinalTemp.ToString())
                                                        );
                                emprestimo.XmlDoc.Root.Add(novaData);
                                emprestimo.XmlDoc.Save("Registros/" + emprestimo.TipoRegistro + ".xml");
                            }

                        }

                        if (comparacaoInicial1 == 0 && comparacaoFinal2 == 0)
                        {
                            item.Remove();
                            emprestimo.XmlDoc.Save("Registros/" + emprestimo.TipoRegistro + ".xml");
                        }

                        return true;
                    }
                    else
                    {
                        horarioLivre = false;
                        continue;
                    }

                } // Fim Else : DataFinal != None

            }

            return horarioLivre;

        }


    }
}

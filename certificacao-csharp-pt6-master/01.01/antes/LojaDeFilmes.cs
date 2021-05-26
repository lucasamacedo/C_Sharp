using System.Collections.Generic;
using System.Xml.Serialization;

namespace _01._01
{
    [XmlRoot("LojaDeFilmes")]
    public class LojaDeFilmes
    {
        [XmlArray("Diretores")]
        public List<Diretor> Diretores = new List<Diretor>();
        [XmlArray("Filmes")]
        public List<Filme> Filmes = new List<Filme>();
        public static void AdicionarFilme(Filme filme)
        {
            // Aqui vai a lógica de inserção de filme...
        }
    }

    [XmlType("Diretor")]
    public class Diretor
    {
        [XmlElement("Nome")]
        public string Nome { get; set; }
        [XmlElement("NumeroDeFilmes")]
        //[XmlIgnore]
        public int NumeroFilmes;
    }

    [XmlType("Filme")]
    public class Filme
    {
        [XmlElement("Diretor")]
        public Diretor Diretor { get; set; }
        [XmlElement("Titulo")]
        public string Titulo { get; set; }
        [XmlElement("Ano")]
        public string Ano { get; set; }
    }
}

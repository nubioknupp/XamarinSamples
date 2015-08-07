using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using SQLite;

namespace ExerciseXamarinIOS
{
    class NewsDao
    {
        private const string Db = "news.db";
        public NewsDao()
        {
            var vDocuments = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var vDb = Path.Combine(vDocuments, Db);
            var isExists = File.Exists(vDb);

            if (!isExists)
            {
                var currentConnection = new SQLiteConnection(Db);
                var vText = "";

                currentConnection.CreateTable<News>();
                vText = "Os ingressos para a Brasil Game Show (BGS) 2015 est�o com 24% de desconto at� o dia 13 de agosto, informa a organiza��o da feira. At� a data, a meia-entrada para um �nico dia de BGS custa R$ 65, enquanto que o passaporte para todos os dias de feira sai por R$ 260.";
                vText += "\n\nEstudantes, portadores de necessidades especiais, professores e idosos maiores de 60 anos t�m direito a meia-entrada. Quem doar 1 kg de alimento n�o perec�vel na entrada do evento tamb�m pode recorrer ao benef�cio.";
                currentConnection.Insert(new News() { Title = "BGS tem ingressos com 24% de desconto", Description = vText });

                vText = "Ser� que a maldi��o do Dow finalmente pegou a Apple? As a��es da fabricante do iPhone t�m recuado desde a divulga��o dos decepcionantes resultados trimestrais, caindo para a m�nima de seis meses de na ter�a-feira (5).";
                vText += "\n\nO recente decl�nio fez desaparecer aproximadamente US$ 100 bilh�es do valor de mercado da Apple - quase o valor de mercado da Boeing e McDonald's.";
                vText += "\n\nPara o presidente-executivo Tim Cook, isso significa que sua participa��o de 950 mil a��es, que valiam mais de US$ 127 milh�es em abril, agora valem cerca de US$ 109 milh�es.";
                vText += "\n\nOs papeis ganharam mais de 137% desde a m�nima em abril de 2013. Mais de 5.700 fundos j� possuem as a��es, de acordo com dados da Morningstar.";
                vText += "\n\nOs decl�nios deixaram as a��es da companhia abaixo da m�dia m�vel de 200 dias, medida de tend�ncia de longo nas a��es, sendo que a �ltima vez que encerram abaixo desta m�dia, em novembro de 2012, as a��es estavam em meio a um decl�nio que durou mais diversos meses, finalmente chegando ao m�nimo em junho de 2013.";
                vText += "\n\n\"O ecossistema da Apple nunca esteve mais forte, mas estamos em um ciclo muito maduro. N�s achamos que a Apple ser� uma boa a��o, mas n�o uma �tima a��o no futuro,\" disse Channing Smith, diretor administrativo da Capital Advisors, em Tulsa, Oklahoma.";
                currentConnection.Insert(new News() { Title = "Queda das a��es da Apple aflige investidores", Description = vText });

                vText = "Nada de bola rolando. Nem das 35 mil vozes a embalar as tramas do elenco dourado por Marcelo Oliveira, especialmente bem-vindas numa p�tria ora mais acostumada a pedaladas fiscais. Nada tamb�m das estrelas internacionais escaladas para o palco multiuso. No pr�ximo s�bado a arquibancada vai balan�ar por outra paix�o. Sete meses depois de inaugurado, o Allianz Parque acolher� a primeira final. Dez craques, cinco de cada lado, buscar�o o t�tulo, e o pr�mio de R$ 60 mil, da segunda etapa do Circuito Brasileiro de League of Legends � LoL, para os �ntimos. Voc� pode (ainda) n�o saber o que �, ou n�o gostar, mas seu filho gosta. Lembra, muito, mas muito simplificadamente, um pique-bandeira no computador.";
                vText += "\n\nO astro do ascendente segmento dos esportes eletr�nicos divide com o Dota 2 (Defence of Ancientes) a majestade dos chamados jogos de estrat�gia em tempo real. Com 30 milh�es de praticantes di�rios, a batalha online criada em 2009 pela Riot Games cultiva uma escalada de audi�ncia e receita. O primeiro lote de sete mil ingressos para o duelo decisivo no est�dio do Palmeiras esgotou em duas horas. At� porque os interessados n�o enfrentaram a corrida de obst�culos encarada pelos que tentam comprar bilhete de futebol via internet, como se faz com facilidade para teatro, cinema, concertos, shows, amistosos da NBA, finais de v�lei, Copa, Olimp�ada � e agora torneios de League of Legends, cujos gestores logo entenderam que o sucesso da divers�o virtual depende de conveni�ncias palp�veis.";
                currentConnection.Insert(new News() { Title = "Esporte eletr�nico ganha a arquibancada", Description = vText });
            }
        }

        public List<News> GetNewses()
        {
            var currentConnection = new SQLiteConnection(Db);

            return currentConnection.Table<News>().ToList();
        } 


    }
}
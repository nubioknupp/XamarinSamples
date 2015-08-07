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
                vText = "Os ingressos para a Brasil Game Show (BGS) 2015 estão com 24% de desconto até o dia 13 de agosto, informa a organização da feira. Até a data, a meia-entrada para um único dia de BGS custa R$ 65, enquanto que o passaporte para todos os dias de feira sai por R$ 260.";
                vText += "\n\nEstudantes, portadores de necessidades especiais, professores e idosos maiores de 60 anos têm direito a meia-entrada. Quem doar 1 kg de alimento não perecível na entrada do evento também pode recorrer ao benefício.";
                currentConnection.Insert(new News() { Title = "BGS tem ingressos com 24% de desconto", Description = vText });

                vText = "Será que a maldição do Dow finalmente pegou a Apple? As ações da fabricante do iPhone têm recuado desde a divulgação dos decepcionantes resultados trimestrais, caindo para a mínima de seis meses de na terça-feira (5).";
                vText += "\n\nO recente declínio fez desaparecer aproximadamente US$ 100 bilhões do valor de mercado da Apple - quase o valor de mercado da Boeing e McDonald's.";
                vText += "\n\nPara o presidente-executivo Tim Cook, isso significa que sua participação de 950 mil ações, que valiam mais de US$ 127 milhões em abril, agora valem cerca de US$ 109 milhões.";
                vText += "\n\nOs papeis ganharam mais de 137% desde a mínima em abril de 2013. Mais de 5.700 fundos já possuem as ações, de acordo com dados da Morningstar.";
                vText += "\n\nOs declínios deixaram as ações da companhia abaixo da média móvel de 200 dias, medida de tendência de longo nas ações, sendo que a última vez que encerram abaixo desta média, em novembro de 2012, as ações estavam em meio a um declínio que durou mais diversos meses, finalmente chegando ao mínimo em junho de 2013.";
                vText += "\n\n\"O ecossistema da Apple nunca esteve mais forte, mas estamos em um ciclo muito maduro. Nós achamos que a Apple será uma boa ação, mas não uma ótima ação no futuro,\" disse Channing Smith, diretor administrativo da Capital Advisors, em Tulsa, Oklahoma.";
                currentConnection.Insert(new News() { Title = "Queda das ações da Apple aflige investidores", Description = vText });

                vText = "Nada de bola rolando. Nem das 35 mil vozes a embalar as tramas do elenco dourado por Marcelo Oliveira, especialmente bem-vindas numa pátria ora mais acostumada a pedaladas fiscais. Nada também das estrelas internacionais escaladas para o palco multiuso. No próximo sábado a arquibancada vai balançar por outra paixão. Sete meses depois de inaugurado, o Allianz Parque acolherá a primeira final. Dez craques, cinco de cada lado, buscarão o título, e o prêmio de R$ 60 mil, da segunda etapa do Circuito Brasileiro de League of Legends – LoL, para os íntimos. Você pode (ainda) não saber o que é, ou não gostar, mas seu filho gosta. Lembra, muito, mas muito simplificadamente, um pique-bandeira no computador.";
                vText += "\n\nO astro do ascendente segmento dos esportes eletrônicos divide com o Dota 2 (Defence of Ancientes) a majestade dos chamados jogos de estratégia em tempo real. Com 30 milhões de praticantes diários, a batalha online criada em 2009 pela Riot Games cultiva uma escalada de audiência e receita. O primeiro lote de sete mil ingressos para o duelo decisivo no estádio do Palmeiras esgotou em duas horas. Até porque os interessados não enfrentaram a corrida de obstáculos encarada pelos que tentam comprar bilhete de futebol via internet, como se faz com facilidade para teatro, cinema, concertos, shows, amistosos da NBA, finais de vôlei, Copa, Olimpíada – e agora torneios de League of Legends, cujos gestores logo entenderam que o sucesso da diversão virtual depende de conveniências palpáveis.";
                currentConnection.Insert(new News() { Title = "Esporte eletrônico ganha a arquibancada", Description = vText });
            }
        }

        public List<News> GetNewses()
        {
            var currentConnection = new SQLiteConnection(Db);

            return currentConnection.Table<News>().ToList();
        } 


    }
}
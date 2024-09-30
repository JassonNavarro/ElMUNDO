using Microsoft.Maui.Controls;

namespace ElMUNDO.Pages;

public partial class Pagina2 : ContentPage
{
	public Pagina2()
	{
		InitializeComponent();
	}

   
    private void Button_Clicked_1(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia1Descripcion.Text.StartsWith("Águila se pone al día en un juego pendiente con Municipal Limeño"))
        {
            // Mostrar la versión completa de la noticia
            noticia1Descripcion.Text = "Águila se medirá este miércoles al Municipal Limeño en un partido que corresponde a la séptima jornada del torneo Apertura y que fue pospuesto.Los dirigidos por Daniel Messina buscarán recuperar el liderato que les fue arrebatado por Firpo el domingo pasado en Usulután.Los migueleños vienen de caer por 1-0 el domingo ante los pamperos en donde además de quedar terceros en la tabla perdieron la racha invicta de partidos que tenían. Por otro lado, los santarroseños tuvieron descanso y actualmente se ubican en la sexta posición del torneo, con 11 unidades.Para este partido, Messina no podrá contar con Benji Villalobos, ya que sufrió un fuerte golpe en su rodilla izquierda.Limeño llega con la reciente cancelación de contrato del jugador Lucas Dos Santos Oliveira por motivos familiares y que fue de mutuo acuerdo.Además, Alianza visitará a Fuerte San Francisco en el Estadio Correcaminos, el encuentro se llevará a cabo este jueves. Los albos se ubican en la quinta plaza del torneo con 11 puntos luego de ganar su último duelo ante FAS,  en contraparte los comandos azules son novenos con 8 unidades luego de empatar ante Dragón. Los dirigidos por el Zarco Rodríguez llegan además con la novedad de su nuevo fichaje, el delantero argentino Ramiro Rocca.En caso de ganar, los de Gotera estarían igualando a los paquidermos en la tabla.";

            // Cambiar el texto del botón a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versión corta de la noticia
            noticia1Descripcion.Text = "Águila se pone al día en un juego pendiente con Municipal Limeño";

            // Cambiar el texto del botón a "Leer más"
            button.Text = "Leer más";
        }

    }

   
    private void Button_Clicked_2(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia2Descripcion.Text.StartsWith("Liverpool conquista San Siro en el clásico europeo ante el Milan"))
        {
            // Mostrar la versión completa de la noticia
            noticia2Descripcion.Text = "El Liverpool se impuso 3-1 en San Siro al AC Milan en un clásico del fútbol europeo que deparó buen juego, goles y ocasiones, este martes en la primera fecha de la renovada Champions League.Los 'Reds' de Arne Slot, que venían de sufrir en Anfield la primera derrota del curso en la liga inglesa ante el Nottingham Forest (1-0), se desquitaron de esa decepción conquistando uno de los templos del fútbol europeo con goles del defensor francés Ibrahima Konaté (23), de su compañero en el centro de la zaga, el neerlandés Virgil Van Dijk (41), y del centrocampista húngaro Dominik Szoboszlai (17), que dejaron sin efecto el tanto inicial del delantero estadounidense Christian Pulisic (3) para los 'rossoneri'. Más allá de la derrota, el Milan de Paulo Fonseca también sufrió la lesión de su arquero francés Mike Maignan al inicio de la segunda parte.El meta internacional francés de 29 años se dañó la rodilla izquierda a raíz de un choque con el portugués Diogo Jota.Protagonistas de las finales de la Champions de 2005 (victoria del Liverpool) y de 2007 (victoria del Milan),ambos equipos suman 13 títulos entre la Champions y su antecesora, la extinta Copa de Europa. El conjunto local había iniciado el partido de la mejor forma con un gol de Pulisic de disparo cruzado para batir al arquero brasileño Allison.Pero los jugadores de Paulo Fonseca, que lograron su primera victoria de la temporada el pasado sábado, no tardaron en ceder la iniciativa a un Liverpool sobrado de calidad para no perdonar sus ocasiones.";

            // Cambiar el texto del botón a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versión corta de la noticia
            noticia2Descripcion.Text = "Liverpool conquista San Siro en el clásico europeo ante el Milan";

            // Cambiar el texto del botón a "Leer más"
            button.Text = "Leer más";
        }

    }

   
    private void Button_Clicked_3(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia3Descripcion.Text.StartsWith("El Bayern de Múnich aplasta al Dinamo Zagreb 9-2 en Champions League"))
        {
            // Mostrar la versión completa de la noticia
            noticia3Descripcion.Text = "El Bayern Múnich inició de manera atronadora su andadura en la renovada Champions League, aplastando 9-2 al Dinamo de Zagreb croata este martes en el Alliaz Arena. En el estreno europeo de Vincent Kompany en el banco del Bayern, los bávaros dieron un festival ofensivo con un póker de Harry Kane (19, 57, 73 y 78),un doblete del francés Michael Olise (38, 61) y goles de Raphaël Guerreiro (33), Leroy Sané (85) y Leon Goretzka (90+2). Estoy muy contento por los chicos. Marcaron goles, pero necesitamos más control, llegará, señaló Kompany.Tras una temporada sin títulos por primera vez desde 2011, el Bayern ha recuperado el hambre en este arranque de curso.Es líder en la Bundesliga con tres victorias en tres partidos y se sitúa al frente de la renovada Champions, un solo grupo con 36 equipos que echó a andar este martes. Sin embargo el semifinalista de la última edición sufrió al inicio de la segunda parte, cuando el Dinamo Zagreb marcó dos goles en dos minutos (Petkovic y Ogiwara, 48 y 50) para situarse 3-2. Pero los jugadores dirigidos por Kompany reanudaron rápidamente la máquina de golear.Kane marcó tres de sus cuatro goles desde el punto de penal, pero para el espectáculo quedarán el tanto de volea de Guerreiro, tras un balón domado con el pecho por Jamal Musiala, el disparo con efecto de Sané o el cabezazo en plancha de Goretzka.Fue un partido increíble, un poco loco... Cuatro goles es realmente una gran noche y marcar tres de penal nunca me había pasado, reaccionó un sorprendido Kane. La cuenta pudo ser más dura para el equipo croata, con el árbitro anulando por fuera de juego dos goles bávaros.La sombra de la noche para el Bayern llegó por la sustitución al descanso de su arquero y capitán Manuel Neuer, dolido tras una dura caída al principio del partido tras una salida al centro del campo.Fue sustituido por Scen Ulreich, que encajó los dos goles.";

            // Cambiar el texto del botón a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versión corta de la noticia
            noticia3Descripcion.Text = "El Bayern de Múnich aplasta al Dinamo Zagreb 9-2 en Champions League";

            // Cambiar el texto del botón a "Leer más"
            button.Text = "Leer más";
        }

    }

   
    private void Button_Clicked_4(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia4Descricion.Text.StartsWith("Real Madrid arranca en Champions con triunfo 3 - 1 ante Stuttgart"))
        {
            // Mostrar la versión completa de la noticia
            noticia4Descricion.Text = "Más equipos, distinto formato... pero los favoritos siguen imponiendo su ley. El vigente campeón Real Madrid, Liverpool, Bayern de Múnich -con goleada 9-2-, y Juventus solventaron sus primeros compromisos este martes y colideran la nueva Liga de Campeones.Ninguno de los seis partidos que alzaron el telón de la Champions 2024-2025 concluyó en tablas,y equipos un escalón por debajo como Aston Villa y Sporting de Portugal tampoco fallaron en sus compromisos ante el Lille (2-0) y el Young Boys (0-3). Así pues, sin sorpresas, los 'grandes' se apuntaron sus primeros tres puntos en una competición ampliada a 36 equipos, cada uno de los cuales se enfrenta a ocho rivales en la primera fase, tras la que los ocho mejores se clasifican de manera directa a octavos,mientras que los que ocupen los puestos del 9 al 24 disputarán un repechaje para completar esta ronda.";

            // Cambiar el texto del botón a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versión corta de la noticia
            noticia4Descricion.Text = "Real Madrid arranca en Champions con triunfo 3-1 ante Stuttgart";

            // Cambiar el texto del botón a "Leer más"
            button.Text = "Leer más";
        }

    }
}
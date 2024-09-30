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

        if (noticia1Descripcion.Text.StartsWith("�guila se pone al d�a en un juego pendiente con Municipal Lime�o"))
        {
            // Mostrar la versi�n completa de la noticia
            noticia1Descripcion.Text = "�guila se medir� este mi�rcoles al Municipal Lime�o en un partido que corresponde a la s�ptima jornada del torneo Apertura y que fue pospuesto.Los dirigidos por Daniel Messina buscar�n recuperar el liderato que les fue arrebatado por Firpo el domingo pasado en Usulut�n.Los miguele�os vienen de caer por 1-0 el domingo ante los pamperos en donde adem�s de quedar terceros en la tabla perdieron la racha invicta de partidos que ten�an. Por otro lado, los santarrose�os tuvieron descanso y actualmente se ubican en la sexta posici�n del torneo, con 11 unidades.Para este partido, Messina no podr� contar con Benji Villalobos, ya que sufri� un fuerte golpe en su rodilla izquierda.Lime�o llega con la reciente cancelaci�n de contrato del jugador Lucas Dos Santos Oliveira por motivos familiares y que fue de mutuo acuerdo.Adem�s, Alianza visitar� a Fuerte San Francisco en el Estadio Correcaminos, el encuentro se llevar� a cabo este jueves. Los albos se ubican en la quinta plaza del torneo con 11 puntos luego de ganar su �ltimo duelo ante FAS,  en contraparte los comandos azules son novenos con 8 unidades luego de empatar ante Drag�n. Los dirigidos por el Zarco Rodr�guez llegan adem�s con la novedad de su nuevo fichaje, el delantero argentino Ramiro Rocca.En caso de ganar, los de Gotera estar�an igualando a los paquidermos en la tabla.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia1Descripcion.Text = "�guila se pone al d�a en un juego pendiente con Municipal Lime�o";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";
        }

    }

   
    private void Button_Clicked_2(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia2Descripcion.Text.StartsWith("Liverpool conquista San Siro en el cl�sico europeo ante el Milan"))
        {
            // Mostrar la versi�n completa de la noticia
            noticia2Descripcion.Text = "El Liverpool se impuso 3-1 en San Siro al AC Milan en un cl�sico del f�tbol europeo que depar� buen juego, goles y ocasiones, este martes en la primera fecha de la renovada Champions League.Los 'Reds' de Arne Slot, que ven�an de sufrir en Anfield la primera derrota del curso en la liga inglesa ante el Nottingham Forest (1-0), se desquitaron de esa decepci�n conquistando uno de los templos del f�tbol europeo con goles del defensor franc�s Ibrahima Konat� (23), de su compa�ero en el centro de la zaga, el neerland�s Virgil Van Dijk (41), y del centrocampista h�ngaro Dominik Szoboszlai (17), que dejaron sin efecto el tanto inicial del delantero estadounidense Christian Pulisic (3) para los 'rossoneri'. M�s all� de la derrota, el Milan de Paulo Fonseca tambi�n sufri� la lesi�n de su arquero franc�s Mike Maignan al inicio de la segunda parte.El meta internacional franc�s de 29 a�os se da�� la rodilla izquierda a ra�z de un choque con el portugu�s Diogo Jota.Protagonistas de las finales de la Champions de 2005 (victoria del Liverpool) y de 2007 (victoria del Milan),ambos equipos suman 13 t�tulos entre la Champions y su antecesora, la extinta Copa de Europa. El conjunto local hab�a iniciado el partido de la mejor forma con un gol de Pulisic de disparo cruzado para batir al arquero brasile�o Allison.Pero los jugadores de Paulo Fonseca, que lograron su primera victoria de la temporada el pasado s�bado, no tardaron en ceder la iniciativa a un Liverpool sobrado de calidad para no perdonar sus ocasiones.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia2Descripcion.Text = "Liverpool conquista San Siro en el cl�sico europeo ante el Milan";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";
        }

    }

   
    private void Button_Clicked_3(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia3Descripcion.Text.StartsWith("El Bayern de M�nich aplasta al Dinamo Zagreb 9-2 en Champions League"))
        {
            // Mostrar la versi�n completa de la noticia
            noticia3Descripcion.Text = "El Bayern M�nich inici� de manera atronadora su andadura en la renovada Champions League, aplastando 9-2 al Dinamo de Zagreb croata este martes en el Alliaz Arena. En el estreno europeo de Vincent Kompany en el banco del Bayern, los b�varos dieron un festival ofensivo con un p�ker de Harry Kane (19, 57, 73 y 78),un doblete del franc�s Michael Olise (38, 61) y goles de Rapha�l Guerreiro (33), Leroy San� (85) y Leon Goretzka (90+2). Estoy muy contento por los chicos. Marcaron goles, pero necesitamos m�s control, llegar�, se�al� Kompany.Tras una temporada sin t�tulos por primera vez desde 2011, el Bayern ha recuperado el hambre en este arranque de curso.Es l�der en la Bundesliga con tres victorias en tres partidos y se sit�a al frente de la renovada Champions, un solo grupo con 36 equipos que ech� a andar este martes. Sin embargo el semifinalista de la �ltima edici�n sufri� al inicio de la segunda parte, cuando el Dinamo Zagreb marc� dos goles en dos minutos (Petkovic y Ogiwara, 48 y 50) para situarse 3-2. Pero los jugadores dirigidos por Kompany reanudaron r�pidamente la m�quina de golear.Kane marc� tres de sus cuatro goles desde el punto de penal, pero para el espect�culo quedar�n el tanto de volea de Guerreiro, tras un bal�n domado con el pecho por Jamal Musiala, el disparo con efecto de San� o el cabezazo en plancha de Goretzka.Fue un partido incre�ble, un poco loco... Cuatro goles es realmente una gran noche y marcar tres de penal nunca me hab�a pasado, reaccion� un sorprendido Kane. La cuenta pudo ser m�s dura para el equipo croata, con el �rbitro anulando por fuera de juego dos goles b�varos.La sombra de la noche para el Bayern lleg� por la sustituci�n al descanso de su arquero y capit�n Manuel Neuer, dolido tras una dura ca�da al principio del partido tras una salida al centro del campo.Fue sustituido por Scen Ulreich, que encaj� los dos goles.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia3Descripcion.Text = "El Bayern de M�nich aplasta al Dinamo Zagreb 9-2 en Champions League";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";
        }

    }

   
    private void Button_Clicked_4(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia4Descricion.Text.StartsWith("Real Madrid arranca en Champions con triunfo 3 - 1 ante Stuttgart"))
        {
            // Mostrar la versi�n completa de la noticia
            noticia4Descricion.Text = "M�s equipos, distinto formato... pero los favoritos siguen imponiendo su ley. El vigente campe�n Real Madrid, Liverpool, Bayern de M�nich -con goleada 9-2-, y Juventus solventaron sus primeros compromisos este martes y colideran la nueva Liga de Campeones.Ninguno de los seis partidos que alzaron el tel�n de la Champions 2024-2025 concluy� en tablas,y equipos un escal�n por debajo como Aston Villa y Sporting de Portugal tampoco fallaron en sus compromisos ante el Lille (2-0) y el Young Boys (0-3). As� pues, sin sorpresas, los 'grandes' se apuntaron sus primeros tres puntos en una competici�n ampliada a 36 equipos, cada uno de los cuales se enfrenta a ocho rivales en la primera fase, tras la que los ocho mejores se clasifican de manera directa a octavos,mientras que los que ocupen los puestos del 9 al 24 disputar�n un repechaje para completar esta ronda.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia4Descricion.Text = "Real Madrid arranca en Champions con triunfo 3-1 ante Stuttgart";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";
        }

    }
}
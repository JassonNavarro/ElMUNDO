namespace ElMUNDO.Pages;

public partial class Pagina4 : ContentPage
{
	public Pagina4()
	{
		InitializeComponent();
	}



    private void Button_Clicked_9(object sender, EventArgs e)
    {

       


            var button = sender as Button;

            if (noticia1Descripcion.Text.StartsWith("El Ministerio de Salud liban�s contabiliza un total de muertos en 105 y el de heridos en 359."))
            {
                // Mostrar la versi�n completa de la noticia
                noticia1Descripcion.Text = "El ej�rcito israel� lanz� este domingo una andanada de bombardeos contra Hezbol� en L�bano que dejaron m�s de 100 muertos, dos d�as despu�s de haber asesinado al l�der del movimiento islamista liban�s, Has�n Nasral�, junto con decenas de otros miembros del grupo en otro ataque.En otro frente, Israel dijo que golpe� objetivos de los rebeldes hut�es en el oeste de Yemen, despu�s de que estos insurgentes proiran�es reivindicaran el lanzamiento de un misil contra el aeropuerto de Tel Aviv.Estos bombardeos provocaron cuatro muertos, seg�n medios de los rebeldes yemenitas.Ning�n lugar est� demasiado lejos para Israel, advirti� el ministro israel� de Defensa, Yoav Gallant, tras los bombardeos.Manteniendo la presi�n militar contra Hezbol�, una formaci�n chiita proiran�, el ej�rcito israel� indic� que golpe� 120 objetivos en L�bano.Corresponsales de la AFP escucharon una fuerte explosi�n y vieron columnas de humo brotando de los suburbios del sur de Beirut, basti�n de Hezbol�, donde el viernes falleci� Nasral� en un bombardeo israel� que arras� edificios enteros.El cuerpo del l�der del movimiento liban�s fue encontrado el s�bado y fue envuelto en un sudario, indic� una fuente cercana a la organizaci�n, precisando que todav�a no se fij� la fecha del funeral.En un balance revisado publicado a �ltima hora del domingo, el Ministerio de Salud liban�s cifr� el total de muertos en 105 y el de heridos en 359.";

                // Cambiar el texto del bot�n a "Leer menos"
                button.Text = "Leer menos";
            }
            else
            {
                // Mostrar la versi�n corta de la noticia
                noticia1Descripcion.Text = "El Ministerio de Salud liban�s contabiliza un total de muertos en 105 y el de heridos en 359.\r\n";

                // Cambiar el texto del bot�n a "Leer m�s"
                button.Text = "Leer m�s";

            }

        }

  
    private void Button_Clicked_10(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia2Descripcion.Text.StartsWith("Las v�ctimas y los da�os reportados por los estados deben ser avalados por el gobierno federal para estimar los recursos de emergencia a destinar a las zonas afectadas."))
        {
            // Mostrar la versi�n completa de la noticia
            noticia2Descripcion.Text = "Medios mexicanos reportaron este domingo la muerte de al menos 20 personas, superior al balance oficial de ocho, por el paso del hurac�n John en el sur de M�xico, zona que visitar� el pr�ximo mi�rcoles Claudia Sheinbaum ya como presidenta del pa�s.John deja 15 muertos s�lo en Guerrero, anuncia en su portada del domingo el peri�dico La Jornada, mientras que la cadena Milenio daba un balance de 18 fallecidos en ese mismo distrito.Hasta el s�bado, el presidente Andr�s Manuel L�pez Obrador, que el martes entrega el gobierno a Sheinbaum, hab�a reportado ocho fallecidos por las lluvias que provoc� el fen�meno en Guerrero.S�lo lamentamos la p�rdida de ocho personas debido a derrumbes por las intensas lluvias, escribi� el mandatario saliente en su cuenta de X.La prensa local, sin citar fuentes directas, se�ala que tambi�n hubo v�ctimas mortales en Michoac�n (oeste) y Oaxaca (sur), estados vecinos de Guerrero.Manuel Maza, director de protecci�n civil de Oaxaca, confirm� a la AFP la muerte de una persona, aunque no ha sido incorporada al balance de las autoridades federales.La AFP ha contactado a Protecci�n Civil y la fiscal�a de Guerrero sin obtener respuesta.Las v�ctimas y los da�os reportados por los estados deben ser avalados por el gobierno federal para estimar los recursos de emergencia a destinar a las zonas afectadas.Sheinbaum anunci� de su lado que su primera gira de trabajo ser� el mi�rcoles a las comunidades afectadas por John, que impact� en dos ocasiones las costas de M�xico.Acord� (...) estar el mi�rcoles por la tarde con el gabinete para hacer una evaluaci�n y los planes para continuar con toda la ayuda necesaria a Guerrero, escribi� la mandataria electa en su cuenta de X.John toc� tierra en Guerrero el pasado martes como un poderoso hurac�n de categor�a 3 en la escala de 5 Saffir-Simpson y sus efectos alcanzaron a Oaxaca.El fen�meno se debilit� en tierra, pero sus remanentes volvieron al Pac�fico y recuperaron fuerza de hurac�n el jueves, antes de reingresar por el estado de Michoac�n (oeste).El balneario de Acapulco ha sido el m�s da�ado. Sus casi 800.000 habitantes revivieron la pesadilla de Otis, un poderoso hurac�n 5 que en octubre de 2023 destruy� el puerto de la ciudad, dejando decenas de muertos y desaparecidos.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia2Descripcion.Text = "Las v�ctimas y los da�os reportados por los estados deben ser avalados por el gobierno federal para estimar los recursos de emergencia a destinar a las zonas afectadas.";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";

        }


    }

   

    private void Button_Clicked_11(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia3Descripcion.Text.StartsWith("Helene toc� tierra el jueves por la tarde cerca de Tallahassee, capital del estado de Florida, como hurac�n de categor�a 4 en una escala de 5, con vientos de 225 km/h y se degrad� a cicl�n postropical, causando intensas inundaciones."))
        {
            // Mostrar la versi�n completa de la noticia
            noticia3Descripcion.Text = "Grupos de rescatistas batallaban el domingo para socorrer a miles de personas afectadas por el paso de la devastadora tormenta Helene por el sureste de Estados Unidos, donde los caminos quedaron inundados, hay apagones e incluso se entrega comida v�a a�rea en zonas de dif�cil acceso.La tormenta dej� estragos en varios estados como Florida, Georgia, Carolina del Norte, Carolina del Sur y Tennessee, con sus fuertes vientos y torrenciales lluvias que dejaron algunos poblados como si hubiesen sido borrados del mapa.Contin�an las b�squedas y esfuerzos de rescate de los oficiales locales, estatales y federales\", inform� Lori Moore-Merrell de la Agencia Federal de Gesti�n de Emergencias.Hay un importante cierre de v�as debido al agua estancada y los riesgos impiden los esfuerzos de respuesta, incluyendo reanudar la energ�a, la limpieza de escombros, las b�squedas y rescate y la evaluaci�n del da�o, a�adi�.Al menos 24 personas murieron en Carolina del Sur, 17 en Georgia, 11 en Florida, 11 en Carolina del Norte y una en Virginia, seg�n las autoridades locales y un recuento de la AFP con base a informaciones de los medios.Al menos 2.7 millones de clientes contin�an sin electricidad el domingo.El domingo continuaban activas tres alertas de inundaciones repentinas en el oeste de Carolina del Norte ante el riesgo de ruptura de represas, inform� el director del Servicio Meteorol�gico Nacional, Ken Graham.El funcionario agreg� que se espera que el tiempo mejore en las �reas afectadas entorno al martes.Miles de personas continuaban buscando socorro en los albergues de la Cruz Roja estadounidense, dijo la responsable Jennifer Pipa.Extremadamente peligrosoHelene toc� tierra el jueves por la tarde cerca de Tallahassee, capital del estado de Florida, como hurac�n de categor�a 4 en una escala de 5, con vientos de 225 km/h y se degrad� a cicl�n postropical, causando intensas inundaciones.Algunas de las zonas m�s afectadas est�n en Carolina del Norte, donde los rescatistas se han visto obligados a enviar suministros por v�a a�rea en algunas �reas debido a la envergadura de los da�os o de la inundaci�n de los caminos, indic� el domingo el gobernador Roy Cooper.Como es tan dif�cil ingresar con camiones por tierra, ayer comenzamos a transportar por aire los suministros a la regi�n, incluidos alimentos y agua, detall�.El director del departamento de gesti�n de emergencias del estado, William Ray, advirti� que las condiciones eran extremadamente peligrosas.La tormenta caus� el cierre de cientos de caminos y el colapso de puentes por las inundaciones. Al menos cuatro autopistas interestatales permanec�an cerradas en Carolina del Norte y Tennessee, indic� el Departamento de Transporte.En la ciudad de Valdosta, en Georgia, la tormenta arranc� los techos de los edificios y las intersecciones de v�as quedaron completamente bloqueadas con �rboles y postes ca�dos.El viento comenz� a golpear muy fuerte, arranc� ramas y pedazos de techo golpeaban los lados del edificio y las ventanas, relat� Steven Mauro, residente de Valdosta.El domingo, el Departamento de Energ�a indic� que sus equipos trabajaban para restablecer la electricidad a todos los clientes, pero que era una respuesta compleja y de varios d�as.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia3Descripcion.Text = "Helene toc� tierra el jueves por la tarde cerca de Tallahassee, capital del estado de Florida, como hurac�n de categor�a 4 en una escala de 5, con vientos de 225 km/h y se degrad� a cicl�n postropical, causando intensas inundaciones.";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";

        }


    }

   
    private void Button_Clicked_12(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia4Descricion.Text.StartsWith("El s�bado, lo hut�es afirmaron que el asesinato por parte de Israel del jefe de Hezbol�, Has�n Nasral�, reforzar� su determinaci�n para atacar Israel."))
        {
            // Mostrar la versi�n completa de la noticia
            noticia4Descricion.Text = "El ej�rcito israel� indic� por su parte que durante una operaci�n a�rea de gran magnitud, decenas de aviones de la fuerza a�rea (...) atacaron objetivos de uso militar del r�gimen terrorista de los hut�es en las regiones de Ras Issa y Hodeida.Las centrales el�ctricas y un puerto mar�timo atacados eran utilizados por los hut�es para trasladar armas iran�es en la regi�n y suministros para las necesidades militares, agreg� un portavoz del ej�rcito, David Avraham, en un comunicado a la AFP.El bombardeo fue realizado en respuesta a los recientes ataques del r�gimen hut� contra el Estado de Israel, seg�n �l.El s�bado, lo hut�es afirmaron que el asesinato por parte de Israel del jefe de Hezbol�, Has�n Nasral�, reforzar� su determinaci�n para atacar Israel.Los rebeldes lanzaron varios ataques contra Israel desde el inicio de la ofensiva israel� contra la Franja de Gaza desencadenada por el ataque sin precedentes de Ham�s contra Israel el 7 de octubre de 2023.En julio pasado, realizaron un ataque de dron contra Tel Aviv que mat� a un civil.En represalia, Israel lanz� entonces ataques contra una central el�ctrica y dep�sitos de combustible en el puerto de Hodeida.Los hut�es, que controlan amplias zonas de Yemen, pertenecen a lo que Ir�n -enemigo jurado de Israel- llama el eje de la resistencia, que agrupa especialmente a Ham�s y a Hezbol�.Atacan tambi�n regularmente a barcos que consideran relacionados con Israel, Estados Unidos o Reino Unido en el mar Rojo y en el golfo de Ad�n.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia4Descricion.Text = "El s�bado, lo hut�es afirmaron que el asesinato por parte de Israel del jefe de Hezbol�, Has�n Nasral�, reforzar� su determinaci�n para atacar Israel.";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";

        }


    }
}

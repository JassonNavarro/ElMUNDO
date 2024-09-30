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

            if (noticia1Descripcion.Text.StartsWith("El Ministerio de Salud libanés contabiliza un total de muertos en 105 y el de heridos en 359."))
            {
                // Mostrar la versión completa de la noticia
                noticia1Descripcion.Text = "El ejército israelí lanzó este domingo una andanada de bombardeos contra Hezbolá en Líbano que dejaron más de 100 muertos, dos días después de haber asesinado al líder del movimiento islamista libanés, Hasán Nasralá, junto con decenas de otros miembros del grupo en otro ataque.En otro frente, Israel dijo que golpeó objetivos de los rebeldes hutíes en el oeste de Yemen, después de que estos insurgentes proiraníes reivindicaran el lanzamiento de un misil contra el aeropuerto de Tel Aviv.Estos bombardeos provocaron cuatro muertos, según medios de los rebeldes yemenitas.Ningún lugar está demasiado lejos para Israel, advirtió el ministro israelí de Defensa, Yoav Gallant, tras los bombardeos.Manteniendo la presión militar contra Hezbolá, una formación chiita proiraní, el ejército israelí indicó que golpeó 120 objetivos en Líbano.Corresponsales de la AFP escucharon una fuerte explosión y vieron columnas de humo brotando de los suburbios del sur de Beirut, bastión de Hezbolá, donde el viernes falleció Nasralá en un bombardeo israelí que arrasó edificios enteros.El cuerpo del líder del movimiento libanés fue encontrado el sábado y fue envuelto en un sudario, indicó una fuente cercana a la organización, precisando que todavía no se fijó la fecha del funeral.En un balance revisado publicado a última hora del domingo, el Ministerio de Salud libanés cifró el total de muertos en 105 y el de heridos en 359.";

                // Cambiar el texto del botón a "Leer menos"
                button.Text = "Leer menos";
            }
            else
            {
                // Mostrar la versión corta de la noticia
                noticia1Descripcion.Text = "El Ministerio de Salud libanés contabiliza un total de muertos en 105 y el de heridos en 359.\r\n";

                // Cambiar el texto del botón a "Leer más"
                button.Text = "Leer más";

            }

        }

  
    private void Button_Clicked_10(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia2Descripcion.Text.StartsWith("Las víctimas y los daños reportados por los estados deben ser avalados por el gobierno federal para estimar los recursos de emergencia a destinar a las zonas afectadas."))
        {
            // Mostrar la versión completa de la noticia
            noticia2Descripcion.Text = "Medios mexicanos reportaron este domingo la muerte de al menos 20 personas, superior al balance oficial de ocho, por el paso del huracán John en el sur de México, zona que visitará el próximo miércoles Claudia Sheinbaum ya como presidenta del país.John deja 15 muertos sólo en Guerrero, anuncia en su portada del domingo el periódico La Jornada, mientras que la cadena Milenio daba un balance de 18 fallecidos en ese mismo distrito.Hasta el sábado, el presidente Andrés Manuel López Obrador, que el martes entrega el gobierno a Sheinbaum, había reportado ocho fallecidos por las lluvias que provocó el fenómeno en Guerrero.Sólo lamentamos la pérdida de ocho personas debido a derrumbes por las intensas lluvias, escribió el mandatario saliente en su cuenta de X.La prensa local, sin citar fuentes directas, señala que también hubo víctimas mortales en Michoacán (oeste) y Oaxaca (sur), estados vecinos de Guerrero.Manuel Maza, director de protección civil de Oaxaca, confirmó a la AFP la muerte de una persona, aunque no ha sido incorporada al balance de las autoridades federales.La AFP ha contactado a Protección Civil y la fiscalía de Guerrero sin obtener respuesta.Las víctimas y los daños reportados por los estados deben ser avalados por el gobierno federal para estimar los recursos de emergencia a destinar a las zonas afectadas.Sheinbaum anunció de su lado que su primera gira de trabajo será el miércoles a las comunidades afectadas por John, que impactó en dos ocasiones las costas de México.Acordé (...) estar el miércoles por la tarde con el gabinete para hacer una evaluación y los planes para continuar con toda la ayuda necesaria a Guerrero, escribió la mandataria electa en su cuenta de X.John tocó tierra en Guerrero el pasado martes como un poderoso huracán de categoría 3 en la escala de 5 Saffir-Simpson y sus efectos alcanzaron a Oaxaca.El fenómeno se debilitó en tierra, pero sus remanentes volvieron al Pacífico y recuperaron fuerza de huracán el jueves, antes de reingresar por el estado de Michoacán (oeste).El balneario de Acapulco ha sido el más dañado. Sus casi 800.000 habitantes revivieron la pesadilla de Otis, un poderoso huracán 5 que en octubre de 2023 destruyó el puerto de la ciudad, dejando decenas de muertos y desaparecidos.";

            // Cambiar el texto del botón a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versión corta de la noticia
            noticia2Descripcion.Text = "Las víctimas y los daños reportados por los estados deben ser avalados por el gobierno federal para estimar los recursos de emergencia a destinar a las zonas afectadas.";

            // Cambiar el texto del botón a "Leer más"
            button.Text = "Leer más";

        }


    }

   

    private void Button_Clicked_11(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia3Descripcion.Text.StartsWith("Helene tocó tierra el jueves por la tarde cerca de Tallahassee, capital del estado de Florida, como huracán de categoría 4 en una escala de 5, con vientos de 225 km/h y se degradó a ciclón postropical, causando intensas inundaciones."))
        {
            // Mostrar la versión completa de la noticia
            noticia3Descripcion.Text = "Grupos de rescatistas batallaban el domingo para socorrer a miles de personas afectadas por el paso de la devastadora tormenta Helene por el sureste de Estados Unidos, donde los caminos quedaron inundados, hay apagones e incluso se entrega comida vía aérea en zonas de difícil acceso.La tormenta dejó estragos en varios estados como Florida, Georgia, Carolina del Norte, Carolina del Sur y Tennessee, con sus fuertes vientos y torrenciales lluvias que dejaron algunos poblados como si hubiesen sido borrados del mapa.Continúan las búsquedas y esfuerzos de rescate de los oficiales locales, estatales y federales\", informó Lori Moore-Merrell de la Agencia Federal de Gestión de Emergencias.Hay un importante cierre de vías debido al agua estancada y los riesgos impiden los esfuerzos de respuesta, incluyendo reanudar la energía, la limpieza de escombros, las búsquedas y rescate y la evaluación del daño, añadió.Al menos 24 personas murieron en Carolina del Sur, 17 en Georgia, 11 en Florida, 11 en Carolina del Norte y una en Virginia, según las autoridades locales y un recuento de la AFP con base a informaciones de los medios.Al menos 2.7 millones de clientes continúan sin electricidad el domingo.El domingo continuaban activas tres alertas de inundaciones repentinas en el oeste de Carolina del Norte ante el riesgo de ruptura de represas, informó el director del Servicio Meteorológico Nacional, Ken Graham.El funcionario agregó que se espera que el tiempo mejore en las áreas afectadas entorno al martes.Miles de personas continuaban buscando socorro en los albergues de la Cruz Roja estadounidense, dijo la responsable Jennifer Pipa.Extremadamente peligrosoHelene tocó tierra el jueves por la tarde cerca de Tallahassee, capital del estado de Florida, como huracán de categoría 4 en una escala de 5, con vientos de 225 km/h y se degradó a ciclón postropical, causando intensas inundaciones.Algunas de las zonas más afectadas están en Carolina del Norte, donde los rescatistas se han visto obligados a enviar suministros por vía aérea en algunas áreas debido a la envergadura de los daños o de la inundación de los caminos, indicó el domingo el gobernador Roy Cooper.Como es tan difícil ingresar con camiones por tierra, ayer comenzamos a transportar por aire los suministros a la región, incluidos alimentos y agua, detalló.El director del departamento de gestión de emergencias del estado, William Ray, advirtió que las condiciones eran extremadamente peligrosas.La tormenta causó el cierre de cientos de caminos y el colapso de puentes por las inundaciones. Al menos cuatro autopistas interestatales permanecían cerradas en Carolina del Norte y Tennessee, indicó el Departamento de Transporte.En la ciudad de Valdosta, en Georgia, la tormenta arrancó los techos de los edificios y las intersecciones de vías quedaron completamente bloqueadas con árboles y postes caídos.El viento comenzó a golpear muy fuerte, arrancó ramas y pedazos de techo golpeaban los lados del edificio y las ventanas, relató Steven Mauro, residente de Valdosta.El domingo, el Departamento de Energía indicó que sus equipos trabajaban para restablecer la electricidad a todos los clientes, pero que era una respuesta compleja y de varios días.";

            // Cambiar el texto del botón a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versión corta de la noticia
            noticia3Descripcion.Text = "Helene tocó tierra el jueves por la tarde cerca de Tallahassee, capital del estado de Florida, como huracán de categoría 4 en una escala de 5, con vientos de 225 km/h y se degradó a ciclón postropical, causando intensas inundaciones.";

            // Cambiar el texto del botón a "Leer más"
            button.Text = "Leer más";

        }


    }

   
    private void Button_Clicked_12(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia4Descricion.Text.StartsWith("El sábado, lo hutíes afirmaron que el asesinato por parte de Israel del jefe de Hezbolá, Hasán Nasralá, reforzará su determinación para atacar Israel."))
        {
            // Mostrar la versión completa de la noticia
            noticia4Descricion.Text = "El ejército israelí indicó por su parte que durante una operación aérea de gran magnitud, decenas de aviones de la fuerza aérea (...) atacaron objetivos de uso militar del régimen terrorista de los hutíes en las regiones de Ras Issa y Hodeida.Las centrales eléctricas y un puerto marítimo atacados eran utilizados por los hutíes para trasladar armas iraníes en la región y suministros para las necesidades militares, agregó un portavoz del ejército, David Avraham, en un comunicado a la AFP.El bombardeo fue realizado en respuesta a los recientes ataques del régimen hutí contra el Estado de Israel, según él.El sábado, lo hutíes afirmaron que el asesinato por parte de Israel del jefe de Hezbolá, Hasán Nasralá, reforzará su determinación para atacar Israel.Los rebeldes lanzaron varios ataques contra Israel desde el inicio de la ofensiva israelí contra la Franja de Gaza desencadenada por el ataque sin precedentes de Hamás contra Israel el 7 de octubre de 2023.En julio pasado, realizaron un ataque de dron contra Tel Aviv que mató a un civil.En represalia, Israel lanzó entonces ataques contra una central eléctrica y depósitos de combustible en el puerto de Hodeida.Los hutíes, que controlan amplias zonas de Yemen, pertenecen a lo que Irán -enemigo jurado de Israel- llama el eje de la resistencia, que agrupa especialmente a Hamás y a Hezbolá.Atacan también regularmente a barcos que consideran relacionados con Israel, Estados Unidos o Reino Unido en el mar Rojo y en el golfo de Adén.";

            // Cambiar el texto del botón a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versión corta de la noticia
            noticia4Descricion.Text = "El sábado, lo hutíes afirmaron que el asesinato por parte de Israel del jefe de Hezbolá, Hasán Nasralá, reforzará su determinación para atacar Israel.";

            // Cambiar el texto del botón a "Leer más"
            button.Text = "Leer más";

        }


    }
}

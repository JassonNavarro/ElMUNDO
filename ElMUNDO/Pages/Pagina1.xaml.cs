namespace ElMUNDO.Pages;

public partial class Pagina1 : ContentPage
{
	public Pagina1()
	{
		InitializeComponent();
	}

    private void Button_Clicked_1(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia1Descripcion.Text.StartsWith("Inicia construcci�n del Parque de la Familia en las faldas del volc�n de San Miguel"))
        {
            // Mostrar la versi�n completa de la noticia
            noticia1Descripcion.Text = "El Ministerio de Obras P�blicas (Mopt) inici� este lunes la construcci�n del Parque de la Familia que estar� ubicado en las faldas del volc�n Chaparrastique, en el cant�n Las Placitas, en el distrito de San Miguel. �Este es el Parque de la Familia por el volc�n Chaparrastique, en el sector de Las Placitas. Este es un espacio p�blico que estaba totalmente abandonado�, destac� el ministro de Obras P�blicas, Romeo Rodr�guez.Rodr�guez detall� que ser�n 9,580 metros cuadrados los intervenidos para la construcci�n de dicha zona recreativa y enfatiz� que �es una de las intervenciones m�s grandes en espacio p�blico que hemos desarrollado en nuestro pa�s por parte del Mopt�.El titular de Obras P�blicas puntualiz� que parte de las intervenciones contemplan la siembra de 50 �rboles adicionales, instalaci�n de luminarias, canchas de usos m�ltiples, zonas de descanso, bah�as de parqueos, miradores, �rea de juegos para ni�os y torres �para que las familias realicen actividades con la seguridad adecuada�.Seg�n el ministro, la obra se realizar� en un plazo m�ximo de cinco meses y enfatiz� que prev� finalizar los trabajos antes del periodo estipulado.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia1Descripcion.Text = "Inicia construcci�n del Parque de la Familia en las faldas del volc�n de San Miguel";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";
        }
    }

   
    private void Button_Clicked_2(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticiaDescripcion2.Text.StartsWith("Al menos 71 sismos han sacudido a El Salvador desde el viernes"))
        {
            // Mostrar la versi�n completa de la noticia
            noticiaDescripcion2.Text = "El Ministerio de Medio Ambiente y Recursos Naturales (Marn) anunci� la ma�ana de este martes que El Salvador ha sido sacudido por 71 sismos desde el viernes en la tarde, cuando inici� una actividad s�smica frente a las costas de Sonsonate. Los temblores iniciaron precisamente con una sacudida de 5.2 en la escala de Richter, a las 3:21 de la tarde que fue percibida en el �rea metropolitana de San Salvador. Los m�s de 71 sismos sentidos fueron contabilizados hasta las 6:00 de la ma�ana de este martes. Medio Ambiente ha dicho en informes especiales que la actividad s�smica frente a Sonsonate es originada por el proceso de subducci�n entre la placa de Cocos y del Caribe.De los 71 sismos, un total de 24 temblores han sido sentidos por la poblaci�n y sus magnitudes han oscilado entre los 3.5 y 5.7, esta �ltima magnitud sentida en un sismo ocurrido la noche del s�bado a las 10:58, causando alg�n susto entre alg�n salvadore�o.Esa noche, la tierra se movi� al menos en cuatro ocasiones, dos de ellas percibidas por los salvadore�os.El Marn ha descartado que esta actividad cause alg�n tsunami.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticiaDescripcion2.Text = "Al menos 71 sismos han sacudido a El Salvador desde el viernes";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";
        }

    }

   
    private void Button_Clicked_3(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia3Descripcion.Text.StartsWith("Motociclista muere en accidente de tr�nsito en carretera a Los Naranjos, Sonsonate"))
        {
            // Mostrar la versi�n completa de la noticia
            noticia3Descripcion.Text = "La Polic�a Nacional Civil (PNC) report� la noche de este lunes la muerte de un motociclista en el kil�metro 67 de la carretera que conduce a Los Naranjos, en Sonsonate. Seg�n informaci�n preliminar, publicada a trav�s de la cuenta de X de la PNC, en dicho siniestro tambi�n est� involucrado un microb�s, sin embargo, no especificaron los detalles ni la identidad del motociclista fallecido.Este tr�gico accidente se suma al que sucedi� la ma�ana de este lunes en Santa Tecla, que dej� un fallecido y diez lesionados en el que se vieron involucrados un microb�s particular y un microb�s de la ruta 101-B.La racha de accidentes continu� tras el reportado en el kil�metro 17 y medio de la carretera de oro, a la altura del distrito de Ciudad Delgado, en el que dos camiones chocaron y dejaron dos lesionados. Adem�s se report� otro accidente en la carretera a Sonsonate a la altura de Lourdes.Seg�n datos del Observatorio Nacional de Seguridad Vial, desde el primero de enero hasta el 15 de septiembre, se reportan 13,905 accidentes de tr�nsito, 8,122 lesionados y 903 fallecidos.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia3Descripcion.Text = "Motociclista muere en accidente de tr�nsito en carretera a Los Naranjos, Sonsonate";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";
        }


    }

  

    private void Button_Clicked_4(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia4Descripcion.Text.StartsWith("Ernesto Castro sobre audios con Alejandro Muyshondt: La verdad que me da risa"))
        {
            // Mostrar la versi�n completa de la noticia
            noticia4Descripcion.Text = "El presidente de la Asamblea Legislativa, Ernesto Castro, calific� este martes de �cuento que se est�n inventando�los audios de conversaciones que supuestamente sostuvo con Alejandro Muyshondt, el ahora fallecido exasesor de seguridad nacional de la Presidencia de la Rep�blica. En los audios publicados por Infobae y Prensa Comunitaria de Guatemala, Ernesto Castro supuestamente est� pidiendo a Alejandro Muyshondt que montara un sistema de espionaje para periodistas y opositores, y le pide intervenir a los periodistas Jorge Betr�n Luna y Carlos Dada. Seg�n las publicaciones,esta petici�n fue realizada en 2020 cuando fung�a como secretario privado de la Presidencia.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia4Descripcion.Text = "Ernesto Castro sobre audios con Alejandro Muyshondt: La verdad que me da risa";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";
        }


    }
}

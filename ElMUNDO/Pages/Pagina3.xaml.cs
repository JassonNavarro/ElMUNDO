namespace ElMUNDO.Pages;

public partial class Pagina3 : ContentPage
{
    public Pagina3()
    {
        InitializeComponent();
    }



    



    private void Button_Clicked_5(object sender, EventArgs e)
    {


        var button = sender as Button;

        if (noticia1Descripcion.Text.StartsWith("Ministro de Trabajo se reunir� con empleados municipales ante irregularidades en comunas"))
        {
            // Mostrar la versi�n completa de la noticia
            noticia1Descripcion.Text = "El ministro de Trabajo Rolando Castro anunci� que este mi�rcoles 2 de octubre se reunir� con trabajadores municipales, luego de las denuncias recibidas de presuntas irregularidades que las comunas pretenden realizar al cesarlos de ley de salarios y pasarlos a contratos.�Hay algunas administraciones municipales queriendo pasar a empleados que est�n por ley de carrera al sistema de contratos. Eso s totalmente ilegal�, asever� Castro a trav�s de su perfil de red social X.El pasado viernes, el ministro Castro ya hab�a advertido a las alcald�as a no obligar a los trabajadores a renunciar a la Ley de la Carrera Administrativa Municipal para pasarlos a sistemas de contratos.�Tenemos muchas denuncias de Alcald�as que quieren obligar a sus trabajadores que renuncien a la ley de la carrera administrativa municipal y pasarlos al sistema de contratos�, public� Castro en su cuenta de X.Diario El Mundo pregunt� al Ministerio de Trabajo cu�les son las alcald�as denunciadas por estas irregularidades se�aladas, sin embargo, respondieron que esa informaci�n ser� revelada por Castro el d�a 2 de octubre, cuando ofrecer� una conferencia.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia1Descripcion.Text = "Ministro de Trabajo se reunir� con empleados municipales ante irregularidades en comunas";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";

        }
    }

    
    private void Button_Clicked_6(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia2Descripcion.Text.StartsWith("Marcela Villatoro acusa a Nuevas Ideas de disfrazar deuda para futuras generaciones"))
        {
            // Mostrar la versi�n completa de la noticia
            noticia2Descripcion.Text = "Es incre�ble el nivel de mentira y cinismo que tienen todas las plenarias, la semana antepasada propuse que se prohibiera endeudar al pa�s por dispensa de tr�mite y obviamente no me apoyaron, la plenaria siguiente ocuparon el mismo mecanismo pero disfraz�ndolo de un contrato de garant�a que no 'era deuda'; y resulta que hoy es la misma historia pero que no era deuda sino 'pr�stamo, critic�.La legisladora opin� que la dispensa de tr�mites es utilizada \"para que la gente no sepa los miles de millones de d�lares que se embolsan cada plenaria sin discusi�n y solo puyando el bot�n porque ni ellos mismos conocen lo que aprueban.Los diputados autorizaron el lunes al ministro de Hacienda a negociar el contrato de garant�a y pr�stamo contingente con el CAF y el jueves aprobaron el contrato ya negociado. El pr�stamo busca ser garant�a de la emisi�n de t�tulos valores autorizados en mayo pasado por hasta $1,500 millones. En su solicitud, el ministro explic� que la operaci�n busca \"garantizar las obligaciones que adquiera la Rep�blica de El Salvador en el marco de la emisi�n de t�tulos valores autorizada mediante decreto legislativo n�mero 20, relacionada a esta cantidad de deuda por emitir.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia2Descripcion.Text = "Marcela Villatoro acusa a Nuevas Ideas de disfrazar deuda para futuras generaciones";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";

        }

    }

   

    private void Button_Clicked_7(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia3Descripcion.Text.StartsWith("El Ejecutivo puede realizar operaciones para mejorar el perfil de la deuda"))
        {
            // Mostrar la versi�n completa de la noticia
            noticia3Descripcion.Text = "El diputado explic� que estaban discutiendo la aprobaci�n de dicha operaci�n iniciada mediante el decreto legislativo 20 de fecha 22 de mayo de 2024\", un decreto mediante el cual los diputados autorizaron al ministro de Hacienda a la emisi�n de hasta $1,500 millones de d�lares para cumplimiento de obligaciones o manejo de pasivos (deuda).Discutimos la aprobaci�n de la incorporaci�n de dichos fondos al presupuesto general de la naci�n y autorizamos al Ministerio de Hacienda destinarlos para las obligaciones estipuladas dentro de este decreto, dijo, aunque no detall� cu�l ser�a el destino final de dichos fondos.Por su parte, el diputado Mauricio Ortiz, tambi�n de Nuevas Ideas, defendi� el contrato de garant�a y pr�stamo contingente por hasta $200 millones con la Corporaci�n Andina de Fomento (CAF) aprobado el jueves por la Asamblea Legislativa.�Simple y sencillamente lo que estamos evaluando es la segunda vuelta de la autorizaci�n para suscribir un contrato de garant�a con el CAF por hasta $200 millones el cual no constituye una nueva deuda�, defendi�.Sin dar mayores detalles, el diputado Ortiz indic� que este tipo de contratos de garant�as es una herramienta legal que se utiliza en este tipo de negociaciones. Dicho sea de paso, el CAF se ha convertido en un aliado importante para el pa�s en t�rminos de desarrollo econ�mico sostenible, agreg� en su intervenci�n.La diputada Claudia Ortiz critic� la falta de transparencia en las aprobaciones de la reforma presupuestaria, el contrato de garant�a y de la facultad entregada a Hacienda para firmar un Acuerdo de Fondeo, todo vinculado seg�n los decretos a la emisi�n millonaria de t�tulos valores. Ortiz cree que no hay transparencia en el manejo de deuda p�blica. La diputada Marcela Villatoro cree que el gobierno est� disfrazando la deuda.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia3Descripcion.Text = "El Ejecutivo puede realizar operaciones para mejorar el perfil de la deuda";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";

        }



    }

    

    private void Button_Clicked_8(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia4Descricion.Text.StartsWith("Claudia Ortiz: �Hay una absoluta falta de transparencia sobre el manejo de la deuda p�blica�"))
        {
            // Mostrar la versi�n completa de la noticia
            noticia4Descricion.Text = "La diputada tambi�n reclam� transparencia en la aprobaci�n del contrato de garant�a y pr�stamo contingente de liquidez por hasta $200 millones con la Corporaci�n Andina de Fomento (CAF), que fue votado despu�s de la incorporaci�n de los $1,200 millones de bonos en el presupuesto 2024 para cumplir con obligaciones del Estado.Se aprueba sin que haya sido p�blico el documento. Entr� y en cinco minutos fue aprobado sin que ning�n diputado pudiese saber qu� dec�a. Me parece que en este caso, que es un contrato de pr�stamo, es grave, protest�.La diputada, que vot� en contra de las aprobaciones, tambi�n critic� la falta de informaci�n de un tercer decreto mediante el cual el Congreso autoriz� a la Hacienda p�blica a que suscriba un Acuerdo de Fondeo para proyectos sociales con entidades p�blicas y privadas por hasta 20 a�os. El decreto de Acuerdo de Fondeo est� relacionado al decreto legislativo n�mero 20 mediante el cual la Asamblea Legislativa autoriz� el 22 de mayo de 2024 a que Hacienda emitiera hasta $1,500 millones en t�tulos valores.Adem�s, tambi�n se dio una autorizaci�n para ir a negociar un Acuerdo de Fondeo. �Qu� es eso? Vaya usted a saber. �No hemos tenido a la vista el contrato ni el proyecto de decreto ni la correspondencia con que ven�a esta solicitud de autorizaci�n, que viene en t�rminos muy vagos, muy ambiguos! Mantenemos esa costumbre, esa mala pr�ctica legislativa, de aprobar temas relacionados con el dinero p�blico escondi�ndose de la gente, reclam� la diputada de oposici�n.";

            // Cambiar el texto del bot�n a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versi�n corta de la noticia
            noticia4Descricion.Text = "Claudia Ortiz: �Hay una absoluta falta de transparencia sobre el manejo de la deuda p�blica�";

            // Cambiar el texto del bot�n a "Leer m�s"
            button.Text = "Leer m�s";

        }

    }
}
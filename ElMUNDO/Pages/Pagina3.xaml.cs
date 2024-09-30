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

        if (noticia1Descripcion.Text.StartsWith("Ministro de Trabajo se reunirá con empleados municipales ante irregularidades en comunas"))
        {
            // Mostrar la versión completa de la noticia
            noticia1Descripcion.Text = "El ministro de Trabajo Rolando Castro anunció que este miércoles 2 de octubre se reunirá con trabajadores municipales, luego de las denuncias recibidas de presuntas irregularidades que las comunas pretenden realizar al cesarlos de ley de salarios y pasarlos a contratos.“Hay algunas administraciones municipales queriendo pasar a empleados que están por ley de carrera al sistema de contratos. Eso s totalmente ilegal”, aseveró Castro a través de su perfil de red social X.El pasado viernes, el ministro Castro ya había advertido a las alcaldías a no obligar a los trabajadores a renunciar a la Ley de la Carrera Administrativa Municipal para pasarlos a sistemas de contratos.“Tenemos muchas denuncias de Alcaldías que quieren obligar a sus trabajadores que renuncien a la ley de la carrera administrativa municipal y pasarlos al sistema de contratos”, publicó Castro en su cuenta de X.Diario El Mundo preguntó al Ministerio de Trabajo cuáles son las alcaldías denunciadas por estas irregularidades señaladas, sin embargo, respondieron que esa información será revelada por Castro el día 2 de octubre, cuando ofrecerá una conferencia.";

            // Cambiar el texto del botón a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versión corta de la noticia
            noticia1Descripcion.Text = "Ministro de Trabajo se reunirá con empleados municipales ante irregularidades en comunas";

            // Cambiar el texto del botón a "Leer más"
            button.Text = "Leer más";

        }
    }

    
    private void Button_Clicked_6(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia2Descripcion.Text.StartsWith("Marcela Villatoro acusa a Nuevas Ideas de disfrazar deuda para futuras generaciones"))
        {
            // Mostrar la versión completa de la noticia
            noticia2Descripcion.Text = "Es increíble el nivel de mentira y cinismo que tienen todas las plenarias, la semana antepasada propuse que se prohibiera endeudar al país por dispensa de trámite y obviamente no me apoyaron, la plenaria siguiente ocuparon el mismo mecanismo pero disfrazándolo de un contrato de garantía que no 'era deuda'; y resulta que hoy es la misma historia pero que no era deuda sino 'préstamo, criticó.La legisladora opinó que la dispensa de trámites es utilizada \"para que la gente no sepa los miles de millones de dólares que se embolsan cada plenaria sin discusión y solo puyando el botón porque ni ellos mismos conocen lo que aprueban.Los diputados autorizaron el lunes al ministro de Hacienda a negociar el contrato de garantía y préstamo contingente con el CAF y el jueves aprobaron el contrato ya negociado. El préstamo busca ser garantía de la emisión de títulos valores autorizados en mayo pasado por hasta $1,500 millones. En su solicitud, el ministro explicó que la operación busca \"garantizar las obligaciones que adquiera la República de El Salvador en el marco de la emisión de títulos valores autorizada mediante decreto legislativo número 20, relacionada a esta cantidad de deuda por emitir.";

            // Cambiar el texto del botón a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versión corta de la noticia
            noticia2Descripcion.Text = "Marcela Villatoro acusa a Nuevas Ideas de disfrazar deuda para futuras generaciones";

            // Cambiar el texto del botón a "Leer más"
            button.Text = "Leer más";

        }

    }

   

    private void Button_Clicked_7(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia3Descripcion.Text.StartsWith("El Ejecutivo puede realizar operaciones para mejorar el perfil de la deuda"))
        {
            // Mostrar la versión completa de la noticia
            noticia3Descripcion.Text = "El diputado explicó que estaban discutiendo la aprobación de dicha operación iniciada mediante el decreto legislativo 20 de fecha 22 de mayo de 2024\", un decreto mediante el cual los diputados autorizaron al ministro de Hacienda a la emisión de hasta $1,500 millones de dólares para cumplimiento de obligaciones o manejo de pasivos (deuda).Discutimos la aprobación de la incorporación de dichos fondos al presupuesto general de la nación y autorizamos al Ministerio de Hacienda destinarlos para las obligaciones estipuladas dentro de este decreto, dijo, aunque no detalló cuál sería el destino final de dichos fondos.Por su parte, el diputado Mauricio Ortiz, también de Nuevas Ideas, defendió el contrato de garantía y préstamo contingente por hasta $200 millones con la Corporación Andina de Fomento (CAF) aprobado el jueves por la Asamblea Legislativa.“Simple y sencillamente lo que estamos evaluando es la segunda vuelta de la autorización para suscribir un contrato de garantía con el CAF por hasta $200 millones el cual no constituye una nueva deuda”, defendió.Sin dar mayores detalles, el diputado Ortiz indicó que este tipo de contratos de garantías es una herramienta legal que se utiliza en este tipo de negociaciones. Dicho sea de paso, el CAF se ha convertido en un aliado importante para el país en términos de desarrollo económico sostenible, agregó en su intervención.La diputada Claudia Ortiz criticó la falta de transparencia en las aprobaciones de la reforma presupuestaria, el contrato de garantía y de la facultad entregada a Hacienda para firmar un Acuerdo de Fondeo, todo vinculado según los decretos a la emisión millonaria de títulos valores. Ortiz cree que no hay transparencia en el manejo de deuda pública. La diputada Marcela Villatoro cree que el gobierno está disfrazando la deuda.";

            // Cambiar el texto del botón a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versión corta de la noticia
            noticia3Descripcion.Text = "El Ejecutivo puede realizar operaciones para mejorar el perfil de la deuda";

            // Cambiar el texto del botón a "Leer más"
            button.Text = "Leer más";

        }



    }

    

    private void Button_Clicked_8(object sender, EventArgs e)
    {

        var button = sender as Button;

        if (noticia4Descricion.Text.StartsWith("Claudia Ortiz: “Hay una absoluta falta de transparencia sobre el manejo de la deuda pública”"))
        {
            // Mostrar la versión completa de la noticia
            noticia4Descricion.Text = "La diputada también reclamó transparencia en la aprobación del contrato de garantía y préstamo contingente de liquidez por hasta $200 millones con la Corporación Andina de Fomento (CAF), que fue votado después de la incorporación de los $1,200 millones de bonos en el presupuesto 2024 para cumplir con obligaciones del Estado.Se aprueba sin que haya sido público el documento. Entró y en cinco minutos fue aprobado sin que ningún diputado pudiese saber qué decía. Me parece que en este caso, que es un contrato de préstamo, es grave, protestó.La diputada, que votó en contra de las aprobaciones, también criticó la falta de información de un tercer decreto mediante el cual el Congreso autorizó a la Hacienda pública a que suscriba un Acuerdo de Fondeo para proyectos sociales con entidades públicas y privadas por hasta 20 años. El decreto de Acuerdo de Fondeo está relacionado al decreto legislativo número 20 mediante el cual la Asamblea Legislativa autorizó el 22 de mayo de 2024 a que Hacienda emitiera hasta $1,500 millones en títulos valores.Además, también se dio una autorización para ir a negociar un Acuerdo de Fondeo. ¿Qué es eso? Vaya usted a saber. ¡No hemos tenido a la vista el contrato ni el proyecto de decreto ni la correspondencia con que venía esta solicitud de autorización, que viene en términos muy vagos, muy ambiguos! Mantenemos esa costumbre, esa mala práctica legislativa, de aprobar temas relacionados con el dinero público escondiéndose de la gente, reclamó la diputada de oposición.";

            // Cambiar el texto del botón a "Leer menos"
            button.Text = "Leer menos";
        }
        else
        {
            // Mostrar la versión corta de la noticia
            noticia4Descricion.Text = "Claudia Ortiz: “Hay una absoluta falta de transparencia sobre el manejo de la deuda pública”";

            // Cambiar el texto del botón a "Leer más"
            button.Text = "Leer más";

        }

    }
}
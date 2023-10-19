function masInformacion(id)
{
    $.ajax({
        url: '/Home/traerInfo',
        type : 'GET',
        data: {id},
        dataType: 'json',

        success: function masInformacion() {
            console.log(masInformacion);
            $("#modalTittle").html("Mas informacion de la serie");
            let inf = "";
            masInformacion.forEach(s => {
                
                inf += "<p>" + serie.sinopsis + "</p>" + "<p>" + serie.anoInicio + "</p>";
            });

            $("#texto_informacion").html(inf);
        }
    });
}

function Actores(id)
{
    $.ajax({
        url: '/Home/traerActores',
        type : 'GET',
        data: {id},
        dataType: 'json',

        success: function(Actores) {
            let act = "";
            Actores.forEach(a => {
                
                act += "<p>" + a.nombre + "</p>";
                
            });
            $("#texto_informacion").html(act);
            $("#modalTittle").html("Actores de la serie");
        }
    });
}

function Temporadas(id)
{
    $.ajax({
        url: '/Home/traerTemporadas',
        type : 'GET',
        data: {id},
        dataType: 'json',

        success : function(Temporadas){
            let temp = "";
            Temporadas.forEach(t => {
                temp += "<p>" + t.tituloTemporada + "</p>";
            });
            $("#texto_informacion").html(temp);   
            $("#modalTittle").html("Temporadas de la serie");     
        }
    });
}
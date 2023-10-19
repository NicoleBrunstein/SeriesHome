
function MostrarMasInfo(pid)
{

    $.ajax(
        {
            url: '/Home/GetSerie',
            data: {id : pid},
            type: 'GET',
            dataType: 'JSON',
            
            
            success: function(response)
            {
            
                alert(response.sinopsis);
            }
        }
    )
}

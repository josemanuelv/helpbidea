
function Marcador(x, y, texto) {
    var codmun = texto.split('#')[0];
    var mun = texto.split('#')[1];
    var codentsing = texto.split('#')[2];
    var entsing = texto.split('#')[4];
    var codvia = texto.split('#')[5];
    var via = texto.split('#')[6];
    var codportal = texto.split('#')[7];
    var numpostal = texto.split('#')[8];
    var nomcasa = texto.split('#')[9];
    var codpostal = texto.split('#')[10];
    var raya = '_______________'
    //var map = new SITNA.Map("mapa");
    map.loaded(function () {
        map.addMarker([x, y], {
            data: {
                "Codmunicipio": codmun, "Municipio": mun,
                "CodEntSingular": codentsing, "Entidad Singular": entsing,
                "CodVia": codvia, "Vía": via,
                "Número": numpostal, "CodPortal": codportal,
                "Código Postal": codpostal, "Nombre casa": nomcasa,
                "_____ ": raya,
                "d1": nomcasa,
                "d2": via + ", " + numpostal,
                "d3": codpostal + " - " + entsing,
                "d4": mun
                                    }
                              }
                     );
        map.zoomToMarkers({
            pointBoundsRadius: 300
        });
    });
}
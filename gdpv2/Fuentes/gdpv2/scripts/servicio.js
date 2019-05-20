function ponResultado(idPortal) {
    $.ajax({
        cache: false,
        type: 'POST',
        async: true,
        url: './Servicios/ServicioGDPv2Propio.svc/DatosPortal',
        data: JSON.stringify({ idioma: $("#comboIdioma option:selected").text(), codPortal: idPortal }),
        contentType: 'application/json',
        dataType: 'json',
        success: function (data) {
            var texto = data;
            var x = data.split('#')[11].replace(",",".");
            var y = data.split('#')[12].replace(",", ".");
            $('[id*=TextBoxResultado]').val(texto);
            Marcador(x,y,texto);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            var algo = "";
        },
        
    });
    return;
}

$(function () {
    $('[id*=txtSearchMunicipio]').typeahead({
        hint: true,
        highlight: true,
        minLength: 1,
        source: function (request, response) {
            $.ajax({                
                cache: false,
                type: 'POST',
                async: true,        
                url: './Servicios/ServicioGDPv2Propio.svc/GetMunicipio',
                data: JSON.stringify({ prefix: request, idioma: $("#comboIdioma option:selected").text()}),
                contentType: 'application/json',
                dataType: 'json',
                success: function (data) {
                        items = [];
                        mapx = {};
                        $.each(data, function (i, item) {
                            var id = item.split('#')[0];
                            var name = item.split('#')[1];
                            mapx[name] = { id: id, name: name };
                            items.push(name);
                        });
                        response(items);
                        $(".dropdown-menu").css("height", "auto");
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    var algo = "";
                }
                
            });
        },
        updater: function (item) {
            $('[id*=hfMunicipio]').val(mapx[item].id);
            return item;
        }
    });
});

$(function () {
    $('[id*=txtSearchEntidadSingular]').typeahead({
        hint: true,
        highlight: true,
        minLength: 1,
        source: function (request, response) {
            $.ajax({
                cache: false,
                type: 'POST',
                async: true,
                url: './Servicios/ServicioGDPv2Propio.svc/GetEntidadSingular',
                data: JSON.stringify({ prefix: request, idioma: $("#comboIdioma option:selected").text(), codMuni: $("#hfMunicipio").val() }),
                contentType: 'application/json',
                dataType: 'json',
                success: function (data) {
                    items = [];
                    mapx = {};
                    $.each(data, function (i, item) {
                        var id = item.split('#')[0];
                        var name = item.split('#')[1];
                        mapx[name] = { id: id, name: name };
                        items.push(name);
                    });
                    response(items);
                    $(".dropdown-menu").css("height", "auto");
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    var algo = "";
                }

            });
        },
        updater: function (item) {
            $('[id*=hfEntidadSingular]').val(mapx[item].id);
            return item;
        }
    });
});

$(function () {
    $('[id*=txtSearchVia]').typeahead({
        hint: true,
        highlight: true,
        minLength: 1,
        source: function (request, response) {
            $.ajax({
                cache: false,
                type: 'POST',
                async: true,
                url: './Servicios/ServicioGDPv2Propio.svc/GetVia',
                data: JSON.stringify({ prefix: request, idioma: $("#comboIdioma option:selected").text(), codMuni: $("#hfMunicipio").val(), codEnti: $("#hfEntidadSingular").val() }),
                contentType: 'application/json',
                dataType: 'json',
                success: function (data) {
                    items = [];
                    mapx = {};
                    $.each(data, function (i, item) {
                        var id = item.split('#')[0];
                        var name = item.split('#')[1];
                        mapx[name] = { id: id, name: name };
                        items.push(name);
                    });
                    response(items);
                    $(".dropdown-menu").css("height", "auto");
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    var algo = "";
                }

            });
        },
        updater: function (item) {
            $('[id*=hfVia]').val(mapx[item].id);
            return item;
        }
    });
});

$(function () {
    $('[id*=txtSearchPortal]').typeahead({
        hint: true,
        highlight: true,
        minLength: 1,
        source: function (request, response) {
            $.ajax({
                cache: false,
                type: 'POST',
                async: true,
                url: './Servicios/ServicioGDPv2Propio.svc/GetPortal',
                data: JSON.stringify({ prefix: request, idioma: $("#comboIdioma option:selected").text(), codVia: $("#hfVia").val() }),
                contentType: 'application/json',
                dataType: 'json',
                success: function (data) {
                    items = [];
                    mapx = {};
                    $.each(data, function (i, item) {
                        var id = item.split('#')[0];
                        var name = item.split('#')[1];
                        mapx[name] = { id: id, name: name };
                        items.push(name);
                    });
                    response(items);
                    $(".dropdown-menu").css("height", "auto");
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    var algo = "";
                }

            });
        },
        updater: function (item) {
            $('[id*=hfPortal]').val(mapx[item].id);
            ponResultado(mapx[item].id);
            return item;
        }
    });
});

$(function () {
    $('[id*=txtSearchCasa]').typeahead({
        hint: true,
        highlight: true,
        minLength: 1,
        source: function (request, response) {
            $.ajax({
                cache: false,
                type: 'POST',
                async: true,
                url: './Servicios/ServicioGDPv2Propio.svc/GetCasa',
                data: JSON.stringify({ prefix: request, idioma: $("#comboIdioma option:selected").text(), codEnti: $("#hfEntidadSingular").val(), codVia: $("#hfVia").val() }),
                contentType: 'application/json',
                dataType: 'json',
                success: function (data) {
                    items = [];
                    mapx = {};
                    $.each(data, function (i, item) {
                        var id = item.split('#')[0];
                        var name = item.split('#')[1];
                        mapx[name] = { id: id, name: name };
                        items.push(name);
                    });
                    response(items);
                    $(".dropdown-menu").css("height", "auto");
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    var algo = "";
                }

            });
        },
        updater: function (item) {
            $('[id*=hfPortal]').val(mapx[item].id);
            ponResultado(mapx[item].id);
            return item;
        }
    });
});



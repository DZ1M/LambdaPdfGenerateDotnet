function baixarPdf(element) {
    $.ajax({
        url: 'https://localhost:44331/api/pdf/generate',
        headers: {
            'Cache-Control': 'no-cache',
            'Cache-control': 'no-store',
            'Pragma': 'no-cache',
            'Expires': 0,
            'authorization': 'Bearer teste'
        },
        dataType: 'json',
        type: "GET",
        success: function (data) {
            console.log(data);
            $('#link-download').attr('href', 'data:' + data.tipo + ';base64,' + encodeURI(data.conteudo).toString());
            $('#link-download').attr('download', data.nome);
            $('#link-download')[0].click();
        }
    });
}
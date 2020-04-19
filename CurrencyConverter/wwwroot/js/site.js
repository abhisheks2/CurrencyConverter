$(document).ready(function () {
    var resultBody = $('#result');
    $('#btnSearch').click(function () {
        resultBody.empty();
        var fromDate = new Date($('#searchFromDate').val());
        var toDate = new Date($('#searchToDate').val());
        if (fromDate > toDate) {
            $('#spanErrorMsg').html('From Date can not be later than To Date');
        }
        else {
            $('#spanErrorMsg').html('');
            resultBody.load('/ConversionHistory/AjaxConversionList?searchFromDate=' + $('#searchFromDate').val() +
                '&searchToDate=' + $('#searchToDate').val());
        }
    })
})

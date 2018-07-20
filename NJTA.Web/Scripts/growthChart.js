Highcharts.chart('schoolStudentGrowth', {
    chart: {
        type: 'column'
    },
    credits: {
        enabled: true,
        text: '',
        href: 'javascript:window.open("http://www.highcharts.com/", "_blank")'
    },
    exporting: {
        enabled: false
    },
    title: {
        text: 'Yearly Students enrollment'
    },
    xAxis: {
        categories: [
            '2010',
            '2011',
            '2012',
            '2013',
            '2014',
            '2015',
            '2016',
            '2017'
        ],
        crosshair: true
    },
    yAxis: {
        min: 0,
        title: {
            text: 'Students'
        }
    },
    tooltip: {
        headerFormat: '<span style="font-size:10px">{point.key}</span><table>',
        pointFormat: '<tr><td style="color:{series.color};padding:0">{series.name}: </td>' +
        '<td style="padding:0"><b>{point.y}</b></td></tr>',
        footerFormat: '</table>',
        shared: true,
        useHTML: true
    },
    plotOptions: {
        column: {
            pointPadding: 0.2,
            borderWidth: 0
        }
    },
    series: [
        {
            name: 'Edison',
            color: '#3B5998',
            data: [65, 122, 177, 223, 237, 324, 425, 570]
        },
        {
            name: 'Parsippany',
            color: '#ff00ff',
            data: [0, 0, 0, 0, 0, 0, 30, 66]
        }
    ]
});
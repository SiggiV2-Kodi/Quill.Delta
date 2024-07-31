using System;
using Newtonsoft.Json.Linq;

namespace Quill.Delta
{
    static class Program
    {
        static void Main(string[] args)
        {
            var opsArray = JArray.Parse(@"[
                {insert: 'Heading 1'}, {attributes: {header: 1}, insert: '\n'},
                {insert: 'Heading 2'}, {attributes: {header: 2}, insert: '\n'},
                {insert: 'Heading 3'}, {attributes: {header: 3}, insert: '\n'},
                {insert: 'Normal Text bla bla bla\n'},
                {attributes: {bold: true}, insert: 'bold Text bla bla bla'}, {insert: '\n'},
                {attributes: {italic: true}, insert: 'italic Text bla bla bla'}, {insert: '\n'},
                {attributes: {underline: true}, insert: 'underlined Text bla bla bla'}, {insert: '\n'},
                {attributes: {underline: true, italic: true, bold: true}, insert: 'Combined Text bla bla bla'}, {insert: '\n\n'},
                {insert: '1'}, {attributes: {list: 'ordered'}, insert: '\n'},
                {insert: '2'}, {attributes: {list: 'ordered'}, insert: '\n'},
                {insert: '3'}, {attributes: {list: 'ordered'}, insert: '\n'},
                {insert: '4'}, {attributes: {list: 'ordered'}, insert: '\n'},
                {insert: '5'}, {attributes: {list: 'ordered'}, insert: '\n'},
                {insert: 'The Dot'}, {attributes: {list: 'bullet'}, insert: '\n'},
                {insert: 'The Dot'}, {attributes: {list: 'bullet'}, insert: '\n'},
                {insert: 'The Dot'}, {attributes: {list: 'bullet'}, insert: '\n'},
                {insert: '\nThis is a Table'}, {attributes: {header: 2}, insert: '\n'},
                {insert: 'Symbol'}, {attributes: {table: '1'}, insert: '\n'},
                {insert: 'Timestamp'}, {attributes: {table: '1'}, insert: '\n'},
                {insert: 'Alert'}, {attributes: {table: '1'}, insert: '\n'},
                {insert: 'Latest reviewer'}, {attributes: {table: '1'}, insert: '\n'},
                {insert: 'Private Client ID'}, {attributes: {table: '1'}, insert: '\n'},
                {insert: 'Alert status'}, {attributes: {table: '1'}, insert: '\n'},
                {insert: 'Alert comment'}, {attributes: {table: '1'}, insert: '\n'},
                {insert: 'MAREL'}, {attributes: {table: '2'}, insert: '\n'},
                {insert: '6.3.2024 11:29:55'}, {attributes: {table: '2'}, insert: '\n'},
                {insert: 'Multiple order changes - Private'}, {attributes: {table: '2'}, insert: '\n'},
                {insert: 'leo@kodi.is'}, {attributes: {table: '2'}, insert: '\n'},
                {insert: '1000000001'}, {attributes: {align: 'right', table: '2'}, insert: '\n'},
                {insert: 'Investigating'}, {attributes: {table: '2'}, insert: '\n'},
                {insert: 'test'}, {attributes: {table: '2'}, insert: '\n'},
                {insert: 'MAREL'}, {attributes: {table: '3'}, insert: '\n'},
                {insert: '6.3.2024 13:20:56'}, {attributes: {table: '3'}, insert: '\n'},
                {insert: 'Large order value shares ISK - Private'}, {attributes: {table: '3'}, insert: '\n'},
                {insert: 'leo@kodi.is'}, {attributes: {table: '3'}, insert: '\n'},
                {insert: '1000000001'}, {attributes: {align: 'right', table: '3'}, insert: '\n'},
                {insert: 'Investigating'}, {attributes: {table: '3'}, insert: '\n'},
                {insert: 'test'}, {attributes: {table: '3'}, insert: '\n'},
                {insert: '\nThis is a IMG'}, {attributes: {header: 2}, insert: '\n'},
                {attributes: {alt: 'Breytingarnar taka gildi næstu mánaðamót.', link: 'https://cdni.mbl.is/frimg/1/41/95/1419507.jpg', color: '#2244cc', background: 'transparent', underline: true}, insert: {image: 'https://cdni.mbl.is/m2/dd_hPEB6yL3gRDAJL7LDKryCrcg=/1640x1093/smart/frimg/1/41/95/1419507.jpg'}},
                {insert: '\n'},
                {attributes: {background: '#ffffff', color: '#333333'}, insert: 'Breytingarnar taka gildi næstu mánaðamót. '},
                {attributes: {link: 'https://www.mbl.is/myndasafn/ljosmyndari-483', background: 'transparent', color: '#003399', italic: true}, insert: 'mbl.is/Eggert Jóhannesson'},
                {insert: '\n\n\n'}
            ]");
            // var opsArray = JArray.Parse(@"[
            //     {insert: '\nThis is a Table'}, {attributes: {header: 2}, insert: '\n'},
            //     {insert: 'Symbol'}, {attributes: {table: '1'}, insert: '\n'},
            //     {insert: 'Timestamp'}, {attributes: {table: '1'}, insert: '\n'},
            //     {insert: 'Alert'}, {attributes: {table: '1'}, insert: '\n'},
            //     {insert: 'Latest reviewer'}, {attributes: {table: '1'}, insert: '\n'},
            //     {insert: 'Private Client ID'}, {attributes: {table: '1'}, insert: '\n'},
            //     {insert: 'Alert status'}, {attributes: {table: '1'}, insert: '\n'},
            //     {insert: 'Alert comment'}, {attributes: {table: '1'}, insert: '\n'},
            //     {insert: 'MAREL'}, {attributes: {table: '2'}, insert: '\n'},
            //     {insert: '6.3.2024 11:29:55'}, {attributes: {table: '2'}, insert: '\n'},
            //     {insert: 'Multiple order changes - Private'}, {attributes: {table: '2'}, insert: '\n'},
            //     {insert: 'leo@kodi.is'}, {attributes: {table: '2'}, insert: '\n'},
            //     {insert: '1000000001'}, {attributes: {align: 'right', table: '2'}, insert: '\n'},
            //     {insert: 'Investigating'}, {attributes: {table: '2'}, insert: '\n'},
            //     {insert: 'test'}, {attributes: {table: '2'}, insert: '\n'},
            //     {insert: 'MAREL'}, {attributes: {table: '3'}, insert: '\n'},
            //     {insert: '6.3.2024 13:20:56'}, {attributes: {table: '3'}, insert: '\n'},
            //     {insert: 'Large order value shares ISK - Private'}, {attributes: {table: '3'}, insert: '\n'},
            //     {insert: 'leo@kodi.is'}, {attributes: {table: '3'}, insert: '\n'},
            //     {insert: '1000000001'}, {attributes: {align: 'right', table: '3'}, insert: '\n'},
            //     {insert: 'Investigating'}, {attributes: {table: '3'}, insert: '\n'},
            //     {insert: 'test'}, {attributes: {table: '3'}, insert: '\n'},
            //     {insert: '\nThis is a Table'}, {attributes: {header: 2}, insert: '\n'},
            // ]");

		var converter = new HtmlConverter(opsArray);
		string html2 = converter.Convert();

		Console.WriteLine(html2);
        }
    }
}
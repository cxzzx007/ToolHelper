using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ToolHelper
{
    public class HttpHelper
    {
        /// <summary>
        /// http get
        /// </summary>
        /// <param name="url">request url</param>
        /// <returns>http response</returns>
        public static string Get(string url)
        {
            if (!url.StartsWith("http"))
            {
                url = $"http://{url}";
            }
            var request = WebRequest.Create(url);
            var response = request.GetResponse();
            var html = "";
            using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                html = sr.ReadToEnd();
            }
            return html;
        }
        /// <summary>
        /// http post
        /// </summary>
        /// <param name="url">request url</param>
        /// <param name="data">rqeuest data</param>
        /// <param name="contentType">http contenttype enum</param>
        /// <returns>http response</returns>
        public static string Post(string url, string data, HttpContentType contentType)
        {
            if (!url.StartsWith("http"))
            {
                url = $"http://{url}";
            }
            var request = WebRequest.Create(url);
            request.ContentType = contentType.ConvertToString();
            request.Method = "POST";
            WriteRequestData(request, data);
            var response = (HttpWebResponse)request.GetResponse();
            /*var html = "";
            Encoding enc = Encoding.GetEncoding("UTF-8");
            using (StreamReader sr = new StreamReader(response.GetResponseStream(), enc))
            {
            html = sr.ReadToEnd();
            }
            return Encoding.UTF8.GetBytes(html);*/
            var size = 8192;
            var buffer = new byte[size];
            var stream = response.GetResponseStream();
            var readed = 0;
            var ms = new MemoryStream();
            while ((readed = stream.Read(buffer, 0, size)) > 0)
            {
                ms.Write(buffer, 0, readed);
            }
            stream.Close();
            var byts = ms.ToArray();
            ms.Close();
            return Encoding.UTF8.GetString(byts);
        }
        static void WriteRequestData(WebRequest req, string post_data)
        {
            Stream sr = null;
            try
            {
                sr = req.GetRequestStream();
                byte[] data = Encoding.UTF8.GetBytes(post_data);
                sr.Write(data, 0, data.Length);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
    public enum HttpContentType
    {
        form,//表单提交 key=&value= application/x-www-form-urlencoded
        file,//上传文件 表单数据保存在http正文部分 multipart/form-data
        json,//json格式   application/json
        xml,//xml格式 text/xml
    }
    public static class HttpContentTypeExtension
    {
        public static string ConvertToString(this HttpContentType httpContentType)
        {
            switch (httpContentType)
            {
                case HttpContentType.form:
                    return "application/x-www-form-urlencoded";
                case HttpContentType.file:
                    return "multipart/form-data";
                case HttpContentType.json:
                    return "application/json";
                case HttpContentType.xml:
                    return "text/xml";
                default:
                    return "application/x-www-form-urlencoded";
            }
        }
    }
}

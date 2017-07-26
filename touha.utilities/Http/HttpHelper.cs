using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace touha.utilities
{
    public class HttpHelper
    {
        /// <summary>
        /// HttpClient实现Post请求
        ///  实例参数：
        ///  url:https://tcc.taobao.com/cc/json/mobile_tel_segment.htm
        ///  parameters:new Dictionary<string, string>()
        ///    {
        ///        {"tel", "15850781443"}
        ///     }
        /// <paramref name="parameters"></paramref>
        /// <paramref name="url"></paramref>
        /// </summary>
        static async Task<string> DoPost(string url, Dictionary<string, string> parameters)
        {
            //设置HttpClientHandler的AutomaticDecompression
            var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip };
            //创建HttpClient（注意传入HttpClientHandler）
            using (var http = new HttpClient(handler))
            {
                //使用FormUrlEncodedContent做HttpContent
                var content = new FormUrlEncodedContent(parameters);

                //await异步等待回应

                var response = await http.PostAsync(url, content);
                //确保HTTP成功状态值
                response.EnsureSuccessStatusCode();
                //await异步读取最后的JSON（注意此时gzip已经被自动解压缩了，因为上面的AutomaticDecompression = DecompressionMethods.GZip）
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}

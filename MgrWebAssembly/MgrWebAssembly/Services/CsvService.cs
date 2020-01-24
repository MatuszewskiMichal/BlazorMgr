using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgrWebAssembly.Services
{
    public class CsvService : ICsvService
    {
        private readonly IJSRuntime _jsRuntime;

        public CsvService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }
        public async Task SaveAsAsync(string filename, byte[] data)
        {
            await _jsRuntime.InvokeAsync<object>(
               "saveAsFile",
               filename,
               Convert.ToBase64String(data));
        }
    }
    public interface ICsvService
    {
        Task SaveAsAsync(string filename, byte[] data);
    }
}

using Moneyfy_ProjectWork.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Moneyfy_ProjectWork.Service.Classes
{
    class JsonService : IJsonService
    {
        public T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json) ?? throw new NullReferenceException("Deserialize error");
        }
    }

}

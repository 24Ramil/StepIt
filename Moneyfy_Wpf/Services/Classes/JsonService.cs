﻿using Moneyfly_WPF.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Moneyfly_WPF.Services.Classes
{
    class JsonService : IJsonService
    {
        public T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json) ?? throw new NullReferenceException("Deserialize error");
        }
    }

}

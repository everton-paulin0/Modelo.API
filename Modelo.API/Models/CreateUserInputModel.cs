﻿using Modelo.Core;

namespace Modelo.API.Models
{
    public class CreateUserInputModel
    {
        public string UserName { get; set; }
        public EnumLevel Level { get; set; }
    }
}

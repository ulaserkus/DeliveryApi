﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.Core.Utilities.Results.Abstract
{
    public interface IDataResult<out T>:IResult
    {
        T Data { get; }
    }
}

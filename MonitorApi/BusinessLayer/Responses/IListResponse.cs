﻿using System.Collections.Generic;

namespace Monitor.BusinessLayer.Responses
{
    public interface IListResponse<TModel> : IResponse where TModel : class
    {
        IEnumerable<TModel> Model { get; set; }
    }
}

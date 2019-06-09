﻿using System.Net;
using Microsoft.AspNetCore.Mvc;
using Monitor.BusinessLayer.Responses;

namespace Monitor.Responses
{
    public static class Extensions
    {
        public static IActionResult ToHttpResponse<TModel>(this IListResponse<TModel> response) where TModel : class
        {
            var status = HttpStatusCode.OK;

            if (response.DidError)
                status = HttpStatusCode.InternalServerError;
            else if (response.Model == null)
                status = HttpStatusCode.NoContent;

            return new ObjectResult(response)
            {
                StatusCode = (int)status
            };
        }

        public static IActionResult ToHttpCreatedResponse<TModel>(this ISingleResponse<TModel> response) where TModel : class
        {
            var status = response.DidError ? HttpStatusCode.InternalServerError : HttpStatusCode.Created;

            return new ObjectResult(response)
            {
                StatusCode = (int)status
            };
        }

        public static IActionResult ToHttpResponse<TModel>(this ISingleResponse<TModel> response) where TModel : class
        {
            var status = HttpStatusCode.OK;

            if (response.DidError)
                status = HttpStatusCode.InternalServerError;
            else if (response.Model == null)
                status = HttpStatusCode.NotFound;

            return new ObjectResult(response)
            {
                StatusCode = (int)status
            };
        }
    }
}

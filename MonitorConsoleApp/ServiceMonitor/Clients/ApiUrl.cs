﻿using System.Collections.Generic;

namespace ServiceMonitor.Clients
{
    public class ApiUrl
    {
        public ApiUrl()
        {
        }

        public ApiUrl(string baseUrl = "http://localhost", string apiSufix = "api", string apiVersion = "")
        {
            BaseUrl = baseUrl;
            ApiSufix = apiSufix;
            ApiVersion = apiVersion;
        }

        public string BaseUrl { get; set; }

        public string ApiSufix { get; set; }

        public string ApiVersion { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public string Id { get; set; }

        public override string ToString()
        {
            var output = new List<string>
            {
                BaseUrl
            };

            if (!string.IsNullOrEmpty(ApiSufix))
                output.Add(ApiSufix);

            if (!string.IsNullOrEmpty(ApiVersion))
                output.Add(ApiVersion);

            output.Add(Controller);

            if (!string.IsNullOrEmpty(Action))
                output.Add(Action);

            if (!string.IsNullOrEmpty(Id))
                output.Add(Id);

            Controller = "";
            Action = "";
            Id = "";

            return string.Join("/", output);
        }
    }
}

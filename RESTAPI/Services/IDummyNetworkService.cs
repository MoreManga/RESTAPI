﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace RESTAPI.Services
{
    public interface IDummyNetworkService
    {
        void SetBaseUri(string baseUri);

        Task<string> Post(
            string relativeUri,
            Dictionary<string, string> parameters,
            string body);

        Task<string> Get(
            string relativeUri,
            Dictionary<string, string> parameters);
    }
}

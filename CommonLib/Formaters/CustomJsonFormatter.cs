﻿using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CommonLib.Models;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;

namespace CommonLib.Formaters
{
    public class CustomJsonFormatter : TextOutputFormatter
    {
        private static ResponseFactory _responseFactory = new ResponseFactory(CustomResponseType.success);

        public CustomJsonFormatter()
        {
            var types = MediaTypeHeaderValue.ParseList(new List<string>()
            {
                "text/html",
                "application/json",
                "text/plain"
            });

            foreach (var item in types)
            {
                SupportedMediaTypes.Add(item);
            }

            SupportedEncodings.Add(Encoding.UTF8);
        }

        /// <summary />
        public override bool CanWriteResult(OutputFormatterCanWriteContext context)
        {
            return true;
        }

        /// <summary />
        public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            return _responseFactory.WriteSealedResponseAsync(context.HttpContext, context.Object);
        }
    }
}

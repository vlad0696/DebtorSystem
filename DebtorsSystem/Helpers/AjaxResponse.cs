using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DebtorsSystem.Helpers
{
    public class AjaxResponse
    {
        public AjaxResponse()
        {
            Success = true;
            Data = new List<object>();
        }

        public AjaxResponse(Exception exception)
            : this()
        {
            Success = false;
            Errors = new[] { exception.Message };
        }

        public AjaxResponse(object data)
            : this()
        {
            Data = data;
        }

        public bool Success
        {
            get; set;
        }
        public object Data
        {
            get; set;
        }
        public string[] Errors
        {
            get; set;
        }
    }
}

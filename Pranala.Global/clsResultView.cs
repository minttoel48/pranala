using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pranala.Global
{
    public class clsResultView
    {
        public bool Status { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
    }

    public sealed class resultView
    {
        public resultView() { }

        public static clsResultView Create(bool status, object data, string message)
        {
            clsResultView result = new clsResultView()
            {
                Status = status,
                Data = data,
                Message = message
            };

            return result;
        }
    }
}

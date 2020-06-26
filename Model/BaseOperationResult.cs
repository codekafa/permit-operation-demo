using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BaseOperationResult
    {
        public bool IsSuccess { get; set; }

        public object Data { get; set; }

        public string[] Messages { get; set; }

    }
}

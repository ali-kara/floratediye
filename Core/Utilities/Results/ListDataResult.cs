using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ListDataResult<T> : Result
    {
        public ListDataResult(List<T> data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public ListDataResult(List<T> data, bool success) : base(success)
        {
            Data = data;
        }

        public ListDataResult()
        {
                
        }


        public List<T>? Data { get; set; }
    }
}

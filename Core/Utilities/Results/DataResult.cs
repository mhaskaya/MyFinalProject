using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success,string message) :base (success,message)
        {
            this.data = data;
        }
        public DataResult(T data, bool success):base(success)
        {
            this.data = data;
        }

        private readonly T data;

        public T GetData()
        {
            return data;
        }

        public T Data { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Result //complex type
    {
        public bool Correct { get; set; } //true, false
        public string ErrorMessage { get; set; } 
        public object Object { get; set; } // 1 registro ->GetById
        public List<object> Objects { get; set; } //>1 registro -> GetAll
        public Exception Ex { get; set; }
    }
}

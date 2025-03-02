using Framework1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLStore
{
    public class Store
    {
        public Store()
        {
            new Testes();
        }
        public Testes TesteOutraRef()
        {
            return new Testes();
        }

    }
}

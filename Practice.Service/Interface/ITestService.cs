using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Service.Interface
{
    public interface ITestService
    {
        public string RandomWord(int WordLength = 1);

        public Task Test();
    }
}

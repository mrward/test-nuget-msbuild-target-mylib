
using System;

namespace MyLib
{
    public class MyClass
    {
        public MyClass()
        {
        }

        public string SayHello()
        {
#if X64
            return "Hello x64";
#else
            return "Hello x86";
#endif
        }
    }
}


#pragma once
using namespace System;


namespace MyCliProject {
    public ref class GreeterCli
    {
        public:
            String^ SayHello()
            {
                return "Hello from C++/CLI Project!";
            }
    };
}


#pragma once
using namespace System;

namespace CliProject {
    public ref class GreeterCli
    {
    public:
        String^ SayHello()
        {
            return "Hello from C++/CLI Project!";
        }
    };
}



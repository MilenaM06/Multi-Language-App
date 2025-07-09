#pragma once

using namespace System;

namespace MyCliProject {
    public ref class Greeter
    {
    public:
        String^ SayHello()
        {
            return "Hello from C++/CLI Project!";
        }
    };
}

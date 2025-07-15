#pragma once
#include "../CppProject/NativeLogger.h"
using namespace System;

namespace CliProject {
    public ref class GreeterCli
    {       
    public:
        String^ SayHello()
        {       
            LogNativeMessage("C++/CLI Project Log - class GreeterCli - SayHello() was called");
            return "Hello from C++/CLI Project!";
        }
    };
}



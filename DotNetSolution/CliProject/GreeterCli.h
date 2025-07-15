#pragma once
#include "../CppProject/NativeLogger.h"
using namespace System;

namespace CliProject {
    public ref class GreeterCli
    {       
    public:
        GreeterCli();      
        String^ SayHello();
    };
}



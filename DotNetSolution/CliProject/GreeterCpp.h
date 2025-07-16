#pragma once
#include "../CppProject/NativeLogger.h"
#include "../CppProject/GreeterCppNative.h"
#include <string>
using namespace System;

namespace CliProject {

    public ref class GreeterCpp
    {
    private:
        GreeterCppNative* nativeGreeter; 

    public:
        GreeterCpp();       
        ~GreeterCpp();     
        !GreeterCpp();      

        String^ SayHello();
    };

}

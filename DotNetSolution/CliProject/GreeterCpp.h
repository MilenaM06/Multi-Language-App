#pragma once
#include "../CppProject/NativeLogger.h"
#include "../CppProject/GreeterCppNative.h"
#include <string>
using namespace System;

namespace CliProject {

    public ref class GreeterCpp
    {
    private:
        GreeterCppNative* nativeGreeter; // Pointer to native class

    public:
        GreeterCpp();       // Constructor
        ~GreeterCpp();      // Destructor
        !GreeterCpp();      // Finalizer

        String^ SayHello(); // Method
    };

}

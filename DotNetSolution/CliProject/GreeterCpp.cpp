#include "pch.h"
#include "GreeterCpp.h"
#include "../CppProject/NativeLogger.h"

namespace CliProject {

    GreeterCpp::GreeterCpp()
    {
        nativeGreeter = new GreeterCppNative();  
    }

    GreeterCpp::~GreeterCpp()
    {
        this->!GreeterCpp(); 
    }

    GreeterCpp::!GreeterCpp()
    {
        if (nativeGreeter != nullptr)
        {
            delete nativeGreeter;
            nativeGreeter = nullptr;
        }
    }

    String^ GreeterCpp::SayHello()
    {
        std::string nativeResult = nativeGreeter->SayHello();

        LogNativeMessage("C++/CLI Project Log - class GreeterCpp - SayHello() was called");

        return gcnew String(nativeResult.c_str());
    }

}
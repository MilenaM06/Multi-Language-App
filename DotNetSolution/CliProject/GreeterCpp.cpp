#include "pch.h"
#include "GreeterCpp.h"
#include "../CppProject/GreeterCppNative.h"  
#include "../CppProject/NativeLogger.h"

GreeterCpp::GreeterCpp()
{
}

String^ GreeterCpp::SayHello()
{
    GreeterCppNative nativeGreeter;
    std::string nativeResult = nativeGreeter.SayHello();

    LogNativeMessage("C++/CLI Project Log - class GreeterCpp - SayHello() was called");
    // Convert std::string to System::String^
    return gcnew String(nativeResult.c_str());
}
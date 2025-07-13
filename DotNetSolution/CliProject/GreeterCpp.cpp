#include "pch.h"
#include "GreeterCpp.h"
#include "../CppProject/GreeterCppNative.h"  

GreeterCpp::GreeterCpp()
{
}

String^ GreeterCpp::SayHello()
{
    GreeterCppNative nativeGreeter;
    std::string nativeResult = nativeGreeter.SayHello();

    // Convert std::string to System::String^
    return gcnew String(nativeResult.c_str());
}
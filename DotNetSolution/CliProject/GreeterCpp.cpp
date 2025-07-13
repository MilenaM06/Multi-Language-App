#include "pch.h"
#include "GreeterCpp.h"
<<<<<<< HEAD:DotNetSolution/CliProject/GreeterCpp.cpp
#include "../CppProject/GreeterCppNative.h"  
=======
#include "../MyCppProject/GreeterCppNative.h"  
>>>>>>> main:MyCliProject/GreeterCpp.cpp

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
#include "pch.h"
#include "GreeterCppNative.h"
#include "NativeLogger.h"

std::string GreeterCppNative::SayHello()
{
    LogNativeMessage("C++ Native Project Log - class GreeterCppNative - SayHello() was called");
    return "Hello from C++ Native Project!";
}
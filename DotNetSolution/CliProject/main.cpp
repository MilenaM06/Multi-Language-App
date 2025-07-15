#include "pch.h"
#include "GreeterCli.h"
#include "../CppProject/NativeLogger.h"
#include <iostream>

int main(array<System::String^>^ args)
{
    try
    {
        InitNativeLogger();
    }
    catch (const std::exception& e)
    {
        std::cerr << "Exception: " << e.what() << std::endl;
        return 1;
    }
    return 0;
}
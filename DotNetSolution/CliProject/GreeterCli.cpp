#include "pch.h"
#include "GreeterCli.h"
using namespace CliProject;

GreeterCli::GreeterCli(){}

String^ GreeterCli::SayHello()
{
    LogNativeMessage("C++/CLI Project Log - class GreeterCli - SayHello() was called");
    return "Hello from C++/CLI Project!";
}
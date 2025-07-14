#include "pch.h"
#include "..\..\CliProject\GreeterCli.h"

namespace CppTests {
    TEST(CliTests, SayHello_ReturnsExpectedString) {
        GreeterCli greeter;

        std::string result = greeter.SayHello();

        EXPECT_EQ(result, "Hello from C++/CLI Project!");
    }
}
#include "pch.h"
#include "..\..\CppProject\GreeterCppNative.h"

namespace CppTests {
    TEST(CppNativeTests, SayHello_ReturnsExpectedString) {
        GreeterCppNative greeter;

        std::string result = greeter.SayHello();

        EXPECT_EQ(result, "Hello from C++ Native Project!");
    }
}
#include "pch.h"
#include "NativeLogger.h"
#include <spdlog/spdlog.h>
#include <spdlog/sinks/basic_file_sink.h>

void InitNativeLogger() {
    static bool initialized = false;
    if (!initialized) {
        auto logger = spdlog::basic_logger_mt("cpp_logger", "Logs/cpp_logs.log");
        spdlog::set_default_logger(logger);
        spdlog::set_level(spdlog::level::info);
        spdlog::flush_on(spdlog::level::info);
        initialized = true;
    }
}

void LogNativeMessage(const char* message) {
    InitNativeLogger();
    spdlog::info(message);
}
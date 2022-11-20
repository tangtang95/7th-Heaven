// DEFINE ----------------------------------------
#define WIN32_LEAN_AND_MEAN

#define MAIN_ASM_NAME L"7thWrapperProxy"
#define MAIN_TYP_NAME L"_7thWrapperProxy.Proxy"
#define MAIN_FUN_NAME L"Main"

// PRAGMA ----------------------------------------

#pragma comment(linker, "/export:DirectInputCreateA=C:\\Windows\\System32\\dinput.DirectInputCreateA,@1")

// INCLUDE ---------------------------------------

#include <Windows.h>
#include <stdio.h>
#include <detours/detours.h>
#include <nethost.h>
#include <hostfxr.h>
#include <coreclr_delegates.h>
#include <TlHelp32.h>

#define X(n) n##_fn n;
#include "hostfxr.x.h"
#include "delegates.x.h"
#undef X

// EXPORTS ---------------------------------------

struct host_exports
{
#define X(n) decltype(&n) n;
#include "host_exports.x.h"
#undef X
} exports;

// IMPORTS ---------------------------------------

// API to initialize 7th Heaven.
static HRESULT(WINAPI* HostInitialize)(host_exports*) = nullptr;

// CreateFileW
static HANDLE(WINAPI* _7thCreateFileW)(LPCWSTR lpFileName, DWORD dwDesiredAccess, DWORD dwShareMode, LPSECURITY_ATTRIBUTES lpSecurityAttributes, DWORD dwCreationDisposition, DWORD dwFlagsAndAttributes, HANDLE hTemplateFile) = nullptr;
static HANDLE(WINAPI* TrueCreateFileW)(LPCWSTR lpFileName, DWORD dwDesiredAccess, DWORD dwShareMode, LPSECURITY_ATTRIBUTES lpSecurityAttributes, DWORD dwCreationDisposition, DWORD dwFlagsAndAttributes, HANDLE hTemplateFile) = CreateFileW;

// ReadFile
static BOOL(WINAPI* _7thReadFile)(HANDLE hFile, LPVOID lpBuffer, DWORD nNumberOfBytesToRead, LPDWORD lpNumberOfBytesRead, LPOVERLAPPED lpOverlapped) = nullptr;
static BOOL(WINAPI* TrueReadFile)(HANDLE hFile, LPVOID lpBuffer, DWORD nNumberOfBytesToRead, LPDWORD lpNumberOfBytesRead, LPOVERLAPPED lpOverlapped) = ReadFile;

// FindFirstFileW
static HANDLE(WINAPI* _7thFindFirstFileW)(LPCWSTR lpFileName, LPWIN32_FIND_DATAW lpFindFileData) = nullptr;
static HANDLE(WINAPI* TrueFindFirstFileW)(LPCWSTR lpFileName, LPWIN32_FIND_DATAW lpFindFileData) = FindFirstFileW;

// SetFilePointer
static DWORD(WINAPI* _7thSetFilePointer)(HANDLE hFile, LONG lDistanceToMove, PLONG lpDistanceToMoveHigh, DWORD dwMoveMethod) = nullptr;
static DWORD(WINAPI* TrueSetFilePointer)(HANDLE hFile, LONG lDistanceToMove, PLONG lpDistanceToMoveHigh, DWORD dwMoveMethod) = SetFilePointer;

// SetFilePointerEx
static BOOL(WINAPI* _7thSetFilePointerEx)(HANDLE hFile, LARGE_INTEGER liDistanceToMove, PLARGE_INTEGER lpNewFilePointer, DWORD dwMoveMethod) = nullptr;
static BOOL(WINAPI* TrueSetFilePointerEx)(HANDLE hFile, LARGE_INTEGER liDistanceToMove, PLARGE_INTEGER lpNewFilePointer, DWORD dwMoveMethod) = SetFilePointerEx;

// CloseHandle
static BOOL(WINAPI* _7thCloseHandle)(HANDLE hObject) = nullptr;
static BOOL(WINAPI* TrueCloseHandle)(HANDLE hObject) = CloseHandle;

// GetFileType
static DWORD(WINAPI* _7thGetFileType)(HANDLE hFile) = nullptr;
static DWORD(WINAPI* TrueGetFileType)(HANDLE hFile) = GetFileType;

// GetFileInformationByHandle
static BOOL(WINAPI* _7thGetFileInformationByHandle)(HANDLE hFile, LPBY_HANDLE_FILE_INFORMATION lpFileInformation) = nullptr;
static BOOL(WINAPI* TrueGetFileInformationByHandle)(HANDLE hFile, LPBY_HANDLE_FILE_INFORMATION lpFileInformation) = GetFileInformationByHandle;

// DuplicateHandle
static BOOL(WINAPI* _7thDuplicateHandle)(HANDLE hSourceProcessHandle, HANDLE hSourceHandle, HANDLE hTargetProcessHandle, LPHANDLE lpTargetHandle, DWORD dwDesiredAccess, BOOL bInheritHandle, DWORD dwOptions) = nullptr;
static BOOL(WINAPI* TrueDuplicateHandle)(HANDLE hSourceProcessHandle, HANDLE hSourceHandle, HANDLE hTargetProcessHandle, LPHANDLE lpTargetHandle, DWORD dwDesiredAccess, BOOL bInheritHandle, DWORD dwOptions) = DuplicateHandle;

// GetFileSize
static DWORD(WINAPI* _7thGetFileSize)(HANDLE hFile, LPDWORD lpFileSizeHigh) = nullptr;
static DWORD(WINAPI* TrueGetFileSize)(HANDLE hFile, LPDWORD lpFileSizeHigh) = GetFileSize;

// GetFileSizeEx
static BOOL(WINAPI* _7thGetFileSizeEx)(HANDLE hFile, PLARGE_INTEGER lpFileSize) = nullptr;
static BOOL(WINAPI* TrueGetFileSizeEx)(HANDLE hFile, PLARGE_INTEGER lpFileSize) = GetFileSizeEx;

// VARS ------------------------------------------

DWORD currentMainThreadId = 0;
HANDLE currentMainThread = nullptr;
BOOL in7thHeaven = false;

// FUNCTIONS -------------------------------------

HANDLE WINAPI _CreateFileW(LPCWSTR lpFileName, DWORD dwDesiredAccess, DWORD dwShareMode, LPSECURITY_ATTRIBUTES lpSecurityAttributes, DWORD dwCreationDisposition, DWORD dwFlagsAndAttributes, HANDLE hTemplateFile)
{
    HANDLE ret = nullptr;

    if (exports.CreateFileW)
    {
        if (!in7thHeaven && GetCurrentThreadId() == currentMainThreadId)
        {
            in7thHeaven = true;
            ret = exports.CreateFileW(lpFileName, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
            in7thHeaven = false;
        }
    }

    if (ret == nullptr)
        ret = TrueCreateFileW(lpFileName, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);

    return ret;
}

BOOL WINAPI _ReadFile(HANDLE hFile, LPVOID lpBuffer, DWORD nNumberOfBytesToRead, LPDWORD lpNumberOfBytesRead, LPOVERLAPPED lpOverlapped)
{
    int ret = FALSE;

    if (exports.ReadFile)
    {
        if (!in7thHeaven && GetCurrentThreadId() == currentMainThreadId)
        {
            in7thHeaven = true;
            ret = exports.ReadFile(hFile, lpBuffer, nNumberOfBytesToRead, lpNumberOfBytesRead, lpOverlapped);
            in7thHeaven = false;
        }
    }

    if (ret == FALSE)
        ret = TrueReadFile(hFile, lpBuffer, nNumberOfBytesToRead, lpNumberOfBytesRead, lpOverlapped);

    return ret;
}

HANDLE WINAPI _FindFirstFileW(LPCWSTR lpFileName, LPWIN32_FIND_DATAW lpFindFileData)
{
    if (exports.FindFirstFileW)
    {
        if (!in7thHeaven && GetCurrentThreadId() == currentMainThreadId)
        {
            in7thHeaven = true;
            exports.FindFirstFileW(lpFileName, lpFindFileData);
            in7thHeaven = false;
        }
    }

    return TrueFindFirstFileW(lpFileName, lpFindFileData);
}

DWORD WINAPI _SetFilePointer(HANDLE hFile, LONG lDistanceToMove, PLONG lpDistanceToMoveHigh, DWORD dwMoveMethod)
{
    DWORD ret = INVALID_SET_FILE_POINTER;

    if (exports.SetFilePointer)
    {
        if (!in7thHeaven && GetCurrentThreadId() == currentMainThreadId)
        {
            in7thHeaven = true;
            ret = exports.SetFilePointer(hFile, lDistanceToMove, lpDistanceToMoveHigh, dwMoveMethod);
            in7thHeaven = false;
        }
    }

    if (ret == INVALID_SET_FILE_POINTER)
        ret = TrueSetFilePointer(hFile, lDistanceToMove, lpDistanceToMoveHigh, dwMoveMethod);

    return ret;
}

BOOL WINAPI _SetFilePointerEx(HANDLE hFile, LARGE_INTEGER liDistanceToMove, PLARGE_INTEGER lpNewFilePointer, DWORD dwMoveMethod)
{
    DWORD ret = FALSE;

    if (exports.SetFilePointer)
    {
        if (!in7thHeaven && GetCurrentThreadId() == currentMainThreadId)
        {
            in7thHeaven = true;
            ret = exports.SetFilePointerEx(hFile, liDistanceToMove, lpNewFilePointer, dwMoveMethod);
            in7thHeaven = false;
        }
    }

    if (ret == FALSE)
        ret = TrueSetFilePointerEx(hFile, liDistanceToMove, lpNewFilePointer, dwMoveMethod);

    return ret;
}

BOOL WINAPI _CloseHandle(HANDLE hObject)
{
    if (exports.CloseHandle)
    {
        if (!in7thHeaven && GetCurrentThreadId() == currentMainThreadId)
        {
            in7thHeaven = true;
            exports.CloseHandle(hObject);
            in7thHeaven = false;
        }
    }

    return TrueCloseHandle(hObject);
}

DWORD WINAPI _GetFileType(HANDLE hFile)
{
    DWORD ret = FILE_TYPE_UNKNOWN;

    if (exports.GetFileType)
    {
        if (!in7thHeaven && GetCurrentThreadId() == currentMainThreadId)
        {
            in7thHeaven = true;
            ret = exports.GetFileType(hFile);
            in7thHeaven = false;
        }
    }

    if (ret == FILE_TYPE_UNKNOWN)
        ret = TrueGetFileType(hFile);

    return ret;
}

BOOL WINAPI _GetFileInformationByHandle(HANDLE hFile, LPBY_HANDLE_FILE_INFORMATION lpFileInformation)
{
    BOOL ret = TrueGetFileInformationByHandle(hFile, lpFileInformation);

    if (exports.GetFileInformationByHandle)
    {
        if (!in7thHeaven && GetCurrentThreadId() == currentMainThreadId)
        {
            in7thHeaven = true;
            ret = exports.GetFileInformationByHandle(hFile, lpFileInformation);
            in7thHeaven = false;
        }
    }

    return ret;
}

BOOL WINAPI _DuplicateHandle(HANDLE hSourceProcessHandle, HANDLE hSourceHandle, HANDLE hTargetProcessHandle, LPHANDLE lpTargetHandle, DWORD dwDesiredAccess, BOOL bInheritHandle, DWORD dwOptions)
{
    BOOL ret = TrueDuplicateHandle(hSourceProcessHandle, hSourceHandle, hTargetProcessHandle, lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);

    if (exports.DuplicateHandle)
    {
        if (!in7thHeaven && GetCurrentThreadId() == currentMainThreadId)
        {
            in7thHeaven = true;
            exports.DuplicateHandle(hSourceProcessHandle, hSourceHandle, hTargetProcessHandle, lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
            in7thHeaven = false;
        }
    }

    return ret;
}

DWORD WINAPI _GetFileSize(HANDLE hFile, LPDWORD lpFileSizeHigh)
{
    DWORD ret = INVALID_FILE_SIZE;

    if (exports.GetFileSize)
    {
        if (!in7thHeaven && GetCurrentThreadId() == currentMainThreadId)
        {
            in7thHeaven = true;
            ret = exports.GetFileSize(hFile, lpFileSizeHigh);
            in7thHeaven = false;
        }
    }

    if (ret == INVALID_FILE_SIZE)
        ret = TrueGetFileSize(hFile, lpFileSizeHigh);

    return ret;
}

BOOL WINAPI _GetFileSizeEx(HANDLE hFile, PLARGE_INTEGER lpFileSize)
{
    BOOL ret = FALSE;

    if (exports.GetFileSizeEx)
    {
        if (!in7thHeaven && GetCurrentThreadId() == currentMainThreadId)
        {
            in7thHeaven = true;
            ret = exports.GetFileSizeEx(hFile, lpFileSize);
            in7thHeaven = false;
        }
    }

    if (ret == FALSE)
        ret = TrueGetFileSizeEx(hFile, lpFileSize);

    return ret;
}

// MAIN ------------------------------------------

#ifndef MAKEULONGLONG
#define MAKEULONGLONG(ldw, hdw) ((ULONGLONG(hdw) << 32) | ((ldw) & 0xFFFFFFFF))
#endif

DWORD GetCurrentProcessMainThreadId()
{
    DWORD dwMainThreadID = 0;
    ULONGLONG ullMinCreateTime = MAXULONGLONG;

    HANDLE hThreadSnap = CreateToolhelp32Snapshot(TH32CS_SNAPTHREAD, 0);
    if (hThreadSnap != INVALID_HANDLE_VALUE) {
        THREADENTRY32 th32;
        th32.dwSize = sizeof(THREADENTRY32);
        BOOL bOK = TRUE;
        for (bOK = Thread32First(hThreadSnap, &th32); bOK; bOK = Thread32Next(hThreadSnap, &th32))
        {
            if (th32.th32OwnerProcessID == GetCurrentProcessId())
            {
                HANDLE hThread = OpenThread(THREAD_QUERY_INFORMATION, TRUE, th32.th32ThreadID);
                if (hThread)
                {
                    FILETIME afTimes[4] = { 0 };
                    if (GetThreadTimes(hThread, &afTimes[0], &afTimes[1], &afTimes[2], &afTimes[3]))
                    {
                        ULONGLONG ullTest = MAKEULONGLONG(afTimes[0].dwLowDateTime, afTimes[0].dwHighDateTime);
                        if (ullTest && ullTest < ullMinCreateTime)
                        {
                            ullMinCreateTime = ullTest;
                            dwMainThreadID = th32.th32ThreadID; // let it be main... :)
                        }
                    }
                    CloseHandle(hThread);
                }
            }
        }
#ifndef UNDER_CE
        CloseHandle(hThreadSnap);
#else
        CloseToolhelp32Snapshot(hThreadSnap);
#endif
    }

    return dwMainThreadID;
}

BOOL WINAPI DllMain(HINSTANCE hinstDLL, DWORD fdwReason, LPVOID lpReserved)
{
    if (DetourIsHelperProcess()) {
        return TRUE;
    }

    if (fdwReason != DLL_PROCESS_ATTACH)
        return TRUE;

    currentMainThreadId = GetCurrentProcessMainThreadId();

    static auto target = &GetCommandLineA;
    static decltype(target) detour = []()
    {
        DetourTransactionBegin();
        DetourUpdateThread(GetCurrentThread());
        // ------------------------------------
        DetourDetach((void**)&target, detour);
        // ------------------------------------
        DetourTransactionCommit();

        size_t buffer_size = 0;
        get_hostfxr_path(nullptr, &buffer_size, nullptr);

        auto buffer = new char_t[buffer_size];
        get_hostfxr_path(buffer, &buffer_size, nullptr);

        auto hostfxr = LoadLibraryW(buffer);
        delete[] buffer;

#define X(n) *(void**)&n = GetProcAddress(hostfxr, #n);
#include "hostfxr.x.h"
#undef X

        hostfxr_handle context = nullptr;
        hostfxr_set_error_writer([](auto message) { OutputDebugString(message); });
        hostfxr_initialize_for_runtime_config(MAIN_ASM_NAME L".runtimeconfig.json", nullptr, &context);

#define X(n) hostfxr_get_runtime_delegate(context, hdt_##n, (void**)&n);
#include "delegates.x.h"
#undef X

        hostfxr_close(context);

        // Get main entry point and load the assembly
        load_assembly_and_get_function_pointer(MAIN_ASM_NAME L".dll", MAIN_TYP_NAME L", " MAIN_ASM_NAME, MAIN_FUN_NAME, UNMANAGEDCALLERSONLY_METHOD, nullptr, (void**)&HostInitialize);

        // Start the 7th lib process
        HostInitialize(&exports);

        // Hook Win32 APIs
        DetourTransactionBegin();
        DetourUpdateThread(GetCurrentThread());
        // ------------------------------------
        DetourAttach((PVOID*)&TrueCreateFileW, _CreateFileW);
        DetourAttach((PVOID*)&TrueReadFile, _ReadFile);
        DetourAttach((PVOID*)&TrueFindFirstFileW, _FindFirstFileW);
        DetourAttach((PVOID*)&TrueSetFilePointer, _SetFilePointer);
        DetourAttach((PVOID*)&TrueSetFilePointerEx, _SetFilePointerEx);
        DetourAttach((PVOID*)&TrueCloseHandle, _CloseHandle);
        DetourAttach((PVOID*)&TrueGetFileType, _GetFileType);
        DetourAttach((PVOID*)&TrueGetFileInformationByHandle, _GetFileInformationByHandle);
        DetourAttach((PVOID*)&TrueDuplicateHandle, _DuplicateHandle);
        DetourAttach((PVOID*)&TrueGetFileSize, _GetFileSize);
        DetourAttach((PVOID*)&TrueGetFileSizeEx, _GetFileSizeEx);
        // ------------------------------------
        DetourTransactionCommit();

        return target();
    };

    DisableThreadLibraryCalls(hinstDLL);
    DetourTransactionBegin();
    DetourUpdateThread(GetCurrentThread());
    // ------------------------------------
    DetourAttach((void**)&target, detour);
    // ------------------------------------
    DetourTransactionCommit();

    return TRUE;
}

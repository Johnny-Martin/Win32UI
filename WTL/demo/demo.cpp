// demo.cpp : 定义应用程序的入口点。
//

#include "stdafx.h"
#include "CMyWindow.h"
#include "GDITrigger.h"

CAppModule _Module;

int Run(LPTSTR /*lpstrCmdLine*/ = NULL, int nCmdShow = SW_SHOWDEFAULT)
{
	CMessageLoop theLoop;
	_Module.AddMessageLoop(&theLoop);

	CMyWindow dlgMain;

	DWORD dStyle = WS_POPUPWINDOW | WS_MINIMIZEBOX | WS_CLIPCHILDREN | WS_CLIPSIBLINGS;//| WS_MINIMIZEBOX | WS_SYSMENU
	//DWORD dStyle = WS_OVERLAPPED | WS_THICKFRAME | WS_MAXIMIZEBOX;//| WS_SYSMENU | WS_MINIMIZEBOX
	if (dlgMain.Create(nullptr, CMyWindow::rcDefault, nullptr, dStyle) == NULL)
	{
		ATLTRACE(_T("Main dialog creation failed!\n"));
		return 0;
	}
	//dlgMain.UpdateWindow();
	dlgMain.ShowWindow(nCmdShow);
	

	int nRet = theLoop.Run();

	_Module.RemoveMessageLoop();
	return nRet;
}

int APIENTRY wWinMain(_In_ HINSTANCE hInstance,
                     _In_opt_ HINSTANCE hPrevInstance,
                     _In_ LPWSTR    lpCmdLine,
                     _In_ int       nCmdShow)
{
    UNREFERENCED_PARAMETER(hPrevInstance);
    UNREFERENCED_PARAMETER(lpCmdLine);

	HRESULT hRes = ::CoInitialize(NULL);
	GDITrigger::Init();

	// If you are running on NT 4.0 or higher you can use the following call instead to 
	// make the EXE free threaded. This means that calls come in on a random RPC thread.
	//	HRESULT hRes = ::CoInitializeEx(NULL, COINIT_MULTITHREADED);
	ATLASSERT(SUCCEEDED(hRes));

	// this resolves ATL window thunking problem when Microsoft Layer for Unicode (MSLU) is used
	::DefWindowProc(NULL, 0, 0, 0L);

	AtlInitCommonControls(ICC_BAR_CLASSES);	// add flags to support other controls

	hRes = _Module.Init(NULL, hInstance);
	ATLASSERT(SUCCEEDED(hRes));

	int nRet = Run(lpCmdLine, nCmdShow);

	_Module.Term();
	::CoUninitialize();

	return nRet;
}

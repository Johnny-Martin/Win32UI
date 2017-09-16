// demo.cpp : 定义应用程序的入口点。
//

#include "stdafx.h"
#include <string>
#include <regex>
#include "CMyWindow.h"
#include "GDITrigger.h"

CAppModule _Module;

using namespace std;
int Run(LPTSTR /*lpstrCmdLine*/ = NULL, int nCmdShow = SW_SHOWDEFAULT)
{
	CMessageLoop theLoop;
	_Module.AddMessageLoop(&theLoop);

	CMyWindow dlgMain;
	RECT rc;
	rc.left = 100;
	rc.top = 100;
	rc.right = 200;
	rc.bottom = 200;

	DWORD dStyle = WS_POPUP | WS_CLIPCHILDREN | WS_CLIPSIBLINGS | WS_MINIMIZEBOX;// | WS_SYSMENU
	//DWORD dStyle = WS_OVERLAPPED | WS_THICKFRAME | WS_MAXIMIZEBOX | WS_SYSMENU | WS_MINIMIZEBOX;// //WS_OVERLAPPEDWINDOW;// 
	if (dlgMain.Create(nullptr, rc, nullptr, dStyle) == NULL)// CMyWindow::rcDefault
	{
		ATLTRACE(_T("Main dialog creation failed!\n"));
		return 0;
	}
	dlgMain.ShowWindow(nCmdShow);
	//::SetWindowPos(dlgMain.m_hWnd, HWND_TOP, 100, 100, 1000, 600, SWP_SHOWWINDOW);
	
	RECT rc2;
	rc2.left = 300;
	rc2.top = 300;
	rc2.right = 400;
	rc2.bottom = 400;
	CMyWindow dlgMain2;
	if (dlgMain2.Create(dlgMain.m_hWnd, rc2, nullptr, dStyle) == NULL)// CMyWindow::rcDefault
	{
		ATLTRACE(_T("Main dialog creation failed!\n"));
		return 0;
	}
	dlgMain2.ShowWindow(nCmdShow);
	//::SetWindowPos(dlgMain2.m_hWnd, HWND_TOP, 100, 100, 1000, 600, SWP_SHOWWINDOW);


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

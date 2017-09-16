#include "stdafx.h"
#include "CMyWindow.h"

CMyWindow::~CMyWindow()
{
	//if (::IsWindow(m_hWnd))
	//{
	//	//PostMessage(WM_DESTROY);
	//	ShowWindow(SW_HIDE);
	//	::DestroyWindow(m_hWnd);
	//	m_hWnd = NULL;
	//}
}
BOOL CMyWindow::PreTranslateMessage(MSG* pMsg) 
{
	return FALSE;
}
LRESULT CMyWindow::OnCreate(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled)
{
	CMessageLoop* pLoop = _Module.GetMessageLoop();
	ATLASSERT(pLoop != NULL);
	pLoop->AddMessageFilter(this);

	bHandled = false;
	return 0;
}
LRESULT CMyWindow::OnEraseBkgnd(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled)
{
	//DefWindowProc();
	bHandled = false;
	return 0;
}
LRESULT CMyWindow::OnPaint(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled)
{
	//要想绘制非客户区，必须使用GDI而不能使用GDI+
	PAINTSTRUCT ps;
	BeginPaint(&ps);

	RECT rc;
	GetWindowRect(&rc);
	HDC hDC = GetWindowDC();

	int TAR_HIGH = 759;
	int TAR_WEIGHT = 1439;
	HBITMAP hbitmap = (HBITMAP)LoadImage(NULL, L"window.bkg.bmp", IMAGE_BITMAP, TAR_WEIGHT, TAR_HIGH, LR_LOADFROMFILE);
	
	//建立DC 
	HDC hMdc = CreateCompatibleDC(hDC);
	SelectObject(hMdc, hbitmap);
	BitBlt(hDC, 0, 0, rc.right - rc.left, rc.bottom - rc.top, hMdc, 0, 0, SRCCOPY);
	DeleteDC(hMdc);

	ReleaseDC(hDC);
	DeleteObject(hbitmap);
	
	/*Gdiplus::Image image(L"window.bkg.png");
	Gdiplus::Status ret = image.GetLastStatus();
	if (ret != Gdiplus::Status::Ok) {
		::MessageBox(NULL, L"加载图片失败", L"警告", MB_OK);
		return 0;
	}
	auto width = image.GetWidth();
	auto height = image.GetHeight();
	Gdiplus::Graphics graphic(hDC);
	graphic.DrawImage(&image, 0, 0, width, height);

	TextOut(hDC, 0, 0, _T("Hello, the fucking world"), 24);*/

	EndPaint(&ps);

	bHandled = false;
	return DefWindowProc();
}
LRESULT CMyWindow::OnNcPaint(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled)
{
	//要想绘制非客户区，必须使用GDI而不能使用GDI+
	return	DefWindowProc();
}
LRESULT CMyWindow::OnMouseMove(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled)
{
	return 0;
}
LRESULT CMyWindow::OnMouseLeave(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled)
{
	return 0;
}
LRESULT CMyWindow::OnDestroy(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled)
{	
	CMessageLoop* pLoop = _Module.GetMessageLoop();
	ATLASSERT(pLoop != NULL);
	pLoop->RemoveMessageFilter(this);

	auto filterCount = pLoop->m_aMsgFilter.GetSize();
	if (filterCount == 0)
	{
		PostQuitMessage(0);
	}
	bHandled = FALSE;
	return 1;
}


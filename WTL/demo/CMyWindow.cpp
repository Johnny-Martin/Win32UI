#include "stdafx.h"
#include "CMyWindow.h"


LRESULT CMyWindow::OnEraseBkgnd(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled)
{
	return 0;
}
LRESULT CMyWindow::OnPaint(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled)
{
	PAINTSTRUCT ps;
	HDC hDC = GetWindowDC();
	BeginPaint(&ps);

	Gdiplus::Image image(L"window.bkg.png");
	Gdiplus::Status ret = image.GetLastStatus();
	if (ret != Gdiplus::Status::Ok) {
		::MessageBox(NULL, L"º”‘ÿÕº∆¨ ß∞‹", L"æØ∏Ê", MB_OK);
		return 0;
	}
	auto width = image.GetWidth();
	auto height = image.GetHeight();
	Gdiplus::Graphics graphic(hDC);
	graphic.DrawImage(&image, 0, 0, width, height);

	TextOut(hDC, 0, 0, _T("Hello, the fucking world"), 24);

	EndPaint(&ps);
	return 0;
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
	PostQuitMessage(0);
	bHandled = FALSE;
	return 0;
}


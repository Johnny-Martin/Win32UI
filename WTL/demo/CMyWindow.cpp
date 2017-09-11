#include "stdafx.h"
#include "CMyWindow.h"

LRESULT CMyWindow::OnEraseBkgnd(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled)
{
	return 0;
}
LRESULT CMyWindow::OnPaint(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled)
{
	PAINTSTRUCT ps;
	HDC hDC = GetDC();
	BeginPaint(&ps);
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


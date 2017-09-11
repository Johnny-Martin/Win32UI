#pragma once

#include "stdafx.h"
#include "resource.h"



class CMyWindow :public CWindowImpl<CMyWindow>
{
public:
	DECLARE_WND_CLASS(_T("CMyWindowClass"));

	BEGIN_MSG_MAP(CMyWindow)
		MESSAGE_HANDLER(WM_ERASEBKGND,  OnEraseBkgnd)
		MESSAGE_HANDLER(WM_PAINT,		OnPaint)
		MESSAGE_HANDLER(WM_MOUSEMOVE,	OnMouseMove)
		MESSAGE_HANDLER(WM_MOUSELEAVE,	OnMouseLeave)
		MESSAGE_HANDLER(WM_DESTROY,		OnDestroy)
	END_MSG_MAP()

public:
	virtual LRESULT					OnEraseBkgnd(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled);
	virtual LRESULT					OnPaint(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled);
	virtual LRESULT					OnMouseMove(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled);
	virtual LRESULT					OnMouseLeave(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled);
	virtual LRESULT					OnDestroy(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled);
};
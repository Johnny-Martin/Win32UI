#pragma once

static UINT HANDLED_MESSAGE[] = {
	WM_SHOWWINDOW,
	WM_INITMENUPOPUP,
	WM_SYSCOMMAND,
	WM_SETTEXT,
	WM_NCPAINT,
	WM_NCCALCSIZE,
	WM_SIZE,
	WM_NCACTIVATE,
	WM_NCHITTEST,
	WM_NCLBUTTONUP,
	WM_NCLBUTTONDOWN,
	WM_NCLBUTTONDBLCLK,
	WM_NCRBUTTONUP,
	WM_NCRBUTTONDOWN,
	WM_NCMOUSEMOVE,
	WM_GETMINMAXINFO,
	WM_WINDOWPOSCHANGING,
	WM_SIZING,
	WM_ACTIVATE
};

#define MESSAGE_COUNT 19

class CSkinWindow {
public:
	CSkinWindow(void);
	~CSkinWindow(void);

	void Load(HINSTANCE, HWND);
	void LoadBitmapFromResource();
	void FreeBitmap();
	void Free();
	void CalcResourceInfo();

	BOOL IsHandledMessage(UINT message);
	LRESULT WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam);

	void OnNcPaintA(HWND, UINT, WPARAM, LPARAM);
	void OnNcPaint(HWND, UINT, WPARAM, LPARAM);
	void OnNcActive(HWND, UINT, WPARAM, LPARAM);
	void OnNcCalcSize(HWND, UINT, WPARAM, LPARAM);
	UINT OnNcHitTest(HWND, UINT, WPARAM, LPARAM);
	void OnNcLButtonUp(HWND, UINT, WPARAM, LPARAM);
	void OnNcLButtonDown(HWND, UINT, WPARAM, LPARAM);
	void OnNcLButtonDblClk(HWND, UINT, WPARAM, LPARAM);
	void OnNcMouseMove(HWND, UINT, WPARAM, LPARAM);
	void OnNcRButtonUp(HWND, UINT, WPARAM, LPARAM);
	void OnNcRButtonDown(HWND, UINT, WPARAM, LPARAM);
	void OnSize(HWND, UINT, WPARAM, LPARAM);
	void OnSizing(HWND, UINT, WPARAM, LPARAM);
	void OnActive(HWND, UINT, WPARAM, LPARAM);
	void OnWindowPosChanging(HWND, UINT, WPARAM, LPARAM);
	void OnGetMinMaxInfo(HWND, UINT, WPARAM, LPARAM);
	void OnSetText(HWND, UINT, WPARAM, LPARAM);
	void OnSysCommand(HWND, UINT, WPARAM, LPARAM);

	void DrawFrame(HDC hDc, int x, int y, int width, int height, int state);
	void DrawTitle(HDC hDc, int x, int y, int width, int state);
	void DrawLeft(HDC hDc, int x, int y, int height, int state);
	void DrawRight(HDC hDc, int x, int y, int height, int state);
	void DrawBottom(HDC hDc, int x, int y, int width, int state);
	BOOL DrawButton(HDC hDc, int index, int state);

	HRGN CreateRgnFromColor(HBITMAP, COLORREF);
	HRGN CreateRegionFromBitmap(HBITMAP, COLORREF);
	HRGN BitmapToRegion(HBITMAP hBmp, COLORREF cTransparentColor = 0, COLORREF cTolerance = 0x101010);
	HRGN GetRegion(HDC hDc, int width, int height);
	RECT GetButtonRect(int index);
	void MyTransparentBlt(HDC, int, int, int, int, HBITMAP, int, int, COLORREF, HPALETTE);
	bool TransparentBltA(
		HDC dcDest,         // handle to Dest DC
		int nXOriginDest,   // x-coord of destination upper-left corner
		int nYOriginDest,   // y-coord of destination upper-left corner
		int nWidthDest,     // width of destination rectangle
		int nHeightDest,    // height of destination rectangle
		HDC dcSrc,          // handle to source DC
		int nXOriginSrc,    // x-coord of source upper-left corner
		int nYOriginSrc,    // y-coord of source upper-left corner
		int nWidthSrc,      // width of source rectangle
		int nHeightSrc,     // height of source rectangle
		UINT crTransparent  // color to make transparent
	);

	void TransparentBltB(
		HDC hdcDest,		// handle to Dest DC
		int nXOriginDest,   // x-coord of destination upper-left corner
		int nYOriginDest,   // y-coord of destination upper-left corner
		int nWidthDest,     // width of destination rectangle
		int nHeightDest,    // height of destination rectangle
		HDC hdcSrc,         // handle to source DC
		int nXOriginSrc,    // x-coord of source upper-left corner
		int nYOriginSrc,    // y-coord of source upper-left corner
		int nWidthSrc,      // width of source rectangle
		int nHeightSrc,     // height of source rectangle
		UINT crTransparent  // color to make transparent
	);

	BOOL MaximizeWindow();
	BOOL MinimizeWindow();
	BOOL RestoreWindow();

	RECT GetMaximizeRect();

private:
	HDC m_MemDC;
	HDC m_SkinDC;
	HDC m_RegionDC;

	//bitmap resources
	HBITMAP m_hLeftBmp;
	HBITMAP m_hTopBmp;
	HBITMAP m_hRightBmp;
	HBITMAP m_hBottomBmp;
	HBITMAP m_hMinBtnBmp;
	HBITMAP m_hMaxBtnBmp;
	HBITMAP m_hRestoreBtnBmp;
	HBITMAP m_hCloseBtnBmp;
	HBITMAP m_hBtnMemBmp;
	HBITMAP m_hBtnMaskBmp;

	//memory bitmaps
	HBITMAP m_MemBitmap;
	HBITMAP m_OldMemBitmap;
	HBITMAP m_OldSkinBitmap;

	//font
	HFONT m_hFont;
	HFONT m_hOldFont;

	//bitmap's information
	BITMAP bmpLeft;
	BITMAP bmpTop;
	BITMAP bmpRight;
	BITMAP bmpBottom;
	BITMAP bmpMinBtn;
	BITMAP bmpMaxBtn;
	BITMAP bmpRestoreBtn;
	BITMAP bmpCloseBtn;

	//caption button's rectangle
	RECT minBtnRect;
	RECT maxBtnRect;
	RECT restoreBtnRect;
	RECT closeBtnRect;

	RECT RestoreWinRect;

	char* WindowText;
	int LeftOffset1, LeftOffset2;
	int RightOffset1, RightOffset2;
	int TopOffset1, TopOffset2;
	int BottomOffset1, BottomOffset2;

	int BorderLeftWidth;
	int BorderRightWidth;
	int BorderTopHeight;
	int BorderBottomHeight;

	HINSTANCE m_hInst;
	HWND m_hWnd;

	BOOL IsActive;
	BOOL m_Loaded;

	COLORREF clrTrans;

	BOOL m_sizable;
	BOOL m_minable;
	BOOL m_maxable;
	BOOL m_sysmenu;
	UINT m_mousedown;

	int m_winstate, m_oldwinstate;

	UINT m_oldHitTest;
	UINT m_moveHitTest;
	UINT m_downHitTest;

	BOOL m_bTrans;
};

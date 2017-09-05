// MainDlg.h : interface of the CMainDlg class
//
/////////////////////////////////////////////////////////////////////////////

#pragma once

#include <atlmisc.h>
#include "DialogRegion.h"

class CMainDlg : public CDialogImpl<CMainDlg>, public CUpdateUI<CMainDlg>,
		public CMessageFilter, public CIdleHandler, CDialogRegionT<CMainDlg>
{
	CBitmap m_bmp;
	BOOL m_running;

	CFont m_font_number;
	CFont m_font_output;

	int m_number;
	CSimpleValArray<int> m_output;
	
	CPoint m_output_pos;
	CPoint m_number_pos;
	int m_number_step;
	int m_output_step;
	
public:
	enum { IDD = IDD_MAINDLG };

	virtual BOOL PreTranslateMessage(MSG* pMsg)
	{
		return CWindow::IsDialogMessage(pMsg);
	}

	virtual BOOL OnIdle()
	{
		return FALSE;
	}

	BEGIN_UPDATE_UI_MAP(CMainDlg)
	END_UPDATE_UI_MAP()

	BEGIN_MSG_MAP(CMainDlg)
		MESSAGE_HANDLER(WM_KEYDOWN, OnKeyDown)
		MESSAGE_HANDLER(WM_INITDIALOG, OnInitDialog)
		MESSAGE_HANDLER(WM_DESTROY, OnDestroy)
		MESSAGE_HANDLER(WM_TIMER, OnTimer)
		MESSAGE_HANDLER(WM_PAINT, OnPaint)
		COMMAND_ID_HANDLER(IDCANCEL, OnCancel)
		CHAIN_MSG_MAP(CDialogRegionT<CMainDlg>)
	END_MSG_MAP()

// Handler prototypes (uncomment arguments if needed):
//	LRESULT MessageHandler(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/)
//	LRESULT CommandHandler(WORD /*wNotifyCode*/, WORD /*wID*/, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
//	LRESULT NotifyHandler(int /*idCtrl*/, LPNMHDR /*pnmh*/, BOOL& /*bHandled*/)

	LRESULT OnKeyDown(UINT /*uMsg*/, WPARAM wParam, LPARAM /*lParam*/, BOOL& bHandled)
	{
		if(wParam == VK_SPACE) onVkSpace();
		else bHandled = FALSE;
		return 0;
	}

	LRESULT OnInitDialog(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/)
	{
		initNumbers();
		initOutput();

		srand(GetTickCount());

		startRandom();

		SetBKBitmap(IDB_BACKGND);
		
		// register object for message filtering and idle updates
		CMessageLoop* pLoop = _Module.GetMessageLoop();
		ATLASSERT(pLoop != NULL);
		pLoop->AddMessageFilter(this);
		pLoop->AddIdleHandler(this);

		UIAddChildWindowContainer(m_hWnd);

		return TRUE;
	}

	LRESULT OnPaint(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/)
	{
		CPaintDC dc(m_hWnd);
  
		CDC memDC;	
		memDC.CreateCompatibleDC(dc.m_hDC);

		CBitmap bmp;
		bmp.LoadBitmap(IDB_BACKGND);
		CBitmap oldBmp = memDC.SelectBitmap(bmp);
		dc.BitBlt(0, 0, 800, 600, memDC, 0, 0, SRCCOPY);

		{
			memDC.SetBkMode(TRANSPARENT);
			memDC.SetTextColor( RGB(255,0,0));
			
			{
				
				memDC.SelectFont(m_font_number);
				
				CString result;
				result.Format(L"%06d", m_number);
				for(int i=0; i<6; i++){
					CString tmp = result.GetAt(i);
					memDC.TextOut(m_number_pos.x+m_number_step*i, m_number_pos.y, tmp);
				}
			}


			//{
			//	memDC.SelectFont(m_font_output);
			//	
			//	for(int i=0; i<m_output.m_nSize; i++){
			//		CString tmp;
			//		tmp.Format(L"%06d", m_output[i]);
			//		memDC.TextOut(m_output_pos.x, m_output_pos.y+m_output_step*i, tmp);
			//	}
			//}
		}

		dc.BitBlt(0, 0, 800, 600, memDC, 0, 0, SRCCOPY);

		// clean up
		memDC.SelectBitmap(oldBmp);
		memDC.DeleteDC();

		return 0;
	}

	LRESULT OnDestroy(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/)
	{
		// unregister message filtering and idle updates
		CMessageLoop* pLoop = _Module.GetMessageLoop();
		ATLASSERT(pLoop != NULL);
		pLoop->RemoveMessageFilter(this);
		pLoop->RemoveIdleHandler(this);

		return 0;
	}

	LRESULT OnCancel(WORD /*wNotifyCode*/, WORD wID, HWND /*hWndCtl*/, BOOL& /*bHandled*/)
	{
		CloseDialog(wID);
		return 0;
	}

	void CloseDialog(int nVal)
	{
		DestroyWindow();
		::PostQuitMessage(nVal);
	}

	LRESULT OnTimer(UINT uMsg, WPARAM wParam, LPARAM lParam, BOOL& bHandled)
	{
		if(m_running){
			m_number = rand()%800+1;
			Invalidate();
			UpdateWindow();
		}
		return 0;
	}

	void setFontByHeight(CFont& font, int fontHeight)
	{
		CLogFont logFont;
		WCHAR fontName[] = L"Arial";
        wcscpy(logFont.lfFaceName,fontName);
        logFont.lfHeight = fontHeight;
        logFont.lfItalic = FALSE;
        logFont.lfWeight = FW_BOLD;
        font.CreateFontIndirect(&logFont);
	}

	void onVkSpace()
	{
		if(m_running){
			m_running = FALSE;
			if(m_number>0 && m_number<=800){
				//m_output.Add(m_number);
				m_output.SetAtIndex(0, m_number);
				Invalidate();
				UpdateWindow();
			}
		}else
			m_running = TRUE;
	}

	void initNumbers()
	{
		m_number = 0;
		m_number_pos.x = 138;
		m_number_pos.y = 230;
		m_number_step = 93;

		setFontByHeight(m_font_number, 80);
	}

	void initOutput()
	{
		m_output.Add(0);
		m_output_pos.x = 380;
		m_output_pos.y = 420;
		m_output_step = 40;
		
		setFontByHeight(m_font_output, 50);
	}

	void startRandom(){
		m_running = TRUE;
		SetTimer ( 1, 100 );
	}
};

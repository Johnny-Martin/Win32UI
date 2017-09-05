/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * DialogRegion.h:
 *                Implementation of CDialogRegionT template class. This class
 *          helps to skin WTL dialog. You'll have to either add bitmap in the
 *          applications' resource OR provide path to bitmap file
 * 
 *  Written by Robin Debnath (d.robin@gmail.com)
 * ___________________________________________________________________________ 
 *
 *  This code may be used in compiled form in any way you desire. This
 *  file may be redistributed by any means PROVIDING it is 
 *  not sold for profit without the authors written consent, and 
 *  providing that this notice and the authors name is included. 
 *  
 *  This file is provided "as is" with no expressed or implied warranty.
 *  The author accepts no liability if it causes any damage to you or your
 *  computer whatsoever. It's free, so don't hassle me about it.
 * ___________________________________________________________________________ 
 *     
 *  __ USAGE _________________________________________________________________
 *   ________________________________________________________________________ 
 *  |WARNING: While working with static controls ensure that the application |
 *  |         does NOT request for common controls 6. In case the project is |
 *  |         manifested you'll have to remove it from your .rc file.        |
 *  |________________________________________________________________________|
 *
 *  In order to skin the Dialog follow the steps below after you include this
 *  header:
 *    ______________
 *      STEP #1: Inherit from this template making the dialog class as base 
 *      _______  for this template
 *
 *               class CMainDlg: public CDialogImpl<CMainDlg>, 
 *                               ...
 *                               ...
 *                               CDialogRegionT<CMainDlg>    // this is step1
 *               {
 *    ______________ 
 *      STEP #2: Add an entry in message map to chain the messages
 *      _______
 *               BEGIN_MSG_MAP(CMainDlg)
 *                   MESSAGE_HANDLER(WM_INITDIALOG, OnInitDialog)
 *                   ...
 *                   ...
 *                   CHAIN_MSG_MAP(CDialogRegionT<CMainDlg>) // this is step2
 *               END_MSG_MAP()
 *    ______________
 *      STEP #3: Set the skin file. You do this by adding the following line
 *      _______  in routine correscponding to WM_INITDIALOG message.
 *
 *               LRESULT CMainDlg::OnInitDialog(UINT uMsg, WPARAM wParam, 
 *                                              LPARAM lParam, BOOL& bHandled)
 *               {
 *                   SetBkBitmap(IDB_BITMAP, 
 *                                 RGB(255,255,0), false);   // this is step3
 *                   //
 *                   // Existing code
 *                   //
 *                   return TRUE;
 *               }
 *  __________________________________________________________________________
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 */


#pragma once

template <class T>
class CDialogRegionT
{
public:
	HRGN     m_hRgn;          // the bitmap region
	BITMAP   m_bmpInfo;       // contains bitmap info
	HDC      m_hdcBmp;        // bitmap device context
	CBitmap  m_Bitmap;        // the bitmap
	BOOL     m_bIsRgnSet;     // Indicates if the region is set
	BOOL     m_bDlgMove;      // Indicates if dialog can be moved by clicking
	                          //  and dragging on any part of dialog
	COLORREF m_crTransparent; // the color which is to be drawn as transparent
public:	

	BEGIN_MSG_MAP(CMainDlg)
		MESSAGE_HANDLER(WM_ERASEBKGND, OnEraseBkGnd)
		MESSAGE_HANDLER(WM_CTLCOLORSTATIC, OnCtlColorStatic)
		MESSAGE_HANDLER(WM_NCHITTEST, OnNCHitTest)
	END_MSG_MAP()

	CDialogRegionT()
	{
		m_bIsRgnSet		= FALSE;
		m_bDlgMove		= FALSE;
		m_hRgn			= NULL;
		m_crTransparent = RGB(255, 0, 255);
	}
	
	~CDialogRegionT()
	{
		if(m_hRgn)
			DeleteObject(m_hRgn);
		if(m_Bitmap)
			m_Bitmap.DeleteObject();
	}


	bool SetDialogRegion()
	{
		T* pT = static_cast<T*>(this);

		// Set the window region
		int iRet = pT->SetWindowRgn( m_hRgn, TRUE );

		if( iRet == 0 )
			return false;	// Ups something went wrong

		int iX  = (GetSystemMetrics(SM_CXSCREEN)) / 2 - (m_bmpInfo.bmWidth / 2);
		int iY  = (GetSystemMetrics(SM_CYSCREEN)) / 2 - (m_bmpInfo.bmHeight / 2);
		
		// Size the window to the size of bitmap
		iRet = pT->SetWindowPos( HWND_NOTOPMOST , iX, iY, m_bmpInfo.bmWidth, m_bmpInfo.bmHeight, NULL );

		m_bIsRgnSet = true;

		return true;
	}

	bool GenerateRegion()
	{
		m_hdcBmp = CreateCompatibleDC(NULL);

		// Get info about the bitmap 
		GetObject(m_Bitmap, sizeof(m_bmpInfo), &m_bmpInfo);
		HGDIOBJ hGdiObj = SelectObject(m_hdcBmp, m_Bitmap);
		m_hRgn = CreateRectRgn(0,0,0,0);

		int iX = 0;
		int iRet = 0;
		for (int iY = 0; iY < m_bmpInfo.bmHeight; iY++)
		{
			do
			{
				while ( iX < m_bmpInfo.bmWidth && GetPixel(m_hdcBmp, iX, iY) == m_crTransparent )
					iX++;
				int iLeftX = iX;
				while ( iX < m_bmpInfo.bmWidth && GetPixel(m_hdcBmp, iX, iY) != m_crTransparent )
					++iX;
				HRGN hRgnTemp = CreateRectRgn(iLeftX, iY, iX, iY+1);
				iRet = CombineRgn(m_hRgn, m_hRgn, hRgnTemp, RGN_OR);
				if(iRet == ERROR)
				{
					return false;
				}

				//delete the temp region for next pass
				DeleteObject(hRgnTemp);
			}while(iX < m_bmpInfo.bmWidth);
			iX = 0;
		}
		
		return true;
	}
	
	bool SetBKBitmap(unsigned int iResourceID, COLORREF crTransparent, bool bDlgMove = true)
	{
		m_crTransparent	= crTransparent;
		return SetBKBitmap(iResourceID, bDlgMove);
	}

	bool SetBKBitmap(unsigned int iResourceID, bool bDlgMove = true)
	{
		bool bRetVal = false;
		
		ATLASSERT(m_Bitmap == NULL);
		// Load the resource bitmap image
		m_Bitmap.LoadBitmap(iResourceID);

		bRetVal	= processBitmap();
		
		if( bRetVal )
			m_bDlgMove = bDlgMove;

		return bRetVal;
	}

	bool SetBKBitmap(LPCTSTR szBMPfileName, COLORREF crTransparent, bool bDlgMove = true)
	{
		m_crTransparent	= crTransparent;
		return SetBKBitmap(szBMPfileName, bDlgMove);
	}

	bool SetBKBitmap(LPCTSTR szBMPfileName, bool bDlgMove = true)
	{
		bool bRetVal = false;
	
		ATLASSERT(m_Bitmap == NULL);
		// Load the bitmap image
		m_Bitmap = (HBITMAP)LoadImage(GetModuleHandle(NULL), szBMPfileName, IMAGE_BITMAP, 0, 0, LR_LOADFROMFILE);
		
		bRetVal	= processBitmap();
		
		if( bRetVal )
			m_bDlgMove = bDlgMove;

		return bRetVal;
	}

	bool processBitmap()
	{
		T* pT = static_cast<T*>(this);

		long oldWinStyle = pT->GetWindowLong(GWL_STYLE);

		if(m_Bitmap == NULL)
			return false;		// Ups we dont have a bitmap image

		// Set the window style to WS_POPUPWINDOW and remove borders
		int iRetVal	= pT->SetWindowLong( GWL_STYLE,  oldWinStyle & WS_POPUPWINDOW & ~WS_BORDER );

		if(iRetVal == 0)
		{
			// Something went wrong
			m_Bitmap.DeleteObject();
			return false;
		}

		if( !GenerateRegion() )
		{
			// Something went wrong, set the old window style
			pT->SetWindowLong( GWL_STYLE, oldWinStyle );
			return false;
		}
		
		// set the region for dialog
		SetDialogRegion();

		return true;
	}

	LRESULT OnEraseBkGnd(UINT /*uMsg*/, WPARAM wParam, LPARAM /*lParam*/, BOOL& bHandled)
	{
		if(m_bIsRgnSet)
		{
			HDC hDC = (HDC) wParam;
			BitBlt(hDC, 0, 0, m_bmpInfo.bmWidth, m_bmpInfo.bmHeight, m_hdcBmp, 0, 0, SRCCOPY);
		}
		bHandled = m_bIsRgnSet;
		return 0;
	}

	LRESULT OnCtlColorStatic(UINT /*uMsg*/, WPARAM wParam, LPARAM /*lParam*/, BOOL& bHandled)
	{
		// We handle this message only if we have set the region
		bHandled = m_bIsRgnSet;

		if(m_bIsRgnSet)
		{
			::SetBkMode((HDC)wParam, TRANSPARENT);
			return (LRESULT) GetStockObject (HOLLOW_BRUSH);
		}
		return 0;
	}

	LRESULT OnNCHitTest(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& bHandled)
	{
		// We handle this message only if we have set the region
		bHandled = m_bIsRgnSet;

		if(m_bDlgMove)	// check if we can move the dialog
		{
			return HTCAPTION;
		}
		else
		{
			return 0;
		}
	}
};

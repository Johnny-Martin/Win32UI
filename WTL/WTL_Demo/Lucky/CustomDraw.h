/*
  A simple class, used for creating a custom drawn pushbutton with the CMemDC
  class.
*/


//  Guard against multiple inclusion.
#ifndef CUSTOMBUTTON_H
#define CUSTOMBUTTON_H


//  Allow the header precompiler to work more efficiently.
#if _MSC_VER >= 1000
#pragma once
#endif // _MSC_VER >= 1000

#include "MemDC.h"

//  Custom drawn button class.
class CCustDraw : public CWindowImpl< CCustDraw, CStatic >
{
public:

  //  Constructor
  CCustDraw( )
  : CWindowImpl< CCustDraw, CStatic >( )
  , m_memDC( 0 )
  {
  }

  //  Destructor
  virtual ~CCustDraw( )
  {
    if( m_memDC )
    {
      delete m_memDC;
    }
  }

  //  Called to subclass the window in the dialog's WM_INITDIALOG handler.
  BOOL SubclassWindow( HWND hWnd )
  {
    return( CWindowImpl< CCustDraw, CStatic >::SubclassWindow( hWnd ) );
  }

  //  Message map, using WTL extended message cracking.
  BEGIN_MSG_MAP(CCustDraw)
    MESSAGE_HANDLER(WM_PAINT, OnPaint)
  END_MSG_MAP( )

  //  Update the button
  LRESULT OnPaint(UINT /*uMsg*/, WPARAM /*wParam*/, LPARAM /*lParam*/, BOOL& /*bHandled*/)
  {
	CPaintDC dc(m_hWnd);
	dc.SetBkMode(TRANSPARENT);
    //  Create the memory DC if it doesn't already exist.
    if( ! m_memDC )
    {
      m_memDC = new CMemDC( m_hWnd );
      m_memDC->SelectStockFont( DEFAULT_GUI_FONT );
	  //m_memDC->SetBkMode(TRANSPARENT);
	  m_memDC->SetTextColor(RGB(255,0,0));
      //m_memDC->SetBkColor( GetSysColor( COLOR_BTNFACE ) );
    }

    //  Generate the button using the memory DC.
    RECT cRect;
    GetClientRect( &cRect );
    m_memDC->FillSolidRect( &cRect, GetSysColor( COLOR_BTNFACE ) );
    m_memDC->DrawEdge( &cRect, EDGE_ETCHED, BF_ADJUST | BF_RECT );
	m_memDC->TextOut(0, 0, "I'm custom drawn.");

    m_memDC->Paint( );
	
	return 0;
  }


private:

  //  The invisible DC to draw on.
  CMemDC* m_memDC;
};


#endif // CUSTOMBUTTON_H
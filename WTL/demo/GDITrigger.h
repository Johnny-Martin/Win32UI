#pragma once
#include "stdafx.h"

class GDITrigger
{
public:
	static void Init();
	~GDITrigger();
private:
	GDITrigger();
	static ULONG_PTR m_gdiplusToken;
	static GdiplusStartupInput m_gdiStartupInput;
};
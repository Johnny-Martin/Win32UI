#include "stdafx.h"
#include "GDITrigger.h"

ULONG_PTR GDITrigger::m_gdiplusToken = ULONG_PTR{};
GdiplusStartupInput GDITrigger::m_gdiStartupInput = GdiplusStartupInput{};

void GDITrigger::Init()
{
	static GDITrigger tigger;
}

GDITrigger::GDITrigger()
{
	GdiplusStartup(&m_gdiplusToken, &m_gdiStartupInput, NULL);
}

GDITrigger::~GDITrigger()
{
	GdiplusShutdown(m_gdiplusToken);
}
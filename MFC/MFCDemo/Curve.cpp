#include"stdafx.h"
#include"Curve.h"

using namespace BaseElement;

Curve::Curve(CDC* pDC, int iMaxPointCount, int iLineWidth):
	m_vecPoints(),
	m_cursor(), 
	m_iCursor(0),
	m_pen(PS_SOLID, 1, RGB(255, 0, 255))
{
	m_pDC = pDC;
	m_iMaxPointCount = iMaxPointCount;
	m_iLineWidth = iLineWidth;

	m_pDC->SelectObject(m_pen);
}

void Curve::AddNewPoint(int x, int y)
{
	if (m_vecPoints.size() > 10240)
		return;

	m_vecPoints.push_back(std::pair<int, int>(x, y));
	
	Draw();
}

void Curve::Draw()
{
	if (m_vecPoints.empty() || m_vecPoints.size() == 1)
	{
		return;
	}

	while (m_iCursor + 1 != m_vecPoints.size())
	{
		std::pair<int, int> pointA = m_vecPoints[m_iCursor];
		std::pair<int, int> pointB = m_vecPoints[++m_iCursor];

		Draw(pointA, pointB);
	}
}

void Curve::Draw(std::pair<int, int> pointA, std::pair<int, int> pointB)
{
	m_pDC->MoveTo(pointA.first, pointA.second);
	m_pDC->LineTo(pointB.first, pointB.second);
}
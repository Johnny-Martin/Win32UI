#pragma once

#include"stdafx.h"
#include"vector"

namespace BaseElement
{
	class Curve
	{
	public:
		Curve(CDC* pDC, int iMaxPointCount = 1024, int iLineWidth = 1);
		void AddNewPoint(int x, int y);
	private:
		void Draw();
		void Draw(std::pair<int, int> pointA, std::pair<int, int> pointB);
		std::vector<std::pair<int, int>> m_vecPoints;
		int m_iMaxPointCount;
		int m_iLineWidth;
		int m_iCursor;
		std::vector<std::pair<int, int>>::iterator m_cursor;
		CDC* m_pDC;
		CPen m_pen;
	};
}
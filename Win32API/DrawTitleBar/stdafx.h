#pragma once


#define WIN32_LEAN_AND_MEAN

#include <windows.h>
#include <stdlib.h>
#include <stdio.h>
#include <malloc.h>
#include <memory.h>
#include <tchar.h>

#include "skinwindow.h"
#include "resource.h"

#define SHOWINT(hWnd, i) \
	{\
	char buffer[10];\
	sprintf(buffer, "%d", i);\
	MessageBox(hWnd, buffer, "", MB_OK);\
	}

#define SHOWRECT(hWnd, rect) \
	{\
	char buffer[128];\
	sprintf(buffer, "RECT: left=%d, top=%d, right=%d, bottom=%d, width=%d, height=%d",\
	rect.left, rect.top, rect.right, rect.bottom, rect.right-rect.left, rect.bottom-rect.top);\
	MessageBox(hWnd, buffer, "", MB_OK);\
	}
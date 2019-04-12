/****************************************************************************
**
** Copyright (C) 2013 Digia Plc and/or its subsidiary(-ies).
** Contact: http://www.qt-project.org/legal
**
** This file is part of the Qt Solutions component.
**
** $QT_BEGIN_LICENSE:BSD$
** You may use this file under the terms of the BSD license as follows:
**
** "Redistribution and use in source and binary forms, with or without
** modification, are permitted provided that the following conditions are
** met:
**   * Redistributions of source code must retain the above copyright
**     notice, this list of conditions and the following disclaimer.
**   * Redistributions in binary form must reproduce the above copyright
**     notice, this list of conditions and the following disclaimer in
**     the documentation and/or other materials provided with the
**     distribution.
**   * Neither the name of Digia Plc and its Subsidiary(-ies) nor the names
**     of its contributors may be used to endorse or promote products derived
**     from this software without specific prior written permission.
**
**
** THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
** "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
** LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
** A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
** OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
** SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
** LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
** DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
** THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
** (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
** OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE."
**
** $QT_END_LICENSE$
**
****************************************************************************/

#include "qmfcapp.h"
#include "qwinwidget.h"

#include <QMessageBox>
#include <QTableWidget>
#include <windows.h>
#include <QPushButton>
#include <QVBoxLayout>

BOOL WINAPI DllMain( HINSTANCE hInstance, DWORD dwReason, LPVOID /*lpvReserved*/ )
{
    static bool ownApplication = FALSE;

    if ( dwReason == DLL_PROCESS_ATTACH )
	ownApplication = QMfcApp::pluginInstance( hInstance );
    if ( dwReason == DLL_PROCESS_DETACH && ownApplication )
	delete qApp;

    return TRUE;
}
QWinWidget *win;
extern "C" __declspec(dllexport) bool showDialog( HWND parent )
{
    win = new QWinWidget(parent);
    RECT r;
    GetWindowRect(parent, &r);
    QVBoxLayout *verticalLayout = new QVBoxLayout();
    verticalLayout->addWidget(new QPushButton(QObject::tr("按钮1")));
    verticalLayout->addWidget(new QPushButton(QObject::tr("按钮2")));
    verticalLayout->addWidget(new QPushButton(QObject::tr("按钮3")));
    win->setLayout(verticalLayout);
    win->setGeometry(0, 0,(r.right-r.left),(r.bottom-r.top));
    win->show();
//    QMessageBox::about( &win, "About QtMfc", "QtMfc Version 1.0\nCopyright (C) 2003" );

    return TRUE;
}

extern "C" __declspec(dllexport) bool showWind(HWND parent)
{
    win = new QWinWidget(parent);
    RECT r;
    GetWindowRect(parent, &r);
    QTableWidget *tb_widget = new QTableWidget(3,4,win);
    tb_widget->setEditTriggers(QAbstractItemView::NoEditTriggers);
    tb_widget->setSelectionBehavior(QAbstractItemView::SelectRows);

    QStringList headerLabels;
    headerLabels << "Name" << "StartOrder" << "EndOrder" << "TaskType";
    tb_widget->setHorizontalHeaderLabels(headerLabels);
    tb_widget->setItem(0,0,new QTableWidgetItem("101"));
    tb_widget->setItem(0,1,new QTableWidgetItem("1"));
    tb_widget->setItem(0,2,new QTableWidgetItem("1"));
    tb_widget->setItem(0,3,new QTableWidgetItem("MF"));
    tb_widget->setItem(1,0,new QTableWidgetItem("102"));
    tb_widget->setItem(1,1,new QTableWidgetItem("2"));
    tb_widget->setItem(1,2,new QTableWidgetItem("2"));
    tb_widget->setItem(1,3,new QTableWidgetItem("LD"));
    tb_widget->setItem(2,0,new QTableWidgetItem("103"));
    tb_widget->setItem(2,1,new QTableWidgetItem("3"));
    tb_widget->setItem(2,2,new QTableWidgetItem("3"));
    tb_widget->setItem(2,3,new QTableWidgetItem("ASW"));
    tb_widget->show();
    tb_widget->resize((r.right-r.left),(r.bottom-r.top));
    QVBoxLayout *verticalLayout = new QVBoxLayout(win);
    verticalLayout->addWidget(tb_widget);

    win->setGeometry(0, 0,(r.right-r.left),(r.bottom-r.top));
    win->show();
    return true;
}

extern "C" __declspec(dllexport) void destoryWin()
{
    delete win;
    win =NULL;
}

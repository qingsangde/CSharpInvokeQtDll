TEMPLATE     = lib
CONFIG	    += dll

HEADERS     +=qmfcapp.h\
              qwinwidget.h

SOURCES	     += main.cpp\
                qmfcapp.cpp\
                qwinwidget.cpp

TARGET	     = qtdll
DLLDESTDIR   = $$[QT_INSTALL_PREFIX]/bin
contains(QT_MAJOR_VERSION, 5): QT += widgets gui-private


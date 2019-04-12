TEMPLATE     = lib
CONFIG	    += dll
SOURCES	     = main.cpp

TARGET	     = qtdialog
DLLDESTDIR   = $$[QT_INSTALL_PREFIX]/bin
#include(../../src/qtwinmigrate.pri)
include(E:/Qt/Project/qt-solutions-master/qtwinmigrate/src/qtwinmigrate.pri)

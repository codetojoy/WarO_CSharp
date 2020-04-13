#!/bin/bash

dotnet clean

if [ $? -ne "0" ]
then
    echo "TRACER: error [clean] "
    exit -1
fi

dotnet build

if [ $? -ne "0" ]
then
    echo "TRACER: error [build] "
    exit -1
fi

dotnet test

if [ $? -ne "0" ]
then
    echo "TRACER: error [test] "
    exit -1
fi

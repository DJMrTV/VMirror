#ifndef VMIRROR_VCLASS
#define VMIRROR_VCLASS

#define VClass();
#include"ClassInfo.h"


namespace VMirror{
    class VClass{
    public:
        inline ClassInfo* GetClassInfo(){
            return ReflectionInfo;
        };
    protected:
        ClassInfo ReflectionInfo;
    }
}

#endif
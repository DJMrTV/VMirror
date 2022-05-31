#ifndef VMIRROR_CLASSINFO
#define VMIRROR_CLASSINFO
#include<map>
#include<string>
#include<functional>

namespace VMirror{ 
    struct ClassInfo{
        std::map<std::string,std::function(void*(void*))> Functions;
    };
}

#endif
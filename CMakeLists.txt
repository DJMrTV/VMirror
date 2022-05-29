#DO NOT TRY TO COMPILE VMIRROR USING CMAKE IT WILL FAIL
#THIS IS JUST FOR MAKING IT EASY TO USE WITH CMAKE

message("This will not compile VMirror this file is just for including VMirror in cmake projects")

add_library(VMirror INTERFACE)
target_include_directories(VMirror INTERFACE include/)
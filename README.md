# MPUtl
Multi-purpose Utility for Multi-media creation and editing

## Branches
* Code: Actual program codes in the ``Code`` folder and build systems in ``Build`` folder
* Concepts: Concepts, drafts... note that most materials here will be deleted when approaching release. Feel free to use it to elaborate your idea.

## Participation
* Every participant will be granted "member" right
* Any individual welcomes, as long as you reads and writes simple English
* Language: make sure you read and write comprehensible English! Writing is CJK, Spanish, Russian... you have to pray me and other participants can read!

## Spec and coding practice
* Main language: C++11 (C++14 syntax is on hold until major compilers all support it)
* Recommended compilers: GCC/Mingw (>=4.9), VS2013-SP5/VS2015-SP1, Clang any recent version(for Mac)
* API: C++ with C-wrapper
* GUI: Any technology welcome, just put them in a separate folder
* Commenting style: use triple-slash and asterisk ``///* Comment *///``
* Disabling a few lines of code: both ``//`` and ``/* */`` acceptable
* use of ``auto`` and ``var``: do not abuse! Use unless the code would otherwise be lengthy or unsafe.
* Disabling a large block of code: enclose the code in 
```
#ifdef __CODEOFF__ 
#define
std::cout<< "Old codes"<<std::endl;
#endif
```


# MPUtl
Multi-purpose Utility for Multi-media creation and editing

## Ultimatum
* To produce an NLE similar to AviUtl with a small set of synth-like build-in functions
* Light and Simple
* 8K video capable
* Embrace HW-acceleration

## Branches
* Code: Actual program codes in the ``Code`` folder and build systems in ``Build`` folder
* Concepts: Concepts, drafts... note that most materials here will be deleted when approaching release. Feel free to use it to elaborate your idea.
* Actually I don't care what branch you create, do what you find useful.
 
## Forking
* If you intend creating a new project by forking this, and going to develop independently, stop. Just clone everything, rename the software name, change the namespace name, than upload to your own repo.
* Fork only if you are contributing to THIS repo, or when I abandon this project.

## Participation
* Every participant will be granted "collaborator" right
* Any individual welcomes, as long as you reads and writes simple English
* Language: make sure you read and write comprehensible English! Writing in CJK, Spanish, Russian... you have to pray me and other participants can read!(Though personally I can read Chinese and Japanese)

## Spec and coding practice
* Main language: C++11 (C++14 syntax is on hold until major compilers all support it)
* Recommended compilers: GCC/Mingw (>=4.9), VS2013-SP5/VS2015-SP1, Clang any recent version(for Mac)
* API: C++ with C-wrapper
* GUI: Any technology welcome, just put them in a separate folder
* Commenting style: use triple-slash and asterisk ``///* Comment *///``
* Disabling a few lines of code: both ``//`` and ``/* */`` acceptable
* use of ``auto`` and ``var``: do not abuse! Use unless the code would otherwise be lengthy or unsafe.
* Namespace assume: ```#define NS mu```, than whenever you need to reference it, use ```namespace NS {...}```
* Disabling a large block of code: enclose the code in 
```
#ifdef __CODEOFF__ 
#define
std::cout<< "Old codes"<<std::endl;
#endif
```

## License matter and dependencies
* __Small dependenices__ with MIT, GPLv2, CC, NoLicense, DWTFYW OK
* When really essential, can use heavier dependencies(e.g. dotNET, Qt) and other license
* Use of other commercial material should stay within __fair-use__ limit
* Pantented algorithm(e.g. SIFT, SURF), should be provided as optional source code to be compiled by user themselves


The above is declared for those who honor the idea of software license. Personally, I do not want to honor them. A "usage and distribution notice" written in plain English is the best IMO:

## Usage Rights
1. Do what the fuck you want with code here as long as: you are not selling it or claiming authorship/patent/copyright with 60% code unchanged
2. If you want to develop or sell something base on this, change the product name and namespace and any product/version string
3. redistributing with malicious code/components is FORBIDDEN and overrides Term.1
4. Copying snippnets of codes for your own use is allowed, but limit to 5 classes or 10 isolated functions
5. This declaration overrides GPL in places where software license or GPL is not legally honoured.


Sounds fair enough?

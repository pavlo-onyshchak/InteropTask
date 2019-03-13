// dllmain.h : Declaration of module class.

class CCOMCModule : public ATL::CAtlDllModuleT< CCOMCModule >
{
public :
	DECLARE_LIBID(LIBID_COMCLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_COMC, "{88F0EA17-3A3A-45F6-8631-971E26244D35}")
};

extern class CCOMCModule _AtlModule;

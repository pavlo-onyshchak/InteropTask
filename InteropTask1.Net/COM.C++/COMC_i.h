

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 8.00.0603 */
/* at Thu Mar 07 11:39:06 2019
 */
/* Compiler settings for COMC.idl:
    Oicf, W1, Zp8, env=Win32 (32b run), target_arch=X86 8.00.0603 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __COMC_i_h__
#define __COMC_i_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __IInteropTask_FWD_DEFINED__
#define __IInteropTask_FWD_DEFINED__
typedef interface IInteropTask IInteropTask;

#endif 	/* __IInteropTask_FWD_DEFINED__ */


#ifndef __InteropTask_FWD_DEFINED__
#define __InteropTask_FWD_DEFINED__

#ifdef __cplusplus
typedef class InteropTask InteropTask;
#else
typedef struct InteropTask InteropTask;
#endif /* __cplusplus */

#endif 	/* __InteropTask_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

#ifdef __cplusplus
extern "C"{
#endif 


#ifndef __IInteropTask_INTERFACE_DEFINED__
#define __IInteropTask_INTERFACE_DEFINED__

/* interface IInteropTask */
/* [unique][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_IInteropTask;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("8FCBC4E0-F7FF-499C-A3BA-FCC156910D65")
    IInteropTask : public IDispatch
    {
    public:
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE Call( void) = 0;
        
    };
    
    
#else 	/* C style interface */

    typedef struct IInteropTaskVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IInteropTask * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IInteropTask * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IInteropTask * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            IInteropTask * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            IInteropTask * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            IInteropTask * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            IInteropTask * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *Call )( 
            IInteropTask * This);
        
        END_INTERFACE
    } IInteropTaskVtbl;

    interface IInteropTask
    {
        CONST_VTBL struct IInteropTaskVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IInteropTask_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IInteropTask_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IInteropTask_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IInteropTask_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define IInteropTask_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define IInteropTask_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define IInteropTask_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define IInteropTask_Call(This)	\
    ( (This)->lpVtbl -> Call(This) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IInteropTask_INTERFACE_DEFINED__ */



#ifndef __COMCLib_LIBRARY_DEFINED__
#define __COMCLib_LIBRARY_DEFINED__

/* library COMCLib */
/* [version][uuid] */ 


EXTERN_C const IID LIBID_COMCLib;

EXTERN_C const CLSID CLSID_InteropTask;

#ifdef __cplusplus

class DECLSPEC_UUID("60F1B737-696D-4454-8DA8-72CB8C011831")
InteropTask;
#endif
#endif /* __COMCLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif



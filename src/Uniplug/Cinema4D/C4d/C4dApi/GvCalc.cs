//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace C4d {

public class GvCalc : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GvCalc(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GvCalc obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GvCalcTime time {
    set {
      C4dApiPINVOKE.GvCalc_time_set(swigCPtr, GvCalcTime.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.GvCalc_time_get(swigCPtr);
      GvCalcTime ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvCalcTime(cPtr, false);
      return ret;
    } 
  }

  public int cpu_count {
    set {
      C4dApiPINVOKE.GvCalc_cpu_count_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.GvCalc_cpu_count_get(swigCPtr);
      return ret;
    } 
  }

  public uint flags {
    set {
      C4dApiPINVOKE.GvCalc_flags_set(swigCPtr, value);
    } 
    get {
      uint ret = C4dApiPINVOKE.GvCalc_flags_get(swigCPtr);
      return ret;
    } 
  }

  public BaseDocument document {
    set {
      C4dApiPINVOKE.GvCalc_document_set(swigCPtr, BaseDocument.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.GvCalc_document_get(swigCPtr);
      BaseDocument ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
      return ret;
    } 
  }

  public GvNodeMaster master {
    set {
      C4dApiPINVOKE.GvCalc_master_set(swigCPtr, GvNodeMaster.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.GvCalc_master_get(swigCPtr);
      GvNodeMaster ret = (cPtr == global::System.IntPtr.Zero) ? null : new GvNodeMaster(cPtr, false);
      return ret;
    } 
  }

  public uint counter {
    set {
      C4dApiPINVOKE.GvCalc_counter_set(swigCPtr, value);
    } 
    get {
      uint ret = C4dApiPINVOKE.GvCalc_counter_get(swigCPtr);
      return ret;
    } 
  }

  public BaseThread thread {
    set {
      C4dApiPINVOKE.GvCalc_thread_set(swigCPtr, BaseThread.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.GvCalc_thread_get(swigCPtr);
      BaseThread ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseThread(cPtr, false);
      return ret;
    } 
  }

}

}

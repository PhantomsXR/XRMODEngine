using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityFusion.Runtime.Debugger
{
    public enum DebugMessageType
    {
        CSAttach,
        SCAttachResult,
        CSBindBreakpoint,
        SCBindBreakpointResult,
        SCModuleLoaded,
        SCThreadStarted,
        SCThreadEnded,
        SCBreakpointHit,
        CSSetBreakpointEnabled,
        CSSetBreakpointCondition,
        CSDeleteBreakpoint,
        CSExecute,
        CSStep,
        SCStepComplete,
        CSResolveVariable,
        SCResolveVariableResult,
        CSResolveIndexAccess,
        SCResolveIndexAccessResult,
        CSEnumChildren,
        SCEnumChildrenResult,
    }
}

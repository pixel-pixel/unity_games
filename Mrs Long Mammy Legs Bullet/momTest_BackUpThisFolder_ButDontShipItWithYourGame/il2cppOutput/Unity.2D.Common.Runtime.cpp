#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>




IL2CPP_EXTERN_C RuntimeClass* ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* PlanarGraph_t02FA29BC8B741D8D08171DFE1F302C9154F29DB4_il2cpp_TypeInfo_var;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t62F2920BAA1CE68D580A11BE01956F666E0D5D23 
{
};
struct Il2CppArrayBounds;

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// System.Double
struct Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F 
{
	// System.Double System.Double::m_value
	double ___m_value_0;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// UnityEngine.U2D.Common.UTess.ModuleHandle
struct ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4 
{
	union
	{
		struct
		{
		};
		uint8_t ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4__padding[1];
	};
};

struct ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_StaticFields
{
	// System.Int32 UnityEngine.U2D.Common.UTess.ModuleHandle::kMaxArea
	int32_t ___kMaxArea_0;
	// System.Int32 UnityEngine.U2D.Common.UTess.ModuleHandle::kMaxEdgeCount
	int32_t ___kMaxEdgeCount_1;
	// System.Int32 UnityEngine.U2D.Common.UTess.ModuleHandle::kMaxIndexCount
	int32_t ___kMaxIndexCount_2;
	// System.Int32 UnityEngine.U2D.Common.UTess.ModuleHandle::kMaxVertexCount
	int32_t ___kMaxVertexCount_3;
	// System.Int32 UnityEngine.U2D.Common.UTess.ModuleHandle::kMaxTriangleCount
	int32_t ___kMaxTriangleCount_4;
	// System.Int32 UnityEngine.U2D.Common.UTess.ModuleHandle::kMaxRefineIterations
	int32_t ___kMaxRefineIterations_5;
	// System.Int32 UnityEngine.U2D.Common.UTess.ModuleHandle::kMaxSmoothenIterations
	int32_t ___kMaxSmoothenIterations_6;
	// System.Single UnityEngine.U2D.Common.UTess.ModuleHandle::kIncrementAreaFactor
	float ___kIncrementAreaFactor_7;
};

// UnityEngine.U2D.Common.UTess.PlanarGraph
struct PlanarGraph_t02FA29BC8B741D8D08171DFE1F302C9154F29DB4 
{
	union
	{
		struct
		{
		};
		uint8_t PlanarGraph_t02FA29BC8B741D8D08171DFE1F302C9154F29DB4__padding[1];
	};
};

struct PlanarGraph_t02FA29BC8B741D8D08171DFE1F302C9154F29DB4_StaticFields
{
	// System.Double UnityEngine.U2D.Common.UTess.PlanarGraph::kEpsilon
	double ___kEpsilon_0;
	// System.Int32 UnityEngine.U2D.Common.UTess.PlanarGraph::kMaxIntersectionTolerance
	int32_t ___kMaxIntersectionTolerance_1;
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif



#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.U2D.Common.UTess.PlanarGraph::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlanarGraph__cctor_m6E671CF811569FAEEC64309C858362A053E3CC8C (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&PlanarGraph_t02FA29BC8B741D8D08171DFE1F302C9154F29DB4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private static readonly double kEpsilon = 0.00001;
		((PlanarGraph_t02FA29BC8B741D8D08171DFE1F302C9154F29DB4_StaticFields*)il2cpp_codegen_static_fields_for(PlanarGraph_t02FA29BC8B741D8D08171DFE1F302C9154F29DB4_il2cpp_TypeInfo_var))->___kEpsilon_0 = (1.0000000000000001E-05);
		// private static readonly int kMaxIntersectionTolerance = 4;  // Maximum Intersection Tolerance per Intersection Loop Check.
		((PlanarGraph_t02FA29BC8B741D8D08171DFE1F302C9154F29DB4_StaticFields*)il2cpp_codegen_static_fields_for(PlanarGraph_t02FA29BC8B741D8D08171DFE1F302C9154F29DB4_il2cpp_TypeInfo_var))->___kMaxIntersectionTolerance_1 = 4;
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.U2D.Common.UTess.ModuleHandle::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ModuleHandle__cctor_mAA8143797E18A75DC8FF19496E58B7064C2F85CA (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// internal static readonly  int kMaxArea = 65536;
		((ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_StaticFields*)il2cpp_codegen_static_fields_for(ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_il2cpp_TypeInfo_var))->___kMaxArea_0 = ((int32_t)65536);
		// internal static readonly  int kMaxEdgeCount = 65536;
		((ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_StaticFields*)il2cpp_codegen_static_fields_for(ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_il2cpp_TypeInfo_var))->___kMaxEdgeCount_1 = ((int32_t)65536);
		// internal static readonly  int kMaxIndexCount = 65536;
		((ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_StaticFields*)il2cpp_codegen_static_fields_for(ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_il2cpp_TypeInfo_var))->___kMaxIndexCount_2 = ((int32_t)65536);
		// internal static readonly  int kMaxVertexCount = 65536;
		((ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_StaticFields*)il2cpp_codegen_static_fields_for(ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_il2cpp_TypeInfo_var))->___kMaxVertexCount_3 = ((int32_t)65536);
		// internal static readonly  int kMaxTriangleCount = kMaxIndexCount / 3;
		int32_t L_0 = ((ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_StaticFields*)il2cpp_codegen_static_fields_for(ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_il2cpp_TypeInfo_var))->___kMaxIndexCount_2;
		((ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_StaticFields*)il2cpp_codegen_static_fields_for(ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_il2cpp_TypeInfo_var))->___kMaxTriangleCount_4 = ((int32_t)(L_0/3));
		// internal static readonly  int kMaxRefineIterations = 48;
		((ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_StaticFields*)il2cpp_codegen_static_fields_for(ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_il2cpp_TypeInfo_var))->___kMaxRefineIterations_5 = ((int32_t)48);
		// internal static readonly  int kMaxSmoothenIterations = 256;
		((ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_StaticFields*)il2cpp_codegen_static_fields_for(ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_il2cpp_TypeInfo_var))->___kMaxSmoothenIterations_6 = ((int32_t)256);
		// internal static readonly  float kIncrementAreaFactor = 1.2f;
		((ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_StaticFields*)il2cpp_codegen_static_fields_for(ModuleHandle_t2F8BE4233858E78501EF0B4D650CECD9A6D5D9F4_il2cpp_TypeInfo_var))->___kIncrementAreaFactor_7 = (1.20000005f);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif

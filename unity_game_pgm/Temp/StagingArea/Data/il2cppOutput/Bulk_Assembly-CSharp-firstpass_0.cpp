#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>
#include <stdint.h>

#include "class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "object-internals.h"

// AspectUtility
struct AspectUtility_t3786687708;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t1158329972;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// System.String
struct String_t;
// UnityEngine.Camera
struct Camera_t189460977;
// UnityEngine.Object
struct Object_t1021602117;
// UnityEngine.Component
struct Component_t3819376471;
// System.Type
struct Type_t;
// System.Type[]
struct TypeU5BU5D_t1664964607;
// UnityEngine.Event
struct Event_t3028476042;
// System.Char[]
struct CharU5BU5D_t1328083999;
// System.Void
struct Void_t1841601450;
// System.Collections.Generic.Dictionary`2<System.String,System.Int32>
struct Dictionary_2_t3986656710;
// System.Reflection.MemberFilter
struct MemberFilter_t3405857066;
// UnityEngine.Camera/CameraCallback
struct CameraCallback_t834278767;

extern RuntimeClass* AspectUtility_t3786687708_il2cpp_TypeInfo_var;
extern RuntimeClass* Object_t1021602117_il2cpp_TypeInfo_var;
extern RuntimeClass* Debug_t1368543263_il2cpp_TypeInfo_var;
extern const RuntimeMethod* GameObject_GetComponent_TisCamera_t189460977_m3191350607_RuntimeMethod_var;
extern Il2CppCodeGenString* _stringLiteral2115673192;
extern Il2CppCodeGenString* _stringLiteral368387673;
extern const uint32_t AspectUtility_Awake_m3454187054_MetadataUsageId;
extern const RuntimeType* Camera_t189460977_0_0_0_var;
extern RuntimeClass* TypeU5BU5D_t1664964607_il2cpp_TypeInfo_var;
extern RuntimeClass* Type_t_il2cpp_TypeInfo_var;
extern RuntimeClass* GameObject_t1756533147_il2cpp_TypeInfo_var;
extern Il2CppCodeGenString* _stringLiteral3668015021;
extern const uint32_t AspectUtility_SetCamera_m3455514222_MetadataUsageId;
extern const uint32_t AspectUtility_get_screenHeight_m4082636461_MetadataUsageId;
extern const uint32_t AspectUtility_get_screenWidth_m3292602408_MetadataUsageId;
extern const uint32_t AspectUtility_get_xOffset_m1312947939_MetadataUsageId;
extern const uint32_t AspectUtility_get_yOffset_m1321033700_MetadataUsageId;
extern const uint32_t AspectUtility_get_screenRect_m1015244010_MetadataUsageId;
extern RuntimeClass* Input_t1785128008_il2cpp_TypeInfo_var;
extern const uint32_t AspectUtility_get_mousePosition_m2609004116_MetadataUsageId;
extern RuntimeClass* Mathf_t2336485820_il2cpp_TypeInfo_var;
extern const uint32_t AspectUtility_get_guiMousePosition_m4219141168_MetadataUsageId;

struct TypeU5BU5D_t1664964607;


#ifndef RUNTIMEOBJECT_H
#define RUNTIMEOBJECT_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEOBJECT_H
#ifndef U3CMODULEU3E_T3783534232_H
#define U3CMODULEU3E_T3783534232_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct  U3CModuleU3E_t3783534232 
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // U3CMODULEU3E_T3783534232_H
#ifndef VALUETYPE_T3507792607_H
#define VALUETYPE_T3507792607_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ValueType
struct  ValueType_t3507792607  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t3507792607_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t3507792607_marshaled_com
{
};
#endif // VALUETYPE_T3507792607_H
struct Il2CppArrayBounds;
#ifndef RUNTIMEARRAY_H
#define RUNTIMEARRAY_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Array

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEARRAY_H
#ifndef STRING_T_H
#define STRING_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.String
struct  String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::length
	int32_t ___length_0;
	// System.Char System.String::start_char
	Il2CppChar ___start_char_1;

public:
	inline static int32_t get_offset_of_length_0() { return static_cast<int32_t>(offsetof(String_t, ___length_0)); }
	inline int32_t get_length_0() const { return ___length_0; }
	inline int32_t* get_address_of_length_0() { return &___length_0; }
	inline void set_length_0(int32_t value)
	{
		___length_0 = value;
	}

	inline static int32_t get_offset_of_start_char_1() { return static_cast<int32_t>(offsetof(String_t, ___start_char_1)); }
	inline Il2CppChar get_start_char_1() const { return ___start_char_1; }
	inline Il2CppChar* get_address_of_start_char_1() { return &___start_char_1; }
	inline void set_start_char_1(Il2CppChar value)
	{
		___start_char_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_2;
	// System.Char[] System.String::WhiteChars
	CharU5BU5D_t1328083999* ___WhiteChars_3;

public:
	inline static int32_t get_offset_of_Empty_2() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_2)); }
	inline String_t* get_Empty_2() const { return ___Empty_2; }
	inline String_t** get_address_of_Empty_2() { return &___Empty_2; }
	inline void set_Empty_2(String_t* value)
	{
		___Empty_2 = value;
		Il2CppCodeGenWriteBarrier((&___Empty_2), value);
	}

	inline static int32_t get_offset_of_WhiteChars_3() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___WhiteChars_3)); }
	inline CharU5BU5D_t1328083999* get_WhiteChars_3() const { return ___WhiteChars_3; }
	inline CharU5BU5D_t1328083999** get_address_of_WhiteChars_3() { return &___WhiteChars_3; }
	inline void set_WhiteChars_3(CharU5BU5D_t1328083999* value)
	{
		___WhiteChars_3 = value;
		Il2CppCodeGenWriteBarrier((&___WhiteChars_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STRING_T_H
#ifndef MEMBERINFO_T_H
#define MEMBERINFO_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.MemberInfo
struct  MemberInfo_t  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MEMBERINFO_T_H
#ifndef ENUM_T2459695545_H
#define ENUM_T2459695545_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Enum
struct  Enum_t2459695545  : public ValueType_t3507792607
{
public:

public:
};

struct Enum_t2459695545_StaticFields
{
public:
	// System.Char[] System.Enum::split_char
	CharU5BU5D_t1328083999* ___split_char_0;

public:
	inline static int32_t get_offset_of_split_char_0() { return static_cast<int32_t>(offsetof(Enum_t2459695545_StaticFields, ___split_char_0)); }
	inline CharU5BU5D_t1328083999* get_split_char_0() const { return ___split_char_0; }
	inline CharU5BU5D_t1328083999** get_address_of_split_char_0() { return &___split_char_0; }
	inline void set_split_char_0(CharU5BU5D_t1328083999* value)
	{
		___split_char_0 = value;
		Il2CppCodeGenWriteBarrier((&___split_char_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t2459695545_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t2459695545_marshaled_com
{
};
#endif // ENUM_T2459695545_H
#ifndef INT32_T2071877448_H
#define INT32_T2071877448_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Int32
struct  Int32_t2071877448 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_2;

public:
	inline static int32_t get_offset_of_m_value_2() { return static_cast<int32_t>(offsetof(Int32_t2071877448, ___m_value_2)); }
	inline int32_t get_m_value_2() const { return ___m_value_2; }
	inline int32_t* get_address_of_m_value_2() { return &___m_value_2; }
	inline void set_m_value_2(int32_t value)
	{
		___m_value_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INT32_T2071877448_H
#ifndef COLOR_T2020392075_H
#define COLOR_T2020392075_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Color
struct  Color_t2020392075 
{
public:
	// System.Single UnityEngine.Color::r
	float ___r_0;
	// System.Single UnityEngine.Color::g
	float ___g_1;
	// System.Single UnityEngine.Color::b
	float ___b_2;
	// System.Single UnityEngine.Color::a
	float ___a_3;

public:
	inline static int32_t get_offset_of_r_0() { return static_cast<int32_t>(offsetof(Color_t2020392075, ___r_0)); }
	inline float get_r_0() const { return ___r_0; }
	inline float* get_address_of_r_0() { return &___r_0; }
	inline void set_r_0(float value)
	{
		___r_0 = value;
	}

	inline static int32_t get_offset_of_g_1() { return static_cast<int32_t>(offsetof(Color_t2020392075, ___g_1)); }
	inline float get_g_1() const { return ___g_1; }
	inline float* get_address_of_g_1() { return &___g_1; }
	inline void set_g_1(float value)
	{
		___g_1 = value;
	}

	inline static int32_t get_offset_of_b_2() { return static_cast<int32_t>(offsetof(Color_t2020392075, ___b_2)); }
	inline float get_b_2() const { return ___b_2; }
	inline float* get_address_of_b_2() { return &___b_2; }
	inline void set_b_2(float value)
	{
		___b_2 = value;
	}

	inline static int32_t get_offset_of_a_3() { return static_cast<int32_t>(offsetof(Color_t2020392075, ___a_3)); }
	inline float get_a_3() const { return ___a_3; }
	inline float* get_address_of_a_3() { return &___a_3; }
	inline void set_a_3(float value)
	{
		___a_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // COLOR_T2020392075_H
#ifndef VECTOR3_T2243707580_H
#define VECTOR3_T2243707580_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Vector3
struct  Vector3_t2243707580 
{
public:
	// System.Single UnityEngine.Vector3::x
	float ___x_1;
	// System.Single UnityEngine.Vector3::y
	float ___y_2;
	// System.Single UnityEngine.Vector3::z
	float ___z_3;

public:
	inline static int32_t get_offset_of_x_1() { return static_cast<int32_t>(offsetof(Vector3_t2243707580, ___x_1)); }
	inline float get_x_1() const { return ___x_1; }
	inline float* get_address_of_x_1() { return &___x_1; }
	inline void set_x_1(float value)
	{
		___x_1 = value;
	}

	inline static int32_t get_offset_of_y_2() { return static_cast<int32_t>(offsetof(Vector3_t2243707580, ___y_2)); }
	inline float get_y_2() const { return ___y_2; }
	inline float* get_address_of_y_2() { return &___y_2; }
	inline void set_y_2(float value)
	{
		___y_2 = value;
	}

	inline static int32_t get_offset_of_z_3() { return static_cast<int32_t>(offsetof(Vector3_t2243707580, ___z_3)); }
	inline float get_z_3() const { return ___z_3; }
	inline float* get_address_of_z_3() { return &___z_3; }
	inline void set_z_3(float value)
	{
		___z_3 = value;
	}
};

struct Vector3_t2243707580_StaticFields
{
public:
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t2243707580  ___zeroVector_4;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t2243707580  ___oneVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t2243707580  ___upVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t2243707580  ___downVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t2243707580  ___leftVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t2243707580  ___rightVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t2243707580  ___forwardVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t2243707580  ___backVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t2243707580  ___positiveInfinityVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t2243707580  ___negativeInfinityVector_13;

public:
	inline static int32_t get_offset_of_zeroVector_4() { return static_cast<int32_t>(offsetof(Vector3_t2243707580_StaticFields, ___zeroVector_4)); }
	inline Vector3_t2243707580  get_zeroVector_4() const { return ___zeroVector_4; }
	inline Vector3_t2243707580 * get_address_of_zeroVector_4() { return &___zeroVector_4; }
	inline void set_zeroVector_4(Vector3_t2243707580  value)
	{
		___zeroVector_4 = value;
	}

	inline static int32_t get_offset_of_oneVector_5() { return static_cast<int32_t>(offsetof(Vector3_t2243707580_StaticFields, ___oneVector_5)); }
	inline Vector3_t2243707580  get_oneVector_5() const { return ___oneVector_5; }
	inline Vector3_t2243707580 * get_address_of_oneVector_5() { return &___oneVector_5; }
	inline void set_oneVector_5(Vector3_t2243707580  value)
	{
		___oneVector_5 = value;
	}

	inline static int32_t get_offset_of_upVector_6() { return static_cast<int32_t>(offsetof(Vector3_t2243707580_StaticFields, ___upVector_6)); }
	inline Vector3_t2243707580  get_upVector_6() const { return ___upVector_6; }
	inline Vector3_t2243707580 * get_address_of_upVector_6() { return &___upVector_6; }
	inline void set_upVector_6(Vector3_t2243707580  value)
	{
		___upVector_6 = value;
	}

	inline static int32_t get_offset_of_downVector_7() { return static_cast<int32_t>(offsetof(Vector3_t2243707580_StaticFields, ___downVector_7)); }
	inline Vector3_t2243707580  get_downVector_7() const { return ___downVector_7; }
	inline Vector3_t2243707580 * get_address_of_downVector_7() { return &___downVector_7; }
	inline void set_downVector_7(Vector3_t2243707580  value)
	{
		___downVector_7 = value;
	}

	inline static int32_t get_offset_of_leftVector_8() { return static_cast<int32_t>(offsetof(Vector3_t2243707580_StaticFields, ___leftVector_8)); }
	inline Vector3_t2243707580  get_leftVector_8() const { return ___leftVector_8; }
	inline Vector3_t2243707580 * get_address_of_leftVector_8() { return &___leftVector_8; }
	inline void set_leftVector_8(Vector3_t2243707580  value)
	{
		___leftVector_8 = value;
	}

	inline static int32_t get_offset_of_rightVector_9() { return static_cast<int32_t>(offsetof(Vector3_t2243707580_StaticFields, ___rightVector_9)); }
	inline Vector3_t2243707580  get_rightVector_9() const { return ___rightVector_9; }
	inline Vector3_t2243707580 * get_address_of_rightVector_9() { return &___rightVector_9; }
	inline void set_rightVector_9(Vector3_t2243707580  value)
	{
		___rightVector_9 = value;
	}

	inline static int32_t get_offset_of_forwardVector_10() { return static_cast<int32_t>(offsetof(Vector3_t2243707580_StaticFields, ___forwardVector_10)); }
	inline Vector3_t2243707580  get_forwardVector_10() const { return ___forwardVector_10; }
	inline Vector3_t2243707580 * get_address_of_forwardVector_10() { return &___forwardVector_10; }
	inline void set_forwardVector_10(Vector3_t2243707580  value)
	{
		___forwardVector_10 = value;
	}

	inline static int32_t get_offset_of_backVector_11() { return static_cast<int32_t>(offsetof(Vector3_t2243707580_StaticFields, ___backVector_11)); }
	inline Vector3_t2243707580  get_backVector_11() const { return ___backVector_11; }
	inline Vector3_t2243707580 * get_address_of_backVector_11() { return &___backVector_11; }
	inline void set_backVector_11(Vector3_t2243707580  value)
	{
		___backVector_11 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_12() { return static_cast<int32_t>(offsetof(Vector3_t2243707580_StaticFields, ___positiveInfinityVector_12)); }
	inline Vector3_t2243707580  get_positiveInfinityVector_12() const { return ___positiveInfinityVector_12; }
	inline Vector3_t2243707580 * get_address_of_positiveInfinityVector_12() { return &___positiveInfinityVector_12; }
	inline void set_positiveInfinityVector_12(Vector3_t2243707580  value)
	{
		___positiveInfinityVector_12 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_13() { return static_cast<int32_t>(offsetof(Vector3_t2243707580_StaticFields, ___negativeInfinityVector_13)); }
	inline Vector3_t2243707580  get_negativeInfinityVector_13() const { return ___negativeInfinityVector_13; }
	inline Vector3_t2243707580 * get_address_of_negativeInfinityVector_13() { return &___negativeInfinityVector_13; }
	inline void set_negativeInfinityVector_13(Vector3_t2243707580  value)
	{
		___negativeInfinityVector_13 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VECTOR3_T2243707580_H
#ifndef VECTOR2_T2243707579_H
#define VECTOR2_T2243707579_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Vector2
struct  Vector2_t2243707579 
{
public:
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;

public:
	inline static int32_t get_offset_of_x_0() { return static_cast<int32_t>(offsetof(Vector2_t2243707579, ___x_0)); }
	inline float get_x_0() const { return ___x_0; }
	inline float* get_address_of_x_0() { return &___x_0; }
	inline void set_x_0(float value)
	{
		___x_0 = value;
	}

	inline static int32_t get_offset_of_y_1() { return static_cast<int32_t>(offsetof(Vector2_t2243707579, ___y_1)); }
	inline float get_y_1() const { return ___y_1; }
	inline float* get_address_of_y_1() { return &___y_1; }
	inline void set_y_1(float value)
	{
		___y_1 = value;
	}
};

struct Vector2_t2243707579_StaticFields
{
public:
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_t2243707579  ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_t2243707579  ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_t2243707579  ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_t2243707579  ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_t2243707579  ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_t2243707579  ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_t2243707579  ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_t2243707579  ___negativeInfinityVector_9;

public:
	inline static int32_t get_offset_of_zeroVector_2() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___zeroVector_2)); }
	inline Vector2_t2243707579  get_zeroVector_2() const { return ___zeroVector_2; }
	inline Vector2_t2243707579 * get_address_of_zeroVector_2() { return &___zeroVector_2; }
	inline void set_zeroVector_2(Vector2_t2243707579  value)
	{
		___zeroVector_2 = value;
	}

	inline static int32_t get_offset_of_oneVector_3() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___oneVector_3)); }
	inline Vector2_t2243707579  get_oneVector_3() const { return ___oneVector_3; }
	inline Vector2_t2243707579 * get_address_of_oneVector_3() { return &___oneVector_3; }
	inline void set_oneVector_3(Vector2_t2243707579  value)
	{
		___oneVector_3 = value;
	}

	inline static int32_t get_offset_of_upVector_4() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___upVector_4)); }
	inline Vector2_t2243707579  get_upVector_4() const { return ___upVector_4; }
	inline Vector2_t2243707579 * get_address_of_upVector_4() { return &___upVector_4; }
	inline void set_upVector_4(Vector2_t2243707579  value)
	{
		___upVector_4 = value;
	}

	inline static int32_t get_offset_of_downVector_5() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___downVector_5)); }
	inline Vector2_t2243707579  get_downVector_5() const { return ___downVector_5; }
	inline Vector2_t2243707579 * get_address_of_downVector_5() { return &___downVector_5; }
	inline void set_downVector_5(Vector2_t2243707579  value)
	{
		___downVector_5 = value;
	}

	inline static int32_t get_offset_of_leftVector_6() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___leftVector_6)); }
	inline Vector2_t2243707579  get_leftVector_6() const { return ___leftVector_6; }
	inline Vector2_t2243707579 * get_address_of_leftVector_6() { return &___leftVector_6; }
	inline void set_leftVector_6(Vector2_t2243707579  value)
	{
		___leftVector_6 = value;
	}

	inline static int32_t get_offset_of_rightVector_7() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___rightVector_7)); }
	inline Vector2_t2243707579  get_rightVector_7() const { return ___rightVector_7; }
	inline Vector2_t2243707579 * get_address_of_rightVector_7() { return &___rightVector_7; }
	inline void set_rightVector_7(Vector2_t2243707579  value)
	{
		___rightVector_7 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_8() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___positiveInfinityVector_8)); }
	inline Vector2_t2243707579  get_positiveInfinityVector_8() const { return ___positiveInfinityVector_8; }
	inline Vector2_t2243707579 * get_address_of_positiveInfinityVector_8() { return &___positiveInfinityVector_8; }
	inline void set_positiveInfinityVector_8(Vector2_t2243707579  value)
	{
		___positiveInfinityVector_8 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_9() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___negativeInfinityVector_9)); }
	inline Vector2_t2243707579  get_negativeInfinityVector_9() const { return ___negativeInfinityVector_9; }
	inline Vector2_t2243707579 * get_address_of_negativeInfinityVector_9() { return &___negativeInfinityVector_9; }
	inline void set_negativeInfinityVector_9(Vector2_t2243707579  value)
	{
		___negativeInfinityVector_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VECTOR2_T2243707579_H
#ifndef RECT_T3681755626_H
#define RECT_T3681755626_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Rect
struct  Rect_t3681755626 
{
public:
	// System.Single UnityEngine.Rect::m_XMin
	float ___m_XMin_0;
	// System.Single UnityEngine.Rect::m_YMin
	float ___m_YMin_1;
	// System.Single UnityEngine.Rect::m_Width
	float ___m_Width_2;
	// System.Single UnityEngine.Rect::m_Height
	float ___m_Height_3;

public:
	inline static int32_t get_offset_of_m_XMin_0() { return static_cast<int32_t>(offsetof(Rect_t3681755626, ___m_XMin_0)); }
	inline float get_m_XMin_0() const { return ___m_XMin_0; }
	inline float* get_address_of_m_XMin_0() { return &___m_XMin_0; }
	inline void set_m_XMin_0(float value)
	{
		___m_XMin_0 = value;
	}

	inline static int32_t get_offset_of_m_YMin_1() { return static_cast<int32_t>(offsetof(Rect_t3681755626, ___m_YMin_1)); }
	inline float get_m_YMin_1() const { return ___m_YMin_1; }
	inline float* get_address_of_m_YMin_1() { return &___m_YMin_1; }
	inline void set_m_YMin_1(float value)
	{
		___m_YMin_1 = value;
	}

	inline static int32_t get_offset_of_m_Width_2() { return static_cast<int32_t>(offsetof(Rect_t3681755626, ___m_Width_2)); }
	inline float get_m_Width_2() const { return ___m_Width_2; }
	inline float* get_address_of_m_Width_2() { return &___m_Width_2; }
	inline void set_m_Width_2(float value)
	{
		___m_Width_2 = value;
	}

	inline static int32_t get_offset_of_m_Height_3() { return static_cast<int32_t>(offsetof(Rect_t3681755626, ___m_Height_3)); }
	inline float get_m_Height_3() const { return ___m_Height_3; }
	inline float* get_address_of_m_Height_3() { return &___m_Height_3; }
	inline void set_m_Height_3(float value)
	{
		___m_Height_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RECT_T3681755626_H
#ifndef BOOLEAN_T3825574718_H
#define BOOLEAN_T3825574718_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Boolean
struct  Boolean_t3825574718 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_2;

public:
	inline static int32_t get_offset_of_m_value_2() { return static_cast<int32_t>(offsetof(Boolean_t3825574718, ___m_value_2)); }
	inline bool get_m_value_2() const { return ___m_value_2; }
	inline bool* get_address_of_m_value_2() { return &___m_value_2; }
	inline void set_m_value_2(bool value)
	{
		___m_value_2 = value;
	}
};

struct Boolean_t3825574718_StaticFields
{
public:
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_0;
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_1;

public:
	inline static int32_t get_offset_of_FalseString_0() { return static_cast<int32_t>(offsetof(Boolean_t3825574718_StaticFields, ___FalseString_0)); }
	inline String_t* get_FalseString_0() const { return ___FalseString_0; }
	inline String_t** get_address_of_FalseString_0() { return &___FalseString_0; }
	inline void set_FalseString_0(String_t* value)
	{
		___FalseString_0 = value;
		Il2CppCodeGenWriteBarrier((&___FalseString_0), value);
	}

	inline static int32_t get_offset_of_TrueString_1() { return static_cast<int32_t>(offsetof(Boolean_t3825574718_StaticFields, ___TrueString_1)); }
	inline String_t* get_TrueString_1() const { return ___TrueString_1; }
	inline String_t** get_address_of_TrueString_1() { return &___TrueString_1; }
	inline void set_TrueString_1(String_t* value)
	{
		___TrueString_1 = value;
		Il2CppCodeGenWriteBarrier((&___TrueString_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BOOLEAN_T3825574718_H
#ifndef VOID_T1841601450_H
#define VOID_T1841601450_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Void
struct  Void_t1841601450 
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VOID_T1841601450_H
#ifndef INTPTR_T_H
#define INTPTR_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INTPTR_T_H
#ifndef SINGLE_T2076509932_H
#define SINGLE_T2076509932_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Single
struct  Single_t2076509932 
{
public:
	// System.Single System.Single::m_value
	float ___m_value_7;

public:
	inline static int32_t get_offset_of_m_value_7() { return static_cast<int32_t>(offsetof(Single_t2076509932, ___m_value_7)); }
	inline float get_m_value_7() const { return ___m_value_7; }
	inline float* get_address_of_m_value_7() { return &___m_value_7; }
	inline void set_m_value_7(float value)
	{
		___m_value_7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SINGLE_T2076509932_H
#ifndef EVENT_T3028476042_H
#define EVENT_T3028476042_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Event
struct  Event_t3028476042  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Event::m_Ptr
	intptr_t ___m_Ptr_0;

public:
	inline static int32_t get_offset_of_m_Ptr_0() { return static_cast<int32_t>(offsetof(Event_t3028476042, ___m_Ptr_0)); }
	inline intptr_t get_m_Ptr_0() const { return ___m_Ptr_0; }
	inline intptr_t* get_address_of_m_Ptr_0() { return &___m_Ptr_0; }
	inline void set_m_Ptr_0(intptr_t value)
	{
		___m_Ptr_0 = value;
	}
};

struct Event_t3028476042_StaticFields
{
public:
	// UnityEngine.Event UnityEngine.Event::s_Current
	Event_t3028476042 * ___s_Current_1;
	// UnityEngine.Event UnityEngine.Event::s_MasterEvent
	Event_t3028476042 * ___s_MasterEvent_2;
	// System.Collections.Generic.Dictionary`2<System.String,System.Int32> UnityEngine.Event::<>f__switch$map0
	Dictionary_2_t3986656710 * ___U3CU3Ef__switchU24map0_3;

public:
	inline static int32_t get_offset_of_s_Current_1() { return static_cast<int32_t>(offsetof(Event_t3028476042_StaticFields, ___s_Current_1)); }
	inline Event_t3028476042 * get_s_Current_1() const { return ___s_Current_1; }
	inline Event_t3028476042 ** get_address_of_s_Current_1() { return &___s_Current_1; }
	inline void set_s_Current_1(Event_t3028476042 * value)
	{
		___s_Current_1 = value;
		Il2CppCodeGenWriteBarrier((&___s_Current_1), value);
	}

	inline static int32_t get_offset_of_s_MasterEvent_2() { return static_cast<int32_t>(offsetof(Event_t3028476042_StaticFields, ___s_MasterEvent_2)); }
	inline Event_t3028476042 * get_s_MasterEvent_2() const { return ___s_MasterEvent_2; }
	inline Event_t3028476042 ** get_address_of_s_MasterEvent_2() { return &___s_MasterEvent_2; }
	inline void set_s_MasterEvent_2(Event_t3028476042 * value)
	{
		___s_MasterEvent_2 = value;
		Il2CppCodeGenWriteBarrier((&___s_MasterEvent_2), value);
	}

	inline static int32_t get_offset_of_U3CU3Ef__switchU24map0_3() { return static_cast<int32_t>(offsetof(Event_t3028476042_StaticFields, ___U3CU3Ef__switchU24map0_3)); }
	inline Dictionary_2_t3986656710 * get_U3CU3Ef__switchU24map0_3() const { return ___U3CU3Ef__switchU24map0_3; }
	inline Dictionary_2_t3986656710 ** get_address_of_U3CU3Ef__switchU24map0_3() { return &___U3CU3Ef__switchU24map0_3; }
	inline void set_U3CU3Ef__switchU24map0_3(Dictionary_2_t3986656710 * value)
	{
		___U3CU3Ef__switchU24map0_3 = value;
		Il2CppCodeGenWriteBarrier((&___U3CU3Ef__switchU24map0_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.Event
struct Event_t3028476042_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.Event
struct Event_t3028476042_marshaled_com
{
	intptr_t ___m_Ptr_0;
};
#endif // EVENT_T3028476042_H
#ifndef BINDINGFLAGS_T1082350898_H
#define BINDINGFLAGS_T1082350898_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.BindingFlags
struct  BindingFlags_t1082350898 
{
public:
	// System.Int32 System.Reflection.BindingFlags::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(BindingFlags_t1082350898, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BINDINGFLAGS_T1082350898_H
#ifndef OBJECT_T1021602117_H
#define OBJECT_T1021602117_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Object
struct  Object_t1021602117  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_t1021602117, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_t1021602117_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_t1021602117_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_t1021602117_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_t1021602117_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};
#endif // OBJECT_T1021602117_H
#ifndef CAMERACLEARFLAGS_T452084705_H
#define CAMERACLEARFLAGS_T452084705_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.CameraClearFlags
struct  CameraClearFlags_t452084705 
{
public:
	// System.Int32 UnityEngine.CameraClearFlags::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(CameraClearFlags_t452084705, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CAMERACLEARFLAGS_T452084705_H
#ifndef RUNTIMETYPEHANDLE_T2330101084_H
#define RUNTIMETYPEHANDLE_T2330101084_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.RuntimeTypeHandle
struct  RuntimeTypeHandle_t2330101084 
{
public:
	// System.IntPtr System.RuntimeTypeHandle::value
	intptr_t ___value_0;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(RuntimeTypeHandle_t2330101084, ___value_0)); }
	inline intptr_t get_value_0() const { return ___value_0; }
	inline intptr_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(intptr_t value)
	{
		___value_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMETYPEHANDLE_T2330101084_H
#ifndef COMPONENT_T3819376471_H
#define COMPONENT_T3819376471_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Component
struct  Component_t3819376471  : public Object_t1021602117
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // COMPONENT_T3819376471_H
#ifndef TYPE_T_H
#define TYPE_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Type
struct  Type_t  : public MemberInfo_t
{
public:
	// System.RuntimeTypeHandle System.Type::_impl
	RuntimeTypeHandle_t2330101084  ____impl_1;

public:
	inline static int32_t get_offset_of__impl_1() { return static_cast<int32_t>(offsetof(Type_t, ____impl_1)); }
	inline RuntimeTypeHandle_t2330101084  get__impl_1() const { return ____impl_1; }
	inline RuntimeTypeHandle_t2330101084 * get_address_of__impl_1() { return &____impl_1; }
	inline void set__impl_1(RuntimeTypeHandle_t2330101084  value)
	{
		____impl_1 = value;
	}
};

struct Type_t_StaticFields
{
public:
	// System.Char System.Type::Delimiter
	Il2CppChar ___Delimiter_2;
	// System.Type[] System.Type::EmptyTypes
	TypeU5BU5D_t1664964607* ___EmptyTypes_3;
	// System.Reflection.MemberFilter System.Type::FilterAttribute
	MemberFilter_t3405857066 * ___FilterAttribute_4;
	// System.Reflection.MemberFilter System.Type::FilterName
	MemberFilter_t3405857066 * ___FilterName_5;
	// System.Reflection.MemberFilter System.Type::FilterNameIgnoreCase
	MemberFilter_t3405857066 * ___FilterNameIgnoreCase_6;
	// System.Object System.Type::Missing
	RuntimeObject * ___Missing_7;

public:
	inline static int32_t get_offset_of_Delimiter_2() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Delimiter_2)); }
	inline Il2CppChar get_Delimiter_2() const { return ___Delimiter_2; }
	inline Il2CppChar* get_address_of_Delimiter_2() { return &___Delimiter_2; }
	inline void set_Delimiter_2(Il2CppChar value)
	{
		___Delimiter_2 = value;
	}

	inline static int32_t get_offset_of_EmptyTypes_3() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___EmptyTypes_3)); }
	inline TypeU5BU5D_t1664964607* get_EmptyTypes_3() const { return ___EmptyTypes_3; }
	inline TypeU5BU5D_t1664964607** get_address_of_EmptyTypes_3() { return &___EmptyTypes_3; }
	inline void set_EmptyTypes_3(TypeU5BU5D_t1664964607* value)
	{
		___EmptyTypes_3 = value;
		Il2CppCodeGenWriteBarrier((&___EmptyTypes_3), value);
	}

	inline static int32_t get_offset_of_FilterAttribute_4() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterAttribute_4)); }
	inline MemberFilter_t3405857066 * get_FilterAttribute_4() const { return ___FilterAttribute_4; }
	inline MemberFilter_t3405857066 ** get_address_of_FilterAttribute_4() { return &___FilterAttribute_4; }
	inline void set_FilterAttribute_4(MemberFilter_t3405857066 * value)
	{
		___FilterAttribute_4 = value;
		Il2CppCodeGenWriteBarrier((&___FilterAttribute_4), value);
	}

	inline static int32_t get_offset_of_FilterName_5() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterName_5)); }
	inline MemberFilter_t3405857066 * get_FilterName_5() const { return ___FilterName_5; }
	inline MemberFilter_t3405857066 ** get_address_of_FilterName_5() { return &___FilterName_5; }
	inline void set_FilterName_5(MemberFilter_t3405857066 * value)
	{
		___FilterName_5 = value;
		Il2CppCodeGenWriteBarrier((&___FilterName_5), value);
	}

	inline static int32_t get_offset_of_FilterNameIgnoreCase_6() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterNameIgnoreCase_6)); }
	inline MemberFilter_t3405857066 * get_FilterNameIgnoreCase_6() const { return ___FilterNameIgnoreCase_6; }
	inline MemberFilter_t3405857066 ** get_address_of_FilterNameIgnoreCase_6() { return &___FilterNameIgnoreCase_6; }
	inline void set_FilterNameIgnoreCase_6(MemberFilter_t3405857066 * value)
	{
		___FilterNameIgnoreCase_6 = value;
		Il2CppCodeGenWriteBarrier((&___FilterNameIgnoreCase_6), value);
	}

	inline static int32_t get_offset_of_Missing_7() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Missing_7)); }
	inline RuntimeObject * get_Missing_7() const { return ___Missing_7; }
	inline RuntimeObject ** get_address_of_Missing_7() { return &___Missing_7; }
	inline void set_Missing_7(RuntimeObject * value)
	{
		___Missing_7 = value;
		Il2CppCodeGenWriteBarrier((&___Missing_7), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TYPE_T_H
#ifndef GAMEOBJECT_T1756533147_H
#define GAMEOBJECT_T1756533147_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.GameObject
struct  GameObject_t1756533147  : public Object_t1021602117
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // GAMEOBJECT_T1756533147_H
#ifndef BEHAVIOUR_T955675639_H
#define BEHAVIOUR_T955675639_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Behaviour
struct  Behaviour_t955675639  : public Component_t3819376471
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BEHAVIOUR_T955675639_H
#ifndef CAMERA_T189460977_H
#define CAMERA_T189460977_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Camera
struct  Camera_t189460977  : public Behaviour_t955675639
{
public:

public:
};

struct Camera_t189460977_StaticFields
{
public:
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPreCull
	CameraCallback_t834278767 * ___onPreCull_2;
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPreRender
	CameraCallback_t834278767 * ___onPreRender_3;
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPostRender
	CameraCallback_t834278767 * ___onPostRender_4;

public:
	inline static int32_t get_offset_of_onPreCull_2() { return static_cast<int32_t>(offsetof(Camera_t189460977_StaticFields, ___onPreCull_2)); }
	inline CameraCallback_t834278767 * get_onPreCull_2() const { return ___onPreCull_2; }
	inline CameraCallback_t834278767 ** get_address_of_onPreCull_2() { return &___onPreCull_2; }
	inline void set_onPreCull_2(CameraCallback_t834278767 * value)
	{
		___onPreCull_2 = value;
		Il2CppCodeGenWriteBarrier((&___onPreCull_2), value);
	}

	inline static int32_t get_offset_of_onPreRender_3() { return static_cast<int32_t>(offsetof(Camera_t189460977_StaticFields, ___onPreRender_3)); }
	inline CameraCallback_t834278767 * get_onPreRender_3() const { return ___onPreRender_3; }
	inline CameraCallback_t834278767 ** get_address_of_onPreRender_3() { return &___onPreRender_3; }
	inline void set_onPreRender_3(CameraCallback_t834278767 * value)
	{
		___onPreRender_3 = value;
		Il2CppCodeGenWriteBarrier((&___onPreRender_3), value);
	}

	inline static int32_t get_offset_of_onPostRender_4() { return static_cast<int32_t>(offsetof(Camera_t189460977_StaticFields, ___onPostRender_4)); }
	inline CameraCallback_t834278767 * get_onPostRender_4() const { return ___onPostRender_4; }
	inline CameraCallback_t834278767 ** get_address_of_onPostRender_4() { return &___onPostRender_4; }
	inline void set_onPostRender_4(CameraCallback_t834278767 * value)
	{
		___onPostRender_4 = value;
		Il2CppCodeGenWriteBarrier((&___onPostRender_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CAMERA_T189460977_H
#ifndef MONOBEHAVIOUR_T1158329972_H
#define MONOBEHAVIOUR_T1158329972_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.MonoBehaviour
struct  MonoBehaviour_t1158329972  : public Behaviour_t955675639
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MONOBEHAVIOUR_T1158329972_H
#ifndef ASPECTUTILITY_T3786687708_H
#define ASPECTUTILITY_T3786687708_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// AspectUtility
struct  AspectUtility_t3786687708  : public MonoBehaviour_t1158329972
{
public:
	// System.Single AspectUtility::_wantedAspectRatio
	float ____wantedAspectRatio_2;

public:
	inline static int32_t get_offset_of__wantedAspectRatio_2() { return static_cast<int32_t>(offsetof(AspectUtility_t3786687708, ____wantedAspectRatio_2)); }
	inline float get__wantedAspectRatio_2() const { return ____wantedAspectRatio_2; }
	inline float* get_address_of__wantedAspectRatio_2() { return &____wantedAspectRatio_2; }
	inline void set__wantedAspectRatio_2(float value)
	{
		____wantedAspectRatio_2 = value;
	}
};

struct AspectUtility_t3786687708_StaticFields
{
public:
	// System.Single AspectUtility::wantedAspectRatio
	float ___wantedAspectRatio_3;
	// UnityEngine.Camera AspectUtility::cam
	Camera_t189460977 * ___cam_4;
	// UnityEngine.Camera AspectUtility::backgroundCam
	Camera_t189460977 * ___backgroundCam_5;

public:
	inline static int32_t get_offset_of_wantedAspectRatio_3() { return static_cast<int32_t>(offsetof(AspectUtility_t3786687708_StaticFields, ___wantedAspectRatio_3)); }
	inline float get_wantedAspectRatio_3() const { return ___wantedAspectRatio_3; }
	inline float* get_address_of_wantedAspectRatio_3() { return &___wantedAspectRatio_3; }
	inline void set_wantedAspectRatio_3(float value)
	{
		___wantedAspectRatio_3 = value;
	}

	inline static int32_t get_offset_of_cam_4() { return static_cast<int32_t>(offsetof(AspectUtility_t3786687708_StaticFields, ___cam_4)); }
	inline Camera_t189460977 * get_cam_4() const { return ___cam_4; }
	inline Camera_t189460977 ** get_address_of_cam_4() { return &___cam_4; }
	inline void set_cam_4(Camera_t189460977 * value)
	{
		___cam_4 = value;
		Il2CppCodeGenWriteBarrier((&___cam_4), value);
	}

	inline static int32_t get_offset_of_backgroundCam_5() { return static_cast<int32_t>(offsetof(AspectUtility_t3786687708_StaticFields, ___backgroundCam_5)); }
	inline Camera_t189460977 * get_backgroundCam_5() const { return ___backgroundCam_5; }
	inline Camera_t189460977 ** get_address_of_backgroundCam_5() { return &___backgroundCam_5; }
	inline void set_backgroundCam_5(Camera_t189460977 * value)
	{
		___backgroundCam_5 = value;
		Il2CppCodeGenWriteBarrier((&___backgroundCam_5), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ASPECTUTILITY_T3786687708_H
// System.Type[]
struct TypeU5BU5D_t1664964607  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Type_t * m_Items[1];

public:
	inline Type_t * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Type_t ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Type_t * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline Type_t * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Type_t ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Type_t * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};


// !!0 UnityEngine.GameObject::GetComponent<System.Object>()
extern "C"  RuntimeObject * GameObject_GetComponent_TisRuntimeObject_m2812611596_gshared (GameObject_t1756533147 * __this, const RuntimeMethod* method);

// System.Void UnityEngine.MonoBehaviour::.ctor()
extern "C"  void MonoBehaviour__ctor_m1825328214 (MonoBehaviour_t1158329972 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.GameObject UnityEngine.GameObject::FindWithTag(System.String)
extern "C"  GameObject_t1756533147 * GameObject_FindWithTag_m3831463693 (RuntimeObject * __this /* static, unused */, String_t* p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// !!0 UnityEngine.GameObject::GetComponent<UnityEngine.Camera>()
#define GameObject_GetComponent_TisCamera_t189460977_m3191350607(__this, method) ((  Camera_t189460977 * (*) (GameObject_t1756533147 *, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m2812611596_gshared)(__this, method)
// System.Boolean UnityEngine.Object::op_Implicit(UnityEngine.Object)
extern "C"  bool Object_op_Implicit_m1757773010 (RuntimeObject * __this /* static, unused */, Object_t1021602117 * p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Camera UnityEngine.Camera::get_main()
extern "C"  Camera_t189460977 * Camera_get_main_m881971336 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Debug::LogError(System.Object)
extern "C"  void Debug_LogError_m3299155069 (RuntimeObject * __this /* static, unused */, RuntimeObject * p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void AspectUtility::SetCamera()
extern "C"  void AspectUtility_SetCamera_m3455514222 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Screen::get_width()
extern "C"  int32_t Screen_get_width_m3526633787 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Screen::get_height()
extern "C"  int32_t Screen_get_height_m3831644396 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Rect::.ctor(System.Single,System.Single,System.Single,System.Single)
extern "C"  void Rect__ctor_m2109726426 (Rect_t3681755626 * __this, float p0, float p1, float p2, float p3, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Camera::set_rect(UnityEngine.Rect)
extern "C"  void Camera_set_rect_m4083842229 (Camera_t189460977 * __this, Rect_t3681755626  p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.GameObject UnityEngine.Component::get_gameObject()
extern "C"  GameObject_t1756533147 * Component_get_gameObject_m2159020946 (Component_t3819376471 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Object::Destroy(UnityEngine.Object)
extern "C"  void Object_Destroy_m3959286051 (RuntimeObject * __this /* static, unused */, Object_t1021602117 * p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Type System.Type::GetTypeFromHandle(System.RuntimeTypeHandle)
extern "C"  Type_t * Type_GetTypeFromHandle_m432505302 (RuntimeObject * __this /* static, unused */, RuntimeTypeHandle_t2330101084  p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.GameObject::.ctor(System.String,System.Type[])
extern "C"  void GameObject__ctor_m3412194074 (GameObject_t1756533147 * __this, String_t* p0, TypeU5BU5D_t1664964607* p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Camera::set_depth(System.Single)
extern "C"  void Camera_set_depth_m553647818 (Camera_t189460977 * __this, float p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Camera::set_clearFlags(UnityEngine.CameraClearFlags)
extern "C"  void Camera_set_clearFlags_m489868550 (Camera_t189460977 * __this, int32_t p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Color UnityEngine.Color::get_black()
extern "C"  Color_t2020392075  Color_get_black_m455352838 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Camera::set_backgroundColor(UnityEngine.Color)
extern "C"  void Camera_set_backgroundColor_m4178084823 (Camera_t189460977 * __this, Color_t2020392075  p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Camera::set_cullingMask(System.Int32)
extern "C"  void Camera_set_cullingMask_m2961679457 (Camera_t189460977 * __this, int32_t p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Rect UnityEngine.Camera::get_rect()
extern "C"  Rect_t3681755626  Camera_get_rect_m277337320 (Camera_t189460977 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Rect::get_height()
extern "C"  float Rect_get_height_m1231429410 (Rect_t3681755626 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Rect::get_width()
extern "C"  float Rect_get_width_m3473344679 (Rect_t3681755626 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Rect::get_x()
extern "C"  float Rect_get_x_m3691430209 (Rect_t3681755626 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Rect::get_y()
extern "C"  float Rect_get_y_m942343878 (Rect_t3681755626 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Input::get_mousePosition()
extern "C"  Vector3_t2243707580  Input_get_mousePosition_m2069200279 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Event UnityEngine.Event::get_current()
extern "C"  Event_t3028476042 * Event_get_current_m2971879972 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector2 UnityEngine.Event::get_mousePosition()
extern "C"  Vector2_t2243707579  Event_get_mousePosition_m1191943012 (Event_t3028476042 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Mathf::Clamp(System.Single,System.Single,System.Single)
extern "C"  float Mathf_Clamp_m1779415170 (RuntimeObject * __this /* static, unused */, float p0, float p1, float p2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void AspectUtility::.ctor()
extern "C"  void AspectUtility__ctor_m3816111133 (AspectUtility_t3786687708 * __this, const RuntimeMethod* method)
{
	{
		__this->set__wantedAspectRatio_2((1.6f));
		MonoBehaviour__ctor_m1825328214(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void AspectUtility::Awake()
extern "C"  void AspectUtility_Awake_m3454187054 (AspectUtility_t3786687708 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AspectUtility_Awake_m3454187054_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		GameObject_t1756533147 * L_0 = GameObject_FindWithTag_m3831463693(NULL /*static, unused*/, _stringLiteral2115673192, /*hidden argument*/NULL);
		Camera_t189460977 * L_1 = GameObject_GetComponent_TisCamera_t189460977_m3191350607(L_0, /*hidden argument*/GameObject_GetComponent_TisCamera_t189460977_m3191350607_RuntimeMethod_var);
		((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->set_cam_4(L_1);
		Camera_t189460977 * L_2 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		IL2CPP_RUNTIME_CLASS_INIT(Object_t1021602117_il2cpp_TypeInfo_var);
		bool L_3 = Object_op_Implicit_m1757773010(NULL /*static, unused*/, L_2, /*hidden argument*/NULL);
		if (L_3)
		{
			goto IL_002d;
		}
	}
	{
		Camera_t189460977 * L_4 = Camera_get_main_m881971336(NULL /*static, unused*/, /*hidden argument*/NULL);
		((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->set_cam_4(L_4);
	}

IL_002d:
	{
		Camera_t189460977 * L_5 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		IL2CPP_RUNTIME_CLASS_INIT(Object_t1021602117_il2cpp_TypeInfo_var);
		bool L_6 = Object_op_Implicit_m1757773010(NULL /*static, unused*/, L_5, /*hidden argument*/NULL);
		if (L_6)
		{
			goto IL_0047;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_t1368543263_il2cpp_TypeInfo_var);
		Debug_LogError_m3299155069(NULL /*static, unused*/, _stringLiteral368387673, /*hidden argument*/NULL);
		return;
	}

IL_0047:
	{
		float L_7 = __this->get__wantedAspectRatio_2();
		((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->set_wantedAspectRatio_3(L_7);
		AspectUtility_SetCamera_m3455514222(NULL /*static, unused*/, /*hidden argument*/NULL);
		return;
	}
}
// System.Void AspectUtility::SetCamera()
extern "C"  void AspectUtility_SetCamera_m3455514222 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AspectUtility_SetCamera_m3455514222_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	float V_1 = 0.0f;
	float V_2 = 0.0f;
	{
		int32_t L_0 = Screen_get_width_m3526633787(NULL /*static, unused*/, /*hidden argument*/NULL);
		int32_t L_1 = Screen_get_height_m3831644396(NULL /*static, unused*/, /*hidden argument*/NULL);
		V_0 = ((float)((float)(((float)((float)L_0)))/(float)(((float)((float)L_1)))));
		float L_2 = V_0;
		float L_3 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_wantedAspectRatio_3();
		if ((!(((float)((float)((float)(((float)((float)(((int32_t)((int32_t)((float)((float)L_2*(float)(100.0f)))))))))/(float)(100.0f)))) == ((float)((float)((float)(((float)((float)(((int32_t)((int32_t)((float)((float)L_3*(float)(100.0f)))))))))/(float)(100.0f)))))))
		{
			goto IL_0077;
		}
	}
	{
		Camera_t189460977 * L_4 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_5;
		memset(&L_5, 0, sizeof(L_5));
		Rect__ctor_m2109726426((&L_5), (0.0f), (0.0f), (1.0f), (1.0f), /*hidden argument*/NULL);
		Camera_set_rect_m4083842229(L_4, L_5, /*hidden argument*/NULL);
		Camera_t189460977 * L_6 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_backgroundCam_5();
		IL2CPP_RUNTIME_CLASS_INIT(Object_t1021602117_il2cpp_TypeInfo_var);
		bool L_7 = Object_op_Implicit_m1757773010(NULL /*static, unused*/, L_6, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_0076;
		}
	}
	{
		Camera_t189460977 * L_8 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_backgroundCam_5();
		GameObject_t1756533147 * L_9 = Component_get_gameObject_m2159020946(L_8, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_t1021602117_il2cpp_TypeInfo_var);
		Object_Destroy_m3959286051(NULL /*static, unused*/, L_9, /*hidden argument*/NULL);
	}

IL_0076:
	{
		return;
	}

IL_0077:
	{
		float L_10 = V_0;
		float L_11 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_wantedAspectRatio_3();
		if ((!(((float)L_10) > ((float)L_11))))
		{
			goto IL_00bc;
		}
	}
	{
		float L_12 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_wantedAspectRatio_3();
		float L_13 = V_0;
		V_1 = ((float)((float)(1.0f)-(float)((float)((float)L_12/(float)L_13))));
		Camera_t189460977 * L_14 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		float L_15 = V_1;
		float L_16 = V_1;
		Rect_t3681755626  L_17;
		memset(&L_17, 0, sizeof(L_17));
		Rect__ctor_m2109726426((&L_17), ((float)((float)L_15/(float)(2.0f))), (0.0f), ((float)((float)(1.0f)-(float)L_16)), (1.0f), /*hidden argument*/NULL);
		Camera_set_rect_m4083842229(L_14, L_17, /*hidden argument*/NULL);
		goto IL_00f1;
	}

IL_00bc:
	{
		float L_18 = V_0;
		float L_19 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_wantedAspectRatio_3();
		V_2 = ((float)((float)(1.0f)-(float)((float)((float)L_18/(float)L_19))));
		Camera_t189460977 * L_20 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		float L_21 = V_2;
		float L_22 = V_2;
		Rect_t3681755626  L_23;
		memset(&L_23, 0, sizeof(L_23));
		Rect__ctor_m2109726426((&L_23), (0.0f), ((float)((float)L_21/(float)(2.0f))), (1.0f), ((float)((float)(1.0f)-(float)L_22)), /*hidden argument*/NULL);
		Camera_set_rect_m4083842229(L_20, L_23, /*hidden argument*/NULL);
	}

IL_00f1:
	{
		Camera_t189460977 * L_24 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_backgroundCam_5();
		IL2CPP_RUNTIME_CLASS_INIT(Object_t1021602117_il2cpp_TypeInfo_var);
		bool L_25 = Object_op_Implicit_m1757773010(NULL /*static, unused*/, L_24, /*hidden argument*/NULL);
		if (L_25)
		{
			goto IL_015b;
		}
	}
	{
		TypeU5BU5D_t1664964607* L_26 = ((TypeU5BU5D_t1664964607*)SZArrayNew(TypeU5BU5D_t1664964607_il2cpp_TypeInfo_var, (uint32_t)1));
		IL2CPP_RUNTIME_CLASS_INIT(Type_t_il2cpp_TypeInfo_var);
		Type_t * L_27 = Type_GetTypeFromHandle_m432505302(NULL /*static, unused*/, LoadTypeToken(Camera_t189460977_0_0_0_var), /*hidden argument*/NULL);
		ArrayElementTypeCheck (L_26, L_27);
		(L_26)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(0), (Type_t *)L_27);
		GameObject_t1756533147 * L_28 = (GameObject_t1756533147 *)il2cpp_codegen_object_new(GameObject_t1756533147_il2cpp_TypeInfo_var);
		GameObject__ctor_m3412194074(L_28, _stringLiteral3668015021, L_26, /*hidden argument*/NULL);
		Camera_t189460977 * L_29 = GameObject_GetComponent_TisCamera_t189460977_m3191350607(L_28, /*hidden argument*/GameObject_GetComponent_TisCamera_t189460977_m3191350607_RuntimeMethod_var);
		((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->set_backgroundCam_5(L_29);
		Camera_t189460977 * L_30 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_backgroundCam_5();
		Camera_set_depth_m553647818(L_30, (-2.14748365E+09f), /*hidden argument*/NULL);
		Camera_t189460977 * L_31 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_backgroundCam_5();
		Camera_set_clearFlags_m489868550(L_31, 2, /*hidden argument*/NULL);
		Camera_t189460977 * L_32 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_backgroundCam_5();
		Color_t2020392075  L_33 = Color_get_black_m455352838(NULL /*static, unused*/, /*hidden argument*/NULL);
		Camera_set_backgroundColor_m4178084823(L_32, L_33, /*hidden argument*/NULL);
		Camera_t189460977 * L_34 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_backgroundCam_5();
		Camera_set_cullingMask_m2961679457(L_34, 0, /*hidden argument*/NULL);
	}

IL_015b:
	{
		return;
	}
}
// System.Int32 AspectUtility::get_screenHeight()
extern "C"  int32_t AspectUtility_get_screenHeight_m4082636461 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AspectUtility_get_screenHeight_m4082636461_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Rect_t3681755626  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		int32_t L_0 = Screen_get_height_m3831644396(NULL /*static, unused*/, /*hidden argument*/NULL);
		Camera_t189460977 * L_1 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_2 = Camera_get_rect_m277337320(L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		float L_3 = Rect_get_height_m1231429410((&V_0), /*hidden argument*/NULL);
		return (((int32_t)((int32_t)((float)((float)(((float)((float)L_0)))*(float)L_3)))));
	}
}
// System.Int32 AspectUtility::get_screenWidth()
extern "C"  int32_t AspectUtility_get_screenWidth_m3292602408 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AspectUtility_get_screenWidth_m3292602408_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Rect_t3681755626  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		int32_t L_0 = Screen_get_width_m3526633787(NULL /*static, unused*/, /*hidden argument*/NULL);
		Camera_t189460977 * L_1 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_2 = Camera_get_rect_m277337320(L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		float L_3 = Rect_get_width_m3473344679((&V_0), /*hidden argument*/NULL);
		return (((int32_t)((int32_t)((float)((float)(((float)((float)L_0)))*(float)L_3)))));
	}
}
// System.Int32 AspectUtility::get_xOffset()
extern "C"  int32_t AspectUtility_get_xOffset_m1312947939 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AspectUtility_get_xOffset_m1312947939_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Rect_t3681755626  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		int32_t L_0 = Screen_get_width_m3526633787(NULL /*static, unused*/, /*hidden argument*/NULL);
		Camera_t189460977 * L_1 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_2 = Camera_get_rect_m277337320(L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		float L_3 = Rect_get_x_m3691430209((&V_0), /*hidden argument*/NULL);
		return (((int32_t)((int32_t)((float)((float)(((float)((float)L_0)))*(float)L_3)))));
	}
}
// System.Int32 AspectUtility::get_yOffset()
extern "C"  int32_t AspectUtility_get_yOffset_m1321033700 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AspectUtility_get_yOffset_m1321033700_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Rect_t3681755626  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		int32_t L_0 = Screen_get_height_m3831644396(NULL /*static, unused*/, /*hidden argument*/NULL);
		Camera_t189460977 * L_1 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_2 = Camera_get_rect_m277337320(L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		float L_3 = Rect_get_y_m942343878((&V_0), /*hidden argument*/NULL);
		return (((int32_t)((int32_t)((float)((float)(((float)((float)L_0)))*(float)L_3)))));
	}
}
// UnityEngine.Rect AspectUtility::get_screenRect()
extern "C"  Rect_t3681755626  AspectUtility_get_screenRect_m1015244010 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AspectUtility_get_screenRect_m1015244010_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Rect_t3681755626  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Rect_t3681755626  V_1;
	memset(&V_1, 0, sizeof(V_1));
	Rect_t3681755626  V_2;
	memset(&V_2, 0, sizeof(V_2));
	Rect_t3681755626  V_3;
	memset(&V_3, 0, sizeof(V_3));
	{
		Camera_t189460977 * L_0 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_1 = Camera_get_rect_m277337320(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		float L_2 = Rect_get_x_m3691430209((&V_0), /*hidden argument*/NULL);
		int32_t L_3 = Screen_get_width_m3526633787(NULL /*static, unused*/, /*hidden argument*/NULL);
		Camera_t189460977 * L_4 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_5 = Camera_get_rect_m277337320(L_4, /*hidden argument*/NULL);
		V_1 = L_5;
		float L_6 = Rect_get_y_m942343878((&V_1), /*hidden argument*/NULL);
		int32_t L_7 = Screen_get_height_m3831644396(NULL /*static, unused*/, /*hidden argument*/NULL);
		Camera_t189460977 * L_8 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_9 = Camera_get_rect_m277337320(L_8, /*hidden argument*/NULL);
		V_2 = L_9;
		float L_10 = Rect_get_width_m3473344679((&V_2), /*hidden argument*/NULL);
		int32_t L_11 = Screen_get_width_m3526633787(NULL /*static, unused*/, /*hidden argument*/NULL);
		Camera_t189460977 * L_12 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_13 = Camera_get_rect_m277337320(L_12, /*hidden argument*/NULL);
		V_3 = L_13;
		float L_14 = Rect_get_height_m1231429410((&V_3), /*hidden argument*/NULL);
		int32_t L_15 = Screen_get_height_m3831644396(NULL /*static, unused*/, /*hidden argument*/NULL);
		Rect_t3681755626  L_16;
		memset(&L_16, 0, sizeof(L_16));
		Rect__ctor_m2109726426((&L_16), ((float)((float)L_2*(float)(((float)((float)L_3))))), ((float)((float)L_6*(float)(((float)((float)L_7))))), ((float)((float)L_10*(float)(((float)((float)L_11))))), ((float)((float)L_14*(float)(((float)((float)L_15))))), /*hidden argument*/NULL);
		return L_16;
	}
}
// UnityEngine.Vector3 AspectUtility::get_mousePosition()
extern "C"  Vector3_t2243707580  AspectUtility_get_mousePosition_m2609004116 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AspectUtility_get_mousePosition_m2609004116_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t2243707580  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Rect_t3681755626  V_1;
	memset(&V_1, 0, sizeof(V_1));
	Rect_t3681755626  V_2;
	memset(&V_2, 0, sizeof(V_2));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Input_t1785128008_il2cpp_TypeInfo_var);
		Vector3_t2243707580  L_0 = Input_get_mousePosition_m2069200279(NULL /*static, unused*/, /*hidden argument*/NULL);
		V_0 = L_0;
		Vector3_t2243707580 * L_1 = (&V_0);
		float L_2 = L_1->get_y_2();
		Camera_t189460977 * L_3 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_4 = Camera_get_rect_m277337320(L_3, /*hidden argument*/NULL);
		V_1 = L_4;
		float L_5 = Rect_get_y_m942343878((&V_1), /*hidden argument*/NULL);
		int32_t L_6 = Screen_get_height_m3831644396(NULL /*static, unused*/, /*hidden argument*/NULL);
		L_1->set_y_2(((float)((float)L_2-(float)(((float)((float)(((int32_t)((int32_t)((float)((float)L_5*(float)(((float)((float)L_6))))))))))))));
		Vector3_t2243707580 * L_7 = (&V_0);
		float L_8 = L_7->get_x_1();
		Camera_t189460977 * L_9 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_10 = Camera_get_rect_m277337320(L_9, /*hidden argument*/NULL);
		V_2 = L_10;
		float L_11 = Rect_get_x_m3691430209((&V_2), /*hidden argument*/NULL);
		int32_t L_12 = Screen_get_width_m3526633787(NULL /*static, unused*/, /*hidden argument*/NULL);
		L_7->set_x_1(((float)((float)L_8-(float)(((float)((float)(((int32_t)((int32_t)((float)((float)L_11*(float)(((float)((float)L_12))))))))))))));
		Vector3_t2243707580  L_13 = V_0;
		return L_13;
	}
}
// UnityEngine.Vector2 AspectUtility::get_guiMousePosition()
extern "C"  Vector2_t2243707579  AspectUtility_get_guiMousePosition_m4219141168 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (AspectUtility_get_guiMousePosition_m4219141168_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_t2243707579  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Rect_t3681755626  V_1;
	memset(&V_1, 0, sizeof(V_1));
	Rect_t3681755626  V_2;
	memset(&V_2, 0, sizeof(V_2));
	Rect_t3681755626  V_3;
	memset(&V_3, 0, sizeof(V_3));
	Rect_t3681755626  V_4;
	memset(&V_4, 0, sizeof(V_4));
	Rect_t3681755626  V_5;
	memset(&V_5, 0, sizeof(V_5));
	Rect_t3681755626  V_6;
	memset(&V_6, 0, sizeof(V_6));
	{
		Event_t3028476042 * L_0 = Event_get_current_m2971879972(NULL /*static, unused*/, /*hidden argument*/NULL);
		Vector2_t2243707579  L_1 = Event_get_mousePosition_m1191943012(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		float L_2 = (&V_0)->get_y_1();
		Camera_t189460977 * L_3 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_4 = Camera_get_rect_m277337320(L_3, /*hidden argument*/NULL);
		V_1 = L_4;
		float L_5 = Rect_get_y_m942343878((&V_1), /*hidden argument*/NULL);
		int32_t L_6 = Screen_get_height_m3831644396(NULL /*static, unused*/, /*hidden argument*/NULL);
		Camera_t189460977 * L_7 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_8 = Camera_get_rect_m277337320(L_7, /*hidden argument*/NULL);
		V_2 = L_8;
		float L_9 = Rect_get_y_m942343878((&V_2), /*hidden argument*/NULL);
		int32_t L_10 = Screen_get_height_m3831644396(NULL /*static, unused*/, /*hidden argument*/NULL);
		Camera_t189460977 * L_11 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_12 = Camera_get_rect_m277337320(L_11, /*hidden argument*/NULL);
		V_3 = L_12;
		float L_13 = Rect_get_height_m1231429410((&V_3), /*hidden argument*/NULL);
		int32_t L_14 = Screen_get_height_m3831644396(NULL /*static, unused*/, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Mathf_t2336485820_il2cpp_TypeInfo_var);
		float L_15 = Mathf_Clamp_m1779415170(NULL /*static, unused*/, L_2, ((float)((float)L_5*(float)(((float)((float)L_6))))), ((float)((float)((float)((float)L_9*(float)(((float)((float)L_10)))))+(float)((float)((float)L_13*(float)(((float)((float)L_14))))))), /*hidden argument*/NULL);
		(&V_0)->set_y_1(L_15);
		float L_16 = (&V_0)->get_x_0();
		Camera_t189460977 * L_17 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_18 = Camera_get_rect_m277337320(L_17, /*hidden argument*/NULL);
		V_4 = L_18;
		float L_19 = Rect_get_x_m3691430209((&V_4), /*hidden argument*/NULL);
		int32_t L_20 = Screen_get_width_m3526633787(NULL /*static, unused*/, /*hidden argument*/NULL);
		Camera_t189460977 * L_21 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_22 = Camera_get_rect_m277337320(L_21, /*hidden argument*/NULL);
		V_5 = L_22;
		float L_23 = Rect_get_x_m3691430209((&V_5), /*hidden argument*/NULL);
		int32_t L_24 = Screen_get_width_m3526633787(NULL /*static, unused*/, /*hidden argument*/NULL);
		Camera_t189460977 * L_25 = ((AspectUtility_t3786687708_StaticFields*)il2cpp_codegen_static_fields_for(AspectUtility_t3786687708_il2cpp_TypeInfo_var))->get_cam_4();
		Rect_t3681755626  L_26 = Camera_get_rect_m277337320(L_25, /*hidden argument*/NULL);
		V_6 = L_26;
		float L_27 = Rect_get_width_m3473344679((&V_6), /*hidden argument*/NULL);
		int32_t L_28 = Screen_get_width_m3526633787(NULL /*static, unused*/, /*hidden argument*/NULL);
		float L_29 = Mathf_Clamp_m1779415170(NULL /*static, unused*/, L_16, ((float)((float)L_19*(float)(((float)((float)L_20))))), ((float)((float)((float)((float)L_23*(float)(((float)((float)L_24)))))+(float)((float)((float)L_27*(float)(((float)((float)L_28))))))), /*hidden argument*/NULL);
		(&V_0)->set_x_0(L_29);
		Vector2_t2243707579  L_30 = V_0;
		return L_30;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif

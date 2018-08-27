// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(float3.DebuggerProxy))]
    [System.Serializable]
    public partial struct float3 : System.IEquatable<float3>, IFormattable
    {
        public float x;
        public float y;
        public float z;

        /// <summary>float3 zero value.</summary>
        public static readonly float3 zero = new float3(0.0f,   0.0f,   0.0f);


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(float x, float y, float z)
        { 
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(float x, float2 yz)
        { 
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(float2 xy, float z)
        { 
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(float3 xyz)
        { 
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
        }

        /// <summary>Constructs a float3 vector constructed from a single float value by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(float v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a float3 vector from a single bool value by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(bool v)
        {
            this.x = v ? 1.0f : 0.0f;
            this.y = v ? 1.0f : 0.0f;
            this.z = v ? 1.0f : 0.0f;
        }

        /// <summary>Constructs a float3 vector from a bool3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(bool3 v)
        {
            this.x = v.x ? 1.0f : 0.0f;
            this.y = v.y ? 1.0f : 0.0f;
            this.z = v.z ? 1.0f : 0.0f;
        }

        /// <summary>Constructs a float3 vector from a single int value by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(int v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a float3 vector from a int3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(int3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        /// <summary>Constructs a float3 vector from a single uint value by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(uint v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a float3 vector from a uint3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(uint3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        /// <summary>Constructs a float3 vector from a single double value by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(double v)
        {
            this.x = (float)v;
            this.y = (float)v;
            this.z = (float)v;
        }

        /// <summary>Constructs a float3 vector from a double3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3(double3 v)
        {
            this.x = (float)v.x;
            this.y = (float)v.y;
            this.z = (float)v.z;
        }


        /// <summary>Implicitly converts a single float value to a float3 vector by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(float v) { return new float3(v); }

        /// <summary>Explicitly converts a single bool value to a float3 vector by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3(bool v) { return new float3(v); }

        /// <summary>Explicitly converts a bool3 vector to a float3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3(bool3 v) { return new float3(v); }

        /// <summary>Implicitly converts a single int value to a float3 vector by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(int v) { return new float3(v); }

        /// <summary>Implicitly converts a int3 vector to a float3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(int3 v) { return new float3(v); }

        /// <summary>Implicitly converts a single uint value to a float3 vector by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(uint v) { return new float3(v); }

        /// <summary>Implicitly converts a uint3 vector to a float3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3(uint3 v) { return new float3(v); }

        /// <summary>Explicitly converts a single double value to a float3 vector by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3(double v) { return new float3(v); }

        /// <summary>Explicitly converts a double3 vector to a float3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3(double3 v) { return new float3(v); }



        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator * (float3 lhs, float3 rhs) { return new float3 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator * (float3 lhs, float rhs) { return new float3 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator * (float lhs, float3 rhs) { return new float3 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator + (float3 lhs, float3 rhs) { return new float3 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator + (float3 lhs, float rhs) { return new float3 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator + (float lhs, float3 rhs) { return new float3 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator - (float3 lhs, float3 rhs) { return new float3 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator - (float3 lhs, float rhs) { return new float3 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator - (float lhs, float3 rhs) { return new float3 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator / (float3 lhs, float3 rhs) { return new float3 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator / (float3 lhs, float rhs) { return new float3 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator / (float lhs, float3 rhs) { return new float3 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator % (float3 lhs, float3 rhs) { return new float3 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator % (float3 lhs, float rhs) { return new float3 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator % (float lhs, float3 rhs) { return new float3 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator ++ (float3 val) { return new float3 (++val.x, ++val.y, ++val.z); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator -- (float3 val) { return new float3 (--val.x, --val.y, --val.z); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (float3 lhs, float3 rhs) { return new bool3 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (float3 lhs, float rhs) { return new bool3 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (float lhs, float3 rhs) { return new bool3 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (float3 lhs, float3 rhs) { return new bool3 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (float3 lhs, float rhs) { return new bool3 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (float lhs, float3 rhs) { return new bool3 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (float3 lhs, float3 rhs) { return new bool3 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (float3 lhs, float rhs) { return new bool3 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (float lhs, float3 rhs) { return new bool3 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (float3 lhs, float3 rhs) { return new bool3 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (float3 lhs, float rhs) { return new bool3 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (float lhs, float3 rhs) { return new bool3 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator - (float3 val) { return new float3 (-val.x, -val.y, -val.z); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 operator + (float3 val) { return new float3 (+val.x, +val.y, +val.z); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (float3 lhs, float3 rhs) { return new bool3 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (float3 lhs, float rhs) { return new bool3 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (float lhs, float3 rhs) { return new bool3 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (float3 lhs, float3 rhs) { return new bool3 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (float3 lhs, float rhs) { return new bool3 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (float lhs, float3 rhs) { return new bool3 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z); }
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(z, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float2(y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float2(y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float2(z, z); }
        }



        // [int index] 
        unsafe public float this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (float3* array = &this) { return ((float*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (float* array = &x) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(float3 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((float3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("float3({0}f, {1}f, {2}f)", x, y, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float3({0}f, {1}f, {2}f)", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public float x;
            public float y;
            public float z;
            public DebuggerProxy(float3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(float x, float y, float z) { return new float3(x, y, z); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(float x, float2 yz) { return new float3(x, yz); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(float2 xy, float z) { return new float3(xy, z); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(float3 xyz) { return new float3(xyz); }

        /// <summary>Returns a float3 vector constructed from a single float value by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(float v) { return new float3(v); }

        /// <summary>Returns a float3 vector constructed from a single bool value by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(bool v) { return new float3(v); }

        /// <summary>Return a float3 vector constructed from a bool3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(bool3 v) { return new float3(v); }

        /// <summary>Returns a float3 vector constructed from a single int value by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(int v) { return new float3(v); }

        /// <summary>Return a float3 vector constructed from a int3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(int3 v) { return new float3(v); }

        /// <summary>Returns a float3 vector constructed from a single uint value by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(uint v) { return new float3(v); }

        /// <summary>Return a float3 vector constructed from a uint3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(uint3 v) { return new float3(v); }

        /// <summary>Returns a float3 vector constructed from a single double value by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(double v) { return new float3(v); }

        /// <summary>Return a float3 vector constructed from a double3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 float3(double3 v) { return new float3(v); }

        /// <summary>Returns a uint hash code of a float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float3 v)
        {
            return csum(asuint(v) * uint3(0x97A65421u, 0x7809205Fu, 0x9C9F0823u)) + 0x5A9CA13Bu;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a float3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hashwide(float3 v)
        {
            return (asuint(v) * uint3(0xAFCDD5EFu, 0xA88D187Du, 0xCF6EBA1Du)) + 0x9D88E5A1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static float select_shuffle_component(float3 a, float3 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.LeftZ:
                    return a.z;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                case ShuffleComponent.RightZ:
                    return b.z;
                default:
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float shuffle(float3 a, float3 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 shuffle(float3 a, float3 b, ShuffleComponent x, ShuffleComponent y)
        {
            return float2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 shuffle(float3 a, float3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return float3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 shuffle(float3 a, float3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return float4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

    }
}

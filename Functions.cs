using System;
using System.Collections.Generic;
using System.Text;

namespace AllMathFromSimpleProgramming
{
    public static class Functions
    {

        /// <summary>
        /// Since c# requires the initialization of bool before it can be used we initialize it here. 
        /// We could just use T/F but that would mean we started with a T and a F. Using this
        /// random function is a way to initialize a bool with an unknown value.
        /// </summary>
        public static bool GetUnknownSwitch { get { return (new Random()).Next(1) == 0; } }

        public static bool True()
        {
            // cannot have 'True' without a switch
            bool a = GetUnknownSwitch;
            return OR(!a, a);
        }

        public static bool False()
        {
            // cannot have 'False' without a switch
            bool a = GetUnknownSwitch;
            return AND(!a, a);
        }

        public static bool T { get { return True(); } }
        public static bool F { get { return False(); } }

        public static bool OR(bool a, bool b)
        {
            return (a || b);
        }

        public static bool NOT(bool a)
        {
            return !a;
        }

        public static bool AND(bool a, bool b)
        {
            return !(!a || !b);
        }

        public static bool AND(bool a, bool b, bool c)
        {
            return !(!a || !b || !c);
        }

        public static bool AND(bool a, bool b, bool c, bool d)
        {
            return !(!a || !b || !c || !d);
        }

        public static bool AND(bool a, bool b, bool c, bool d, bool e)
        {
            return !(!a || !b || !c || !d || !e);
        }

        public static bool AND(bool a, bool b, bool c, bool d, bool e, bool f, bool g, bool h)
        {
            return !(!a || !b || !c || !d || !e || !f || !g || !h);
        }

        public static bool AND(bool a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i)
        {
            return !(!a || !b || !c || !d || !e || !f || !g || !h || !i);
        }

        public static bool AND(bool a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, bool j, bool k, bool l, bool m, bool n, bool o, bool p)
        {
            return !(!a || !b || !c || !d || !e || !f || !g || !h || !i || !j || !k || !l || !m || !n || !o || !p);
        }

        public static bool AND(bool a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, bool j, bool k, bool l, bool m, bool n, bool o, bool p, bool q)
        {
            return !(!a || !b || !c || !d || !e || !f || !g || !h || !i || !j || !k || !l || !m || !n || !o || !p || !q);
        }

        public static bool AND(bool a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, bool j, bool k, bool l, bool m, bool n, bool o, bool p, bool a1, bool b1, bool c1, bool d1, bool e1, bool f1, bool g1, bool h1, bool i1, bool j1, bool k1, bool l1, bool m1, bool n1, bool o1, bool p1)
        {
            return !(!a || !b || !c || !d || !e || !f || !g || !h || !i || !j || !k || !l || !m || !n || !o || !p || !a1 || !b1 || !c1 || !d1 || !e1 || !f1 || !g1 || !h1 || !i1 || !j1 || !k1 || !l1 || !m1 || !n1 || !o1 || !p1);
        }

        public static bool AND(bool a, bool b, bool c, bool d, bool e, bool f, bool g, bool h, bool i, bool j, bool k, bool l, bool m, bool n, bool o, bool p, bool a1, bool b1, bool c1, bool d1, bool e1, bool f1, bool g1, bool h1, bool i1, bool j1, bool k1, bool l1, bool m1, bool n1, bool o1, bool p1, bool a2)
        {
            return !(!a || !b || !c || !d || !e || !f || !g || !h || !i || !j || !k || !l || !m || !n || !o || !p || !a1 || !b1 || !c1 || !d1 || !e1 || !f1 || !g1 || !h1 || !i1 || !j1 || !k1 || !l1 || !m1 || !n1 || !o1 || !p1 || !a2);
        }


        //public static bool AND(bool a, bool b, bool c, bool d, bool e, bool f = T, bool g = T, bool h = T, bool i = T, bool j = T, bool k = T, bool l = T, bool m = T, bool n = T, bool o = T, bool p = T, bool q = T, bool r = T, bool a1 = T, bool b01 = T, bool c1 = T, bool d1 = T, bool e1 = T, bool f1 = T, bool g1 = T, bool h1 = T, bool i1 = T, bool j1 = T, bool k1 = T, bool l1 = T, bool m1 = T, bool n1 = T, bool o1 = T, bool p1 = T, bool q1 = T, bool r1 = T)
        //{
        //    return !(!a || !b || !c || !d || !e || !f || !g || !h || !i || !j || !k || !l || !m || !n || !o || !p || !q || !r || !a1 || !b01 || !c1 || !d1 || !e1 || !f1 || !g1 || !h1 || !i1 || !j1 || !k1 || !l1 || !m1 || !n1 || !o1 || !p1 || !q1 || !r1);
        //}

        public static bool NOR(bool a, bool b)
        {
            return !(a || b);
        }

        public static bool XOR(bool a, bool b)
        {
            return AND(a, !b) || AND(!a, b);
        }

        public static bool XOR(bool a, bool b, bool c)
        {
            return XOR(XOR(a, b), c);
        }

        public static bool NAND(bool a, bool b)
        {
            return !AND(a, b);
        }

        public static bool If(bool a, bool b, bool c)
        {
            return AND(a, b) || AND(!a, c);
        }

        public static bool isEqual(bool a, bool b)
        {
            return !XOR(a, b); 
        }

        public static void Assign(bool s, out bool d)
        {
            d = (s || s);
        }

        public static bool Add(bool a1, bool a0, bool b01, bool b00, out bool r1, out bool r0)
        {
            r0 = XOR(a0, b00, F);
            bool carry = AND(a0, b00) || AND(a0, F) || AND(b00, F);
            r1 = XOR(a1, b01, carry);
            return AND(a1, b01) || AND(a1, carry) || AND(b01, carry); //return carry
        }

        public static bool Add(bool a1, bool a0, bool b01, bool b00, out bool r1, out bool r0, bool carryIn)
        {
            r0 = XOR(a0, b00, carryIn);
            bool carry = AND(a0, b00) || AND(a0, carryIn) || AND(b00, carryIn);
            r1 = XOR(a1, b01, carry);
            return AND(a1, b01) || AND(a1, carry) || AND(b01, carry); //return carry
        }

        public static bool Add(bool a3, bool a2, bool a1, bool a0, bool b03, bool b02, bool b01, bool b00, out bool r3, out bool r2, out bool r1, out bool r0)
        {
            bool carry = Add(a1, a0, b01, b00, out r1, out r0, F);
            return Add(a3, a2, b03, b02, out r3, out r2, carry); // return carry
        }

        public static bool Add(bool a3, bool a2, bool a1, bool a0, bool b03, bool b02, bool b01, bool b00, out bool r3, out bool r2, out bool r1, out bool r0, bool carryIn)
        {
            bool carry = Add(a1, a0, b01, b00, out r1, out r0, carryIn);
            return Add(a3, a2, b03, b02, out r3, out r2, carry); // return carry
        }

        public static bool Add( bool a7, bool a6, bool a5, bool a4, bool a3, bool a2, bool a1, bool a0, bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00, out bool r7, out bool r6, out bool r5, out bool r4, out bool r3, out bool r2, out bool r1, out bool r0)
        {
            bool carry = Add(a3, a2, a1, a0, b03, b02, b01, b00, out r3, out r2, out r1, out r0, F);
            return Add(a7, a6, a5, a4, b07, b06, b05, b04, out r7, out r6, out r5, out r4, false); // return carry
        }

        public static bool Add(bool a7, bool a6, bool a5, bool a4, bool a3, bool a2, bool a1, bool a0, bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00, out bool r7, out bool r6, out bool r5, out bool r4, out bool r3, out bool r2, out bool r1, out bool r0, bool carryIn)
        {
            bool carry = Add(a3, a2, a1, a0, b03, b02, b01, b00, out r3, out r2, out r1, out r0, carryIn);
            return Add(a7, a6, a5, a4, b07, b06, b05, b04, out r7, out r6, out r5, out r4, carry); // return carry
        }

        public static bool Add(UINT_8 a, UINT_8 b, out UINT_8 r)
        {
            bool carry = Add(a.b03, a.b02, a.b01, a.b00, b.b03, b.b02, b.b01, b.b00, out r.b03, out r.b02, out r.b01, out r.b00, F);
            return Add(a.b07, a.b06, a.b05, a.b04, b.b07, b.b06, b.b05, b.b04, out r.b07, out r.b06, out r.b05, out r.b04, carry); // return carry
        }


        public static bool Add(UINT_8 a, UINT_8 b, out UINT_8 r, bool carryIn)
        {
            bool carry = Add(a.b03, a.b02, a.b01, a.b00, b.b03, b.b02, b.b01, b.b00, out r.b03, out r.b02, out r.b01, out r.b00, carryIn);
            return Add(a.b07, a.b06, a.b05, a.b04, b.b07, b.b06, b.b05, b.b04, out r.b07, out r.b06, out r.b05, out r.b04, carry); // return carry
        }

        public static bool Add(UINT_16 a, UINT_16 b, out UINT_16 r)
        {
            UINT_8 r0, r1;
            bool carry = Add(a.GetByte0(), b.GetByte0(), out r0, F);
            carry = Add(a.GetByte1(), b.GetByte1(), out r1, carry);

            r = new UINT_16();
            r.SetByte0(r0);
            r.SetByte1(r1);
            return carry; // return carry
        }

        public static bool Add(UINT_16 a, UINT_16 b, out UINT_16 r, bool carryIn)
        {
            UINT_8 r0, r1;
            bool carry = Add(a.GetByte0(), b.GetByte0(), out r0, carryIn);
            carry = Add(a.GetByte1(), b.GetByte1(), out r1, carry);

            r = new UINT_16();
            r.SetByte0(r0);
            r.SetByte1(r1);
            return carry; // return carry
        }


        public static bool Add(UINT_32 a, UINT_32 b, out UINT_32 r)
        {
            UINT_16 r0, r1;
            bool carry = Add(a.GetUShort0(), b.GetUShort0(), out r0, F);
            carry = Add(a.GetUShort1(), b.GetUShort1(), out r1, carry);

            r = new UINT_32();
            r.SetUShort0(r0);
            r.SetUShort1(r1);
            return carry; // return carry
        }

        public static bool Add(UINT_32 a, UINT_32 b, out UINT_32 r, bool carryIn)
        {
            UINT_16 r0, r1;
            bool carry = Add(a.GetUShort0(), b.GetUShort0(), out r0, carryIn);
            carry = Add(a.GetUShort1(), b.GetUShort1(), out r1, carry);

            r = new UINT_32();
            r.SetUShort0(r0);
            r.SetUShort1(r1);
            return carry; // return carry
        }

        public static UINT_32 Inc(UINT_32 a)
        {
            bool carry = a.b00;
            a.b00 = NOT(a.b00);

            a.b01 = XOR(a.b01, carry); carry = AND(!a.b01, carry);
            a.b02 = XOR(a.b02, carry); carry = AND(!a.b02, carry);
            a.b03 = XOR(a.b03, carry); carry = AND(!a.b03, carry);
            a.b04 = XOR(a.b04, carry); carry = AND(!a.b04, carry);
            a.b05 = XOR(a.b05, carry); carry = AND(!a.b05, carry);
            a.b06 = XOR(a.b06, carry); carry = AND(!a.b06, carry);
            a.b07 = XOR(a.b07, carry); carry = AND(!a.b07, carry);
            a.b08 = XOR(a.b08, carry); carry = AND(!a.b08, carry);
            a.b09 = XOR(a.b09, carry); carry = AND(!a.b09, carry);
            a.b10 = XOR(a.b10, carry); carry = AND(!a.b10, carry);
            a.b11 = XOR(a.b11, carry); carry = AND(!a.b11, carry);
            a.b12 = XOR(a.b12, carry); carry = AND(!a.b12, carry);
            a.b13 = XOR(a.b13, carry); carry = AND(!a.b13, carry);
            a.b14 = XOR(a.b14, carry); carry = AND(!a.b14, carry);
            a.b15 = XOR(a.b15, carry); carry = AND(!a.b15, carry);
            a.b16 = XOR(a.b16, carry); carry = AND(!a.b16, carry);
            a.b17 = XOR(a.b17, carry); carry = AND(!a.b17, carry);
            a.b18 = XOR(a.b18, carry); carry = AND(!a.b18, carry);
            a.b19 = XOR(a.b19, carry); carry = AND(!a.b19, carry);
            a.b20 = XOR(a.b20, carry); carry = AND(!a.b20, carry);
            a.b21 = XOR(a.b21, carry); carry = AND(!a.b21, carry);
            a.b22 = XOR(a.b22, carry); carry = AND(!a.b22, carry);
            a.b23 = XOR(a.b23, carry); carry = AND(!a.b23, carry);
            a.b24 = XOR(a.b24, carry); carry = AND(!a.b24, carry);
            a.b25 = XOR(a.b25, carry); carry = AND(!a.b25, carry);
            a.b26 = XOR(a.b26, carry); carry = AND(!a.b26, carry);
            a.b27 = XOR(a.b27, carry); carry = AND(!a.b27, carry);
            a.b28 = XOR(a.b28, carry); carry = AND(!a.b28, carry);
            a.b29 = XOR(a.b29, carry); carry = AND(!a.b29, carry);
            a.b30 = XOR(a.b30, carry); carry = AND(!a.b30, carry);
            a.b31 = XOR(a.b31, carry); carry = AND(!a.b31, carry);

            return a;
        }

        public static bool Greater(UINT_32 a, UINT_32 b)
        {
            return
                 OR(AND(a.b31, !b.b31), AND(OR(a.b31, !b.b31),
                 OR(AND(a.b30, !b.b30), AND(OR(a.b30, !b.b30),
                 OR(AND(a.b29, !b.b29), AND(OR(a.b29, !b.b29),
                 OR(AND(a.b28, !b.b28), AND(OR(a.b28, !b.b28),
                 OR(AND(a.b27, !b.b27), AND(OR(a.b27, !b.b27),
                 OR(AND(a.b26, !b.b26), AND(OR(a.b26, !b.b26),
                 OR(AND(a.b25, !b.b25), AND(OR(a.b25, !b.b25),
                 OR(AND(a.b24, !b.b24), AND(OR(a.b24, !b.b24),
                 OR(AND(a.b23, !b.b23), AND(OR(a.b23, !b.b23),
                 OR(AND(a.b22, !b.b22), AND(OR(a.b22, !b.b22),
                 OR(AND(a.b21, !b.b21), AND(OR(a.b21, !b.b21),
                 OR(AND(a.b20, !b.b20), AND(OR(a.b20, !b.b20),
                 OR(AND(a.b19, !b.b19), AND(OR(a.b19, !b.b19),
                 OR(AND(a.b18, !b.b18), AND(OR(a.b18, !b.b18),
                 OR(AND(a.b17, !b.b17), AND(OR(a.b17, !b.b17),
                 OR(AND(a.b16, !b.b16), AND(OR(a.b16, !b.b16),
                 OR(AND(a.b15, !b.b15), AND(OR(a.b15, !b.b15),
                 OR(AND(a.b14, !b.b14), AND(OR(a.b14, !b.b14),
                 OR(AND(a.b13, !b.b13), AND(OR(a.b13, !b.b13),
                 OR(AND(a.b12, !b.b12), AND(OR(a.b12, !b.b12),
                 OR(AND(a.b11, !b.b11), AND(OR(a.b11, !b.b11),
                 OR(AND(a.b10, !b.b10), AND(OR(a.b10, !b.b10),
                 OR(AND(a.b09, !b.b09), AND(OR(a.b09, !b.b09),
                 OR(AND(a.b08, !b.b08), AND(OR(a.b08, !b.b08),
                 OR(AND(a.b07, !b.b07), AND(OR(a.b07, !b.b07),
                 OR(AND(a.b06, !b.b06), AND(OR(a.b06, !b.b06),
                 OR(AND(a.b05, !b.b05), AND(OR(a.b05, !b.b05),
                 OR(AND(a.b04, !b.b04), AND(OR(a.b04, !b.b04),
                 OR(AND(a.b03, !b.b03), AND(OR(a.b03, !b.b03),
                 OR(AND(a.b02, !b.b02), AND(OR(a.b02, !b.b02),
                 OR(AND(a.b01, !b.b01), AND(OR(a.b01, !b.b01),
                 OR(AND(a.b00, !b.b00), AND(OR(a.b00, !b.b00),
                 F))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))));
        }

        public static bool GreaterOrEqual(UINT_32 a, UINT_32 b)
        {
            return
                 OR(AND(a.b31, !b.b31), AND(OR(a.b31, !b.b31),
                 OR(AND(a.b30, !b.b30), AND(OR(a.b30, !b.b30),
                 OR(AND(a.b29, !b.b29), AND(OR(a.b29, !b.b29),
                 OR(AND(a.b28, !b.b28), AND(OR(a.b28, !b.b28),
                 OR(AND(a.b27, !b.b27), AND(OR(a.b27, !b.b27),
                 OR(AND(a.b26, !b.b26), AND(OR(a.b26, !b.b26),
                 OR(AND(a.b25, !b.b25), AND(OR(a.b25, !b.b25),
                 OR(AND(a.b24, !b.b24), AND(OR(a.b24, !b.b24),
                 OR(AND(a.b23, !b.b23), AND(OR(a.b23, !b.b23),
                 OR(AND(a.b22, !b.b22), AND(OR(a.b22, !b.b22),
                 OR(AND(a.b21, !b.b21), AND(OR(a.b21, !b.b21),
                 OR(AND(a.b20, !b.b20), AND(OR(a.b20, !b.b20),
                 OR(AND(a.b19, !b.b19), AND(OR(a.b19, !b.b19),
                 OR(AND(a.b18, !b.b18), AND(OR(a.b18, !b.b18),
                 OR(AND(a.b17, !b.b17), AND(OR(a.b17, !b.b17),
                 OR(AND(a.b16, !b.b16), AND(OR(a.b16, !b.b16),
                 OR(AND(a.b15, !b.b15), AND(OR(a.b15, !b.b15),
                 OR(AND(a.b14, !b.b14), AND(OR(a.b14, !b.b14),
                 OR(AND(a.b13, !b.b13), AND(OR(a.b13, !b.b13),
                 OR(AND(a.b12, !b.b12), AND(OR(a.b12, !b.b12),
                 OR(AND(a.b11, !b.b11), AND(OR(a.b11, !b.b11),
                 OR(AND(a.b10, !b.b10), AND(OR(a.b10, !b.b10),
                 OR(AND(a.b09, !b.b09), AND(OR(a.b09, !b.b09),
                 OR(AND(a.b08, !b.b08), AND(OR(a.b08, !b.b08),
                 OR(AND(a.b07, !b.b07), AND(OR(a.b07, !b.b07),
                 OR(AND(a.b06, !b.b06), AND(OR(a.b06, !b.b06),
                 OR(AND(a.b05, !b.b05), AND(OR(a.b05, !b.b05),
                 OR(AND(a.b04, !b.b04), AND(OR(a.b04, !b.b04),
                 OR(AND(a.b03, !b.b03), AND(OR(a.b03, !b.b03),
                 OR(AND(a.b02, !b.b02), AND(OR(a.b02, !b.b02),
                 OR(AND(a.b01, !b.b01), AND(OR(a.b01, !b.b01),
                 OR(AND(a.b00, !b.b00), AND(OR(a.b00, !b.b00),
                 T))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))));
        }

        public static UINT_32 Add(UINT_32 a, UINT_32 b)
        {
            UINT_32 r = new UINT_32();
            Add(a, b, out r);
            return r;
        }

        public static UINT_32 ShiftLeft(UINT_32 i)
        {
            return new UINT_32(i.b30, i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, false);
        }

        public static UINT_32 ShiftLeft(UINT_32 i, bool F)
        {
            return new UINT_32(i.b30, i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F);
        }

        public static UINT_32 ShiftLeftBy2(UINT_32 i)
        {
            return new UINT_32(i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F);
        }

        public static UINT_32 ShiftLeftBy3(UINT_32 i)
        {
            return new UINT_32(i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F);
        }

        public static UINT_32 ShiftLeftBy4(UINT_32 i)
        {
            return new UINT_32(i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F);
        }

        public static UINT_32 ShiftLeftBy5(UINT_32 i)
        {
            return new UINT_32(i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F);
        }

        public static UINT_32 ShiftLeftBy6(UINT_32 i)
        {
            return new UINT_32(i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F);
        }

        public static UINT_32 ShiftLeftBy7(UINT_32 i)
        {
            return new UINT_32(i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F);
        }

        public static UINT_32 ShiftLeftBy8(UINT_32 i)
        {
            return new UINT_32(i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F);
        }

        public static UINT_32 ShiftLeftBy16(UINT_32 i)
        {
            return new UINT_32(i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }

        public static UINT_32 ShiftLeftBy2(UINT_32 i, bool carryIn)
        {
            return new UINT_32(i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn);
        }

        public static UINT_32 ShiftLeftBy3(UINT_32 i, bool carryIn)
        {
            return new UINT_32(i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn);
        }

        public static UINT_32 ShiftLeftBy4(UINT_32 i, bool carryIn)
        {
            return new UINT_32(i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn);
        }

        public static UINT_32 ShiftLeftBy5(UINT_32 i, bool carryIn)
        {
            return new UINT_32(i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn);
        }

        public static UINT_32 ShiftLeftBy6(UINT_32 i, bool carryIn)
        {
            return new UINT_32(i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }

        public static UINT_32 ShiftLeftBy7(UINT_32 i, bool carryIn)
        {
            return new UINT_32(i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }

        public static UINT_32 ShiftLeftBy8(UINT_32 i, bool carryIn)
        {
            return new UINT_32(i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }

        public static UINT_32 ShiftLeftBy16(UINT_32 i, bool carryIn)
        {
            return new UINT_32(i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }

        public static UINT_32 ShiftLeftBy01(UINT_32 i, out bool overflow)
        {
            // generated with the following...
            //for (int i = 1; i < 32; i++) { Console.Write(@"
            //public static UINT_32 ShiftLeftBy" + i.ToString("00") + @"(UINT_32 i, out bool overflow, bool carryIn = F)
            //{
            //    overflow = (i.b31"); for (int j = 30; j >= (32 - i); j--) Console.Write(" || i.b" + j.ToString("00")); Console.Write(@" );
            //    return new UINT_32("); for (int j = 31 - i; j >= 0; j--) Console.Write("i.b" + j.ToString("00") + ", "); for (int j = 0; j < i - 1; j++) Console.Write("carryIn,"); Console.Write(@"carryIn);
            //}
            //"); }

            overflow = (i.b31);
            return new UINT_32(i.b30, i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F);
        }

        public static UINT_32 ShiftLeftBy01(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31);
            return new UINT_32(i.b30, i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn);
        }

        public static UINT_32 ShiftLeftBy02(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30);
            return new UINT_32(i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F);
        }

        public static UINT_32 ShiftLeftBy02(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30);
            return new UINT_32(i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn);
        }

        public static UINT_32 ShiftLeftBy03(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29);
            return new UINT_32(i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F);
        }

        public static UINT_32 ShiftLeftBy04(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28);
            return new UINT_32(i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy05(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27);
            return new UINT_32(i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy06(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26);
            return new UINT_32(i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy07(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25);
            return new UINT_32(i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy08(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24);
            return new UINT_32(i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy09(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23);
            return new UINT_32(i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy10(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22);
            return new UINT_32(i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy11(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21);
            return new UINT_32(i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy12(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20);
            return new UINT_32(i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy13(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19);
            return new UINT_32(i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy14(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18);
            return new UINT_32(i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy15(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17);
            return new UINT_32(i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy16(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16);
            return new UINT_32(i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy17(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15);
            return new UINT_32(i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy18(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14);
            return new UINT_32(i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy19(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13);
            return new UINT_32(i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy20(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12);
            return new UINT_32(i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy21(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11);
            return new UINT_32(i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy22(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10);
            return new UINT_32(i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy23(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09);
            return new UINT_32(i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy24(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08);
            return new UINT_32(i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy25(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07);
            return new UINT_32(i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy26(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07 || i.b06);
            return new UINT_32(i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy27(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07 || i.b06 || i.b05);
            return new UINT_32(i.b04, i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy28(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07 || i.b06 || i.b05 || i.b04);
            return new UINT_32(i.b03, i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy29(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07 || i.b06 || i.b05 || i.b04 || i.b03);
            return new UINT_32(i.b02, i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy30(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07 || i.b06 || i.b05 || i.b04 || i.b03 || i.b02);
            return new UINT_32(i.b01, i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy31(UINT_32 i, out bool overflow)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07 || i.b06 || i.b05 || i.b04 || i.b03 || i.b02 || i.b01);
            return new UINT_32(i.b00, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
        }


        public static UINT_32 ShiftLeftBy03(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29);
            return new UINT_32(i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy04(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28);
            return new UINT_32(i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy05(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27);
            return new UINT_32(i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy06(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26);
            return new UINT_32(i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy07(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25);
            return new UINT_32(i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy08(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24);
            return new UINT_32(i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy09(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23);
            return new UINT_32(i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy10(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22);
            return new UINT_32(i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy11(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21);
            return new UINT_32(i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy12(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20);
            return new UINT_32(i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy13(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19);
            return new UINT_32(i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy14(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18);
            return new UINT_32(i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy15(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17);
            return new UINT_32(i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy16(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16);
            return new UINT_32(i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy17(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15);
            return new UINT_32(i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy18(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14);
            return new UINT_32(i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy19(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13);
            return new UINT_32(i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy20(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12);
            return new UINT_32(i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy21(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11);
            return new UINT_32(i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy22(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10);
            return new UINT_32(i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy23(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09);
            return new UINT_32(i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy24(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08);
            return new UINT_32(i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy25(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07);
            return new UINT_32(i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy26(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07 || i.b06);
            return new UINT_32(i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy27(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07 || i.b06 || i.b05);
            return new UINT_32(i.b04, i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy28(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07 || i.b06 || i.b05 || i.b04);
            return new UINT_32(i.b03, i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy29(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07 || i.b06 || i.b05 || i.b04 || i.b03);
            return new UINT_32(i.b02, i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy30(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07 || i.b06 || i.b05 || i.b04 || i.b03 || i.b02);
            return new UINT_32(i.b01, i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }


        public static UINT_32 ShiftLeftBy31(UINT_32 i, out bool overflow, bool carryIn)
        {
            overflow = (i.b31 || i.b30 || i.b29 || i.b28 || i.b27 || i.b26 || i.b25 || i.b24 || i.b23 || i.b22 || i.b21 || i.b20 || i.b19 || i.b18 || i.b17 || i.b16 || i.b15 || i.b14 || i.b13 || i.b12 || i.b11 || i.b10 || i.b09 || i.b08 || i.b07 || i.b06 || i.b05 || i.b04 || i.b03 || i.b02 || i.b01);
            return new UINT_32(i.b00, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn, carryIn);
        }

        public static UINT_32 ShiftLeft(UINT_32 i, out bool carryOut)
        {
            carryOut = i.b31;
            return ShiftLeft(i, F);
        }

        public static UINT_32 ShiftLeft(UINT_32 i, out bool carryOut, bool carryIn)
        {
            carryOut = i.b31;
            return ShiftLeft(i, carryIn);
        }

        public static INT_32 ShiftLeft(INT_32 i)
        {
            return new INT_32(i.b30, i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00, F);
        }

        /// <summary>
        /// Arithmetic Shift Right (sign bit is copied)
        /// </summary>
        public static UINT_32 ShiftRight(UINT_32 i)
        {
            return new UINT_32(i.b31, i.b31, i.b30, i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01);
        }

        /// <summary>
        /// Logical Shift Right
        /// </summary>
        public static INT_32 ShiftRightWithZeroFill(INT_32 i)
        {
            return new INT_32(F, i.b31, i.b30, i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01);
        }


        public static INT_32 AND(bool a, INT_32 b)
        {
            return new INT_32(
                AND(a, b.b31),
                AND(a, b.b30),
                AND(a, b.b29),
                AND(a, b.b28),
                AND(a, b.b27),
                AND(a, b.b26),
                AND(a, b.b25),
                AND(a, b.b24),
                AND(a, b.b23),
                AND(a, b.b22),
                AND(a, b.b21),
                AND(a, b.b20),
                AND(a, b.b19),
                AND(a, b.b18),
                AND(a, b.b17),
                AND(a, b.b16),
                AND(a, b.b15),
                AND(a, b.b14),
                AND(a, b.b13),
                AND(a, b.b12),
                AND(a, b.b11),
                AND(a, b.b10),
                AND(a, b.b09),
                AND(a, b.b08),
                AND(a, b.b07),
                AND(a, b.b06),
                AND(a, b.b05),
                AND(a, b.b04),
                AND(a, b.b03),
                AND(a, b.b02),
                AND(a, b.b01),
                AND(a, b.b00)
                );
        }

        public static UINT_32 AND(bool a, UINT_32 b)
        {
            return new UINT_32(
                AND(a, b.b31),
                AND(a, b.b30),
                AND(a, b.b29),
                AND(a, b.b28),
                AND(a, b.b27),
                AND(a, b.b26),
                AND(a, b.b25),
                AND(a, b.b24),
                AND(a, b.b23),
                AND(a, b.b22),
                AND(a, b.b21),
                AND(a, b.b20),
                AND(a, b.b19),
                AND(a, b.b18),
                AND(a, b.b17),
                AND(a, b.b16),
                AND(a, b.b15),
                AND(a, b.b14),
                AND(a, b.b13),
                AND(a, b.b12),
                AND(a, b.b11),
                AND(a, b.b10),
                AND(a, b.b09),
                AND(a, b.b08),
                AND(a, b.b07),
                AND(a, b.b06),
                AND(a, b.b05),
                AND(a, b.b04),
                AND(a, b.b03),
                AND(a, b.b02),
                AND(a, b.b01),
                AND(a, b.b00)
                );
        }


        public static UINT_32 If(bool a, UINT_32 b, UINT_32 c)
        {
            return new UINT_32(
                AND(a, b.b31) || AND(!a, c.b31),
                AND(a, b.b30) || AND(!a, c.b30),
                AND(a, b.b29) || AND(!a, c.b29),
                AND(a, b.b28) || AND(!a, c.b28),
                AND(a, b.b27) || AND(!a, c.b27),
                AND(a, b.b26) || AND(!a, c.b26),
                AND(a, b.b25) || AND(!a, c.b25),
                AND(a, b.b24) || AND(!a, c.b24),
                AND(a, b.b23) || AND(!a, c.b23),
                AND(a, b.b22) || AND(!a, c.b22),
                AND(a, b.b21) || AND(!a, c.b21),
                AND(a, b.b20) || AND(!a, c.b20),
                AND(a, b.b19) || AND(!a, c.b19),
                AND(a, b.b18) || AND(!a, c.b18),
                AND(a, b.b17) || AND(!a, c.b17),
                AND(a, b.b16) || AND(!a, c.b16),
                AND(a, b.b15) || AND(!a, c.b15),
                AND(a, b.b14) || AND(!a, c.b14),
                AND(a, b.b13) || AND(!a, c.b13),
                AND(a, b.b12) || AND(!a, c.b12),
                AND(a, b.b11) || AND(!a, c.b11),
                AND(a, b.b10) || AND(!a, c.b10),
                AND(a, b.b09) || AND(!a, c.b09),
                AND(a, b.b08) || AND(!a, c.b08),
                AND(a, b.b07) || AND(!a, c.b07),
                AND(a, b.b06) || AND(!a, c.b06),
                AND(a, b.b05) || AND(!a, c.b05),
                AND(a, b.b04) || AND(!a, c.b04),
                AND(a, b.b03) || AND(!a, c.b03),
                AND(a, b.b02) || AND(!a, c.b02),
                AND(a, b.b01) || AND(!a, c.b01),
                AND(a, b.b00) || AND(!a, c.b00)
                );
        }

        public static INT_32 If(bool a, INT_32 b, INT_32 c)
        {
            return new INT_32(
                AND(a, b.b31) || AND(!a, c.b31),
                AND(a, b.b30) || AND(!a, c.b30),
                AND(a, b.b29) || AND(!a, c.b29),
                AND(a, b.b28) || AND(!a, c.b28),
                AND(a, b.b27) || AND(!a, c.b27),
                AND(a, b.b26) || AND(!a, c.b26),
                AND(a, b.b25) || AND(!a, c.b25),
                AND(a, b.b24) || AND(!a, c.b24),
                AND(a, b.b23) || AND(!a, c.b23),
                AND(a, b.b22) || AND(!a, c.b22),
                AND(a, b.b21) || AND(!a, c.b21),
                AND(a, b.b20) || AND(!a, c.b20),
                AND(a, b.b19) || AND(!a, c.b19),
                AND(a, b.b18) || AND(!a, c.b18),
                AND(a, b.b17) || AND(!a, c.b17),
                AND(a, b.b16) || AND(!a, c.b16),
                AND(a, b.b15) || AND(!a, c.b15),
                AND(a, b.b14) || AND(!a, c.b14),
                AND(a, b.b13) || AND(!a, c.b13),
                AND(a, b.b12) || AND(!a, c.b12),
                AND(a, b.b11) || AND(!a, c.b11),
                AND(a, b.b10) || AND(!a, c.b10),
                AND(a, b.b09) || AND(!a, c.b09),
                AND(a, b.b08) || AND(!a, c.b08),
                AND(a, b.b07) || AND(!a, c.b07),
                AND(a, b.b06) || AND(!a, c.b06),
                AND(a, b.b05) || AND(!a, c.b05),
                AND(a, b.b04) || AND(!a, c.b04),
                AND(a, b.b03) || AND(!a, c.b03),
                AND(a, b.b02) || AND(!a, c.b02),
                AND(a, b.b01) || AND(!a, c.b01),
                AND(a, b.b00) || AND(!a, c.b00)
                );
        }

        public static bool Equal(UINT_32 a, UINT_32 b)
        {
            return !(
                XOR(a.b31, b.b31) ||
                XOR(a.b30, b.b30) ||
                XOR(a.b29, b.b29) ||
                XOR(a.b28, b.b28) ||
                XOR(a.b27, b.b27) ||
                XOR(a.b26, b.b26) ||
                XOR(a.b25, b.b25) ||
                XOR(a.b24, b.b24) ||
                XOR(a.b23, b.b23) ||
                XOR(a.b22, b.b22) ||
                XOR(a.b21, b.b21) ||
                XOR(a.b20, b.b20) ||
                XOR(a.b19, b.b19) ||
                XOR(a.b18, b.b18) ||
                XOR(a.b17, b.b17) ||
                XOR(a.b16, b.b16) ||
                XOR(a.b15, b.b15) ||
                XOR(a.b14, b.b14) ||
                XOR(a.b13, b.b13) ||
                XOR(a.b12, b.b12) ||
                XOR(a.b11, b.b11) ||
                XOR(a.b10, b.b10) ||
                XOR(a.b09, b.b09) ||
                XOR(a.b08, b.b08) ||
                XOR(a.b07, b.b07) ||
                XOR(a.b06, b.b06) ||
                XOR(a.b05, b.b05) ||
                XOR(a.b04, b.b04) ||
                XOR(a.b03, b.b03) ||
                XOR(a.b02, b.b02) ||
                XOR(a.b01, b.b01) ||
                XOR(a.b00, b.b00));
        }

        public static bool EqualWithMask(UINT_32 a, UINT_32 b, UINT_32 m)
        {
            return !(
                AND(m.b31, XOR(a.b31, b.b31)) ||
                AND(m.b30, XOR(a.b30, b.b30)) ||
                AND(m.b29, XOR(a.b29, b.b29)) ||
                AND(m.b28, XOR(a.b28, b.b28)) ||
                AND(m.b27, XOR(a.b27, b.b27)) ||
                AND(m.b26, XOR(a.b26, b.b26)) ||
                AND(m.b25, XOR(a.b25, b.b25)) ||
                AND(m.b24, XOR(a.b24, b.b24)) ||
                AND(m.b23, XOR(a.b23, b.b23)) ||
                AND(m.b22, XOR(a.b22, b.b22)) ||
                AND(m.b21, XOR(a.b21, b.b21)) ||
                AND(m.b20, XOR(a.b20, b.b20)) ||
                AND(m.b19, XOR(a.b19, b.b19)) ||
                AND(m.b18, XOR(a.b18, b.b18)) ||
                AND(m.b17, XOR(a.b17, b.b17)) ||
                AND(m.b16, XOR(a.b16, b.b16)) ||
                AND(m.b15, XOR(a.b15, b.b15)) ||
                AND(m.b14, XOR(a.b14, b.b14)) ||
                AND(m.b13, XOR(a.b13, b.b13)) ||
                AND(m.b12, XOR(a.b12, b.b12)) ||
                AND(m.b11, XOR(a.b11, b.b11)) ||
                AND(m.b10, XOR(a.b10, b.b10)) ||
                AND(m.b09, XOR(a.b09, b.b09)) ||
                AND(m.b08, XOR(a.b08, b.b08)) ||
                AND(m.b07, XOR(a.b07, b.b07)) ||
                AND(m.b06, XOR(a.b06, b.b06)) ||
                AND(m.b05, XOR(a.b05, b.b05)) ||
                AND(m.b04, XOR(a.b04, b.b04)) ||
                AND(m.b03, XOR(a.b03, b.b03)) ||
                AND(m.b02, XOR(a.b02, b.b02)) ||
                AND(m.b01, XOR(a.b01, b.b01)) ||
                AND(m.b00, XOR(a.b00, b.b00)));
        }

        public static bool Equal(INT_32 a, INT_32 b)
        {
            return !(
                XOR(a.b31, b.b31) ||
                XOR(a.b30, b.b30) ||
                XOR(a.b29, b.b29) ||
                XOR(a.b28, b.b28) ||
                XOR(a.b27, b.b27) ||
                XOR(a.b26, b.b26) ||
                XOR(a.b25, b.b25) ||
                XOR(a.b24, b.b24) ||
                XOR(a.b23, b.b23) ||
                XOR(a.b22, b.b22) ||
                XOR(a.b21, b.b21) ||
                XOR(a.b20, b.b20) ||
                XOR(a.b19, b.b19) ||
                XOR(a.b18, b.b18) ||
                XOR(a.b17, b.b17) ||
                XOR(a.b16, b.b16) ||
                XOR(a.b15, b.b15) ||
                XOR(a.b14, b.b14) ||
                XOR(a.b13, b.b13) ||
                XOR(a.b12, b.b12) ||
                XOR(a.b11, b.b11) ||
                XOR(a.b10, b.b10) ||
                XOR(a.b09, b.b09) ||
                XOR(a.b08, b.b08) ||
                XOR(a.b07, b.b07) ||
                XOR(a.b06, b.b06) ||
                XOR(a.b05, b.b05) ||
                XOR(a.b04, b.b04) ||
                XOR(a.b03, b.b03) ||
                XOR(a.b02, b.b02) ||
                XOR(a.b01, b.b01) ||
                XOR(a.b00, b.b00));
        }

        public static INT_32 Neg(INT_32 i)   // Neg with Two's complement
        {
            UINT_32 t = new UINT_32(!i.b31, !i.b30, !i.b29, !i.b28, !i.b27, !i.b26, !i.b25, !i.b24, !i.b23, !i.b22, !i.b21, !i.b20, !i.b19, !i.b18, !i.b17, !i.b16, !i.b15, !i.b14, !i.b13, !i.b12, !i.b11, !i.b10, !i.b09, !i.b08, !i.b07, !i.b06, !i.b05, !i.b04, !i.b03, !i.b02, !i.b01, !i.b00);
            UINT_32 one = new UINT_32() { b00 = T };
            UINT_32 r = new UINT_32() { b00 = T };
            bool carry = Add(t, one, out r);
            //Add_32bit(t, carry, out r);
            return r.CastAsInt_32();
        }

        public static INT_32 Abs(INT_32 i)
        {
            return If(i.b31 == T, Neg(i), i);
        }

        public static INT_32 Add(INT_32 a, INT_32 b)
        {
            UINT_32 t = new UINT_32();
            bool carry = Add(a.CastAsUInt_32(), b.CastAsUInt_32(), out t);
            return t.CastAsInt_32();
        }

        public static INT_32 Add(INT_32 a, INT_32 b, bool carryIn)
        {
            UINT_32 t = new UINT_32();
            bool carry = Add(a.CastAsUInt_32(), b.CastAsUInt_32(), out t, carryIn);
            return t.CastAsInt_32();
        }

        public static UINT_32 Subtract(UINT_32 a, UINT_32 b)
        {
            UINT_32 t = new UINT_32();
            bool carry = Add(a, Neg(b.CastAsInt_32()).CastAsUInt_32(), out t);
            return t;
        }

        public static UINT_32 Subtract(UINT_32 a, UINT_32 b, bool carryIn)
        {
            UINT_32 t = new UINT_32();
            bool carry = Add(a, Neg(b.CastAsInt_32()).CastAsUInt_32(), out t, carryIn);
            return t;
        }

        public static INT_32 Subtract(INT_32 a, INT_32 b)
        {
            return Add(a, Neg(b));
        }

        public static INT_32 Subtract(INT_32 a, INT_32 b, bool carryIn)
        {
            return Add(a, Neg(b), carryIn);
        }

        public static UINT_32 Mult(UINT_32 a, UINT_32 b)
        {
            // 10101011
            //       10
            // 00000000
            //10101011

            //UINT_32 i0 = new UINT_32(a.b31, a.b30, a.b29, a.b28, a.b27, a.b26, a.b25, a.b24, a.b23, a.b22, a.b21, a.b20, a.b19, a.b18, a.b17, a.b16, a.b15, a.b14, a.b13, a.b12, a.b11, a.b10, a.b09, a.b08, a.b07, a.b06, a.b05, a.b04, a.b03, a.b02, a.b01);
            UINT_32 s01 = ShiftLeft(a);
            UINT_32 s02 = ShiftLeft(s01);
            UINT_32 s03 = ShiftLeft(s02);
            UINT_32 s04 = ShiftLeft(s03);
            UINT_32 s05 = ShiftLeft(s04);
            UINT_32 s06 = ShiftLeft(s05);
            UINT_32 s07 = ShiftLeft(s06);
            UINT_32 s08 = ShiftLeft(s07);
            UINT_32 s09 = ShiftLeft(s08);
            UINT_32 s10 = ShiftLeft(s09);
            UINT_32 s11 = ShiftLeft(s10);
            UINT_32 s12 = ShiftLeft(s11);
            UINT_32 s13 = ShiftLeft(s12);
            UINT_32 s14 = ShiftLeft(s13);
            UINT_32 s15 = ShiftLeft(s14);
            UINT_32 s16 = ShiftLeft(s15);
            UINT_32 s17 = ShiftLeft(s16);
            UINT_32 s18 = ShiftLeft(s17);
            UINT_32 s19 = ShiftLeft(s18);
            UINT_32 s20 = ShiftLeft(s19);
            UINT_32 s21 = ShiftLeft(s20);
            UINT_32 s22 = ShiftLeft(s21);
            UINT_32 s23 = ShiftLeft(s22);
            UINT_32 s24 = ShiftLeft(s23);
            UINT_32 s25 = ShiftLeft(s24);
            UINT_32 s26 = ShiftLeft(s25);
            UINT_32 s27 = ShiftLeft(s26);
            UINT_32 s28 = ShiftLeft(s27);
            UINT_32 s29 = ShiftLeft(s28);
            UINT_32 s30 = ShiftLeft(s29);
            UINT_32 s31 = ShiftLeft(s30);

            return
                Add(AND(b.b31, s31),
                Add(AND(b.b30, s30),
                Add(AND(b.b29, s29),
                Add(AND(b.b28, s28),
                Add(AND(b.b27, s27),
                Add(AND(b.b26, s26),
                Add(AND(b.b25, s25),
                Add(AND(b.b24, s24),
                Add(AND(b.b23, s23),
                Add(AND(b.b22, s22),
                Add(AND(b.b21, s21),
                Add(AND(b.b20, s20),
                Add(AND(b.b19, s19),
                Add(AND(b.b18, s18),
                Add(AND(b.b17, s17),
                Add(AND(b.b16, s16),
                Add(AND(b.b15, s15),
                Add(AND(b.b14, s14),
                Add(AND(b.b13, s13),
                Add(AND(b.b12, s12),
                Add(AND(b.b11, s11),
                Add(AND(b.b10, s10),
                Add(AND(b.b09, s09),
                Add(AND(b.b08, s08),
                Add(AND(b.b07, s07),
                Add(AND(b.b06, s06),
                Add(AND(b.b05, s05),
                Add(AND(b.b04, s04),
                Add(AND(b.b03, s03),
                Add(AND(b.b02, s02),
                Add(AND(b.b01, s01),
                AND(b.b00, a))))))))))))))))))))))))))))))));
        }

        public static INT_32 Mult(INT_32 a, INT_32 b)
        {
            bool isNeg = XOR(a.b31, b.b31);

            UINT_32 posA = Abs(a).CastAsUInt_32();

            INT_32 result = Mult(Abs(a).CastAsUInt_32(), Abs(b).CastAsUInt_32()).CastAsInt_32();

            return If(isNeg, Neg(result), result);
        }

        public static UINT_32 Div(UINT_32 b, UINT_32 a)
        {
            // b = Increment(b);

            UINT_32 total = b, temp, answer = new UINT_32();
            bool overflow, sub;

            //for i = 31 to 0
            //     b00000000000 = shiftleftby31 (bbbbbbbbbbbb)
            //     bool overflowed = shiftleft Overfload()
            //     if (!Overflowed)   // did the left shift overflow...then skip
            //       if (tttttttttttt>-b00000000000 (if positive then keep and mark "1", else aaaaa and mark"0")
            //         tttttttttttt
            //        -b00000000000
            //         tttttttttttt   
            //       push a 1 or 0

            temp = ShiftLeftBy31(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy30(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy29(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy28(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy27(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy26(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy25(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy24(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy23(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy22(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy21(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy20(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy19(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy18(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy17(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy16(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy15(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy14(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy13(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy12(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy11(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy10(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy09(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy08(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy07(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy06(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy05(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy04(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy03(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy02(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy01(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);

            // and the last bit...
            sub = GreaterOrEqual(total, a);
            answer = ShiftLeft(answer, sub);


            //// Here we use && so we only for short circuiting
            //bool temp;
            //temp = a.b00 && Assign(
            //    If(Greater(), Subtract(b))
            //    , out r);

            return answer;
        }


        public static UINT_32 Inv(UINT_32 a)
        {
            // b = Increment(b);
            UINT_32 ONE = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T);

            UINT_32 b = ONE;
            UINT_32 total = ONE, temp, answer = new UINT_32();
            bool overflow, sub;

            //for i = 31 to 0
            //     b00000000000 = shiftleftby31 (bbbbbbbbbbbb)
            //     bool overflowed = shiftleft Overfload()
            //     if (!Overflowed)   // did the left shift overflow...then skip
            //       if (tttttttttttt>-b00000000000 (if positive then keep and mark "1", else aaaaa and mark"0")
            //         tttttttttttt
            //        -b00000000000
            //         tttttttttttt   
            //       push a 1 or 0

            temp = ShiftLeftBy31(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy30(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy29(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy28(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy27(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy26(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy25(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy24(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy23(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy22(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy21(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy20(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy19(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy18(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy17(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy16(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy15(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy14(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy13(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy12(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy11(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy10(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy09(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy08(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy07(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy06(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy05(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy04(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy03(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy02(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);
            temp = ShiftLeftBy01(a, out overflow); sub = !overflow && GreaterOrEqual(total, temp); total = If(sub, Subtract(total, temp), total); answer = ShiftLeft(answer, sub);

            // and the last bit...
            sub = GreaterOrEqual(total, a);
            answer = ShiftLeft(answer, sub);

            return answer;
        }

        public static UINT_32 Pi()
        {
            // https://www.wikihow.com/Calculate-Pi Using method 3 - Nilakantha series
            // π = 3 + 4 / (2 * 3 * 4) - 4 / (4 * 5 * 6) + 4 / (6 * 7 * 8) - 4 / (8 * 9 * 10) + 4 / (10 * 11 * 12) - 4 / (12 * 13 * 14) ...
            // π = 3 + 1 / (1 * 3 * 2) - 1 / (2 * 5 * 3) + 1 / (3 * 7 * 4) - 1 / (4 * 9 * 5) + 1 / (5 * 11 * 6) - 1 / (6 * 13 * 7) ...

            UINT_32 total = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
            UINT_32 four = new UINT_32(T, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);

            UINT_32 a = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T); // starts at 1
            UINT_32 b = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, T); // starts at 3
            UINT_32 c = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, F); // starts at 2

            total = Add(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       1111111101    (high)  
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       111111000010  (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       111111100010  (high)  
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       11111100010  (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       11111110110  (high)                                                                                                                
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       111111001000  (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       111111101011  (high)     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       111111001011  (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       111111101000 (high)     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       111111001101  (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       111111100110 (high)     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       111111010000 (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       111111100100(high)     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       1111110101000 (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       1111111000001(high)  
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       1111110101100 (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       1111110111101(high)  
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       1111110110000 (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       1111110111001(high)  
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       11111101100110 (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       11111101101110(high)  
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       11111101101000 (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       11111101101100 (high)  
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       11111101101001 (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       11111101101011 (high) 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       1111110110101000 (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       1111110110101011 (high) 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       111111011010100101 (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       111111011010101011 (high) 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       1111110110101001101 (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       1111110110101010100 (high) 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       11111101101010011110 (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       11111101101010100101 (high) 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c))));
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));     
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       11111101101010011110 (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       11111101101010100011 (high) 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); 
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Subtract(total, Div(four, Mult(a, Mult(b, c)))); //       11111101101010011111 (low)
            a = Inc(a); b = Inc(Inc(b)); c = Inc(c); total = Add(total, Div(four, Mult(a, Mult(b, c))));      //       11111101101010100010 (high? - matches to full 32 bits) 
                                                                                            // Actual Pi: 11.0010010000111111011010101000100010000101101000110000100011010011

            total = ShiftRight(total);

            //add the front 3
            UINT_32 three = new UINT_32(T, T, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
            total = Add(total, three);

            return total;   // 3.14159202  Actual: 3.14159265
        }
    }
}

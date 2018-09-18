using System;
using System.Collections.Generic;
using System.Text;
using static AllMathFromSimpleProgramming.Functions;


namespace AllMathFromSimpleProgramming
{
    public struct UINT_8
    {
        public bool b07;
        public bool b06;
        public bool b05;
        public bool b04;
        public bool b03;
        public bool b02;
        public bool b01;
        public bool b00;

        public UINT_8(bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            this.b07 = b07;
            this.b06 = b06;
            this.b05 = b05;
            this.b04 = b04;
            this.b03 = b03;
            this.b02 = b02;
            this.b01 = b01;
            this.b00 = b00;
        }

        public void Clear()
        {
            b07 = F;
            b06 = F;
            b05 = F;
            b04 = F;
            b03 = F;
            b02 = F;
            b01 = F;
            b00 = F;
        }
    }

    public struct INT_8
    {
        public bool b31;
        public bool b06;
        public bool b05;
        public bool b04;
        public bool b03;
        public bool b02;
        public bool b01;
        public bool b00;

        public INT_8(bool b31, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            this.b31 = b31;
            this.b06 = b06;
            this.b05 = b05;
            this.b04 = b04;
            this.b03 = b03;
            this.b02 = b02;
            this.b01 = b01;
            this.b00 = b00;
        }

        public void Clear()
        {
            b31 = F;
            b06 = F;
            b05 = F;
            b04 = F;
            b03 = F;
            b02 = F;
            b01 = F;
            b00 = F;
        }
    }

    public struct UINT_16
    {
        public bool b15;
        public bool b14;
        public bool b13;
        public bool b12;
        public bool b11;
        public bool b10;
        public bool b09;
        public bool b08;
        public bool b07;
        public bool b06;
        public bool b05;
        public bool b04;
        public bool b03;
        public bool b02;
        public bool b01;
        public bool b00;

        public UINT_16(bool b15, bool b14, bool b13, bool b12, bool b11, bool b10, bool b09, bool b08, bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            this.b15 = b15;
            this.b14 = b14;
            this.b13 = b13;
            this.b12 = b12;
            this.b11 = b11;
            this.b10 = b10;
            this.b09 = b09;
            this.b08 = b08;
            this.b07 = b07;
            this.b06 = b06;
            this.b05 = b05;
            this.b04 = b04;
            this.b03 = b03;
            this.b02 = b02;
            this.b01 = b01;
            this.b00 = b00;
        }

        public UINT_8 GetByte0()
        {
            return new UINT_8(b07, b06, b05, b04, b03, b02, b01, b00);
        }

        public UINT_8 GetByte1()
        {
            return new UINT_8(b15, b14, b13, b12, b11, b10, b09, b08);
        }

        public void SetByte0(bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            this.b07 = b07;
            this.b06 = b06;
            this.b05 = b05;
            this.b04 = b04;
            this.b03 = b03;
            this.b02 = b02;
            this.b01 = b01;
            this.b00 = b00;
        }

        public void SetByte1(bool b15, bool b14, bool b13, bool b12, bool b11, bool b10, bool b09, bool b08)
        {
            this.b15 = b15;
            this.b14 = b14;
            this.b13 = b13;
            this.b12 = b12;
            this.b11 = b11;
            this.b10 = b10;
            this.b09 = b09;
            this.b08 = b08;
        }

        public void SetByte0(UINT_8 i)
        {
            b07 = i.b07;
            b06 = i.b06;
            b05 = i.b05;
            b04 = i.b04;
            b03 = i.b03;
            b02 = i.b02;
            b01 = i.b01;
            b00 = i.b00;
        }

        public void SetByte1(UINT_8 i)
        {
            b15 = i.b07;
            b14 = i.b06;
            b13 = i.b05;
            b12 = i.b04;
            b11 = i.b03;
            b10 = i.b02;
            b09 = i.b01;
            b08 = i.b00;
        }

        public static implicit operator UINT_16(UINT_8 i)
        {
            return new UINT_16(F, F, F, F, F, F, F, F, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00);
        }

        public void Clear()
        {
            b15 = F;
            b14 = F;
            b13 = F;
            b12 = F;
            b11 = F;
            b10 = F;
            b09 = F;
            b08 = F;
            b07 = F;
            b06 = F;
            b05 = F;
            b04 = F;
            b03 = F;
            b02 = F;
            b01 = F;
            b00 = F;
        }
    }

    public struct INT_16
    {
        public bool b31;
        public bool b14;
        public bool b13;
        public bool b12;
        public bool b11;
        public bool b10;
        public bool b09;
        public bool b08;
        public bool b07;
        public bool b06;
        public bool b05;
        public bool b04;
        public bool b03;
        public bool b02;
        public bool b01;
        public bool b00;

        public INT_16(bool b31, bool b14, bool b13, bool b12, bool b11, bool b10, bool b09, bool b08, bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            this.b31 = b31;
            this.b14 = b14;
            this.b13 = b13;
            this.b12 = b12;
            this.b11 = b11;
            this.b10 = b10;
            this.b09 = b09;
            this.b08 = b08;
            this.b07 = b07;
            this.b06 = b06;
            this.b05 = b05;
            this.b04 = b04;
            this.b03 = b03;
            this.b02 = b02;
            this.b01 = b01;
            this.b00 = b00;
        }

        public UINT_8 GetByte0()
        {
            return new UINT_8(b07, b06, b05, b04, b03, b02, b01, b00);
        }

        public UINT_8 GetByte1()
        {
            return new UINT_8(b31, b14, b13, b12, b11, b10, b09, b08);
        }

        public void SetByte0(bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            this.b07 = b07;
            this.b06 = b06;
            this.b05 = b05;
            this.b04 = b04;
            this.b03 = b03;
            this.b02 = b02;
            this.b01 = b01;
            this.b00 = b00;
        }

        public void SetByte1(bool b15, bool b14, bool b13, bool b12, bool b11, bool b10, bool b09, bool b08)
        {
            this.b31 = b15;
            this.b14 = b14;
            this.b13 = b13;
            this.b12 = b12;
            this.b11 = b11;
            this.b10 = b10;
            this.b09 = b09;
            this.b08 = b08;
        }

        public void SetByte0(UINT_8 i)
        {
            b07 = i.b07;
            b06 = i.b06;
            b05 = i.b05;
            b04 = i.b04;
            b03 = i.b03;
            b02 = i.b02;
            b01 = i.b01;
            b00 = i.b00;
        }

        public void SetByte1(UINT_8 i)
        {
            b31 = i.b07;
            b14 = i.b06;
            b13 = i.b05;
            b12 = i.b04;
            b11 = i.b03;
            b10 = i.b02;
            b09 = i.b01;
            b08 = i.b00;
        }

        public static implicit operator INT_16(UINT_8 i)
        {
            return new INT_16(F, F, F, F, F, F, F, F, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00);
        }

        public static implicit operator INT_16(INT_8 i)
        {
            return new INT_16(i.b31, F, F, F, F, F, F, F, F, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00);
        }

        public void Clear()
        {
            b31 = F;
            b14 = F;
            b13 = F;
            b12 = F;
            b11 = F;
            b10 = F;
            b09 = F;
            b08 = F;
            b07 = F;
            b06 = F;
            b05 = F;
            b04 = F;
            b03 = F;
            b02 = F;
            b01 = F;
            b00 = F;
        }
    }

    public struct UINT_32
    {
        public bool b31;
        public bool b30;
        public bool b29;
        public bool b28;
        public bool b27;
        public bool b26;
        public bool b25;
        public bool b24;
        public bool b23;
        public bool b22;
        public bool b21;
        public bool b20;
        public bool b19;
        public bool b18;
        public bool b17;
        public bool b16;
        public bool b15;
        public bool b14;
        public bool b13;
        public bool b12;
        public bool b11;
        public bool b10;
        public bool b09;
        public bool b08;
        public bool b07;
        public bool b06;
        public bool b05;
        public bool b04;
        public bool b03;
        public bool b02;
        public bool b01;
        public bool b00;

        public UINT_32(bool b31, bool b30, bool b29, bool b28, bool b27, bool b26, bool b25, bool b24, bool b23, bool b22, bool b21, bool b20, bool b19, bool b18, bool b17, bool b16, bool b15, bool b14, bool b13, bool b12, bool b11, bool b10, bool b09, bool b08, bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            this.b31 = b31;
            this.b30 = b30;
            this.b29 = b29;
            this.b28 = b28;
            this.b27 = b27;
            this.b26 = b26;
            this.b25 = b25;
            this.b24 = b24;
            this.b23 = b23;
            this.b22 = b22;
            this.b21 = b21;
            this.b20 = b20;
            this.b19 = b19;
            this.b18 = b18;
            this.b17 = b17;
            this.b16 = b16;
            this.b15 = b15;
            this.b14 = b14;
            this.b13 = b13;
            this.b12 = b12;
            this.b11 = b11;
            this.b10 = b10;
            this.b09 = b09;
            this.b08 = b08;
            this.b07 = b07;
            this.b06 = b06;
            this.b05 = b05;
            this.b04 = b04;
            this.b03 = b03;
            this.b02 = b02;
            this.b01 = b01;
            this.b00 = b00;
        }

        public UINT_8 GetByte0()
        {
            return new UINT_8(b07, b06, b05, b04, b03, b02, b01, b00);
        }

        public UINT_8 GetByte1()
        {
            return new UINT_8(b15, b14, b13, b12, b11, b10, b09, b08);
        }

        public UINT_8 GetByte2()
        {
            return new UINT_8(b23, b22, b21, b20, b19, b18, b17, b16);
        }

        public UINT_8 GetByte3()
        {
            return new UINT_8(b31, b30, b29, b28, b27, b26, b25, b24);
        }

        public UINT_16 GetUShort0()
        {
            return new UINT_16(b15, b14, b13, b12, b11, b10, b09, b08, b07, b06, b05, b04, b03, b02, b01, b00);
        }

        public UINT_16 GetUShort1()
        {
            return new UINT_16(b31, b30, b29, b28, b27, b26, b25, b24, b23, b22, b21, b20, b19, b18, b17, b16);
        }


        public void SetUShort0(UINT_16 i)
        {
            b15 = i.b15;
            b14 = i.b14;
            b13 = i.b13;
            b12 = i.b12;
            b11 = i.b11;
            b10 = i.b10;
            b09 = i.b09;
            b08 = i.b08;
            b07 = i.b07;
            b06 = i.b06;
            b05 = i.b05;
            b04 = i.b04;
            b03 = i.b03;
            b02 = i.b02;
            b01 = i.b01;
            b00 = i.b00;
        }

        public void SetUShort1(UINT_16 i)
        {
            b31 = i.b15;
            b30 = i.b14;
            b29 = i.b13;
            b28 = i.b12;
            b27 = i.b11;
            b26 = i.b10;
            b25 = i.b09;
            b24 = i.b08;
            b23 = i.b07;
            b22 = i.b06;
            b21 = i.b05;
            b20 = i.b04;
            b19 = i.b03;
            b18 = i.b02;
            b17 = i.b01;
            b16 = i.b00;
        }

        public void SetByte0(bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            this.b07 = b07;
            this.b06 = b06;
            this.b05 = b05;
            this.b04 = b04;
            this.b03 = b03;
            this.b02 = b02;
            this.b01 = b01;
            this.b00 = b00;
        }

        public void SetByte1(bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            b15 = b07;
            b14 = b06;
            b13 = b05;
            b12 = b04;
            b11 = b03;
            b10 = b02;
            b09 = b01;
            b08 = b00;
        }

        public void SetByte2(bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            b23 = b07;
            b22 = b06;
            b21 = b05;
            b20 = b04;
            b19 = b03;
            b18 = b02;
            b17 = b01;
            b16 = b00;
        }

        public void SetByte0(UINT_8 i)
        {
            b07 = i.b07;
            b06 = i.b06;
            b05 = i.b05;
            b04 = i.b04;
            b03 = i.b03;
            b02 = i.b02;
            b01 = i.b01;
            b00 = i.b00;
        }

        public void SetByte1(UINT_8 i)
        {
            b15 = i.b07;
            b14 = i.b06;
            b13 = i.b05;
            b12 = i.b04;
            b11 = i.b03;
            b10 = i.b02;
            b09 = i.b01;
            b08 = i.b00;
        }

        public void SetByte2(UINT_8 i)
        {
            b23 = i.b07;
            b22 = i.b06;
            b21 = i.b05;
            b20 = i.b04;
            b19 = i.b03;
            b18 = i.b02;
            b17 = i.b01;
            b16 = i.b00;
        }

        public void SetByte3(UINT_8 i)
        {
            b31 = i.b07;
            b30 = i.b06;
            b29 = i.b05;
            b28 = i.b04;
            b27 = i.b03;
            b26 = i.b02;
            b25 = i.b01;
            b24 = i.b00;
        }

        public static implicit operator UINT_32(UINT_8 i)
        {
            return new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F,
                F, F, F, F, F, F, F, F, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00);
        }

        public static implicit operator UINT_32(UINT_16 i)
        {

            return new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F,
                i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00);
        }

        //public static explicit operator UINT_32(INT_32 i)
        //{
        //    return If(a.b31 == T, Neg(a), a).CastAsUInt_32();
        //}

        public INT_32 CastAsInt_32()
        {
            return new INT_32(b31, b30, b29, b28, b27, b26, b25, b24, b23, b22, b21, b20, b19, b18, b17, b16, b15, b14, b13, b12, b11, b10, b09, b08, b07, b06, b05, b04, b03, b02, b01, b00);
        }

        public void Clear()
        {
            b31 = F;
            b30 = F;
            b29 = F;
            b28 = F;
            b27 = F;
            b26 = F;
            b25 = F;
            b24 = F;
            b23 = F;
            b22 = F;
            b21 = F;
            b20 = F;
            b19 = F;
            b18 = F;
            b17 = F;
            b16 = F;
            b15 = F;
            b14 = F;
            b13 = F;
            b12 = F;
            b11 = F;
            b10 = F;
            b09 = F;
            b08 = F;
            b07 = F;
            b06 = F;
            b05 = F;
            b04 = F;
            b03 = F;
            b02 = F;
            b01 = F;
            b00 = F;
        }
    }

    public struct INT_32
    {
        public bool b31;
        public bool b30;
        public bool b29;
        public bool b28;
        public bool b27;
        public bool b26;
        public bool b25;
        public bool b24;
        public bool b23;
        public bool b22;
        public bool b21;
        public bool b20;
        public bool b19;
        public bool b18;
        public bool b17;
        public bool b16;
        public bool b15;
        public bool b14;
        public bool b13;
        public bool b12;
        public bool b11;
        public bool b10;
        public bool b09;
        public bool b08;
        public bool b07;
        public bool b06;
        public bool b05;
        public bool b04;
        public bool b03;
        public bool b02;
        public bool b01;
        public bool b00;

        public INT_32(bool b31, bool b30, bool b29, bool b28, bool b27, bool b26, bool b25, bool b24, bool b23, bool b22, bool b21, bool b20, bool b19, bool b18, bool b17, bool b16, bool b15, bool b14, bool b13, bool b12, bool b11, bool b10, bool b09, bool b08, bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            this.b31 = b31;
            this.b30 = b30;
            this.b29 = b29;
            this.b28 = b28;
            this.b27 = b27;
            this.b26 = b26;
            this.b25 = b25;
            this.b24 = b24;
            this.b23 = b23;
            this.b22 = b22;
            this.b21 = b21;
            this.b20 = b20;
            this.b19 = b19;
            this.b18 = b18;
            this.b17 = b17;
            this.b16 = b16;
            this.b15 = b15;
            this.b14 = b14;
            this.b13 = b13;
            this.b12 = b12;
            this.b11 = b11;
            this.b10 = b10;
            this.b09 = b09;
            this.b08 = b08;
            this.b07 = b07;
            this.b06 = b06;
            this.b05 = b05;
            this.b04 = b04;
            this.b03 = b03;
            this.b02 = b02;
            this.b01 = b01;
            this.b00 = b00;
        }

        public UINT_8 GetByte0()
        {
            return new UINT_8(b07, b06, b05, b04, b03, b02, b01, b00);
        }

        public UINT_8 GetByte1()
        {
            return new UINT_8(b15, b14, b13, b12, b11, b10, b09, b08);
        }

        public UINT_8 GetByte2()
        {
            return new UINT_8(b23, b22, b21, b20, b19, b18, b17, b16);
        }

        public UINT_8 GetByte3()
        {
            return new UINT_8(b31, b30, b29, b28, b27, b26, b25, b24);
        }

        public UINT_16 GetUShort0()
        {
            return new UINT_16(b15, b14, b13, b12, b11, b10, b09, b08, b07, b06, b05, b04, b03, b02, b01, b00);
        }

        public UINT_16 GetUShort1()
        {
            return new UINT_16(b31, b30, b29, b28, b27, b26, b25, b24, b23, b22, b21, b20, b19, b18, b17, b16);
        }


        public void SetUShort0(UINT_16 i)
        {
            b15 = i.b15;
            b14 = i.b14;
            b13 = i.b13;
            b12 = i.b12;
            b11 = i.b11;
            b10 = i.b10;
            b09 = i.b09;
            b08 = i.b08;
            b07 = i.b07;
            b06 = i.b06;
            b05 = i.b05;
            b04 = i.b04;
            b03 = i.b03;
            b02 = i.b02;
            b01 = i.b01;
            b00 = i.b00;
        }

        public void SetUShort1(UINT_16 i)
        {
            b31 = i.b15;
            b30 = i.b14;
            b29 = i.b13;
            b28 = i.b12;
            b27 = i.b11;
            b26 = i.b10;
            b25 = i.b09;
            b24 = i.b08;
            b23 = i.b07;
            b22 = i.b06;
            b21 = i.b05;
            b20 = i.b04;
            b19 = i.b03;
            b18 = i.b02;
            b17 = i.b01;
            b16 = i.b00;
        }

        public void SetByte0(bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            this.b07 = b07;
            this.b06 = b06;
            this.b05 = b05;
            this.b04 = b04;
            this.b03 = b03;
            this.b02 = b02;
            this.b01 = b01;
            this.b00 = b00;
        }

        public void SetByte1(bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            b15 = b07;
            b14 = b06;
            b13 = b05;
            b12 = b04;
            b11 = b03;
            b10 = b02;
            b09 = b01;
            b08 = b00;
        }

        public void SetByte2(bool b07, bool b06, bool b05, bool b04, bool b03, bool b02, bool b01, bool b00)
        {
            b23 = b07;
            b22 = b06;
            b21 = b05;
            b20 = b04;
            b19 = b03;
            b18 = b02;
            b17 = b01;
            b16 = b00;
        }

        public void SetByte0(UINT_8 i)
        {
            b07 = i.b07;
            b06 = i.b06;
            b05 = i.b05;
            b04 = i.b04;
            b03 = i.b03;
            b02 = i.b02;
            b01 = i.b01;
            b00 = i.b00;
        }

        public void SetByte1(UINT_8 i)
        {
            b15 = i.b07;
            b14 = i.b06;
            b13 = i.b05;
            b12 = i.b04;
            b11 = i.b03;
            b10 = i.b02;
            b09 = i.b01;
            b08 = i.b00;
        }

        public void SetByte2(UINT_8 i)
        {
            b23 = i.b07;
            b22 = i.b06;
            b21 = i.b05;
            b20 = i.b04;
            b19 = i.b03;
            b18 = i.b02;
            b17 = i.b01;
            b16 = i.b00;
        }

        public void SetByte3(UINT_8 i)
        {
            b31 = i.b07;
            b30 = i.b06;
            b29 = i.b05;
            b28 = i.b04;
            b27 = i.b03;
            b26 = i.b02;
            b25 = i.b01;
            b24 = i.b00;
        }

        public static implicit operator INT_32(UINT_8 i)
        {
            return new INT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F,
                F, F, F, F, F, F, F, F, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00);
        }

        public static implicit operator INT_32(UINT_16 i)
        {

            return new INT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F,
                i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00);
        }


        public static implicit operator INT_32(INT_8 i)
        {
            return new INT_32(i.b31, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F,
                F, F, F, F, F, F, F, F, F, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00);
        }

        public static implicit operator INT_32(INT_16 i)
        {

            return new INT_32(i.b31, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F,
                F, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00);
        }

        public static explicit operator INT_32(UINT_32 i)
        {
            return new INT_32(F, i.b30, i.b29, i.b28, i.b27, i.b26, i.b25, i.b24, i.b23, i.b22, i.b21, i.b20, i.b19, i.b18, i.b17, i.b16, i.b15, i.b14, i.b13, i.b12, i.b11, i.b10, i.b09, i.b08, i.b07, i.b06, i.b05, i.b04, i.b03, i.b02, i.b01, i.b00);
        }

        public UINT_32 CastAsUInt_32()
        {
            return new UINT_32(b31, b30, b29, b28, b27, b26, b25, b24, b23, b22, b21, b20, b19, b18, b17, b16, b15, b14, b13, b12, b11, b10, b09, b08, b07, b06, b05, b04, b03, b02, b01, b00);
        }

        public void Clear()
        {
            b31 = F;
            b30 = F;
            b29 = F;
            b28 = F;
            b27 = F;
            b26 = F;
            b25 = F;
            b24 = F;
            b23 = F;
            b22 = F;
            b21 = F;
            b20 = F;
            b19 = F;
            b18 = F;
            b17 = F;
            b16 = F;
            b15 = F;
            b14 = F;
            b13 = F;
            b12 = F;
            b11 = F;
            b10 = F;
            b09 = F;
            b08 = F;
            b07 = F;
            b06 = F;
            b05 = F;
            b04 = F;
            b03 = F;
            b02 = F;
            b01 = F;
            b00 = F;
        }


    }
}

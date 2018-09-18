using System;
using static AllMathFromSimpleProgramming.Functions;

namespace AllMathFromSimpleProgramming
{
    class Program
    {
        static Program()
        {
            Console.WriteLine("Seems we need this...." +
                "\r\n - Switches - Yes/No storage" +
                "\r\n - NOT" +
                "\r\n - OR" +
                "\r\n - Map switches how we want");

            Console.WriteLine("We don't need..." +
                "\r\n - no \"true\" or \"false\" is used - we can create those" +
                "\r\n - no loops (do, while, for, goto...) are used" +
                "\r\n - no statements(aka clock cycles) - i do use however they are not required" +
                "\r\n - no if/then/else used - we do create our own however" +
                "\r\n - no +,-,*,/ are used - we do create our own however");
        }

        static void Main(string[] args)
        {
            bool r0 = F, r1=F, r2 = F, r3= F, r4 = F, r5 = F, r6 = F, r7 = F;
            UINT_8 rUInt8 = new UINT_8();
            UINT_16 rUInt16 = new UINT_8();
            UINT_32 rUInt32 = new UINT_32();
            INT_16 rInt16 = new INT_8();
            INT_32 rInt32 = new INT_32();

            Assign(T, out r1);
            Console.WriteLine("False == F " +  (False() == F ? "[PASS]" : "[FAIL]"));
            Console.WriteLine("True == T " +  (True() == T ? "[PASS]" : "[FAIL]"));
            Console.WriteLine("Assign(T, T) == T " +  (r1 == T ? "[PASS]" : "[FAIL]"));
            Console.WriteLine("Assign(T, T) == T " +  (r1 == T ? "[PASS]" : "[FAIL]"));
            Console.WriteLine("AND(T, T) == T " + (AND(T, T) == T ? "[PASS]" : "[FAIL]"));
            Console.WriteLine("AND(F, T) == F " + (AND(F, T) == F ? "[PASS]" : "[FAIL]"));
            Console.WriteLine("XOR(F,T,T) == F " + (XOR(F, T, T) == F ? "[PASS]" : "[FAIL]"));
            Console.WriteLine("XOR(T,T,T) == T " + (XOR(T, T, T) == T ? "[PASS]" : "[FAIL]"));
            Console.WriteLine("if(F,F,T) == T " + (If(F, F, T) == T ? "[PASS]" : "[FAIL]"));
            Console.WriteLine("AND(Add_2bit(F, F, T, T, out r1, out r0) == F,r1 == T, r0 == T) " + 
                (AND(Add(F, F, T, T, out r1, out r0) == F,r1 == T, r0 == T) ? "[PASS]" : "[FAIL]"));
            Console.WriteLine("AND(Add_2bit(F, T, T, T, out r1, out r0) == T,r1 == F, r0 == F) " +
                (AND(Add(F, T, T, T, out r1, out r0) == T, r1 == F, r0 == F) ? "[PASS]" : "[FAIL]"));
            Console.WriteLine("AND(Add_2bit(F, T, T, F, out r1, out r0) == F, r1 == T, r0 == T) " +
                (AND(Add(F, T, T, F, out r1, out r0) == F, r1 == T, r0 == T) ? "[PASS]" : "[FAIL]"));

            // 0110 + 1100 = 10010
            Console.WriteLine("AND(Add_4bit(F, T, T, F,  T, T, F, F, out r3, out r2, out r1, out r0) == T, r3 == F, r2 == F, r1 == T, r0 == F " +
                (AND(Add(F, T, T, F,  T, T, F, F, out r3, out r2, out r1, out r0) == T, r3 == F, r2 == F, r1 == T, r0 == F) ? "[PASS]" : "[FAIL]"));

            // 01101100 + 11001101 = 1 00111001
            Console.WriteLine("AND(Add_8bit(F, T, T, F, T, T, F, F, T, T, F, F, T, T, F, T, out r7, out r6, out r5, out r4, out r3, out r2, out r1, out r0) == T, r7 == F, r6 == F, r5 == T, r4 == T, r3 == T, r2 == F, r1 == F, r0 == T " +
                (AND(Add(F, T, T, F, T, T, F, F, T, T, F, F, T, T, F, T, out r7, out r6, out r5, out r4, out r3, out r2, out r1, out r0) == T, r7 == F, r6 == F, r5 == T, r4 == T, r3 == T, r2 == F, r1 == F, r0 == T) ? "[PASS]" : "[FAIL]"));

            // 11011001 + 11011001 = 1 10110010
            UINT_8 myInt8 = new UINT_8(T, T, F, T, T, F, F, T);
            Console.WriteLine("AND(Add_8bit(myInt8, myInt8, out rInt8) == T, rInt8.b07 == T, rInt8.b06 == F, rInt8.b05 == T, rInt8.b04 == T, rInt8.b03 == F, rInt8.b02 == F, rInt8.b01 == T, rInt8.b00 == F) " +
                (AND(Add(myInt8, myInt8, out rUInt8) == T, rUInt8.b07 == T, rUInt8.b06 == F, rUInt8.b05 == T, rUInt8.b04 == T, rUInt8.b03 == F, rUInt8.b02 == F, rUInt8.b01 == T, rUInt8.b00 == F) ? "[PASS]" : "[FAIL]"));

            // 0111111001011001 + 1000000110100110 = 0 1111111111111111
            UINT_16 myInt16a = new UINT_16(F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T);
            UINT_16 myInt16b = new UINT_16(T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F);
            Console.WriteLine("AND(Add_16bit(myInt16a, myInt16b, out rInt16) == F, rInt16.b15 == T, rInt16.b14 == T...rInt16.b00 == T) " +
                (AND(Add(myInt16a, myInt16b, out rUInt16) == F, rUInt16.b15 == T, rUInt16.b14 == T, rUInt16.b13 == T, rUInt16.b12 == T, rUInt16.b11 == T, rUInt16.b10 == T, rUInt16.b09 == T, rUInt16.b08 == T
                , rUInt16.b07 == T, rUInt16.b06 == T, rUInt16.b05 == T, rUInt16.b04 == T, rUInt16.b03 == T, rUInt16.b02 == T, rUInt16.b01 == T, rUInt16.b00 == T
                ) ? "[PASS]" : "[FAIL]"));

            // 01111110010110011000000110100110 + 10000001101001100111111001011001 = 0 11111111111111111111111111111111
            UINT_32 myInt32a = new UINT_32(T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F, F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T);
            UINT_32 myInt32b = new UINT_32(F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T,T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F);
            Console.WriteLine("AND(Add_32bit(myInt32a, myInt32b, out rInt32) == F, rInt32.b31 == T, rInt32.b30 == T... rInt32.b00 == T) " +
                (AND(Add(myInt32a, myInt32b, out rUInt32) == F, rUInt32.b31 == T, rUInt32.b30 == T, rUInt32.b29 == T, rUInt32.b28 == T, rUInt32.b27 == T, rUInt32.b26 == T, rUInt32.b25 == T, rUInt32.b24 == T
                , rUInt32.b23 == T, rUInt32.b22 == T, rUInt32.b21 == T, rUInt32.b20 == T, rUInt32.b19 == T, rUInt32.b18 == T, rUInt32.b17 == T, rUInt32.b16 == T, rUInt32.b15 == T, rUInt32.b14 == T, rUInt32.b13 == T, 
                rUInt32.b12 == T, rUInt32.b11 == T, rUInt32.b10 == T, rUInt32.b09 == T, rUInt32.b08 == T, rUInt32.b07 == T, rUInt32.b06 == T, rUInt32.b05 == T, rUInt32.b04 == T, rUInt32.b03 == T, rUInt32.b02 == T, rUInt32.b01 == T, rUInt32.b00 == T
                ) ? "[PASS]" : "[FAIL]"));

            // 01111110010110011000000110100111 + 10000001101001100111111001011001 = 1 00000000000000000000000000000000
            UINT_32 myInt32c = new UINT_32(T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F, F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T);
            UINT_32 myInt32d = new UINT_32(F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T, T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, T);
            Console.WriteLine("AND(Add_32bit(myInt32c, myInt32d, out rInt32) == T, rInt32.b31 == F, rInt32.b30 == F... rInt32.b00 == F) " +
                (AND(Add(myInt32c, myInt32d, out rUInt32) == T, rUInt32.b31 == F, rUInt32.b30 == F, rUInt32.b29 == F, rUInt32.b28 == F, rUInt32.b27 == F, rUInt32.b26 == F, rUInt32.b25 == F, rUInt32.b24 == F
                , rUInt32.b23 == F, rUInt32.b22 == F, rUInt32.b21 == F, rUInt32.b20 == F, rUInt32.b19 == F, rUInt32.b18 == F, rUInt32.b17 == F, rUInt32.b16 == F, rUInt32.b15 == F, rUInt32.b14 == F, rUInt32.b13 == F,
                rUInt32.b12 == F, rUInt32.b11 == F, rUInt32.b10 == F, rUInt32.b09 == F, rUInt32.b08 == F, rUInt32.b07 == F, rUInt32.b06 == F, rUInt32.b05 == F, rUInt32.b04 == F, rUInt32.b03 == F, rUInt32.b02 == F, rUInt32.b01 == F, rUInt32.b00 == F
                ) ? "[PASS]" : "[FAIL]"));

            // 01111110010110011000000110100110 == 10000001101001100111111001011001 => FALSE
            UINT_32 myInt32e = new UINT_32(T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F, F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T);
            UINT_32 myInt32f = new UINT_32(F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T, T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F);
            bool result = Equal(myInt32e, myInt32f);
            Console.WriteLine("Equal(UINT_32, UINT_32) " +
                (!result ? "[PASS]" : "[FAIL]"));

            // 01111110010110011000000110100110 =>(inv + 1)=> 10000001101001100111111001011010 
            INT_32 myInt32g = new INT_32(F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T, T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F);
            INT_32 myInt32h = new INT_32(T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F, F, T, T, T, T, T, T, F, F, T, F, T, T, F, T, F);
            result = Equal(Neg(myInt32g), myInt32h);
            Console.WriteLine("Neg(INT_32, INT_32) " +
                (result ? "[PASS]" : "[FAIL]"));
            
            // 01111110010110011000000110100111 - 00000001101001100111111001011001 = 01111100101100110000001101001110
            INT_32 myInt32j = new INT_32(F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T, T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, T);
            INT_32 myInt32i = new INT_32(F, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F, F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T);
            rInt32 = Subtract(myInt32j, myInt32i);
            Console.WriteLine("Subtract(myInt32j, myInt32i) " +
                (AND( rInt32.b31 == F, rInt32.b30 == T, rInt32.b29 == T, rInt32.b28 == T, rInt32.b27 == T, rInt32.b26 == T, rInt32.b25 == F, rInt32.b24 == F
                , rInt32.b23 == T, rInt32.b22 == F, rInt32.b21 == T, rInt32.b20 == T, rInt32.b19 == F, rInt32.b18 == F, rInt32.b17 == T, rInt32.b16 == T, rInt32.b15 == F, rInt32.b14 == F, rInt32.b13 == F,
                rInt32.b12 == F, rInt32.b11 == F, rInt32.b10 == F, rInt32.b09 == T, rInt32.b08 == T, rInt32.b07 == F, rInt32.b06 == T, rInt32.b05 == F, rInt32.b04 == F, rInt32.b03 == T, rInt32.b02 == T, rInt32.b01 == T, rInt32.b00 == F
                ) ? "[PASS]" : "[FAIL]"));

            // 00000001101001100111111001011001 - 01111110010110011000000110100111 = 100000110100110011111100101100100
            //                                                                9876543210987654321098765432109876543210
            INT_32 myInt32b21 = new INT_32(F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T, T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, T);
            INT_32 myInt32a21 = new INT_32(F, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F, F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T);
            rInt32 = Subtract(myInt32a21, myInt32b21);
            Console.WriteLine("Subtract(myInt32a21, myInt32b21) " +
                (AND(rInt32.b31 == T, rInt32.b30 == F, rInt32.b29 == F, rInt32.b28 == F, rInt32.b27 == F, rInt32.b26 == F, rInt32.b25 == T, rInt32.b24 == T
                , rInt32.b23 == F, rInt32.b22 == T, rInt32.b21 == F, rInt32.b20 == F, rInt32.b19 == T, rInt32.b18 == T, rInt32.b17 == F, rInt32.b16 == F, rInt32.b15 == T, rInt32.b14 == T, rInt32.b13 == T,
                rInt32.b12 == T, rInt32.b11 == T, rInt32.b10 == T, rInt32.b09 == F, rInt32.b08 == F, rInt32.b07 == T, rInt32.b06 == F, rInt32.b05 == T, rInt32.b04 == T, rInt32.b03 == F, rInt32.b02 == F, rInt32.b01 == T, rInt32.b00 == F
                ) ? "[PASS]" : "[FAIL]"));

            // 01111110010110011000000110100111 - 00000001101001100111111001011001 = 01111100101100110000001101001110
            UINT_32 myUInt32j = new UINT_32(F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T, T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, T);
            UINT_32 myUInt32i = new UINT_32(F, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F, F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T);
            rUInt32 = Subtract(myUInt32j, myUInt32i);
            Console.WriteLine("Subtract(myUInt32j, myUInt32i) " +
                (AND(rUInt32.b31 == F, rUInt32.b30 == T, rUInt32.b29 == T, rUInt32.b28 == T, rUInt32.b27 == T, rUInt32.b26 == T, rUInt32.b25 == F, rUInt32.b24 == F
                , rUInt32.b23 == T, rUInt32.b22 == F, rUInt32.b21 == T, rUInt32.b20 == T, rUInt32.b19 == F, rUInt32.b18 == F, rUInt32.b17 == T, rUInt32.b16 == T, rUInt32.b15 == F, rUInt32.b14 == F, rUInt32.b13 == F,
                rUInt32.b12 == F, rUInt32.b11 == F, rUInt32.b10 == F, rUInt32.b09 == T, rUInt32.b08 == T, rUInt32.b07 == F, rUInt32.b06 == T, rUInt32.b05 == F, rUInt32.b04 == F, rUInt32.b03 == T, rUInt32.b02 == T, rUInt32.b01 == T, rUInt32.b00 == F
                ) ? "[PASS]" : "[FAIL]"));

            // 11111110010110011000000110100111 - 00000001101001100111111001011001 = 11111100101100110000001101001110
            UINT_32 myUInt32a21 = new UINT_32(T, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T, T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, T);
            UINT_32 myUInt32b21 = new UINT_32(F, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F, F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T);
            rUInt32 = Subtract(myUInt32a21, myUInt32b21);
            Console.WriteLine("Subtract(myUInt32a21, myUInt32b21) " +
                (AND(rUInt32.b31 == T, rUInt32.b30 == T, rUInt32.b29 == T, rUInt32.b28 == T, rUInt32.b27 == T, rUInt32.b26 == T, rUInt32.b25 == F, rUInt32.b24 == F
                , rUInt32.b23 == T, rUInt32.b22 == F, rUInt32.b21 == T, rUInt32.b20 == T, rUInt32.b19 == F, rUInt32.b18 == F, rUInt32.b17 == T, rUInt32.b16 == T, rUInt32.b15 == F, rUInt32.b14 == F, rUInt32.b13 == F,
                rUInt32.b12 == F, rUInt32.b11 == F, rUInt32.b10 == F, rUInt32.b09 == T, rUInt32.b08 == T, rUInt32.b07 == F, rUInt32.b06 == T, rUInt32.b05 == F, rUInt32.b04 == F, rUInt32.b03 == T, rUInt32.b02 == T, rUInt32.b01 == T, rUInt32.b00 == F
                ) ? "[PASS]" : "[FAIL]"));

            // 11111110010110011000000110100111 - 11000001101001100111111001011001 = 00111100101100110000001101001110
            UINT_32 myUInt32a20 = new UINT_32(T, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T, T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, T);
            UINT_32 myUInt32b20 = new UINT_32(T, T, F, F, F, F, F, T, T, F, T, F, F, T, T, F, F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T);
            rUInt32 = Subtract(myUInt32a20, myUInt32b20);
            Console.WriteLine("Subtract(myUInt32a20, myUInt32b20) " +
                (AND(rUInt32.b31 == F, rUInt32.b30 == F, rUInt32.b29 == T, rUInt32.b28 == T, rUInt32.b27 == T, rUInt32.b26 == T, rUInt32.b25 == F, rUInt32.b24 == F
                , rUInt32.b23 == T, rUInt32.b22 == F, rUInt32.b21 == T, rUInt32.b20 == T, rUInt32.b19 == F, rUInt32.b18 == F, rUInt32.b17 == T, rUInt32.b16 == T, rUInt32.b15 == F, rUInt32.b14 == F, rUInt32.b13 == F,
                rUInt32.b12 == F, rUInt32.b11 == F, rUInt32.b10 == F, rUInt32.b09 == T, rUInt32.b08 == T, rUInt32.b07 == F, rUInt32.b06 == T, rUInt32.b05 == F, rUInt32.b04 == F, rUInt32.b03 == T, rUInt32.b02 == T, rUInt32.b01 == T, rUInt32.b00 == F
                ) ? "[PASS]" : "[FAIL]"));

            // 00000000000000011000000110100110 * 00000000000000000111111001011001 = 10111110010101011100011010110110
            UINT_32 myUInt32a22 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F);
            UINT_32 myUInt32b22 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T);
            rUInt32 = Mult(myUInt32a22, myUInt32b22);
            Console.WriteLine("Mult(myUInt32a22, myUInt32b22) " +
                (AND(rUInt32.b31 == T, rUInt32.b30 == F, rUInt32.b29 == T, rUInt32.b28 == T, rUInt32.b27 == T, rUInt32.b26 == T, rUInt32.b25 == T, rUInt32.b24 == F,
                rUInt32.b23 == F, rUInt32.b22 == T,  rUInt32.b21 == F, rUInt32.b20 == T, rUInt32.b19 == F, rUInt32.b18 == T, rUInt32.b17 == F, rUInt32.b16 == T, 
                rUInt32.b15 == T, rUInt32.b14 == T, rUInt32.b13 == F,  rUInt32.b12 == F, rUInt32.b11 == F, rUInt32.b10 == T, rUInt32.b09 == T, rUInt32.b08 == F,
                rUInt32.b07 == T,   rUInt32.b06 == F,   rUInt32.b05 == T, rUInt32.b04 == T, rUInt32.b03 == F, rUInt32.b02 == T, rUInt32.b01 == T, rUInt32.b00 == F
                ) ? "[PASS]" : "[FAIL]"));

            // 00000000000000011000000110100111(98727) * 00000000000000000111111001011001 = 10111110010101011100011010110111
            UINT_32 myUInt32a23 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, T);
            UINT_32 myUInt32b23 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T);
            rUInt32 = Mult(myUInt32a23, myUInt32b23);
            Console.WriteLine("Mult(myUInt32a23, myUInt32b23) " +
                (AND(rUInt32.b31 == T, rUInt32.b30 == F, rUInt32.b29 == T, rUInt32.b28 == T, rUInt32.b27 == T, rUInt32.b26 == T, rUInt32.b25 == T, rUInt32.b24 == F,
                rUInt32.b23 == F, rUInt32.b22 == T, rUInt32.b21 == F, rUInt32.b20 == T, rUInt32.b19 == F, rUInt32.b18 == T, rUInt32.b17 == T, rUInt32.b16 == F,
                rUInt32.b15 == F, rUInt32.b14 == T, rUInt32.b13 == F, rUInt32.b12 == F, rUInt32.b11 == F, rUInt32.b10 == T, rUInt32.b09 == F, rUInt32.b08 == T,
                rUInt32.b07 == F, rUInt32.b06 == F, rUInt32.b05 == F, rUInt32.b04 == F, rUInt32.b03 == T, rUInt32.b02 == T, rUInt32.b01 == T, rUInt32.b00 == T
                ) ? "[PASS]" : "[FAIL]"));

            // 00000000000000011000000110100110(98726) * 111111111111111111111111100000110100111(-15961)  =  10100010 00010011 10111001 01001010  (-1575765686)
            INT_32 myInt32a24 = new INT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, F);
            INT_32 myInt32b24 = new INT_32(T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, F, F, F, F, F, T, T, F, T, F, F, T, T, T);
            INT_32 myAnswer24 = new INT_32(T, F, T, F, F, F, T, F, F, F, F, T, F, F, T, T, T, F, T, T, T, F, F, T, F, T, F, F, T, F, T, F);
            rInt32 = Mult(myInt32a24, myInt32b24);
            Console.WriteLine("Mult(myInt32a24, myInt32b24) " + (Equal(rInt32,myAnswer24) ? "[PASS]" : "[FAIL]"));


            // 00000000000000011000000110100111(98727) * 00000000000000000111111001011001(32345) = 11
            UINT_32 myUInt32a25 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, T, F, F, F, F, F, F, T, T, F, T, F, F, T, T, T);
            UINT_32 myUInt32b25 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, T, T, T, T, T, F, F, T, F, T, T, F, F, T);
            UINT_32 myAnswer_25 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, T);
            rUInt32 = Div(myUInt32a25, myUInt32b25);
            Console.WriteLine("Div(myUInt32a25, myUInt32b25) " + (Equal(rUInt32, myAnswer_25) ? "[PASS]" : "[FAIL]"));

            // 00000000000000000000000000001010 / 00000000000000000000000000000010 = 00000000000000000000000000000101
            UINT_32 myUInt32a26 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, F, T, F);
            UINT_32 myUInt32b26 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, F);
            UINT_32 myAnswer_26 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, F, T);
            rUInt32 = Div(myUInt32a26, myUInt32b26);
            Console.WriteLine("Div(myUInt32a26, myUInt32b26) " + (Equal(rUInt32, myAnswer_26) ? "[PASS]" : "[FAIL]"));

            // 00000000000000000000000000001011 / 00000000000000000000000000000011 = 00000000000000000000000000000011
            UINT_32 myUInt32a27 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, F, T, T);
            UINT_32 myUInt32b27 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, T);
            UINT_32 myAnswer_27 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, T);
            rUInt32 = Div(myUInt32a27, myUInt32b27);
            Console.WriteLine("Div(myUInt32a27, myUInt32b27) " + (Equal(rUInt32, myAnswer_27) ? "[PASS]" : "[FAIL]"));

            // 00000000000001000000000000000000 / 00000000000000000000000000000100 = 00000000000000010000000000000000
            UINT_32 myUInt32a28 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, T, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
            UINT_32 myUInt32b28 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, F, F);
            UINT_32 myAnswer_28 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
            rUInt32 = Div(myUInt32a28, myUInt32b28);
            Console.WriteLine("Div(myUInt32a28, myUInt32b28) " + (Equal(rUInt32, myAnswer_28) ? "[PASS]" : "[FAIL]"));

            // 00100000000000000000000000000000 / 00000000000000000000000000000110 = 00000101010101010101010101010101
            UINT_32 myUInt32a29 = new UINT_32(F, F, T, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F);
            UINT_32 myUInt32b29 = new UINT_32(F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, F, T, T, F);
            UINT_32 myAnswer_29 = new UINT_32(F, F, F, F, F, T, F, T, F, T, F, T, F, T, F, T, F, T, F, T, F, T, F, T, F, T, F, T, F, T, F, T);
            rUInt32 = Div(myUInt32a29, myUInt32b29);
            Console.WriteLine("Div(myUInt32a29, myUInt32b29) " + (Equal(rUInt32, myAnswer_29) ? "[PASS]" : "[FAIL]"));

            // 32 binary bits are accurate -     11.001001000011111101101010100010 or  3.1415926534... (pi is 3.1415926535...)
            UINT_32 myAnswer_30     = new UINT_32(T, T, F, F, T, F, F, T, F, F, F, F, T, T, T, T, T, T, F, T, T, F, T, F, T, F, T, F, F, F, T, F);
            rUInt32 = Pi();
            Console.WriteLine("Pi() " + (Equal(rUInt32, myAnswer_30) ? "[PASS]" : "[FAIL]"));

            Console.ReadKey();
        }
    }
}

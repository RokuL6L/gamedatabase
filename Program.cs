using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdwrqr
{
    class Program
    {
        static void Main()
        {
            char[] cha = "abcdefgh".ToCharArray();
            bool search = false;
            int i = 0;
            string inputValue;
            Char changeValue;

            Console.Write("찾으시는 글자는 무엇인가요?  : ");
            inputValue = Console.ReadLine();
            if (inputValue.Length > 1)
            {
                Console.WriteLine("한 글자만 입력하시오  : ");
                inputValue = Console.ReadLine();
            }
            changeValue = char.Parse(inputValue);

            while (search == false)
            {
                if (cha[i] == changeValue)
                {
                    search = true;
                }
                Console.Write("{0}", cha[i]);
                i++;
                i = i % cha.Length;

            }
        }


        //-------------------------------배열 크기 키우기 (동적 배열)-----------------------------

        /*
        static void Main()
        {
            int[] A = new int[4];
            A[0] = 5;
            Console.WriteLine("{0}", A.Length);
            Sizeup(ref A);
            Console.WriteLine("{0}", A.Length);
        }

        static void Sizeup(ref int[] arr)
        {
            int arrLength = arr.Length;
            int[] temparr = new int[arrLength * 2];
            for(int i = 0; i<arrLength; i++)
            {
                temparr[i] = arr[i];
            }
            arr = temparr;
        }

        */

        // -------------------------------피라미드 만들기--------------------------------

        /*
        char[][] stack = new char[5][];

        stack[0] = new char[1] { '*' };
        stack[1] = new char[3] { '*','*','*' };
        stack[2] = new char[5] { '*', '*', '*','*', '*' };
        stack[3] = new char[7] { '*', '*', '*', '*', '*', '*', '*' };
        stack[4] = new char[9] { '*', '*', '*', '*', '*', '*', '*', '*', '*' };

        int air = stack.Length;

        for(int i = 0; i<stack.Length; i++)
        {
            for (int j = 0; j < air; j++)
            {
                Console.Write(" ");
            }
            air -= 1;
            Console.WriteLine("{0}", string.Join("", stack[i] ) );
        }

        */

        // ------------------------최댓값 찾기-----------------------------

        /*
        int[] array = { 2, 50, 20, 17, 67, 71, 91, 40, 48, 1 ,9945612, 42};
        int index = 0;


        for(int i = 0; i<array.Length; i++)
        {
            if (array[i] > index)
            {
                index = array[i];
            }
        }
        Console.WriteLine("최댓값은 {0} 입니다.", index);
        */
    }
}

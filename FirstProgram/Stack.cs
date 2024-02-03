using System;
namespace Stack1
{
    class Stack2
    {
        public static void Stack3()
        {

            Stack<int> st = new Stack<int>();
            while (st.Count > 0)
            {
                st.Pop();

            }
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Pop();
            st.Peek();

        }
    }
}
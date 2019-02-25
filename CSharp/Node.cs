using System;
namespace SingleLinkedListproject
{
    class Node
    {
        public int info;
        public Node link; //This link always refers to the next node of the list.

        public Node(int i)
        {
            info = i;
            link = null;
        }
    }
}

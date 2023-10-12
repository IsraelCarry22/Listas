namespace All_List.Clases
{
    public class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }

        public Node()
        {
            Next = null;
            Data = 0;
        }

        public Node(int d)
        {
            Data = d;
            Next = null;
        }
    }
}
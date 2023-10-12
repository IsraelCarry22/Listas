namespace All_List.Clases
{
    public class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }

        public Node()
        {
            this.Next = null;
            this.Data = 0;
        }

        public Node(int d)
        {
            this.Data = d;
            this.Next = null;
        }
    }
}
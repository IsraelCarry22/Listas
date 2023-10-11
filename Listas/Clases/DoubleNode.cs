namespace All_List.Clases
{
    public class DoubleNode
    {
        public DoubleNode Back { get; set; }
        public DoubleNode Next { get; set; }
        public int Data { get; set; }

        public DoubleNode()
        {
            Back = null;
            Next = null;
        }

        public DoubleNode(int d)
        {
            Data = d;
            Back = null;
            Next = null;
        }
    }
}
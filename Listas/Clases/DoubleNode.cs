namespace All_List.Clases
{
    public class DoubleNode : Node
    { 
        public DoubleNode Back { get; set; }

        public DoubleNode() : base()
        {
            this.Back = null;
            this.Data = 0;
            this.Next = null;
        }

        public DoubleNode(int data) : base()
        {
            this.Data = data;
            this.Next = null;
            this.Back = null;
        }
    }
}
namespace Custom_Doubly_Linked_List
{
    /// <summary>
    /// Creating Node class.
    /// </summary>
    public class Node<T>
    {
        /// <summary>
        /// Creating property For Node Value.
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// Creating property For Node Value.
        /// </summary>
        public Node<T> Next { get; set; }
        /// <summary>
        /// Creating property for Node Previous.
        /// </summary>
        public Node<T> Previous { get; set; }

       
    }
}

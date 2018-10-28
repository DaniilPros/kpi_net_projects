namespace Lab3
{
    internal interface ISubscriber
    {
        string Name { get; set; }
        void ReceiveItem();
    }
}
namespace Quill.Delta
{
    public abstract class InsertData
    {
        public DataType Type { get; private set; }
        public string Value { get; set; }

        protected InsertData(DataType type, string value)
        {
            Type = type;
            Value = value;
        }
    }
}

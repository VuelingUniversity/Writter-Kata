using Writer.models;

namespace Writer.interfaces
{
    public interface IFactory
    {
        public WriterModel CreateWriter(string format);
        void PrintDictionary();

    }
}
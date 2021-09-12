namespace WriterKata.models
{
    interface IFactory
    {
        WriterModel CreateWriter(string format);
        void PrintDictionary();

    }
}
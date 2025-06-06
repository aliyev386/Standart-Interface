namespace ConsoleApp1
{
    class ProDocumentProgram : DocumentProgram
    {
        public sealed override void EditDocument()
        {
            Console.WriteLine("Document Opened");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }
}

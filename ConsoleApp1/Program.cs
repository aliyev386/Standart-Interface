using ConsoleApp1;
Console.Write("Enter key word: ");
string keyWord = Console.ReadLine();
DocumentProgram docProgram;
if (keyWord == "basic") 
{
    docProgram = new DocumentProgram();
    docProgram.OpenDocument();
    docProgram.EditDocument();
    docProgram.SaveDocument();
}
else if (keyWord == "pro")
{
    docProgram = new ProDocumentProgram();
    docProgram.OpenDocument();
    docProgram.EditDocument();
    docProgram.SaveDocument();
}
else if(keyWord == "expert")
{
    docProgram = new ExpertDocument();
    docProgram.OpenDocument();
    docProgram.EditDocument();
    docProgram.SaveDocument();
}


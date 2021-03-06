namespace IntefaceSegrationPrinciple
{

    public interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
    }
    public interface IFaxContent
    {
        bool FaxContent(string content);
    }
    
    public interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }
    
}
namespace SMDR.Infratructure.Models
{
    public interface ICallLog
    {
        string Raw { get; set; }
        void Enhance();
    }
   

}

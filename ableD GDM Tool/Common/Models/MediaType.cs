using System.Security.Cryptography;
using System.Windows;

namespace ableD_GDM_Tool.Common.Models
{
    public abstract class MediaType : IMediatype
    {
        public string MediaTypeName { get; set; }
        public abstract string GetReadData();

    }

    public class Tkt : MediaType
    {
        public int Length { get; set; }
        public string AirlineCode { get; set; }
        public string IssueDate { get; set; }
        public string PnrRl { get; set; }
        public string TktRl { get; set; }
        public string ConfirmationNumber { get; set; }
        public string Spare { get; set; } = "   ";
        public string Identification { get; set; }
        public string IssueTime { get; set; }
        
        
        
        public override string GetReadData()
        { 
            
            
            string.Concat(AirlineCode, IssueDate, PnrRl, TktRl, ConfirmationNumber, Spare, Identification, IssueTime);
            return "super";


        }
    }

    public interface IMediatype
    {
       string MediaTypeName { get; set; }
       string GetReadData();
    }
}
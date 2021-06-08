using System;

namespace DeliveryService.Contracts
{
    public interface ILogger
    {
        string CreateOrOpenFile();

        void CreateNewNote(string note);      
    }
}

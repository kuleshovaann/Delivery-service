using System;

namespace Models.Contracts
{
    public interface IStarter
    {
        void Start(ICompany company, ICustomer customer);
    }
}

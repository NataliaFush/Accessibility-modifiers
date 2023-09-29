using Core;
using Core.Interfaces;

namespace Service
{
    public class CustomerService
    {
        protected IRepository _repository;

        public CustomerService(IRepository repository)
        {
            _repository = repository;
        }

        
    }
}
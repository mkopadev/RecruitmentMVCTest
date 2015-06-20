using System;
using System.Threading.Tasks;
using Applicita.RecruitmentTest.Service.Commands;
using Applicita.RecruitmentTest.Service.Interfaces;

namespace Applicita.RecruitmentTest.Service
{
    public class TaxRateService : ITaxRateService
    {
        public TaxRateService()
        {
        }

        public Task<double> CalculateTax(double netAmount, double taxRate)
        {
            throw new NotImplementedException();
        }

        public Task AddTaxRate(AddTaxRateCommand command)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTaxRate(UpdateTaxRateCommand command)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTaxRate(DeleteTaxRateCommand command)
        {
            throw new NotImplementedException();
        }
    }
}

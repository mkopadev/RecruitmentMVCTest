using System;
using System.Threading.Tasks;
using MKopa.RecruitmentTest.Service.Commands;
using MKopa.RecruitmentTest.Service.Interfaces;

namespace MKopa.RecruitmentTest.Service
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

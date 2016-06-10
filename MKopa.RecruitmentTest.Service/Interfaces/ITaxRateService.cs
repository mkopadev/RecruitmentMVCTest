using System.Threading.Tasks;
using MKopa.RecruitmentTest.Service.Commands;

namespace MKopa.RecruitmentTest.Service.Interfaces
{
    public interface ITaxRateService
    {
        Task<double> CalculateTax(double netAmount, double taxRate);
        Task AddTaxRate(AddTaxRateCommand command);
        Task UpdateTaxRate(UpdateTaxRateCommand command);
        Task DeleteTaxRate(DeleteTaxRateCommand command);
    }
}
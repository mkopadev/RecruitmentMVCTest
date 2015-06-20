using System.Threading.Tasks;
using Applicita.RecruitmentTest.Service.Commands;

namespace Applicita.RecruitmentTest.Service.Interfaces
{
    public interface ITaxRateService
    {
        Task<double> CalculateTax(double netAmount, double taxRate);
        Task AddTaxRate(AddTaxRateCommand command);
        Task UpdateTaxRate(UpdateTaxRateCommand command);
        Task DeleteTaxRate(DeleteTaxRateCommand command);
    }
}
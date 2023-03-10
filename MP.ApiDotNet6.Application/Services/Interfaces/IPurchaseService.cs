using MP.ApiDotNet6.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.Services.Interfaces
{
    public interface IPurchaseService
    {
        Task<ResultService<PurchaseDTO>> CreateAsync(PurchaseDTO purchaseDTO);
        Task<ResultService<PurchaseDTO>> UpdateAsync(PurchaseDTO purchaseDTO);
        Task<ResultService> DeleteAsync(int id);
        Task<ResultService<PurchaseDetailDTO>> GetByIdAsync(int id);
        Task<ResultService<ICollection<PurchaseDetailDTO>>> GetAllAsync();
    }
}

using MP.ApiDotNet6.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.ApiDotNet6.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<ResultService<ProductDTO>> CreateAsync(ProductDTO productDTO);
        Task<ResultService<ProductDTO>> GetByIdAsync(int id);
        Task<ResultService<ICollection<ProductDTO>>> GetAsync();
        Task<ResultService> UpdateAsync(ProductDTO productDTO);
        Task<ResultService> DeleteAsync(int id);
    }
}

using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserResponseDto>> GetAllAsync();
        Task<UserResponseDto?> GetByIdAsync(int id);
        Task CreateAsync(UserCreateDto userDto);
        Task UpdateAsync(UserUpdateDto userDto);
        Task DeleteAsync(int id);
    }
}

using Udemy.ToDoAppNTier.Common.ResponseObjects;
using Udemy.ToDoAppNTier.Dtos.Interfaces;
using Udemy.ToDoAppNTier.Dtos.WorkDtos;

namespace Udemy.ToDoAppNTier.Business.Interfaces
{
    public interface IWorkService
    {
        Task<IResponse<WorkCreateDto>> Create(WorkCreateDto dto);

        Task<IResponse> Remove(int id);

        Task<IResponse<WorkUpdateDto>> Update(WorkUpdateDto dto);
        Task<IResponse<List<WorkListDto>>> GetAll();

        Task<IResponse<IDto>> GetById<IDto>(int id);
    }
}